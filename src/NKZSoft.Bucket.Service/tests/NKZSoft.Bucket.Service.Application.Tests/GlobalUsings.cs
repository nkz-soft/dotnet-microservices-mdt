global using Xunit;
global using MediatR;
global using Moq;
global using FluentAssertions;

global using NKZSoft.Bucket.Service.Application.Common.Paging;
global using NKZSoft.Bucket.Service.Application.Common.Repositories;
global using NKZSoft.Bucket.Service.Application.Tests.Common;
global using NKZSoft.Bucket.Service.Application.TodoItems.Commands.Create;
global using NKZSoft.Bucket.Service.Application.TodoItems.Commands.Delete;
global using NKZSoft.Bucket.Service.Application.TodoItems.Models;
global using NKZSoft.Bucket.Service.Application.TodoItems.Queries.Get;
global using NKZSoft.Bucket.Service.Application.TodoItems.Queries.GetPage;
global using NKZSoft.Bucket.Service.Persistence.PostgreSQL.Repositories;
