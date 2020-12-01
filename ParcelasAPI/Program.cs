using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParcelasAPI
{
    //testando commit 
    public class Program
    {
        Parcelas parcela = new Parcelas();
        public static void Main(string[] args)
        {
            string entradaQuantidadeParcelas;
            string entradaDebito;

            int quantidadeParcelas;
            double debito;

            Console.WriteLine("Digite o valor do d�bito: ");
            entradaDebito = Console.ReadLine();

            try
            {
                debito = Convert.ToDouble(entradaDebito);
                Parcelas.debito = debito;
            }
            catch (FormatException e)
            {
                Console.WriteLine("Valor inv�lido para o campo d�bito");
            }
            Console.WriteLine("Digite o n�mero de parcelas: ");
            entradaQuantidadeParcelas = Console.ReadLine();

            try { 
                quantidadeParcelas = Convert.ToInt32(entradaQuantidadeParcelas);
                Parcelas.quantidadeParcelas = quantidadeParcelas;
            }
            catch(FormatException e)
            {
                Console.WriteLine("Valor inv�lido para n�mero de parcelas");
            }           
            //Console.WriteLine(Parcelas.quantidadeParcelas);
            //Console.WriteLine(Parcelas.debito);
            //CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
    
                });
    }
}
