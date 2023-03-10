global using System;
global using System.Diagnostics.CodeAnalysis;
global using System.Reflection;
global using Ardalis.Specification;
global using Ardalis.Specification.EntityFrameworkCore;
global using EFCoreSecondLevelCacheInterceptor;
global using Microsoft.EntityFrameworkCore;
global using Microsoft.EntityFrameworkCore.Metadata.Builders;
global using Microsoft.EntityFrameworkCore.Design;
global using Microsoft.Extensions.Configuration;
global using Microsoft.Extensions.DependencyInjection;
global using MediatR;
global using Microsoft.EntityFrameworkCore.ChangeTracking;
global using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
global using Microsoft.Extensions.DependencyInjection.Extensions;
global using NKZSoft.Order.Service.Application.Common.Interfaces;
global using NKZSoft.Order.Service.Common;
global using NKZSoft.Order.Service.Domain.AggregatesModel.ToDoAggregates.Entities;
global using NKZSoft.Order.Service.Domain.Common;
global using NKZSoft.Order.Service.EFCore.Caching.Redis;
global using Serilog;
