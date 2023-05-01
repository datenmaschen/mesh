# Datamesh Azure Reference Implementation

We are following the cloud-scale analytics scenario from Microsoft which is documented here:

- https://learn.microsoft.com/en-us/azure/cloud-adoption-framework/scenarios/cloud-scale-analytics/

Which aims at the following goals:

- Serve data as a product, rather than a byproduct
- Provide an ecosystem of data products, rather than a singular data warehouse that might not best fit your data scenario
- Drive a default approach to enforce data governance and security
- Drive teams to consistently prioritize business outcomes instead of focusing just on the underlying technology.

This is a real world implementation which consists of 3 streams:

- Data Platform Services
- Data Platform Automatisation
- Data Platform Confinience

The Services are implemented using Azure App Services (https://learn.microsoft.com/en-us/azure/app-service/overview) the automatisation is done using Azure DevOps (https://azure.microsoft.com/en-us/products/devops/) and the Confinience Layer is using asp.net MVC (https://dotnet.microsoft.com/en-us/apps/aspnet/mvc).