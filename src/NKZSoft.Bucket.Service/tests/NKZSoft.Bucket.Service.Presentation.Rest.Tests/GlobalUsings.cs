global using System.Net;
global using DotNet.Testcontainers.Containers;
global using Microsoft.AspNetCore.Hosting;
global using Microsoft.Extensions.DependencyInjection;
global using Microsoft.EntityFrameworkCore;

global using Xunit;
global using Xunit.Extensions.Ordering;
global using FluentAssertions;
global using MediatR;

global using NKZSoft.Bucket.Service.Domain.AggregatesModel.ToDoAggregates.Entities;
global using NKZSoft.Bucket.Service.Persistence.PostgreSQL;
global using NKZSoft.Bucket.Service.Common.Tests;
global using NKZSoft.Bucket.Service.Application.Models;
global using NKZSoft.Bucket.Service.Application.Common.Interfaces;
global using NKZSoft.Bucket.Service.Application.Common.Paging;
global using NKZSoft.Bucket.Service.Application.TodoItems.Commands.Create;
global using NKZSoft.Bucket.Service.Application.TodoItems.Models;
global using NKZSoft.Bucket.Service.Persistence.PostgreSQL.Extensions;