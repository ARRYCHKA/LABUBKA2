using Microsoft.EntityFrameworkCore;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataAccessLayer
{
    /// <summary>
    /// Представляет контекст базы данных для приложения, обеспечивающий доступ к данным студентов.
    /// Этот класс настраивает подключение к базе данных и определяет структуру таблицы Students.
    /// </summary>
    public class AppDbContext : DbContext
    {
        /// <summary>
        /// Получает или устанавливает DbSet студентов. Это представляет таблицу Students в базе данных.
        /// </summary>
        public DbSet<Car> car { get; set; }

        /// <summary>
        /// Инициализирует новый экземпляр класса AppDbContext.
        /// </summary>
        /// <param name="options">Параметры, используемые DbContext.</param>
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            ChangeTracker.AutoDetectChangesEnabled = true;
        }

        /// <summary>
        /// Настраивает модель, которая была обнаружена по соглашению из типов сущностей,
        /// представленных в свойствах DbSet в производном контексте.
        /// </summary>
        /// <param name="modelBuilder">Построитель, используемый для конструирования модели для этого контекста.</param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Car>(entity =>
            {
                entity.ToTable("students");
                entity.Property(e => e.Id).HasColumnName("id");
                entity.Property(e => e.Brand).HasColumnName("Brand");
                entity.Property(e => e.Color).HasColumnName("Color");
                entity.Property(e => e.Year).HasColumnName("Year");
            });
        }
    }
}
