﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI11_CU44_ConsultarEncuesta.Entidades.Interfaces
{
    internal interface IAgregado
    {
        Iiterador crearIterador(Object filtros);
    }
}
