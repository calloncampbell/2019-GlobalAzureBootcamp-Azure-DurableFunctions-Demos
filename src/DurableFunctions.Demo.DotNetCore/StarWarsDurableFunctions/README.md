# Notes

## Task Hubs
A task hub in Durable Functions is a logical container for Azure Storage resources that are used for orchestrations. Orchestrator and activity functions can only interact with each other when they belong to the same task hub.

https://docs.microsoft.com/en-us/azure/azure-functions/durable/durable-functions-task-hubs

## Versioning
### Side-by-side deployments
The most fail-proof way to ensure that breaking changes are deployed safely is by deploying them side-by-side with your older versions. This can be done using any of the following techniques:
1. Deploy all the updates as entirely new functions (new names).
1. Deploy all the updates as a new function app with a different storage account.
1. Deploy a new copy of the function app but with an updated ``TaskHub`` name. **This is the recommended technique.**

The task hub can be configured in the host.json file as follows:

#### Functions 1.x
```json
{
    "durableTask": {
        "HubName": "MyTaskHubV2"
    }
}
```

#### Functions 2.x
The default value is ``DurableFunctionsHub``.

All Azure Storage entities are named based on the HubName configuration value. By giving the task hub a new name, you ensure that separate queues and history table are created for the new version of your application.

https://docs.microsoft.com/en-us/azure/azure-functions/durable/durable-functions-versioning


