#https://docs.microsoft.com/en-us/azure/container-instances/container-instances-tutorial-prepare-app
#https://docs.microsoft.com/en-us/azure/app-service/scripts/cli-linux-acr-aspnetcore
mkdir c:\temp\aci
cd c:\temp\aci

git clone https://github.com/Azure-Samples/aci-helloworld.git

#build docker file

# net start com.docker.service
# restart-service *docker*
# Ensure Docker desktop is running Linux Container
# path to folder containg docker file
docker build ./aci-helloworld -t aci-tutorial-app

docker images

# testing app locally
docker run -d -p 8080:80 aci-tutorial-app

# Create Azure Resource Group
az group create --name PaaSAcceleratorTest --location "Central US"
# Create Azure Container registry
az acr create --resource-group PaaSAcceleratorTest  --name acrPaaSAcceleratorTest --sku Basic --admin-enabled true

az acr login --name acrPaaSAcceleratorTest

#Tag image with container registry
az acr show --name acrPaaSAcceleratorTest --query loginServer --output table

docker tag aci-tutorial-app acrpaasacceleratortest.azurecr.io/aci-tutorial-app:v1
docker images
docker push acrpaasacceleratortest.azurecr.io/aci-tutorial-app:v1
# List images in container registry
az acr repository list --name acrPaaSAcceleratorTest --output table
# tag for a specific image
az acr repository show-tags --name acrPaaSAcceleratorTest  --repository aci-tutorial-app --output table

#Deploy a container application to Azure Container Instances
#az container create --resource-group myResourceGroup --name aci-tutorial-app --image <acrLoginServer>/aci-tutorial-app:v1 --cpu 1 --memory 1 --registry-login-server #<acrLoginServer> --registry-username <service-principal-ID> --registry-password <service-principal-password> --dns-name-label <aciDnsLabel> --ports 80

az container create --resource-group PaaSAcceleratorTest --name aci-tutorial-app --image acrpaasacceleratortest.azurecr.io/aci-tutorial-app:v1 --cpu 1 --memory 1 --registry-login-server acrpaasacceleratortest.azurecr.io --registry-username "4cadb99f-0865-4826-b447-f17b54282f31" --registry-password "fdee6d30-h8e6-d4d3-154f-3e96bd217a5c" --dns-name-label aciDnsLabelTest --ports 80

#show progress
az container show --resource-group PaaSAcceleratorTest --name aci-tutorial-app --query instanceView.state
#application logs
az container show --resource-group PaaSAcceleratorTest --name aci-tutorial-app --query ipAddress.fqdn

###################################################################################################################
#create app service plan 
az appservice plan create -n passwebapp01 -g PaaSAcceleratorTest --is-linux -l "Central US" --sku S1 --number-of-workers 1
# create app in app service plan
#az webapp create --name <app_name> --plan AppServiceLinuxDockerPlan --resource-group myResourceGroup --deployment-container-image-name <acr_registry_name>.azurecr.io/<container_name:version>
az webapp create -n "myPaaSAppTest1" -g PaaSAcceleratorTest -p passwebapp01 -i acrpaasacceleratortest.azurecr.io/aci-tutorial-app:v1 --registry-username <serviceprincipaluser> --registry-password <serviceprincipalpassword>
# Configure web app with a custom Docker Container from Azure Container Registry.
az webapp config container set --resource-group PaaSAcceleratorTest  --name myPaaSAppTest1 --docker-registry-server-url http://acrpaasacceleratortest.azurecr.io --docker-registry-server-user "4cadb99f-0865-4826-b447-f17b54282f31" --docker-registry-server-password "fdee6d30-h8e6-d4d3-154f-3e96bd217a5c"

#public registry (dockerhub)
#az webapp create --resource-group PaaSAcceleratorTest --plan passwebapp01 --name myPaaSAppTest1 --deployment-container-image-name <dockerid>/aci-tutorial-app:v1

# enable logging
#az webapp log config -n myPaaSAppTest1 -g PaaSAcceleratorTest --web-server-logging filesystem


