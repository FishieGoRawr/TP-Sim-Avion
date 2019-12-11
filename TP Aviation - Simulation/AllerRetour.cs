﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Aviation___Simulation
{
    class AllerRetour : EnVol
    {
        public AllerRetour(Aeronef aeronef) : base(aeronef)
        {
            Index = 4;
            this.m_aeronef = aeronef;
            this.m_positionActuelle = aeronef.Origine;
        }

        public override void avancer(int tempsPasse, List<Client> clients)
        {

            int x = m_positionActuelle.PosX;
            int y = m_positionActuelle.PosY;

            int clientX = clients[m_aeronef.IndexClient].Destination.PosX;
            int clientY = clients[m_aeronef.IndexClient].Destination.PosY;

            double distance = pythagore(clientX - x, clientY - y);
            double ticks = distance / (m_aeronef.Vitesse * tempsPasse);

            m_positionActuelle.PosX += Convert.ToInt32((clientX - x) / ticks);
            m_positionActuelle.PosY += Convert.ToInt32((clientY - y) / ticks);

            switch (m_aeronef.Type)
            {
                case "Secours":
                    if (true)
                    {
                        
                    }
                    else
                    {

                    }
                    break;
                case "Incendies":
                    if (true)
                    {

                    }
                    break;
                default:
                    break;
            }
        }

        public double pythagore(int a, int b)
        {
            double c = 0;

            a = a * a;
            b = b * b;
            c = Math.Sqrt(a + b);

            return c;
        }
    }
}
