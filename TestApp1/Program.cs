using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //IMessageWriter writer = new ConsoleMessageWriter();
            var typeName = ConfigurationManager.AppSettings["messageWriter"];
            var type = Type.GetType(typeName, true);
            IMessageWriter writer = (IMessageWriter)Activator.CreateInstance(type);
            Salutation Sal = new Salutation(writer);
            Sal.Exclaim();
            Console.ReadLine();
        }
    }
}
