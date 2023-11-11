using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace PPAI11_CU44_ConsultarEncuesta.Entidades.Interfaces
{
    internal interface Iiterador
    {

        void actual();
        bool haTerminado();
        void primero();
        void siguiente();
        bool cumpleFiltros();
    }
}
