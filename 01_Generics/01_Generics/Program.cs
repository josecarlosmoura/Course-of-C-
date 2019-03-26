using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01_Generics.Modelo;

namespace _01_Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro carro = new Carro() { Marca = "Fiat", Modelo = "Uno" };
            Casa casa = new Casa() { Cidade = "Uberlândia", Endereco = "João Naves" };
            Usuario usuario = new Usuario() { Nome = "José", Email = "jose.silva@cedrotech.com", Senha = "jose123" };

            Serializador.Serializar(carro);
            Serializador.Serializar(casa);
            Serializador.Serializar(usuario);

            Carro carroDois = Serializador.Deserializar<Carro>();
            Casa casaDois = Serializador.Deserializar<Casa>();
            Usuario usuarioDois = Serializador.Deserializar<Usuario>();

            Console.WriteLine($"Carro2\n Marca: {carroDois.Marca}\n Modelo: {carroDois.Modelo}");

            Console.WriteLine($"Casa2\n Cidade: {casaDois.Cidade}\n Endereço: {casaDois.Endereco}");

            Console.WriteLine($"Usuário2\n Nome: {usuarioDois.Nome}\n Email: {usuarioDois.Email}\n Senha: {usuarioDois.Senha}");

            Console.ReadKey();
        }
    }
}