using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPC
{
    public partial class FormExtendedSelect : Form
    {
        private static Dictionary<string, string> dictionary_0 = new Dictionary<string, string>();

        public List<ClassIntervalo> listaX;

        public List<ClassIntervalo> listaY;

        public List<ClassIntervalo> listaZ;

        static FormExtendedSelect()
        {
            FormExtendedSelect.dictionary_0 = new Dictionary<string, string>();
        }

        public FormExtendedSelect()
        {
            FormExtendedSelect class02 = this;

             
            FormExtendedSelect class021 = this;

            InitializeComponent();
        }
    }
}
