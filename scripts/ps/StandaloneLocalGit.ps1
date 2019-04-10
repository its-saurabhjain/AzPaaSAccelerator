az webapp deployment user set --user-name itsaurabh --password itsaurabh@123

az group create --name PaaSAcceleratorTest --location "Central US"
az appservice plan create --name myAppTestPlan --resource-group PaaSAcceleratorTest --sku FREE

az webapp create --name paaswebtest1 --resource-group PaaSAcceleratorTest --plan myAppTestPlan --deployment-local-git


az webapp create --name paaswebtest1 --resource-group PaaSAcceleratorTest --plan myAppTestPlan --deployment-local-git

cd to the project directory
git remote add azure "https://itsaurabh@paaswebtest1.scm.azurewebsites.net/paaswebtest1.git"

git push azure master