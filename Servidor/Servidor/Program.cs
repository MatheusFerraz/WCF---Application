using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCF.Contrato;
using WCF.Servidor;
using System.ServiceModel;

namespace Servidor
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost svh = new ServiceHost(typeof(ServiceImplementation));
            svh.AddServiceEndpoint(typeof(WCF.Contrato.IService1), new NetTcpBinding(), "net.tcp://localhost:");
            svh.Open();

            Console.WriteLine("Rodando Servidor...");
            Console.ReadLine();
            svh.Close();
        }
    }
}
