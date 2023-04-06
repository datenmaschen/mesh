# Getting started

Trust the certificate:

```bash
dotnet dev-certs https --trust
```

In devcontainer ensure ef installed and in path:

```bash
 dotnet tool install --global dotnet-ef
 dotnet tool install --global dotnet-aspnet-codegenerator
 dotnet tool install -g Microsoft.dotnet-httprepl
 export PATH="$PATH:/home/vscode/.dotnet/tools"
```

In a new deployed container, you need to update the database.

## References from Microsoft

- https://learn.microsoft.com/en-us/ef/core/cli/dotnet
- https://learn.microsoft.com/en-us/aspnet/core/tutorials/first-web-api?view=aspnetcore-6.0&tabs=visual-studio-code
- https://learn.microsoft.com/en-us/ef/core/managing-schemas/migrations/?tabs=dotnet-core-cli
- https://docs.github.com/en/codespaces/setting-up-your-project-for-codespaces/adding-a-dev-container-configuration/setting-up-your-dotnet-project-for-codespaces
- https://learn.microsoft.com/en-us/aspnet/core/fundamentals/configuration/?view=aspnetcore-7.0
- https://learn.microsoft.com/en-us/aspnet/core/data/ef-rp/intro?view=aspnetcore-7.0&tabs=visual-studio-code

## Reference from Medium

- https://medium.com/@woeterman_94/how-to-generate-a-swagger-json-file-on-build-in-net-core-fa74eec3df1