global using Xunit;
global using MediatR;
global using Moq;
global using FluentAssertions;

global using NKZSoft.Order.Service.Application.Common.Paging;
global using NKZSoft.Order.Service.Application.Common.Repositories;
global using NKZSoft.Order.Service.Application.Tests.Common;
global using NKZSoft.Order.Service.Application.TodoItems.Commands.Create;
global using NKZSoft.Order.Service.Application.TodoItems.Commands.Delete;
global using NKZSoft.Order.Service.Application.TodoItems.Models;
global using NKZSoft.Order.Service.Application.TodoItems.Queries.Get;
global using NKZSoft.Order.Service.Application.TodoItems.Queries.GetPage;
global using NKZSoft.Order.Service.Persistence.PostgreSQL.Repositories;
