﻿using MagicVilla_API.Modelos.DTO;

namespace MagicVilla_API.Datos
{
    public static class VillaStore
    {
        public static List<VillaDto> villaList = new List<VillaDto>
        {
            new VillaDto
            {
                Id = 1,
                Nombre = "Visita la piscina",
                Ocupantes = 3,
                MetrosCuadrados = 50,
            },
            new VillaDto 
            { 
                Id = 2,
                Nombre = "Visita a la playa",
                Ocupantes = 4,
                MetrosCuadrados = 80
            }
        };
    }
}
