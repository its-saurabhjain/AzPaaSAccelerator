#az account clear
#az login
#Set variables to be read/input by user
$resourceGroup = "PaaSAcceleratorTest"
$location = "Central US"
$appSvcPlan = "myAppServicePlan"
$paaswebapp = "paaswebapp"
$webappname=  $paaswebapp + $(Get-Random -Minimum 1 -Maximum 100)
$appdirectory= 'C:\PaaSAccelerators\samples\dotNetFramework\ASP.NetMVC\ASP.NetMVC-Standalone\*'
$zipDirectory = 'C:\PaaSAccelerators\samples\dotNetFramework\ASP.NetMVC\'

#Retrieve value from Json object
 #$val = $(az account list -o json)
 #$x = $val | ConvertFrom-Json
 #$x[0].cloudName
 #$grpList =$(az group list -o json) | ConvertFrom-Json
 #$grpList[0].id

az group create --name $resourceGroup --location $location
echo "Resource Group Created......."
# Create an App Service plan in `FREE` tier.
az appservice plan create --name $appSvcPlan --resource-group $resourceGroup --sku FREE
echo "App Service Plan Created......."
# Create a web app.
az webapp create --name $webappname --resource-group $resourceGroup --plan $appSvcPlan
echo "WebApp Created......."

Compress-Archive -Path $appdirectory -DestinationPath ($zipDirectory + "ASP.NetMVC-Standalone.zip") -Update

#Deployments
#AZ CLI Deployment using zip files
az webapp deployment source config-zip --resource-group $resourceGroup --name $webappname --src ($zipDirectory + "ASP.NetMVC-Standalone.zip")

echo "App Deployed......."