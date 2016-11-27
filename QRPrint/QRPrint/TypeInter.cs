using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace QRPrint
{
    class TypeInter
    {
        public string nom_type { get;}
        public string id_type { get;}
        private string id_parent;
        private int parent_default = 0;
        private static string path = Path.GetPathRoot(Environment.SystemDirectory)+"Client\\type.txt";

        public TypeInter(string name, string idParent)
        {
            this.nom_type = name;
            this.id_parent = idParent;
            this.id_type = Guid.NewGuid().ToString();
        }
        public TypeInter(string name, string idParent, string idType):this(name,idParent)
        {
            this.id_type = idType;
        }
        public static void addType(TypeInter newType)
        {         
            string line = newType.id_type + ";" + newType.nom_type + ";" + newType.id_parent;
            if (!File.Exists(TypeInter.path))
                File.WriteAllText(TypeInter.path,line+Environment.NewLine);           
            else
                File.AppendAllText(TypeInter.path, line+Environment.NewLine);
        }

        public static void deleteType(string typeId)
        {
           /* using (StreamReader file = new StreamReader(TypeInter.path))
            {
                string line;
                while((line = file.ReadLine()) != null)
                {
                    if (line.Contains(typeId))
                    {

                    }
                }
            }*/
        }

        public static List<TypeInter> getAllType()
        {
            List<TypeInter> listType = new List<TypeInter>();
            if (new FileInfo(TypeInter.path).Length > 10)
            {
                using (StreamReader file = new StreamReader(TypeInter.path))
                {
                    string lines;
                    while ((lines = file.ReadLine()) != null)
                    {
                        string[] line = lines.Split(';');
                        if(line.Length > 1) // ignore empty line
                        {
                            listType.Add(new TypeInter(line[1].ToString(), line[2].ToString(), line[0].ToString()));
                        }
                        
                    }
                }
            }
            return listType;
        }
    }
}
