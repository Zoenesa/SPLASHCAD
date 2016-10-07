using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.Runtime;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Colors;
using Autodesk.AutoCAD.Geometry;
using Autodesk.AutoCAD.ApplicationServices.Core;
using Autodesk.AutoCAD.Interop;
using Autodesk.AutoCAD.Interop.Common;
using System.Runtime.InteropServices;
using Telerik.WinControls.UI;

namespace SPC
{
    public partial class FormGrafica : RadForm
    {

        static FormGrafica()
        {
            FormGrafica.dictionary_0 = new Dictionary<string, string>();
            FormGrafica.dictionary_1 = new Dictionary<string, string>();
        }

        public FormGrafica()
        {
            FormGrafica formGrafica = this;
            base.Load += new EventHandler(FormGrafica_Load);
            InitializeComponent();
        }


        private AcadApplication acadApplication_0;
        private AcadDocument acadDocument_0;
        private static Dictionary<string, string> dictionary_0;
        private static Dictionary<string, string> dictionary_1;
        private AcadSelectionSet Field_19;
        private string string_0, string_1, string_2;
        private double double_0;
        private bool bool_0, bool_1;
        private short short_0;

        private void method_0()
        {
            this.Close();
        }

        private void FormGrafica_Load(object sender, EventArgs e)
        {
            if (this.short_0 != 2)
            {
                this.Close();
            }
        }

        public virtual AcadDocument ThisDrawing
        {
            get
            {
                return this.acadDocument_0;
            }
            set
            {
                FormGrafica formgrafica = this;
                _DAcadDocumentEvents_BeginCloseEventHandler variable =
                    new _DAcadDocumentEvents_BeginCloseEventHandler(formgrafica.method_0);
                if (this.acadDocument_0 != null)
                {
                    (new ComAwareEventInfo(typeof(_DAcadDocumentEvents_Event), "BeginClose")).RemoveEventHandler(this.acadDocument_0, variable);
                }
                this.acadDocument_0 = value;
                if (this.acadDocument_0 !=null)
                {
                    (new ComAwareEventInfo(typeof(_DAcadDocumentEvents_Event), "BeginClose")).AddEventHandler(this.acadDocument_0, variable);
                }
            }
        }

        private void TabControlGrafica_SelectedPageChanged(object sender, EventArgs e)
        {

        }

        public virtual AcadApplication xAcad
        {
            get
            {
                return this.acadApplication_0;
            }
            set
            {
                FormGrafica formGrafica = this;
                _DAcadApplicationEvents_BeginQuitEventHandler variable = new _DAcadApplicationEvents_BeginQuitEventHandler(formGrafica.method_1);
                if (this.acadApplication_0 != null)
                {
                    (new ComAwareEventInfo(typeof(_DAcadApplicationEvents_Event), "BeginQuit")).RemoveEventHandler(this.acadApplication_0, variable);
                }
                this.acadApplication_0 = value;
                if (this.acadApplication_0 != null)
                {
                    (new ComAwareEventInfo(typeof(_DAcadApplicationEvents_Event), "BeginQuit")).AddEventHandler(this.acadApplication_0, variable);
                }
            }
        }

        [DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
        private static extern short GetAsyncKeyState(int int_0);

        private void method_1(ref bool bool_2)
        {
            this.Close();
        }



    }
}
