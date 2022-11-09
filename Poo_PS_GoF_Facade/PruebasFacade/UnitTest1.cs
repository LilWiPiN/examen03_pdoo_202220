using Poo_PS_GoF_Facade;

namespace PruebasFacade
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void DemuestraCreditoAprobadoReputacionB()
        {
            string nombreCliente = "Daniel";
            float valorPrestamo = 10000;
            float valorCesantias = 15000;
            int puntajeDataCredito = 800;

            EntidadCrediticia laEntidad = new EntidadCrediticia(nombreCliente, valorPrestamo,
                                                                valorCesantias, puntajeDataCredito);

            laEntidad.EstudiaCredito();

            string resultadoEsperado = "APROBADA! :-) ";
            string resultadoObtenido = laEntidad.ObtieneResultadoAprovacion();

            Assert.AreEqual(resultadoEsperado, resultadoObtenido);
        }

        [TestMethod]
        public void DemuestraCreditoRechazadoReputacionA()
        {
            //Arrange
            string nombreCliente = "Daniel";
            float valorPrestamo = 30000;
            float valorCesantias = 2000;
            int puntajeDataCredito = 1000;

            EntidadCrediticia laEntidad = new EntidadCrediticia(nombreCliente, valorPrestamo,
                                                                valorCesantias, puntajeDataCredito);

            laEntidad.EstudiaCredito();

            //Act
            string resultadoEsperado = "RECHAZADA! :_( ";
            string resultadoObtenido = laEntidad.ObtieneResultadoAprovacion();

            //Assert
            Assert.AreEqual(resultadoEsperado, resultadoObtenido);
        }
    }
}