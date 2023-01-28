global using System;
global using HealthChecks.UI.Client;
global using Microsoft.Extensions.Configuration;
global using Microsoft.Extensions.DependencyInjection;
global using Microsoft.Extensions.Logging;
global using Microsoft.AspNetCore.Builder;
global using Microsoft.AspNetCore.Diagnostics.HealthChecks;
global using NKZSoft.Service.Configuration.Logger;
global using NKZSoft.Bucket.Service.Application;
global using NKZSoft.Bucket.Service.Application.Common.Interfaces;
global using NKZSoft.Bucket.Service.Infrastructure.Core;
global using NKZSoft.Bucket.Service.MessageBrokers.RabbitMq.Extensions;
global using NKZSoft.Bucket.Service.Persistence.PostgreSQL.Extensions;
global using NKZSoft.Bucket.Service.Presentation.Rest.Extensions;

