using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autodesk.AutoCAD.Runtime;

namespace SPC
{
      
    class Class_00
    {
        [CommandMethod("AcotarSeccion")]
        public void AcotarSeccion()
        {

        }
        [CommandMethod("AcotarTodo")]
        public void AcotarTodo()
        {

        }

        [CommandMethod("Ayuda")]
        public void Ayuda()
        {

        }

        [CommandMethod("BorrarCapas")]
        public void BorrarCapas()
        {

        }

        [CommandMethod("Contadores")]
        public void Contadores()
        {

        }

        [CommandMethod("CopiACapa")]
        public void CopiACapa()
        {

        }

        [CommandMethod("Cruces")]
        public void Cruces()
          {
        //new FormCruces().Show();
          }

        [CommandMethod("DescartarRepetidos")]
        public void DescartarRepetidos()
             {
        //new CVarios().Method_02();
             }

        [CommandMethod("Edicion3DPoly")]
        public void Edicion3DPoly()
    {
        //new Form3DPolyEdit().Show();
    }

        [CommandMethod("EscalaArea")]
        public void EscalaArea()
    {
        //new CVarios().EscalaAreaInicio();
    }

        [CommandMethod("ExtendedSelect")]
        public void ExtendedSelect()
    {
        //new Class_02().Show();
    }

        [CommandMethod("GestorH")]
        public void GestorH()
    {
        //new FormHidden().Show();
    }

        [CommandMethod("GirarTodo")]
        public void GirarTodo()
    {
        //new FormGirarTodo().Show();
    }

        [CommandMethod("SPCGEOM")]
        public void Grafica()
        {
            new FormGrafica().Show();
        }

        [CommandMethod("CopiaM")]
        public void InsercionM()
    {
        //new FormCopiaMultiple().Show();
    }

        [CommandMethod("ModificarTextos")]
        public void ModificarTextos()
    {
        //new FormModTextos().Show();
    }

        [CommandMethod("Numerar")]
        public void Numerar()
    {
        //new FormNumerar().Show();
    }

    [CommandMethod("ProyectarTodo")]
    public void ProyectarTodo()
    {
        //new FormProyectarTodo().Show();
    }

    [CommandMethod("CopiaADibujo")]
    public void Method_00()
    {
        //new FormCopiaADibujo().Show();
    }

    [CommandMethod("TodoVisible")]
    public void Method_01()
    {
        //new CVarios().TodoVisible();
    }

    [CommandMethod("AplanarTodo")]
    public void Method_02()
    {
        //new CVarios().AplanarTodo();
    }

    [CommandMethod("DivideGradua")]
    public void Method_03()
    {
        //new FormDivideGradua().Show();
    }

    }
}
