# 2019 Global Azure Bootcamp - Azure Durable Functions Demos
This repo contains a .NET solution for my 2019 Global Azure Bootcamp presentation and demo on **Serverless Orchestration with Azure Durable Functions**. It also serves as demo material for some of my other Azure Functions [presentations](https://www.slideshare.net/calloncampbell).

## Solution

The solution consists of the following projects:
- DurableFunctions.Demo.DotNetCore, a Function App targeted at .NET Core 2.1.

The current version of this Function App depends on the free (and fun) external Star Wars API - [SWAPI](https://swapi.co/) in order to demonstrate function chaining and fan-out/fan-in patterns.  This API doesn't require any authentication which makes it easier to demo and experiment with.

## Demos

The Function App solution consists of the following demos (found in seperate solution folders) which can be executed independently.
