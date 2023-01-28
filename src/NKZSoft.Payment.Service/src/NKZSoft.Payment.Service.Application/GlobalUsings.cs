global using System.Collections.Generic;
global using System.Diagnostics.CodeAnalysis;
global using System.Reflection;

global using Microsoft.Extensions.Logging;
global using Microsoft.EntityFrameworkCore;
global using FluentValidation;
global using FluentResults;
global using MediatR;
global using Mapster;
global using MapsterMapper;
global using System.Linq.Expressions;
global using System.Runtime.Serialization;
global using Ardalis.Specification;
global using Ardalis.Specification.EntityFrameworkCore;
global using FluentValidation.Results;
global using MassTransit;
global using Microsoft.Extensions.DependencyInjection;
global using Microsoft.Extensions.DependencyInjection.Extensions;
global using NKZSoft.Payment.Service.Application.TodoItems.Specifications;
global using NKZSoft.Payment.Service.Common;

global using NKZSoft.Payment.Service.Domain.AggregatesModel.ToDoAggregates.Entities;
global using NKZSoft.Payment.Service.Domain.Events;
global using NKZSoft.Payment.Service.Events.Event.ToDoItem.Create;
global using NKZSoft.Payment.Service.Events.Event.ToDoItem.Update;
