global using System.Net;
global using DotNet.Testcontainers.Containers;
global using Microsoft.AspNetCore.Hosting;
global using Microsoft.Extensions.DependencyInjection;
global using Microsoft.EntityFrameworkCore;

global using Xunit;
global using Xunit.Extensions.Ordering;
global using FluentAssertions;
global using MediatR;

global using NKZSoft.Order.Service.Domain.AggregatesModel.ToDoAggregates.Entities;
global using NKZSoft.Order.Service.Persistence.PostgreSQL;
global using NKZSoft.Order.Service.Common.Tests;
global using NKZSoft.Order.Service.Application.Models;
global using NKZSoft.Order.Service.Application.Common.Interfaces;
global using NKZSoft.Order.Service.Application.Common.Paging;
global using NKZSoft.Order.Service.Application.TodoItems.Commands.Create;
global using NKZSoft.Order.Service.Application.TodoItems.Models;
global using NKZSoft.Order.Service.Persistence.PostgreSQL.Extensions;