using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using ZeldaDosProbres.Core;

namespace ZeldaDosPobres.Test
{
    [TestFixture]
    public class QuandoEstiverNoNivel1
    {
        private Nivel1 nivel1;
        private Jogo jogo;

        [SetUp]
        public void Cenario()
        {
            jogo = new Jogo();
            nivel1 = new Nivel1(jogo);
        }
        
        [Test]
        public void DeveTerUmInimigo()
        {
            Assert.That(nivel1.Inimigos.Count, Is.EqualTo(1));
        }

        [Test]
        public void DeveTerArmaNoRecinto()
        {
            Assert.That(nivel1.ArmaNoRecinto, Is.InstanceOf<Espada>());
        }
    }
}
