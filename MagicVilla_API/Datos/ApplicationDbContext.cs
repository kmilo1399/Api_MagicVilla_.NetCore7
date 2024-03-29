﻿using MagicVilla_API.Modelos;
using Microsoft.EntityFrameworkCore;

namespace MagicVilla_API.Datos
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :base(options)
        {
            
        }

        public DbSet<Villa> villas {  get; set; }

        public DbSet<NumeroVilla> numeroVillas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Villa>().HasData(
                    new Villa()
                    {
                        Id = 1,
                        Nombre = "villa real",
                        Detalle = "Detalle de la villa",
                        ImagenUrl = "",
                        Ocupantes = 5,
                        MetrosCuadrados = 50,
                        Tarifa = 200,
                        Amenidad = "",
                        FechaCreacion = DateTime.Now,
                        FechaActualizacion = DateTime.Now,
                    },
                    new Villa()
                    {
                        Id = 2,
                        Nombre = "Premium vista a la piscina",
                        Detalle = "Detalle de la villa",
                        ImagenUrl = "",
                        Ocupantes = 4,
                        MetrosCuadrados = 40,
                        Tarifa = 150,
                        Amenidad = "",
                        FechaCreacion = DateTime.Now,
                        FechaActualizacion = DateTime.Now,
                    }
                );
        }
    }
}
