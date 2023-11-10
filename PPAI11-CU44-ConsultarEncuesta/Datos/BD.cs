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
            Cliente clienteUno = new Cliente(Dni: 23123135, NombreCompleto: "Martin Pig", NroCelular: 351674823);
            Cliente clienteDos = new Cliente(Dni: 23123133, NombreCompleto: "Kevin Mas", NroCelular: 351658402);
            Cliente clienteTres = new Cliente(Dni: 23123137, NombreCompleto: "Ismael Gattuso", NroCelular: 351090232);
            Cliente clienteCuatro = new Cliente(Dni: 23123137, NombreCompleto: "Joaco Buco", NroCelular: 351091398);
            Cliente clienteCinco = new Cliente(Dni: 23123138, NombreCompleto: "Lucas Mendoza", NroCelular: 351674823);
            Cliente clienteSeis = new Cliente(Dni: 23123139, NombreCompleto: "Martina López", NroCelular: 351658402);
            Cliente clienteSiete = new Cliente(Dni: 23123140, NombreCompleto: "Carlos Rodríguez", NroCelular: 351090232);
            Cliente clienteOcho = new Cliente(Dni: 23123141, NombreCompleto: "Luisa García", NroCelular: 351091398);
            Cliente clienteNueve = new Cliente(Dni: 23123142, NombreCompleto: "Javier Fernández", NroCelular: 351674823);
            Cliente clienteDiez = new Cliente(Dni: 23123143, NombreCompleto: "María Martínez", NroCelular: 351658402);


            listaClientes.Add(clienteUno);
            listaClientes.Add(clienteDos);
            listaClientes.Add(clienteTres);
            listaClientes.Add(clienteCuatro);
            listaClientes.Add(clienteCinco);
            listaClientes.Add(clienteSeis);
            listaClientes.Add(clienteSiete);
            listaClientes.Add(clienteOcho);
            listaClientes.Add(clienteNueve);
            listaClientes.Add(clienteDiez);
            ;

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
            //CREACION DE ENCUESTA
            List<Encuesta> listaEncuestas = new List<Encuesta>();

            Encuesta encuesta3 = new Encuesta("Encuesta de satisfacion del servicio ofrecido", new DateTime(2024, 12, 1, 1, 00, 00), ListaPreguntas());

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
            List<CambioEstado> cambioEstados5 = new List<CambioEstado>();
            List<CambioEstado> cambioEstados6 = new List<CambioEstado>();
            List<CambioEstado> cambioEstados7 = new List<CambioEstado>();
            List<CambioEstado> cambioEstados8 = new List<CambioEstado>();
            List<CambioEstado> cambioEstados9 = new List<CambioEstado>();
            List<CambioEstado> cambioEstados10 = new List<CambioEstado>();



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
            //Cambios de estado para llamada 5 - LLEVADO A BD
            CambioEstado cambioestado5I = new CambioEstado(FechaHoraInicio: new DateTime(2021, 1, 15, 9, 30, 0), Estado: ListaEstados()[0]);
            CambioEstado cambioestado5F = new CambioEstado(FechaHoraInicio: new DateTime(2021, 1, 15, 9, 42, 0), Estado: ListaEstados()[1]);
            //Cambios de estado para llamada 6
            CambioEstado cambioestado6I = new CambioEstado(FechaHoraInicio: new DateTime(2021, 3, 28, 14, 45, 0), Estado: ListaEstados()[0]);
            CambioEstado cambioestado6F = new CambioEstado(FechaHoraInicio: new DateTime(2021, 3, 28, 15, 00, 30), Estado: ListaEstados()[1]);
            //Cambios de estado para llamada 7
            CambioEstado cambioestado7I = new CambioEstado(FechaHoraInicio: new DateTime(2022, 10, 5, 11, 0, 0), Estado: ListaEstados()[0]);
            CambioEstado cambioestado7F = new CambioEstado(FechaHoraInicio: new DateTime(2022, 10, 5, 11, 15, 0), Estado: ListaEstados()[1]);
            //Cambios de estado para llamada 8
            CambioEstado cambioestado8I = new CambioEstado(FechaHoraInicio: new DateTime(2023, 2, 20, 16, 10, 0), Estado: ListaEstados()[0]);
            CambioEstado cambioestado8F = new CambioEstado(FechaHoraInicio: new DateTime(2023, 2, 20, 16, 18, 0), Estado: ListaEstados()[1]);
            //Cambios de estado para llamada 9
            CambioEstado cambioestado9I = new CambioEstado(FechaHoraInicio: new DateTime(2021, 1, 15, 9, 30, 0), Estado: ListaEstados()[0]);
            CambioEstado cambioestado9F = new CambioEstado(FechaHoraInicio: new DateTime(2021, 1, 15, 9, 42, 0), Estado: ListaEstados()[1]);
            //Cambios de estado para llamada 10
            CambioEstado cambioestado10I = new CambioEstado(FechaHoraInicio: new DateTime(2021, 3, 28, 14, 45, 0), Estado: ListaEstados()[0]);
            CambioEstado cambioestado10F = new CambioEstado(FechaHoraInicio: new DateTime(2021, 3, 28, 15, 00, 30), Estado: ListaEstados()[1]);


            //Se agregan los cambios de estado a la lista de estados

            cambioEstados1.Add(cambioestado1I);
            cambioEstados1.Add(cambioestado1F);
            cambioEstados2.Add(cambioestado2I);
            cambioEstados2.Add(cambioestado2F);
            cambioEstados3.Add(cambioestado3I);
            cambioEstados3.Add(cambioestado3F);
            cambioEstados4.Add(cambioestado4I);
            cambioEstados4.Add(cambioestado4F);
            //LLEVADOS A BD
            cambioEstados5.Add(cambioestado5I);
            cambioEstados5.Add(cambioestado5F);
            cambioEstados6.Add(cambioestado6I);
            cambioEstados6.Add(cambioestado6F);
            cambioEstados7.Add(cambioestado7I);
            cambioEstados7.Add(cambioestado7F);
            cambioEstados8.Add(cambioestado8I);
            cambioEstados8.Add(cambioestado8F);
            cambioEstados9.Add(cambioestado9I);
            cambioEstados9.Add(cambioestado9F);
            cambioEstados10.Add(cambioestado10I);
            cambioEstados10.Add(cambioestado10F);

            //LISTAS PARA RESPUESTAS DE CLIENTES DE LLAMADAS

            List<RespuestaDeCliente> listaRespuestasC1 = new List<RespuestaDeCliente>();
            List<RespuestaDeCliente> listaRespuestasC2 = new List<RespuestaDeCliente>();
            List<RespuestaDeCliente> listaRespuestasC3 = new List<RespuestaDeCliente>();
            List<RespuestaDeCliente> listaRespuestasC4 = new List<RespuestaDeCliente>();
            List<RespuestaDeCliente> listaRespuestasC5 = new List<RespuestaDeCliente>();
            List<RespuestaDeCliente> listaRespuestasC6 = new List<RespuestaDeCliente>();
            List<RespuestaDeCliente> listaRespuestasC7 = new List<RespuestaDeCliente>();
            List<RespuestaDeCliente> listaRespuestasC8 = new List<RespuestaDeCliente>();
            List<RespuestaDeCliente> listaRespuestasC9 = new List<RespuestaDeCliente>();
            List<RespuestaDeCliente> listaRespuestasC10 = new List<RespuestaDeCliente>();


            //RESPUESTAS DE CLIENTES

            RespuestaDeCliente respuesta1C1 = new RespuestaDeCliente(fechaEncuesta: new DateTime(2021, 1, 15, 9, 42, 10), respuestaSeleccionada: ListasRespuestaPosibles()[0][0]);
            RespuestaDeCliente respuesta2C1 = new RespuestaDeCliente(fechaEncuesta: new DateTime(2021, 1, 15, 9, 42, 10), respuestaSeleccionada: ListasRespuestaPosibles()[1][1]);
            RespuestaDeCliente respuesta3C1 = new RespuestaDeCliente(fechaEncuesta: new DateTime(2021, 1, 15, 9, 42, 10), respuestaSeleccionada: ListasRespuestaPosibles()[1][1]);

            RespuestaDeCliente respuesta1C2 = new RespuestaDeCliente(fechaEncuesta: new DateTime(2021, 1, 15, 9, 42, 10), respuestaSeleccionada: ListasRespuestaPosibles()[0][1]);
            RespuestaDeCliente respuesta2C2 = new RespuestaDeCliente(fechaEncuesta: new DateTime(2021, 1, 15, 9, 42, 10), respuestaSeleccionada: ListasRespuestaPosibles()[1][4]);
            RespuestaDeCliente respuesta3C2 = new RespuestaDeCliente(fechaEncuesta: new DateTime(2021, 1, 15, 9, 42, 10), respuestaSeleccionada: ListasRespuestaPosibles()[1][4]);

            RespuestaDeCliente respuesta1C3 = new RespuestaDeCliente(fechaEncuesta: new DateTime(2022, 10, 5, 11, 0, 0), respuestaSeleccionada: ListasRespuestaPosibles()[0][0]);
            RespuestaDeCliente respuesta2C3 = new RespuestaDeCliente(fechaEncuesta: new DateTime(2022, 10, 5, 11, 0, 0), respuestaSeleccionada: ListasRespuestaPosibles()[1][3]);
            RespuestaDeCliente respuesta3C3 = new RespuestaDeCliente(fechaEncuesta: new DateTime(2022, 10, 5, 11, 0, 0), respuestaSeleccionada: ListasRespuestaPosibles()[1][2]);

            RespuestaDeCliente respuesta1C4 = new RespuestaDeCliente(fechaEncuesta: new DateTime(2023, 2, 20, 16, 10, 0), respuestaSeleccionada: ListasRespuestaPosibles()[0][1]);
            RespuestaDeCliente respuesta2C4 = new RespuestaDeCliente(fechaEncuesta: new DateTime(2023, 2, 20, 16, 10, 0), respuestaSeleccionada: ListasRespuestaPosibles()[1][4]);
            RespuestaDeCliente respuesta3C4 = new RespuestaDeCliente(fechaEncuesta: new DateTime(2023, 2, 20, 16, 10, 0), respuestaSeleccionada: ListasRespuestaPosibles()[1][3]);

            RespuestaDeCliente respuesta1C5 = new RespuestaDeCliente(fechaEncuesta: new DateTime(2021, 1, 15, 9, 30, 0), respuestaSeleccionada: ListasRespuestaPosibles()[0][0]);
            RespuestaDeCliente respuesta2C5 = new RespuestaDeCliente(fechaEncuesta: new DateTime(2021, 1, 15, 9, 30, 0), respuestaSeleccionada: ListasRespuestaPosibles()[1][4]);
            RespuestaDeCliente respuesta3C5 = new RespuestaDeCliente(fechaEncuesta: new DateTime(2021, 1, 15, 9, 30, 0), respuestaSeleccionada: ListasRespuestaPosibles()[1][3]);

            RespuestaDeCliente respuesta1C6 = new RespuestaDeCliente(fechaEncuesta: new DateTime(2021, 3, 28, 14, 45, 0), respuestaSeleccionada: ListasRespuestaPosibles()[0][1]);
            RespuestaDeCliente respuesta2C6 = new RespuestaDeCliente(fechaEncuesta: new DateTime(2021, 3, 28, 14, 45, 0), respuestaSeleccionada: ListasRespuestaPosibles()[1][4]);
            RespuestaDeCliente respuesta3C6 = new RespuestaDeCliente(fechaEncuesta: new DateTime(2021, 3, 28, 14, 45, 0), respuestaSeleccionada: ListasRespuestaPosibles()[1][2]);

            RespuestaDeCliente respuesta1C7 = new RespuestaDeCliente(fechaEncuesta: new DateTime(2022, 10, 5, 11, 0, 0), respuestaSeleccionada: ListasRespuestaPosibles()[0][0]);
            RespuestaDeCliente respuesta2C7 = new RespuestaDeCliente(fechaEncuesta: new DateTime(2022, 10, 5, 11, 0, 0), respuestaSeleccionada: ListasRespuestaPosibles()[1][1]);
            RespuestaDeCliente respuesta3C7 = new RespuestaDeCliente(fechaEncuesta: new DateTime(2022, 10, 5, 11, 0, 0), respuestaSeleccionada: ListasRespuestaPosibles()[1][1]);

            RespuestaDeCliente respuesta1C8 = new RespuestaDeCliente(fechaEncuesta: new DateTime(2023, 2, 20, 16, 10, 0), respuestaSeleccionada: ListasRespuestaPosibles()[0][1]);
            RespuestaDeCliente respuesta2C8 = new RespuestaDeCliente(fechaEncuesta: new DateTime(2023, 2, 20, 16, 10, 0), respuestaSeleccionada: ListasRespuestaPosibles()[1][4]);
            RespuestaDeCliente respuesta3C8 = new RespuestaDeCliente(fechaEncuesta: new DateTime(2023, 2, 20, 16, 10, 0), respuestaSeleccionada: ListasRespuestaPosibles()[1][3]);

            RespuestaDeCliente respuesta1C9 = new RespuestaDeCliente(fechaEncuesta: new DateTime(2021, 1, 15, 9, 30, 0), respuestaSeleccionada: ListasRespuestaPosibles()[0][0]);
            RespuestaDeCliente respuesta2C9 = new RespuestaDeCliente(fechaEncuesta: new DateTime(2021, 1, 15, 9, 30, 0), respuestaSeleccionada: ListasRespuestaPosibles()[1][1]);
            RespuestaDeCliente respuesta3C9 = new RespuestaDeCliente(fechaEncuesta: new DateTime(2021, 1, 15, 9, 30, 0), respuestaSeleccionada: ListasRespuestaPosibles()[1][1]);

            RespuestaDeCliente respuesta1C10 = new RespuestaDeCliente(fechaEncuesta: new DateTime(2021, 3, 28, 15, 00, 30), respuestaSeleccionada: ListasRespuestaPosibles()[0][1]);
            RespuestaDeCliente respuesta2C10 = new RespuestaDeCliente(fechaEncuesta: new DateTime(2021, 3, 28, 15, 00, 30), respuestaSeleccionada: ListasRespuestaPosibles()[1][4]);
            RespuestaDeCliente respuesta3C10 = new RespuestaDeCliente(fechaEncuesta: new DateTime(2021, 3, 28, 15, 00, 30), respuestaSeleccionada: ListasRespuestaPosibles()[1][4]);

            listaRespuestasC1.Add(respuesta1C1);
            listaRespuestasC1.Add(respuesta2C1);
            listaRespuestasC1.Add(respuesta3C1);

            listaRespuestasC2.Add(respuesta1C2);
            listaRespuestasC2.Add(respuesta2C2);
            listaRespuestasC2.Add(respuesta3C2);

            listaRespuestasC3.Add(respuesta1C3);
            listaRespuestasC3.Add(respuesta2C3);
            listaRespuestasC3.Add(respuesta3C3);

            listaRespuestasC4.Add(respuesta1C4);
            listaRespuestasC4.Add(respuesta2C4);
            listaRespuestasC4.Add(respuesta3C4);

            listaRespuestasC5.Add(respuesta1C5);
            listaRespuestasC5.Add(respuesta2C5);
            listaRespuestasC5.Add(respuesta3C5);

            listaRespuestasC6.Add(respuesta1C6);
            listaRespuestasC6.Add(respuesta2C6);
            listaRespuestasC6.Add(respuesta3C6);

            listaRespuestasC7.Add(respuesta1C7);
            listaRespuestasC7.Add(respuesta2C7);
            listaRespuestasC7.Add(respuesta3C7);

            listaRespuestasC8.Add(respuesta1C8);
            listaRespuestasC8.Add(respuesta2C8);
            listaRespuestasC8.Add(respuesta3C8);

            listaRespuestasC9.Add(respuesta1C9);
            listaRespuestasC9.Add(respuesta2C9);
            listaRespuestasC9.Add(respuesta3C9);

            listaRespuestasC10.Add(respuesta1C10);
            listaRespuestasC10.Add(respuesta2C10);
            listaRespuestasC10.Add(respuesta3C10);

            //CREACION DE LLAMADAS

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
                respuestasDeCliente: listaRespuestasC3,
                encuestaEnviada: true,
                cambioEstado: cambioEstados3,
                cliente: ListaClientes()[2]
                );

            Llamada llamada4 = new Llamada(
                descripcionOperador: "El operador brinda atención al cliente de manera amable y" +
                " profesional, ofreciendo soluciones y resolviendo consultas con eficiencia.",
                detalleAccionRequerida: "Se requiere que el operador registre la información",
                observacionAuditor: "el operador demostró empatia",
                respuestasDeCliente: listaRespuestasC4,
                encuestaEnviada: true,
                cambioEstado: cambioEstados4,
                cliente: ListaClientes()[3]
                );

            //LLEVADA A BD
            Llamada llamada5 = new Llamada(
                descripcionOperador: "El operador brinda atención al cliente de manera amable y" +
                " profesional, ofreciendo soluciones y resolviendo consultas con eficiencia.",
                detalleAccionRequerida: "Se requiere que el operador registre la información",
                observacionAuditor: "el operador demostró empatia",
                respuestasDeCliente: listaRespuestasC5,
                encuestaEnviada: true,
                cambioEstado: cambioEstados5,
                cliente: ListaClientes()[4]
                );

            Llamada llamada6 = new Llamada(
                descripcionOperador: "El operador brinda atención al cliente de manera amable y" +
                " profesional, ofreciendo soluciones y resolviendo consultas con eficiencia.",
                detalleAccionRequerida: "Se requiere que el operador registre la información",
                observacionAuditor: "el operador demostró empatia",
                respuestasDeCliente: listaRespuestasC6,
                encuestaEnviada: true,
                cambioEstado: cambioEstados6,
                cliente: ListaClientes()[5]
                );

            Llamada llamada7 = new Llamada(
                descripcionOperador: "El operador brinda atención al cliente de manera amable y" +
                " profesional, ofreciendo soluciones y resolviendo consultas con eficiencia.",
                detalleAccionRequerida: "Se requiere que el operador registre la información",
                observacionAuditor: "el operador demostró empatia",
                respuestasDeCliente: listaRespuestasC7,
                encuestaEnviada: true,
                cambioEstado: cambioEstados7,
                cliente: ListaClientes()[6]
                );

            Llamada llamada8 = new Llamada(
                descripcionOperador: "El operador brinda atención al cliente de manera amable y" +
                " profesional, ofreciendo soluciones y resolviendo consultas con eficiencia.",
                detalleAccionRequerida: "Se requiere que el operador registre la información",
                observacionAuditor: "el operador demostró empatia",
                respuestasDeCliente: listaRespuestasC8,
                encuestaEnviada: true,
                cambioEstado: cambioEstados8,
                cliente: ListaClientes()[7]
                );

            Llamada llamada9 = new Llamada(
                descripcionOperador: "El operador brinda atención al cliente de manera amable y" +
                " profesional, ofreciendo soluciones y resolviendo consultas con eficiencia.",
                detalleAccionRequerida: "Se requiere que el operador registre la información",
                observacionAuditor: "el operador demostró empatia",
                respuestasDeCliente: listaRespuestasC9,
                encuestaEnviada: true,
                cambioEstado: cambioEstados9,
                cliente: ListaClientes()[8]
                );

            Llamada llamada10 = new Llamada(
                descripcionOperador: "El operador brinda atención al cliente de manera amable y" +
                " profesional, ofreciendo soluciones y resolviendo consultas con eficiencia.",
                detalleAccionRequerida: "Se requiere que el operador registre la información",
                observacionAuditor: "el operador demostró empatia",
                respuestasDeCliente: listaRespuestasC10,
                encuestaEnviada: true,
                cambioEstado: cambioEstados10,
                cliente: ListaClientes()[9]
                );


            listaLlamadas.Add(llamada1);
            listaLlamadas.Add(llamada2);
            listaLlamadas.Add(llamada3);
            listaLlamadas.Add(llamada4);
            listaLlamadas.Add(llamada5);
            listaLlamadas.Add(llamada6);
            listaLlamadas.Add(llamada7);
            listaLlamadas.Add(llamada8);
            listaLlamadas.Add(llamada9);
            listaLlamadas.Add(llamada10);



            return listaLlamadas;
        }
    }
}