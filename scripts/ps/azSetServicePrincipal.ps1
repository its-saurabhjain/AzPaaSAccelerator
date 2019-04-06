az login
#Set Active Subscription
az account set --subscription ""
#Create Service Principal
az ad sp create-for-rbac -n "PaaSAcceleratorAzAPI"
#az ad sp show --id "http://PaaSAcceleratorAzAPI"