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

## References from Microsoft

- https://learn.microsoft.com/en-us/ef/core/cli/dotnet
- https://learn.microsoft.com/en-us/aspnet/core/tutorials/first-web-api?view=aspnetcore-6.0&tabs=visual-studio-code
- https://learn.microsoft.com/en-us/ef/core/managing-schemas/migrations/?tabs=dotnet-core-cli
- https://docs.github.com/en/codespaces/setting-up-your-project-for-codespaces/adding-a-dev-container-configuration/setting-up-your-dotnet-project-for-codespaces
