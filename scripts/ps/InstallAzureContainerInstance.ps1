#https://docs.microsoft.com/en-us/azure/container-instances/container-instances-tutorial-prepare-app
#https://docs.microsoft.com/en-us/azure/app-service/scripts/cli-linux-acr-aspnetcore
# net start com.docker.service
# restart-service *docker*
# Ensure Docker desktop is running Linux Container
#Set variables to be read/input by user
param(
    $resourceGroup = "",
    $location = "",
	$appSvcPlan = "",
	$paaswebapp = "",
	$gitUrl = "",
	$acrName = "",
	$containerTag = ""
)
$userName = $env:AzSPUserName
$password = $env:AzSPPassword
$aciDnsLabel = "aciDnsLabelTest"
#cls
echo "##########Executing########################"
Remove-Item c:\temp\acr -Force  -Recurse -ErrorAction SilentlyContinue
$mainpath = (Get-Location).path
echo $mainpath
mkdir c:\temp\acr
cd c:\temp\acr
echo (Get-Location).path
git clone $gitUrl
$dir = $(dir -Directory)

#build docker file
# path to folder containg docker file
docker build ./$dir -t $containerTag

docker images

# testing app locally
#docker run -d -p 8080:80 aci-tutorial-app

# Create Azure Resource Group
$location1 = $location.replace('@' , ' ')
az group create --name $resourceGroup --location $location1
# Create Azure Container registry
az acr create --resource-group $resourceGroup  --name $acrName --sku Basic --admin-enabled true
# Login to ACR
az acr login --name $acrName
#Tag image with container registry
az acr show --name $acrName --query loginServer --output table
$registry = $(az acr show --name $acrName --query loginServer --output table)
$targetImage = $registry[2] + '/' + $containerTag + ':v1'
docker tag $containerTag  $targetImage
docker images
docker push $targetImage
# List images in container registry
az acr repository list --name $acrName --output table
# tag for a specific image
az acr repository show-tags --name $acrName  --repository $containerTag --output table

$loginServer = $(az acr show --name $acrName  --output json) | ConvertFrom-Json
$loginServerUrl = "http://" + $loginServer[0].loginServer
echo 'login server url: ' + $loginServerUrl
##################################################
##Deploy a container image to Azure Container Instances
##az container create --resource-group myResourceGroup --name aci-tutorial-app --image <acrLoginServer>/aci-tutorial-app:v1 --cpu 1 --memory 1 --registry-login-server #<acrLoginServer> --registry-username <service-principal-ID> --registry-password <service-principal-password> --dns-name-label <aciDnsLabel> --ports 80
#az container create --resource-group $resourceGroup --name $containerTag --image $targetImage --cpu 1 --memory 1 --registry-login-server acrpaasacceleratortest.azurecr.io --registry-username $userName --registry-password $password --dns-name-label $aciDnsLabel --ports 80

##show progress
#az container show --resource-group $resourceGroup --name $containerTag --query instanceView.state
##application logs
#az container show --resource-group $resourceGroup --name $containerTag --query ipAddress.fqdn
#######################################################

##Deploy a container image to App Service web job 
#create app service plan for linux container
az appservice plan create -n $appSvcPlan -g $resourceGroup --is-linux -l $location1 --sku S1 --number-of-workers 1
# create app in app service plan
#az webapp create --name <app_name> --plan AppServiceLinuxDockerPlan --resource-group myResourceGroup --deployment-container-image-name <acr_registry_name>.azurecr.io/<container_name:version>
az webapp create -n $paaswebapp -g $resourceGroup -p $appSvcPlan -i $targetImage
# Configure web app with a custom Docker Container from Azure Container Registry.
az webapp config container set --resource-group $resourceGroup  --name $paaswebapp --docker-registry-server-url $loginServerUrl --docker-registry-server-user $userName --docker-registry-server-password $password

#public registry (dockerhub)
#az webapp create --resource-group PaaSAcceleratorTest --plan passwebapp01 --name myPaaSAppTest1 --deployment-container-image-name <dockerid>/aci-tutorial-app:v1

# enable logging
az webapp log config -n $paaswebapp -g $resourceGroup --web-server-logging filesystem

cd $mainpath
echo (Get-Location).path
echo "##########Completed########################"

