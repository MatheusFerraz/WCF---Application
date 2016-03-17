using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using WCF.Contrato;
using WCF.Servidor;

namespace Cliente
{
    class Program
    {
        static void Main(string[] args)
        {
           try
           {
                ChannelFactory<WCF.Contrato.IService1> scf = new ChannelFactory<WCF.Contrato.IService1>(new NetTcpBinding(),"net.tcp://localhost:");
                
                WCF.Contrato.IService1 s = scf.CreateChannel();

            while (true)
            {
                Console.Write("Enviar para o Servidor: ");
                string nome = Console.ReadLine();
                string resposta = s.Ping(nome);
                Console.WriteLine("Resposta vinda do servidor: " + resposta);
            }
         }
          catch (System.Exception)
          {
                Console.WriteLine("Servidor fora do ar.");
                Console.ReadLine();
          }
        }
    }
}
