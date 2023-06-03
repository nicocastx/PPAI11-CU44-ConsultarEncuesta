using PPAI11_CU44_ConsultarEncuesta.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI11_CU44_ConsultarEncuesta.Datos
{
    public class BD
    {
        static string descripcionRP15 = "Ingrese un valor del 1 al 5 donde: 1-Completamente Insatisfecho, 2-Poco Satisfecho, 3-Satisfecho, 4-Muy Satisfecho, 5-Altamente Satisfecho.";
        static string descripcionRP12 = "Ingrese el 1 para marcar 'Sí' o ingrese el 2 para marcar 'No'.";

        /*Objetos Cliente*/
        Cliente clienteUno = new Cliente(43881554, "Fransico Ahumada", 352659835);
        Cliente clienteDos = new Cliente(42114678, "Ernesto Ducart", 351657866);
        Cliente clienteTres = new Cliente(4177953, "Agustin Ortega", 351597243);
        Cliente clienteCuatro = new Cliente(43881554, "Agostina Beletti", 351237966);
        Cliente ClienteCinco = new Cliente(43224678, "Leandro Colmenares", 351457292);

        //Objetos Llamadas
        Llamada llamada1 = new Llamada(
            descripcionOperador: "Esta es una llamada",
            detalleAccionRequerida: 1,
            duracion: 12,
            encuestaEnviada: true,
            observacionAuditor: ""
            );



        /*Objetos Encuesta*/
        Encuesta encuesta = new Encuesta("Encuesta de satisfacción del Cliente", new DateTime(2023, 12, 31, 23, 59, 59));

        /*Objetos Pregunta*/
        Pregunta preguntaUno = new Pregunta("¿Nuestro Servicio logró solucionar su problema?");
        Pregunta preguntaDos = new Pregunta("¿Cómo evaluaría su satisfacción respecto al servicio entregado por nuestro Operador?");
        Pregunta preguntaTres = new Pregunta("En general,¿Qué tan satisfecho está con esta compañía?");

        /*Objetos Respuesta Posible*/
        RespuestaPosible respuestaPosibleSN = new RespuestaPosible(descripcionRP12, 1);
        RespuestaPosible respuestaPosibleNS = new RespuestaPosible(descripcionRP12, 2);

        RespuestaPosible respuestaPosibleUno = new RespuestaPosible(descripcionRP15, 1);
        RespuestaPosible respuestaPosibleDos = new RespuestaPosible(descripcionRP15, 2);
        RespuestaPosible respuestaPosibleTres = new RespuestaPosible(descripcionRP15, 3);
        RespuestaPosible respuestaPosibleCuatro = new RespuestaPosible(descripcionRP15, 4);
        RespuestaPosible respuestaPosibleCinco = new RespuestaPosible(descripcionRP15, 5);


        //Objetos respuestasDeCliente
        RespuestaDeCliente respuesta1Cliente1 = new RespuestaDeCliente(fechaEncuesta: new DateTime(2023, 12, 31, 23, 59, 59), respuestaSeleccionada: respuestaPosibleUno);
    }




}
