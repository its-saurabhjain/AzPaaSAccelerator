#az account clear
#az login
#Set variables to be read/input by user
param(
    $resourceGroup = "",
    $location = "",
	$appSvcPlan = "",
	$paaswebapp = "",
	$zipFileServer = "",
	$zipFileName = ""
)
$webappname=  $paaswebapp + $(Get-Random -Minimum 1 -Maximum 100)
#parameter having spaces is dealt with using @
$location1 = $location.replace('@' , ' ')
az group create --name $resourceGroup --location $location1
echo "Resource Group Created......."
# Create an App Service plan in `FREE` tier.
az appservice plan create --name $appSvcPlan --resource-group $resourceGroup --sku FREE
echo "App Service Plan Created......."
# Create a web app.
az webapp create --name $webappname --resource-group $resourceGroup --plan $appSvcPlan
echo "WebApp Created......."
# File is already
#Compress-Archive -Path $appdirectory -DestinationPath ($zipDirectory + "ASP.NetMVC-Standalone.zip") -Update
#Deployments
#AZ CLI Deployment using zip files
az webapp deployment source config-zip --resource-group $resourceGroup --name $webappname --src ($zipFileServer + "\\" + $zipFileName)
echo "App Deployed......."