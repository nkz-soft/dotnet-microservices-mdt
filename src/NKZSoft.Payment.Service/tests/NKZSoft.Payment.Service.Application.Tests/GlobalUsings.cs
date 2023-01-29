global using Xunit;
global using MediatR;
global using Moq;
global using FluentAssertions;

global using NKZSoft.Payment.Service.Application.Common.Paging;
global using NKZSoft.Payment.Service.Application.Common.Repositories;
global using NKZSoft.Payment.Service.Application.Tests.Common;
global using NKZSoft.Payment.Service.Application.TodoItems.Commands.Create;
global using NKZSoft.Payment.Service.Application.TodoItems.Commands.Delete;
global using NKZSoft.Payment.Service.Application.TodoItems.Models;
global using NKZSoft.Payment.Service.Application.TodoItems.Queries.Get;
global using NKZSoft.Payment.Service.Application.TodoItems.Queries.GetPage;
global using NKZSoft.Payment.Service.Persistence.PostgreSQL.Repositories;
