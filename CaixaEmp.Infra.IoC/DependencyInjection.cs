﻿using CaixaEmp.Application.Interfaces;
using CaixaEmp.Application.Mappings;
using CaixaEmp.Application.Services;
using CaixaEmp.Domain.Interfaces;
using CaixaEmp.Domain.Validation;
using CaixaEmp.Infra.Data.Context;
using AutoMapper;
using CaixaEmp.Infra.Data.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEmp.Infra.IoC
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
             options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"
            ), b => b.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName)));

            services.AddScoped<IEmplooyerRepository, EmplooyerRepository>();
            services.AddScoped<IExpenseCategoryRepository, ExpenseCategoryRepository>();
            services.AddScoped<IExpenseRepository, ExpenseRepository>();
            services.AddScoped<IInclusionRepository, InclusionRepository>();
            services.AddScoped<IWithdrawalRepository, WithdrawalRepository>();
            services.AddScoped<IBalanceRepository, BalanceRespository>();
            services.AddScoped<IMonthRepository, MonthRepository>();

            services.AddScoped<IEmplooyerService, EmplooyerService>();
            services.AddScoped<IExpenseCategoryService, ExpenseCategoryService>();
            services.AddScoped<IExpenseService, ExpenseService>();
            services.AddScoped<IInclusionService, InclusionService>();
            services.AddScoped<IWithdrawalService, WithdrawalService>();
            services.AddScoped<IBalanceService, BalanceService>();
            services.AddScoped<IMonthService, MonthService>();

            services.AddAutoMapper(typeof(DomainToDTOMappingProfile));


            return services;
        }
    }
}
