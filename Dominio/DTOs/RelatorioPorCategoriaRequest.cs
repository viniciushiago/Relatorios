﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.DTOs
{
    public class RelatorioPorCategoriaRequest
    {
        public DateTime? DataInicio { get; set; }
        public DateTime? DataFim { get; set; }
    }
}
