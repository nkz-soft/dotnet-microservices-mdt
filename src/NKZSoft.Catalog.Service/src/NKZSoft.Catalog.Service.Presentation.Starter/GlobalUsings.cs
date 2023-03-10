global using System;
global using HealthChecks.UI.Client;
global using Microsoft.Extensions.Configuration;
global using Microsoft.Extensions.DependencyInjection;
global using Microsoft.Extensions.Logging;
global using Microsoft.AspNetCore.Builder;
global using Microsoft.AspNetCore.Diagnostics.HealthChecks;
global using NKZSoft.Service.Configuration.Logger;
global using NKZSoft.Catalog.Service.Application;
global using NKZSoft.Catalog.Service.Application.Common.Interfaces;
global using NKZSoft.Catalog.Service.Infrastructure.Core;
global using NKZSoft.Catalog.Service.MessageBrokers.RabbitMq.Extensions;
global using NKZSoft.Catalog.Service.Persistence.PostgreSQL.Extensions;