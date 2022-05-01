using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stagaire
{
    class stagaire
    {
        private string nom;
        private string prenom;
        private bool sexe;
        private DateTime dateNissance;
        private string filier;
        private bool interne;
        private int NummeroIncription;

        public string Nom
        {
            get
            {
                return nom;
            }

            set
            {
                nom = value;
            }
        }

        public string Prenom
        {
            get
            {
                return prenom;
            }

            set
            {
                prenom = value;
            }
        }

        public bool Sexe
        {
            get
            {
                return sexe;
            }

            set
            {
                sexe = value;
            }
        }

        public DateTime DateNissance
        {
            get
            {
                return dateNissance;
            }

            set
            {
                dateNissance = value;
            }
        }

        public string Filier
        {
            get
            {
                return filier;
            }

            set
            {
                filier = value;
            }
        }

        public bool Interne
        {
            get
            {
                return interne;
            }

            set
            {
                interne = value;
            }
        }

        public int NummeroIncription1
        {
            get
            {
                return NummeroIncription;
            }

            set
            {
                NummeroIncription = value;
            }
        }

        public stagaire(string nom, string prenom, bool sexe, DateTime dateNissance, string filier,bool interne, int nummeroIncription)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.sexe = sexe;
            this.dateNissance = dateNissance;
            this.filier = filier;
            this.Interne = interne;
            NummeroIncription = nummeroIncription;
        }
        
    }
}
