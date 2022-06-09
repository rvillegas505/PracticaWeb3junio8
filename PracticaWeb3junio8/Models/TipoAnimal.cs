﻿using System;
using System.Collections.Generic;

#nullable disable

namespace PracticaWeb3junio8.Models
{
    public partial class TipoAnimal
    {
        public TipoAnimal()
        {
            Animals = new HashSet<Animal>();
        }

        public int IdTipoAnimal { get; set; }
        public string Nombre { get; set; }

        public virtual ICollection<Animal> Animals { get; set; }
    }
}
