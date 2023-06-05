using PPAI11_CU44_ConsultarEncuesta.Entidades;
using System;
using System.Collections.Generic;

namespace PPAI11_CU44_ConsultarEncuesta.Datos
{
    public class BD
    {

        public static List<Cliente> ListaClientes()
        {
            List<Cliente> listaClientes = new List<Cliente>();
            Cliente clienteUno = new Cliente(Dni: 23123135, NombreCompleto: "Tito Pig", NroCelular: 351674823);
            Cliente clienteDos = new Cliente(Dni: 23123133, NombreCompleto: "Kevin crack", NroCelular: 351658402);
            Cliente clienteTres = new Cliente(Dni: 23123137, NombreCompleto: "Isma Gatto", NroCelular: 351090232);
            Cliente clienteCuatro = new Cliente(Dni: 23123137, NombreCompleto: "Joaco Wachin", NroCelular: 351091398);
            listaClientes.Add(clienteUno);
            listaClientes.Add(clienteDos);
            listaClientes.Add(clienteTres);
            listaClientes.Add(clienteCuatro);

            return listaClientes;
        }

        public static List<Estado> ListaEstados()
        {
            List<Estado> listaEstados = new List<Estado>();
            Estado estadoI = new Estado(nombre: "Inicializada");
            Estado estadoF = new Estado(nombre: "Finalizada");
            listaEstados.Add(estadoI);
            listaEstados.Add(estadoF);

            return listaEstados;
        }

        public static List<List<RespuestaPosible>> ListasRespuestaPosibles()
        {

            List<RespuestaPosible> listaRespuestaPosibleP1 = new List<RespuestaPosible>();

            RespuestaPosible respuestaP6 = new RespuestaPosible("Ingrese el 1 para marcar 'Sí' o ingrese el 2 para marcar 'No'.", 1);
            RespuestaPosible respuestaP7 = new RespuestaPosible("Ingrese el 1 para marcar 'Sí' o ingrese el 2 para marcar 'No'.", 2);

            listaRespuestaPosibleP1.Add(respuestaP6);
            listaRespuestaPosibleP1.Add(respuestaP7);


            List<RespuestaPosible> listaRespuestaPosibleP2 = new List<RespuestaPosible>();

            RespuestaPosible respuestaP1 = new RespuestaPosible("Ingrese un valor del 1 al 5 donde: 1-Completamente Insatisfecho, 2-Poco Satisfecho, 3-Satisfecho, 4-Muy Satisfecho, 5-Altamente Satisfecho.", 1);
            RespuestaPosible respuestaP2 = new RespuestaPosible("Ingrese un valor del 1 al 5 donde: 1-Completamente Insatisfecho, 2-Poco Satisfecho, 3-Satisfecho, 4-Muy Satisfecho, 5-Altamente Satisfecho.", 2);
            RespuestaPosible respuestaP3 = new RespuestaPosible("Ingrese un valor del 1 al 5 donde: 1-Completamente Insatisfecho, 2-Poco Satisfecho, 3-Satisfecho, 4-Muy Satisfecho, 5-Altamente Satisfecho.", 3);
            RespuestaPosible respuestaP4 = new RespuestaPosible("Ingrese un valor del 1 al 5 donde: 1-Completamente Insatisfecho, 2-Poco Satisfecho, 3-Satisfecho, 4-Muy Satisfecho, 5-Altamente Satisfecho.", 4);
            RespuestaPosible respuestaP5 = new RespuestaPosible("Ingrese un valor del 1 al 5 donde: 1-Completamente Insatisfecho, 2-Poco Satisfecho, 3-Satisfecho, 4-Muy Satisfecho, 5-Altamente Satisfecho.", 5);

            listaRespuestaPosibleP2.Add(respuestaP1);
            listaRespuestaPosibleP2.Add(respuestaP2);
            listaRespuestaPosibleP2.Add(respuestaP3);
            listaRespuestaPosibleP2.Add(respuestaP4);
            listaRespuestaPosibleP2.Add(respuestaP5);


            List<List<RespuestaPosible>> listasRespuestaPosible = new List<List<RespuestaPosible>>
            {
                listaRespuestaPosibleP1,
                listaRespuestaPosibleP2
            };

            return listasRespuestaPosible;
        }

        public static List<Pregunta> ListaPreguntas()
        {
            List<Pregunta> listaPreguntas = new List<Pregunta>();
            Pregunta pregunta1 = new Pregunta("¿Nuestro Servicio logró solucionar su problema?", ListasRespuestaPosibles()[0]);
            Pregunta pregunta2 = new Pregunta("¿Cómo evaluaría su satisfacción respecto al servicio?", ListasRespuestaPosibles()[1]);
            Pregunta pregunta3 = new Pregunta("En general,¿Qué tan satisfecho está con esta compañía?", ListasRespuestaPosibles()[1]);

            listaPreguntas.Add(pregunta1);
            listaPreguntas.Add(pregunta2);
            listaPreguntas.Add(pregunta3);

            return listaPreguntas;
        }



        public static List<Encuesta> ListaEncuestas()
        {
            List<Encuesta> listaEncuestas = new List<Encuesta>();
            //Encuesta encuesta1 = new Encuesta("Encuesta de satisfacion del servicio ofrecido", new DateTime(2021, 12, 1, 1, 00, 00), ListaPreguntas());
            //Encuesta encuesta2 = new Encuesta("Encuesta de satisfacion del servicio ofrecido", new DateTime(2022, 12, 1, 1, 00, 00), ListaPreguntas());
            Encuesta encuesta3 = new Encuesta("Encuesta de satisfacion del servicio ofrecido", new DateTime(2024, 12, 1, 1, 00, 00), ListaPreguntas());

            //listaEncuestas.Add(encuesta1);
            //listaEncuestas.Add(encuesta2);
            listaEncuestas.Add(encuesta3);

            return listaEncuestas;
        }

        public static List<Llamada> ListaLlamadas()
        {
            List<Llamada> listaLlamadas = new List<Llamada>();

            //LISTAS DE CAMBIO DE ESTADO PARA LLAMADAS

            List<CambioEstado> cambioEstados1 = new List<CambioEstado>();
            List<CambioEstado> cambioEstados2 = new List<CambioEstado>();
            List<CambioEstado> cambioEstados3 = new List<CambioEstado>();
            List<CambioEstado> cambioEstados4 = new List<CambioEstado>();


            //CAMBIOS DE ESTADO PARA LLAMADAS

            //Cambios de estado para llamada 1
            CambioEstado cambioestado1I = new CambioEstado(FechaHoraInicio: new DateTime(2021, 1, 15, 9, 30, 0), Estado: ListaEstados()[0]);
            CambioEstado cambioestado1F = new CambioEstado(FechaHoraInicio: new DateTime(2021, 1, 15, 9, 42, 0), Estado: ListaEstados()[1]);
            //Cambios de estado para llamada 2
            CambioEstado cambioestado2I = new CambioEstado(FechaHoraInicio: new DateTime(2021, 3, 28, 14, 45, 0), Estado: ListaEstados()[0]);
            CambioEstado cambioestado2F = new CambioEstado(FechaHoraInicio: new DateTime(2021, 3, 28, 15, 00, 30), Estado: ListaEstados()[1]);
            //Cambios de estado para llamada 3
            CambioEstado cambioestado3I = new CambioEstado(FechaHoraInicio: new DateTime(2022, 10, 5, 11, 0, 0), Estado: ListaEstados()[0]);
            CambioEstado cambioestado3F = new CambioEstado(FechaHoraInicio: new DateTime(2022, 10, 5, 11, 15, 0), Estado: ListaEstados()[1]);
            //Cambios de estado para llamada 4
            CambioEstado cambioestado4I = new CambioEstado(FechaHoraInicio: new DateTime(2023, 2, 20, 16, 10, 0), Estado: ListaEstados()[0]);
            CambioEstado cambioestado4F = new CambioEstado(FechaHoraInicio: new DateTime(2023, 2, 20, 16, 18, 0), Estado: ListaEstados()[1]);

            //Se agregan los cambios de estado a la lista de estados

            cambioEstados1.Add(cambioestado1I);
            cambioEstados1.Add(cambioestado1F);
            cambioEstados2.Add(cambioestado2I);
            cambioEstados2.Add(cambioestado2F);
            cambioEstados3.Add(cambioestado3I);
            cambioEstados3.Add(cambioestado3F);
            cambioEstados4.Add(cambioestado4I);
            cambioEstados4.Add(cambioestado4F);

            //LISTAS PARA RESPUESTAS DE CLIENTES DE LLAMADAS

            List<RespuestaDeCliente> listaRespuestasC1 = new List<RespuestaDeCliente>();
            List<RespuestaDeCliente> listaRespuestasC2 = new List<RespuestaDeCliente>();

            //RESPUESTAS DE CLIENTES

            RespuestaDeCliente respuesta1C1 = new RespuestaDeCliente(fechaEncuesta: new DateTime(2021, 1, 15, 9, 42, 10), respuestaSeleccionada: ListasRespuestaPosibles()[0][0]);
            RespuestaDeCliente respuesta2C1 = new RespuestaDeCliente(fechaEncuesta: new DateTime(2021, 1, 15, 9, 42, 10), respuestaSeleccionada: ListasRespuestaPosibles()[0][1]);
            RespuestaDeCliente respuesta3C1 = new RespuestaDeCliente(fechaEncuesta: new DateTime(2021, 1, 15, 9, 42, 10), respuestaSeleccionada: ListasRespuestaPosibles()[1][1]);

            RespuestaDeCliente respuesta1C2 = new RespuestaDeCliente(fechaEncuesta: new DateTime(2021, 1, 15, 9, 42, 10), respuestaSeleccionada: ListasRespuestaPosibles()[0][1]);
            RespuestaDeCliente respuesta2C2 = new RespuestaDeCliente(fechaEncuesta: new DateTime(2021, 1, 15, 9, 42, 10), respuestaSeleccionada: ListasRespuestaPosibles()[1][4]);
            RespuestaDeCliente respuesta3C2 = new RespuestaDeCliente(fechaEncuesta: new DateTime(2021, 1, 15, 9, 42, 10), respuestaSeleccionada: ListasRespuestaPosibles()[0][0]);

            listaRespuestasC1.Add(respuesta1C1);
            listaRespuestasC1.Add(respuesta2C1);
            listaRespuestasC1.Add(respuesta3C1);

            listaRespuestasC2.Add(respuesta1C2);
            listaRespuestasC2.Add(respuesta2C2);
            listaRespuestasC2.Add(respuesta3C2);

            Llamada llamada1 = new Llamada(
                descripcionOperador: "El operador brinda atención al cliente de manera amable y" +
                " profesional, ofreciendo soluciones y resolviendo consultas con eficiencia.",
                detalleAccionRequerida: "Se requiere que el operador registre la información",
                observacionAuditor: " el operador demostró un excelente manejo de las llamadas",
                respuestasDeCliente: listaRespuestasC1,
                encuestaEnviada: true,
                cambioEstado: cambioEstados1,
                cliente: ListaClientes()[0]
                );

            Llamada llamada2 = new Llamada(
                descripcionOperador: "El operador brinda atención al cliente de manera amable y" +
                " profesional, ofreciendo soluciones y resolviendo consultas con eficiencia.",
                detalleAccionRequerida: "Se requiere que el operador registre la información",
                observacionAuditor: "el operador demostró paciencia",
                respuestasDeCliente: listaRespuestasC2,
                encuestaEnviada: true,
                cambioEstado: cambioEstados2,
                cliente: ListaClientes()[1]
                );

            Llamada llamada3 = new Llamada(
                descripcionOperador: "El operador brinda atención al cliente de manera amable y" +
                " profesional, ofreciendo soluciones y resolviendo consultas con eficiencia.",
                detalleAccionRequerida: "Se requiere que el operador registre la información",
                observacionAuditor: "el operador demostró empatia",
                respuestasDeCliente: listaRespuestasC2,
                encuestaEnviada: true,
                cambioEstado: cambioEstados3,
                cliente: ListaClientes()[2]
                );

            Llamada llamada4 = new Llamada(
            descripcionOperador: "El operador brinda atención al cliente de manera amable y" +
            " profesional, ofreciendo soluciones y resolviendo consultas con eficiencia.",
            detalleAccionRequerida: "Se requiere que el operador registre la información",
            observacionAuditor: "el operador demostró empatia",
            respuestasDeCliente: listaRespuestasC1,
            encuestaEnviada: true,
            cambioEstado: cambioEstados4,
            cliente: ListaClientes()[3]
            );



            listaLlamadas.Add(llamada1);
            listaLlamadas.Add(llamada2);
            listaLlamadas.Add(llamada3);
            listaLlamadas.Add(llamada4);

            return listaLlamadas;
        }
    }
}