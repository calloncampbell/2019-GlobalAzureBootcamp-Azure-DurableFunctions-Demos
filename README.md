# 2019 Global Azure Bootcamp - Azure Durable Functions Demos
This repo contains a .NET Core solution for my 2019 Global Azure Bootcamp presentation and demos on **Serverless Orchestration with Azure Durable Functions**. It also serves as demo material for some of my other Azure Functions [presentations](https://www.slideshare.net/calloncampbell).

## Getting Started

### Requirements
- Visual Studio 2019, Visual Studio 2017, Visual Studio Code and/or the Azure Portal
- .NET Core 2.1
- Visual Studio Code [REST Client](https://github.com/Huachao/vscode-restclient) extension (optional)
- Microsoft [Azure Storage Explorer](https://azure.microsoft.com/en-us/features/storage-explorer/) (optional)

### Solution

The solution consists of the following projects:
- DurableFunctions.Demo.DotNetCore, a Function App targeted at .NET Core 2.1.

The current version of this Function App depends on the free (and fun) external Star Wars API - [SWAPI](https://swapi.co/) in order to demonstrate function chaining and fan-out/fan-in patterns.  This API doesn't require any authentication which makes it easier to demo and experiment with.

### Demos

The Function App solution consists of the following demos (found in seperate solution folders) which can be executed independently.

#### 0 - Function Starters
TODO

#### 1 - Function Basics
TODO

#### 2 - Function Chaining
TODO

#### 3 - Function Fan-Out/Fan-In
TODO

## Using the Visual Studio Code REST Client Extension
During my demos I used the excellent [REST Client](https://github.com/Huachao/vscode-restclient) extension for Visual Studio Code. If you have this extension installed then you can use the http files located in the [`api-tests`](/api-tests) folder to start the orchestration functions.

## References
Durable Functions (an extension of [Azure Functions](https://functions.azure.com) and [Azure WebJobs](https://docs.microsoft.com/en-us/azure/app-service/web-sites-create-web-jobs)) enables writing *long-running*, *stateful* function orchestrations in code in a serverless environment (PaaS options and self-hosting are also supported).

For more information on Azure Durable Functions take a look at the documentation and/or source code on GitHub:
- [Azure Durable Fucntions documentation](https://docs.microsoft.com/en-us/azure/azure-functions/durable/durable-functions-overview)
- [Azure Durable Functions Extension on GitHub](https://github.com/Azure/azure-functions-durable-extension)

## Special Thanks
I would like to thank [Marc Duiker](https://github.com/marcduiker/demos-azure-durable-functions) for his Azure Durable Function [videos](https://www.youtube.com/playlist?list=PLoSzmz8jSD1cP3nW7lpk9sIw3cvJnSA_g) and samples as inspiration for my presentation and demos. 
