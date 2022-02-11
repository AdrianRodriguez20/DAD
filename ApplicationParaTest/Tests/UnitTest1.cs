using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ApplicationParaTest;

namespace Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]

        public void leerArchivo_Existe_Test()
        {
            string resultado, resultado_ok;

            resultado = EjercicioCaracteres.leerArchivo();
            resultado_ok = "á à lá é è de le clí clicliOOOOOOOOOOOU" + "kilo àéí" + "la la la";
            Assert.AreEqual(resultado_ok, resultado);
        }

        [TestMethod]
        public void sacarAcentos_Test()
        {
            string resultado, resultado_ok;

            resultado = EjercicioCaracteres.sacarAcentos("á Áó Ó");
            resultado_ok = "a Ao O";
            Assert.AreEqual(resultado_ok, resultado);
        }
        
        [TestMethod]
        public void darVuelta_Test()
        {
            string resultado, resultado_ok;

            resultado = EjercicioCaracteres.darVuelta("hola");
            resultado_ok = "aloh";
            Assert.AreEqual(resultado_ok, resultado);
        }
        

        
    }
}
