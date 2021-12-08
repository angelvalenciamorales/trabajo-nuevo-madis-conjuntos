using System.Collections.Generic;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Aplicacion_Conjuntos;

namespace TestConjunto
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void probarUnion()
        {
            //Preparacion de datos esperados
            HashSet<string> listConjuntoA = new HashSet<string>();
            HashSet<string> listConjuntoB = new HashSet<string>();            
                        
            listConjuntoA.Add("2");
            listConjuntoA.Add("7");
            listConjuntoA.Add("10");
            listConjuntoA.Add("15");
            listConjuntoA.Add("22");

            listConjuntoB.Add("3");
            listConjuntoB.Add("7");
            listConjuntoB.Add("14");
            listConjuntoB.Add("15");
            listConjuntoB.Add("30");

            HashSet<string> unionAB = new HashSet<string>();
            unionAB.Add("2");
            unionAB.Add("7");
            unionAB.Add("15");
            unionAB.Add("10");
            unionAB.Add("22");
            unionAB.Add("3");
            unionAB.Add("14");
            unionAB.Add("30");
            //unionAB.Add("77");

            var cdoble = new ConjuntoDoble(listConjuntoA,listConjuntoB);

            //Ejecutar prueba
            HashSet<string> resultado;
            resultado = cdoble.operarUnion();
            bool iguales = unionAB.SetEquals(resultado);

            //Assert 
            Assert.IsTrue(iguales);
        }

        [TestMethod]
        public void probarInterseccion()
        {
            //Preparacion de datos esperados
            HashSet<string> listConjuntoA = new HashSet<string>();
            HashSet<string> listConjuntoB = new HashSet<string>();

            listConjuntoA.Add("2");
            listConjuntoA.Add("7");
            listConjuntoA.Add("10");
            listConjuntoA.Add("15");
            listConjuntoA.Add("22");

            listConjuntoB.Add("3");
            listConjuntoB.Add("7");
            listConjuntoB.Add("14");
            listConjuntoB.Add("15");
            listConjuntoB.Add("30");

            HashSet<string> interseccionAB = new HashSet<string>();
            interseccionAB.Add("15");
            interseccionAB.Add("7");
            //interseccionAB.Add("30");

            var cDoble = new ConjuntoDoble(listConjuntoA,listConjuntoB);

            //Ejecucion de prueba
            var resultado = cDoble.operarInterseccion();
            bool iguales = interseccionAB.SetEquals(resultado);

            //Assert
            Assert.IsTrue(iguales);

        }

        [TestMethod]
        public void probarDiferenciaAB()
        {
            //Preparacion de datos esperados
            HashSet<string> listConjuntoA = new HashSet<string>();
            HashSet<string> listConjuntoB = new HashSet<string>();

            listConjuntoA.Add("2");
            listConjuntoA.Add("7");
            listConjuntoA.Add("10");
            listConjuntoA.Add("15");
            listConjuntoA.Add("22");

            listConjuntoB.Add("3");
            listConjuntoB.Add("7");
            listConjuntoB.Add("14");
            listConjuntoB.Add("15");
            listConjuntoB.Add("30");

            HashSet<string> diferenciaAB = new HashSet<string>();
            diferenciaAB.Add("2");
            diferenciaAB.Add("22");
            diferenciaAB.Add("10");
            //diferenciaAB.Add("15");

            var cDoble = new ConjuntoDoble(listConjuntoA,listConjuntoB);

            //Ejecucion de prueba
            var resultado = cDoble.operarDiferenciaAB();
            bool iguales = diferenciaAB.SetEquals(resultado);

            //Assert
            Assert.IsTrue(iguales);
            
        }

        [TestMethod]
        public void probarDiferenciaBA()
        {
            HashSet<string> listConjuntoA = new HashSet<string>();
            HashSet<string> listConjuntoB = new HashSet<string>();

            listConjuntoA.Add("2");
            listConjuntoA.Add("7");
            listConjuntoA.Add("10");
            listConjuntoA.Add("15");
            listConjuntoA.Add("22");

            listConjuntoB.Add("3");
            listConjuntoB.Add("7");
            listConjuntoB.Add("14");
            listConjuntoB.Add("15");
            listConjuntoB.Add("30");

            HashSet<string> diferenciaBA = new HashSet<string>();
            diferenciaBA.Add("3");
            diferenciaBA.Add("30");
            diferenciaBA.Add("14");
            //diferenciaAB.Add("8");

            var cDoble = new ConjuntoDoble(listConjuntoA, listConjuntoB);

            //Ejecucion de prueba
            var resultado = cDoble.operarDiferenciaBA();
            bool iguales = diferenciaBA.SetEquals(resultado);

            //Assert
            Assert.IsTrue(iguales);
        }

        [TestMethod]
        public void probarDiferenciaSimetrica()
        {
            HashSet<string> listConjuntoA = new HashSet<string>();
            HashSet<string> listConjuntoB = new HashSet<string>();

            listConjuntoA.Add("2");
            listConjuntoA.Add("7");
            listConjuntoA.Add("10");
            listConjuntoA.Add("15");
            listConjuntoA.Add("22");

            listConjuntoB.Add("3");
            listConjuntoB.Add("7");
            listConjuntoB.Add("14");
            listConjuntoB.Add("15");
            listConjuntoB.Add("30");

            HashSet<string> diferenciaSim = new HashSet<string>();
            diferenciaSim.Add("3");
            diferenciaSim.Add("30");
            diferenciaSim.Add("14");
            diferenciaSim.Add("2");
            diferenciaSim.Add("22");
            diferenciaSim.Add("10");
            //diferenciaSim.Add("7");

            var cDoble = new ConjuntoDoble(listConjuntoA,listConjuntoB);

            var resultado = cDoble.operarDiferenciaSimetrica();
            bool iguales = diferenciaSim.SetEquals(resultado);

            //Assert
            Assert.IsTrue(iguales);
        }
    }
}