using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WCF.Servidor
{
    public class ServiceImplementation : WCF.Contrato.IService1
    {
        public string Ping(string nome)
        {
            Console.WriteLine("Recebendo do cliente: " + nome);
            return nome;
        }
    }
}
