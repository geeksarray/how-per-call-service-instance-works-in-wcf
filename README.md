# How Per Call Service Instance works in WCF

This article helps you to understand how per call WCF service works and how its instances get created. This article will also go through a tutorial for implementing and executing Per Call WCF Service.

## How instances are created in WCF Per Call Service mode?
A WCF service configured as InstanceContextMode.PerCall will create a dedicated instance for each request irrespective of existing or new client. It does not save any client data in service memory. Once service returns response to client, instance get disposed.

## When and why InstanceContextMode.PerCall
1. If your service needs to be stateless and scalable.
1. Your service must have light weight or none initialization execution.
1. PerCall services are single threaded.
1. PerCall services are highly scalable. Server crash affects to only current ongoing instance and its execution, next calls will be routed to another server.
1. PerCall services are less expensive than PerSession services as only those objects will be in service memory for whose client call is in process.

For more details on implementation please visit - [WCF Per Call Service](https://geeksarray.com/blog/how-per-call-service-instance-works-in-wcf)

[WCF Per Call Service](https://github.com/geeksarray/how-per-call-service-instance-works-in-wcf/tree/main/PerCallService) - It is a WCF Service with configuration to create a new instance of service on every request.

[WCF Service Client app](https://github.com/geeksarray/how-per-call-service-instance-works-in-wcf/tree/main/PerCallServiceClient) - Console application that consumes WCF service.

Following diagram explains how per call service creates instance of WCF service and destroy after it's use.

![WCF Per call service execution](https://geeksarray.com/images/blog/percall.png)

