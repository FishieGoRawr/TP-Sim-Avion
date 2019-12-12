using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Aviation___Simulation
{
    class Aller : EnVol
    {
        public Aller(Aeronef aeronef) : base(aeronef)
        {
            Index = 3;
            this.m_aeronef = aeronef;
            //this.m_positionActuelle = aeronef.Origine;
            this.m_positionActuelle = new PositionGeo(aeronef.Origine.PosX, aeronef.Origine.PosY);
        }

        public override void avancer(int tempsPasse, List<Client> clients)
        {
            int x = this.m_positionActuelle.PosX;
            int y = this.m_positionActuelle.PosY;

            int clientX = this.m_aeronef.m_clientDestination.m_posX;
            int clientY = this.m_aeronef.m_clientDestination.m_posY;

            double distance = pythagore(clientX - x, clientY - y);
            double ticks = distance / (m_aeronef.Vitesse * tempsPasse);

            if (ticks > 0 && this.m_aeronef.Localisation != this.m_aeronef.m_clientDestination)
            {
                double newX = Math.Floor((clientX - x) / ticks);
                double newY = Math.Floor((clientY - y) / ticks);

                if ((this.m_positionActuelle.PosX + newX >= this.m_aeronef.m_clientDestination.PosX) || (this.m_positionActuelle.PosY + newY >= this.m_aeronef.m_clientDestination.PosY))
                {
                    this.m_positionActuelle = new PositionGeo(this.m_aeronef.m_clientDestination.PosX, this.m_aeronef.m_clientDestination.PosY);
                }
                else
                {
                    this.m_positionActuelle.PosX += (int)newX;
                    this.m_positionActuelle.PosY += (int)newY;
                }                

                this.m_aeronef.Localisation = new PositionGeo(m_positionActuelle.PosX, m_positionActuelle.PosY);
            }
            else
            {
                this.m_aeronef.Origine = new PositionGeo(this.m_aeronef.m_clientDestination.PosX, this.m_aeronef.m_clientDestination.PosY);
                this.m_positionActuelle = null;
                Index = 6;
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
