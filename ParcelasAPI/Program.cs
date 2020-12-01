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

            Console.WriteLine("Digite o valor do débito: ");
            entradaDebito = Console.ReadLine();

            try
            {
                debito = Convert.ToDouble(entradaDebito);
                Parcelas.debito = debito;
            }
            catch (FormatException e)
            {
                Console.WriteLine("Valor inválido para o campo débito");
            }
            Console.WriteLine("Digite o número de parcelas: ");
            entradaQuantidadeParcelas = Console.ReadLine();

            try { 
                quantidadeParcelas = Convert.ToInt32(entradaQuantidadeParcelas);
                Parcelas.quantidadeParcelas = quantidadeParcelas;
            }
            catch(FormatException e)
            {
                Console.WriteLine("Valor inválido para número de parcelas");
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
