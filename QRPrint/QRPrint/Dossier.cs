using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace QRPrint
{
    class Dossier
    {
        public string nom { get; set; }
        public string prenom { get; set; }
        public string num { get; }
        private string racine = Path.GetPathRoot(Environment.SystemDirectory);
        public string fullPath;

        public Dossier(string nom,string prenom,string num)
        {
            if(num != "000")
            {
                this.num = num;
                this.nom = nom;
                this.prenom = prenom;
                try
                {
                    createArborescence();
                }
                catch(Exception e)
                {
                    throw new ArgumentException(e.Message);
                }
            }
            else
            {
                throw new ArgumentException("Le numéro de dossier n'est pas correcte");
            }
            
        }
        private void createArborescence()
        {
            fullPath = racine + "Client\\" + this.nom + this.prenom + num;
            if (Directory.Exists(fullPath))
            {
                throw new ArgumentException("Le dossier client existe déjà");
            }
            else
            {
                Directory.CreateDirectory(fullPath);
            }
        }
        
    }
}
