using Microsoft.EntityFrameworkCore;
using Api.Monitoramento.Domain.Models;
using Api.Monitoramento.Infra.Data.EntityConfig;
using System;
using System.Collections.Generic;
using System.Text;

namespace Api.Monitoramento.Infra.Data.Context
{    
    public class MonitoramentoContext : DbContext
    {
        public DbSet<HardwareMonitoramento> HardwaresMonitoramentos { get; set; }
        public DbSet<HardwareMonitoramentoLog> HardwaresMonitoramentosLog { get; set; }
        public MonitoramentoContext(DbContextOptions<MonitoramentoContext> options) : base(options)
        {
            this.Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration<HardwareMonitoramento>(new HardwareMonitoramentoConfig());

            modelBuilder.ApplyConfiguration<HardwareMonitoramentoLog>(new HardwareMonitoramentoLogConfig());
            modelBuilder.Entity<HardwareMonitoramentoLog>().HasOne(h => h.HardwareMonitoramento);
         }
    }
}
