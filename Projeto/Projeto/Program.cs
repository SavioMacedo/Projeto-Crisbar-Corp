using Projeto.Controllers;
using System;

namespace Projeto
{
    class Program
    {
        static void Main(string[] args)
        {
            ExemploController exemplo = new ExemploController();
            exemplo.HelloWorld();
            Console.ReadKey();
        }
    }
}
