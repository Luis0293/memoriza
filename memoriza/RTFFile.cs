using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace memoriza
{
    class RTFFile
    {
        private string _path = Application.StartupPath + "\\Resources\\Texto.txt";
        private string _texto;

        public string Texto
        {
            set
            { _texto = value; }

            get
            {
                _texto = File.ReadAllText(_path);
                return _texto;
            }
        }

        public string Reset
        {
            get
            {
                return _texto = "";
            }
        }


        public void Salvar()
        {
            File.WriteAllText(_path, _texto);
        }
    }
}
