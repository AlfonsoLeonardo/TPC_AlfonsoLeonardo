﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class IngreditePorComida
    {
        public Ingrediente Ingrediente { set; get; }
        public Comida Comida { set; get; }
        public DateTime FechaCreacion { get; set; }
        public Usuario UsuarioCreacion { get; set; }
        public DateTime FechaModificacion { get; set; }
        public Usuario UsuarioModificacion { get; set; }
        public decimal Cantidad { set; get; }
        public bool Estado { set; get; }

    }
    public class IngredienteC
    {
        public bool Agregar { get; set; }
        public int Id { get; set; }
        public string Nombre { get; set; }
        public decimal Cantidad { get; set; }
        public bool Estado { get; set; }


    }
}
