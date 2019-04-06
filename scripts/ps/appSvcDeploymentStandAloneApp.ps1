#az account clear
#az login
#Set variables to be read/input by user

#$resourceGroup = "PaaSAcceleratorTest"

param(
    $resourceGroup = "",
    $location = "",
	$appSvcPlan = "",
	$paaswebapp = ""
)

$webappname=  $paaswebapp + $(Get-Random -Minimum 1 -Maximum 100)
$appdirectory= 'C:\PaaSAccelerators\samples\dotNetFramework\ASP.NetMVC\ASP.NetMVC-Standalone\*'
$zipDirectory = 'C:\PaaSAccelerators\samples\dotNetFramework\ASP.NetMVC\'

$location1 = $location.replace('@' , ' ')
az group create --name $resourceGroup --location $location1

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