using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp1
{
    public class Salutation
    {
        private readonly IMessageWriter _writer;

        // in constucter indect the Dependancy 
        public Salutation(IMessageWriter writer)
        {

            if (writer == null)
            {
                throw new ArgumentNullException("writer");
            }
            _writer = writer;
        }

        // use dependancy
        public void Exclaim()
        {
            _writer.write("Hello DI !!!");
        }


    }
}
