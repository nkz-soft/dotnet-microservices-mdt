global using System;
global using HealthChecks.UI.Client;
global using Microsoft.Extensions.Configuration;
global using Microsoft.Extensions.DependencyInjection;
global using Microsoft.Extensions.Logging;
global using Microsoft.AspNetCore.Builder;
global using Microsoft.AspNetCore.Diagnostics.HealthChecks;
global using NKZSoft.Service.Configuration.Logger;
global using NKZSoft.Order.Service.Application;
global using NKZSoft.Order.Service.Application.Common.Interfaces;
global using NKZSoft.Order.Service.Infrastructure.Core;
global using NKZSoft.Order.Service.MessageBrokers.RabbitMq.Extensions;
global using NKZSoft.Order.Service.Persistence.PostgreSQL.Extensions;
global using NKZSoft.Order.Service.Presentation.Rest.Extensions;

