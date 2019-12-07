using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TP_Aviation___Simulation
{
    class ControllerSimulateur
    {
        public ControllerSimulateur()
        {

        }

        //Exemple
        public void deserialize()
        {
            XmlSerializer xs = new XmlSerializer(typeof(ControllerSimulateur));
            using (StreamReader rd = new StreamReader("person.xml"))
            {
                ControllerSimulateur p = xs.Deserialize(rd) as ControllerSimulateur;
            }
        }
    }
}
