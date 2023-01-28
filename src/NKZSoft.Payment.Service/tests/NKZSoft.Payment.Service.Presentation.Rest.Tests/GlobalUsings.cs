global using System.Net;
global using DotNet.Testcontainers.Containers;
global using Microsoft.AspNetCore.Hosting;
global using Microsoft.Extensions.DependencyInjection;
global using Microsoft.EntityFrameworkCore;

global using Xunit;
global using Xunit.Extensions.Ordering;
global using FluentAssertions;
global using MediatR;

global using NKZSoft.Payment.Service.Domain.AggregatesModel.ToDoAggregates.Entities;
global using NKZSoft.Payment.Service.Persistence.PostgreSQL;
global using NKZSoft.Payment.Service.Common.Tests;
global using NKZSoft.Payment.Service.Application.Models;
global using NKZSoft.Payment.Service.Application.Common.Interfaces;
global using NKZSoft.Payment.Service.Application.Common.Paging;
global using NKZSoft.Payment.Service.Application.TodoItems.Commands.Create;
global using NKZSoft.Payment.Service.Application.TodoItems.Models;
global using NKZSoft.Payment.Service.Persistence.PostgreSQL.Extensions;