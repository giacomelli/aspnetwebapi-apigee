aspnetwebapi-apigee
===================

The goal of this project is help developers to implement an Web API using ASP .NET Web API and follow the [Apigee Web API Design](http://pages.apigee.com/web-api-design-ebook.html).



Setup
========

NuGet
--------
PM> Install-Package AspNetWebApi.ApiGee



Using
========
SuccessHandlingFilterAttribute
--------
Filter to encapsulate any success in a response with 200 status code.


```csharp

[SuccessHandlingFilterAttribute]
public void Put(long id, Customer customer)
{
	CustomerService.ModifyCustomer(id, customer);
}

```


ErrorHandlingFilterAttribute
--------
Filter to encapsulate any error in a response with 400 status code.

```csharp

var filters = GlobalConfiguration.Configuration.Filters;
filters.Add(new ErrorHandlingFilterAttribute());


```
