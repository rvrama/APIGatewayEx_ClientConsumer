## Followed this link to prepare a simple working version of API Gateway using Ocelot with ASP.Net Core Web API
https://www.telerik.com/blogs/getting-started-api-gateways-aspnet-core

## Content.Api folder contains the basic api (in the path localhost:5001/api/content)
## Content.ApiGateway folder contains the actual gateway (credit to Ocelot).  The program just does the routing from localhost:5151/cms/content to the Content.Api above.

Just follow the steps in the above link.
Note : Ocelot is still evolving, so, the Retry-After, ClientIdHeaders are not working as expected (atleast to me).  
Also, the Ratelimit is not restricting based on the the ratelimit configuration precisely as mentioned in the ocelot.json.  But it works.
