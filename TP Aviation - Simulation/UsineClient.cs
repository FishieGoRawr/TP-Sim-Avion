﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Aviation___Simulation
{
    public sealed class UsineClient
    {
        private static UsineClient m_usineClient = null;

        UsineClient()
        {
        }

        public static UsineClient getUsineClient
        {
            get
            {
                if (m_usineClient == null)
                {
                    m_usineClient = new UsineClient();
                }
                return m_usineClient;
            }
        }

        public Client creerPassager(List<Areoport> listAreoport, Areoport origine)
        {
            Client newClient = null;

            newClient = new Passager(listAreoport, origine);

            return newClient;
        }

        public Client creerMarchandise(List<Areoport> listAreoport, Areoport origine)
        {
            Client newClient = null;

            newClient = new Marchandise(listAreoport, origine);

            return newClient;
        }

        public Client creerObservateur(int width, int height) 
        {
            Client newClient = null;

            newClient = new Observateur(width, height);

            return newClient;
        }

        public Client creerFeu(int width, int height)
        {
            Client newClient = null;

            newClient = new Feu(width, height);

            return newClient;
        }

        public Client creerSecours(int width, int height)
        {
            Client newClient = null;

            newClient = new Secours(width, height);

            return newClient;
        }
    }
}
