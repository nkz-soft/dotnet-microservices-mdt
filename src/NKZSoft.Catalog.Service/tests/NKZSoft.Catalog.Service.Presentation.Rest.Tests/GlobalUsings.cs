global using DotNet.Testcontainers.Containers;
global using Microsoft.AspNetCore.Hosting;

global using Xunit;
global using Xunit.Extensions.Ordering;
global using FluentAssertions;
global using MediatR;

global using NKZSoft.Catalog.Service.Common.Tests;
global using NKZSoft.Catalog.Service.Application.Common.Interfaces;
global using NKZSoft.Catalog.Service.Application.Common.Paging;
global using NKZSoft.Catalog.Service.Application.Models;
global using NKZSoft.Catalog.Service.Application.Product.Commands.Create;
global using NKZSoft.Catalog.Service.Application.Product.Models;
global using NKZSoft.Catalog.Service.Domain.AggregatesModel.ProductAggregates.Entities;
global using NKZSoft.Catalog.Service.Persistence.PostgreSQL.Extensions;
global using RestSharp;


