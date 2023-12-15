using System.Text.Json;
using ProjetoViagem.Domain.Entities;

namespace ProjetoViagem.Teste
{
    [TestClass]
    public class UnitTestDomain
    {
        [TestMethod]
        public void TestCidade()
        {
            var cidade = new Cidade
            {
                Nome = "Birigui",
                Estado = "SP"
            };

            Console.WriteLine(JsonSerializer.Serialize(cidade));
            Assert.AreEqual(cidade.Nome, "Birigui");
            Assert.AreEqual(cidade.Estado, "SP");
        }

        [TestMethod] 
        public void TestUsuario() 
        {
            var usuario = new Usuario
            {
                Nome = "Caio",
                Email = "caio.hespporte@gmail.com",
                Senha = "1234"
            };

            Console.WriteLine(JsonSerializer.Serialize(usuario));
            Assert.AreEqual(usuario.Nome, "Caio");
            Assert.AreEqual(usuario.Email, "caio.hespporte@gmail.com");
            Assert.AreEqual(usuario.Senha, "1234");
        }
    
    }
}