using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using TPFinal;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestTPFinal
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestLogin()
        {
            Fachada iFachada = new Fachada();
            string DNI = "12345678";
            string PIN = "1234";
            Usuario iUsuario=iFachada.Login(DNI, PIN);
            Assert.AreEqual(iUsuario.Nombre,"Juan Amador");
        }

        [TestMethod]
        public void TestLoginFallido()
        {
            Fachada iFachada = new Fachada();
            string DNI = "12345678";
            string PIN = "0000";
            Usuario iUsuario = iFachada.Login(DNI, PIN);
            Assert.AreEqual(iUsuario, null);
        }

        [TestMethod]
        public void TestTarjetas()
        {
            Fachada iFachada = new Fachada();
            string DNI = "12345679";
            List<Product> iLista = iFachada.ObtenerTarjetas(DNI);
            Product TarjetaDevuelta = iLista.First();
            Assert.AreEqual(TarjetaDevuelta.name, "Tarjeta Mastercard Banco del Sur");
        }

        [TestMethod]
        public void TestSaldo()
        {
            Fachada iFachada = new Fachada();
            string DNI = "12345680";
            string iSaldo = iFachada.SaldoCuentaCorriente(DNI);
            Assert.AreEqual(iSaldo, "23900");
        }

        [TestMethod]
        public void TestMovimientos()
        {
            Fachada iFachada = new Fachada();
            string DNI = "12345680";
            List<Movement> iLista = iFachada.UltimosMovimientos(DNI);
            Movement MovimientoDevuelto = iLista.First();
            Assert.AreEqual(MovimientoDevuelto.date, "2018-12-01");
        }
    }
}
