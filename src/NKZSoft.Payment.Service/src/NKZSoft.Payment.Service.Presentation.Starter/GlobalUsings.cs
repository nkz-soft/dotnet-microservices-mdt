global using System;
global using EFCoreSecondLevelCacheInterceptor;
global using HealthChecks.UI.Client;
global using Microsoft.Extensions.Configuration;
global using Microsoft.Extensions.DependencyInjection;
global using Microsoft.Extensions.Logging;
global using Microsoft.AspNetCore.Builder;
global using Microsoft.AspNetCore.Diagnostics.HealthChecks;
global using NKZSoft.Service.Configuration.Logger;
global using NKZSoft.Payment.Service.Application;
global using NKZSoft.Payment.Service.Application.Common.Interfaces;
global using NKZSoft.Payment.Service.EFCore.Caching.Redis.Extensions;
global using NKZSoft.Payment.Service.Infrastructure.Core;
global using NKZSoft.Payment.Service.MessageBrokers.RabbitMq.Extensions;
global using NKZSoft.Payment.Service.Persistence.PostgreSQL.Extensions;
global using NKZSoft.Payment.Service.Presentation.Rest.Extensions;

