﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroEscola.Models
{
    internal class Curso
    {
            public int Id { get; set; }

            public string Nome { get; set; }

            public string CargaHoraria { get; set; }

            public string Descricao { get; set; }

            public string Turno { get; set; }
        }
}
