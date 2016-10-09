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
using Telerik.WinControls;
using System.Xml;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System.Management;
using System.Runtime.CompilerServices;
using System.Collections;
using System.Globalization;
using Autodesk.AutoCAD.EditorInput;

namespace SPC
{
    public partial class FormGrafica : RadForm 
    {


        [DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
        private static extern short GetAsyncKeyState(int int_0);
               
        static FormGrafica()
        {
            FormGrafica.dictionary_0 = new Dictionary<string, string>();
            FormGrafica.dictionary_1 = new Dictionary<string, string>();
        }

        public FormGrafica()
        {

            
            this.Load += new System.EventHandler(this.FormGrafica_Load);
            //this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormGrafica_KeyDown);
            this.classComunes_0 = new ClassComunes();
            
            InitializeComponent();

            this.acadSelectionSet_0 = null;
            this.string_1 = "";
            this.bool_0 = false;
            this.bool_1 = false;
            this.short_0 = 0;
        }        

        private void method_0()
        {
            this.Close();
        }

        public void frmClose(object sender, DocumentBeginCloseEventHandler e)
        {
            this.Close();
        }

        private void method_1(ref bool bool_2)
        {
            this.Close();
        }

        private bool method_2a(string string_3)
        {
            bool flag = false;
            try
            {
                
            }
            catch (System.Exception exception)
            {
                ProjectData.SetProjectError(exception);
                this.ComboBoxLetra.Items.Clear();
                this.ComboBoxLetra.SelectedIndex = 0;
                this.ThisDrawing.ActiveTextStyle = this.ThisDrawing.TextStyles.Item(0);
                ProjectData.ClearProjectError();
            }
            return flag;
        }
        private void method_2()
        {
          
            try
            {
                Document mdiactive = Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager.MdiActiveDocument;
                Autodesk.AutoCAD.EditorInput.Editor editor = mdiactive.Editor;
                editor.SetImpliedSelection(new ObjectId[0]);
                Database database = mdiactive.Database;
                PromptPointOptions options = new PromptPointOptions("")
                { Message = "\n" + dictionary_0["sSpecifyCatenariaP1"] };

                PromptPointResult result = mdiactive.Editor.GetPoint(options);
                Autodesk.AutoCAD.Geometry.Point3d p3d = result.Value;
                if (result.Status == PromptStatus.Cancel)
                {
                    MessageBox.Show("Cancel by User");
                }
            }
            catch (System.Exception exception2)
            {
                ProjectData.SetProjectError(exception2);
                System.Exception exception1 = exception2;
                MessageBox.Show(string.Concat("Error en TransicionClotoide: ", exception1.Message), "InnerSoft - Message", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                ProjectData.ClearProjectError();
            }

            try
            {
                
            }
            catch (System.Exception ex2)
            {
                ProjectData.SetProjectError(ex2);
                ProjectData.ClearProjectError();

            }

        }

        private void method_32()
        {
            try
            {
                if (Class_7.string_0 == "es")
                {
                    //    this.FrameOrder.Text = "Ordenar Segun";
                    //    this.OptionButtonOrdenarX.Text = "Coordenada X";
                    //    this.OptionButtonOrdenarY.Text = "Coordenada Y";
                    //    this.FrameDirection.Text = "En Orden";
                    //    this.OptionButtonCoordPrimariaAscendente.Text = "Ascendente";
                    //    this.OptionButtonCPDown.Text = "Descendente";
                    //    this.CommandButtonEjecutar.Text = "Ejecutar";
                    //    this.CommandButtonCerrar.Text = "Cerrar";
                    //    this.FrameSCoord.Text = "Con la Coord. Y (Para misma Coord. X)";
                    //    this.OptionButtonSecundariaAscendente.Text = "Ascendente";
                    //    this.OptionButtonCSDown.Text = "Descendente";
                    //    this.FrameIndice.Text = "Indices/Textos";
                    //    this.CheckBoxIndice.Text = "Insertar Indice";
                    //    this.CheckBoxBorrarIndice.Text = "Borrar Indices Previos";
                    //    this.LabelIndexHeight.Text = "Altura Indice/Texto";
                    //    this.LabelTextStyle.Text = "Estilo de Letra";
                    //    this.TabPage1.Text = "Grafica";
                    //    this.TabPage2.Text = "Regresion 2D";
                    //    this.TabPage4.Text = "Envoltura Convexa 2D";
                    //    this.TabPage3.Text = "Envoltura Convexa 3D";
                    //    this.TabPage5.Text = "Parabola";
                    //    this.TabPage6.Text = "Clotoide";
                    //    this.TabPage7.Text = "Acuerdo Vertical";
                    //    this.TabPage8.Text = "Circulos/Tangentes";
                    //    this.TabPage9.Text = "Calculadora 3D";
                    //    this.TabPage10.Text = "3D Arco/Circulo";
                    //    this.TabPage11.Text = "Regresion 3D";
                    //    this.TabPage12.Text = "Clotoide Trans.";
                    //    this.TabPage13.Text = "Catenaria";
                    //    this.LabelConvexHull.Text = "Dado un conjunto de puntos en el plano, su envoltura convexa est\x00e1 definida por el pol\x00edgono convexo de \x00e1rea m\x00ednima que cubre todos los puntos (esto es, todos los puntos est\x00e1n dentro del pol\x00edgono).";
                    //    this.RadioButtonCHull3DTriangulos.Text = "Dibujar Caras Triangulares";
                    //    this.RadioButtonCHull3DLineas.Text = "Dibujar Lineas Triangulares";
                    //    this.RadioButtonCHull3DContorno.Text = "Dibujar Contorno";
                    //    this.Label3DConvexVersionInfo.Text = "Esta herramienta solo esta disponible en AutoCAD 2012 o versiones mas recientes.";
                    //    this.CheckBoxCG.Text = "Dibujar Centro Gravedad";
                    //    this.RadioButtonYsobreX.Text = "Linea mediante Regresion Lineal Simple: Y sobre X";
                    //    this.RadioButtonXsobreY.Text = "Linea mediante Regresion Lineal Simple: X sobre Y";
                    //    this.RadioButton2DOrtoRegresion.Text = "Linea mediante Regresion Ortogonal: Metodo de Deming";
                    //    this.RadioButton2DCircleRegression.Text = "Circulo mediante Regresion por Minimos Cuadrados";
                    //    this.RadioButtonLineaRegresionOrtogonal.Text = "Linea mediante Regresion Ortogonal en 3D";
                    //    this.RadioButtonPlanoRegresionSimpleZ.Text = "Plano mediante Regresion por Minimos Cuadrados respecto al eje Z";
                    //    this.RadioButtonPlanoRegresionOrtogonal.Text = "Plano mediante Regresion Ortogonal en 3D: Metodo DVS";
                    //    this.RadioButtonEsferaMinimosCuadrados.Text = "Esfera mediante Regresion por Minimos Cuadrados";
                    //    this.CheckBoxCG3D.Text = "Dibujar Centro de Gravedad";
                    //    this.GroupBoxParabolaMode.Text = "Modo";
                    //    this.RadioButtonParabolaPuntoVertice.Text = "Vertice y Punto";
                    //    this.RadioButtonParabolaTresPuntos.Text = "Tres Puntos";
                    //    this.RadioButtonParabolaTresTangentes.Text = "Tres Tangentes";
                    //    this.RadioButtonParabolaDosTangentesX.Text = "Dos Tangentes y Coord. X del Vertice";
                    //    this.RadioButtonTangentePunto.Text = "Tangente Adyacente y Punto";
                    //    this.RadioButtonParabolaEcuacion.Text = "Ecuacion";
                    //    this.LabelParabolaX.Text = "Incremento en el Eje X (∆x)";
                    //    this.GroupBoxParabolaObjectType.Text = "Tipo Objeto";
                    //    this.RadioButtonParabolaSPLine.Text = "SPLine Grado 3";
                    //    this.RadioButtonParabola3DPoly.Text = "3D-Poli Cuadratica";
                    //    this.LabelSPLINESEGS.Text = "Establece el n\x00famero de rectas que se deben generar para ajustar la polil\x00ednea a una curva SPLinea";
                    //    this.GroupBoxClothoidObjectType.Text = "Tipo Objeto Clotoide";
                    //    this.RadioButtonClotoideRadioLongitud.Text = "Radio y Longitud";
                    //    this.RadioButtonClotoideRadioAngulo.Text = "Radio y Angulo Total";
                    //    this.RadioButtonClotoideLongitudAngulo.Text = "Longitud y Angulo Total";
                    //    this.RadioButtonClotoideSpline.Text = "SPLine";
                    //    this.RadioButtonClotoide3DPoly.Text = "3D-Polilinea de Rectas";
                    //    this.RadioButtonClotoideLWPoly.Text = "LW-Polinea de Arcos";
                    //    this.LabelClotoideNumeroPuntos.Text = "Numero de Puntos Clotoide";
                    //    this.LabelClotoideGrados.Text = "grados";
                    //    this.RadioButtonClotoideSplineCCC.Text = "SPLine";
                    //    this.RadioButtonClotoide3DPolyCCC.Text = "3D-Polilinea de Rectas";
                    //    this.RadioButtonClotoideLWPolyCCC.Text = "LW-Polinea de Arcos";
                    //    this.LabelClotoideNumeroPuntosCCC.Text = "Numero de Puntos Clotoide";
                    //    this.RadioButtonCCCRadioLClotoide.Text = "Clot-Circulo-Clot: Longitud del Circulo (Rc) y Longitud de la Clotoide (Lcth)";
                    //    this.RadioButtonCCCRadioLCirculo.Text = "Clot-Circulo-Clot: Radio del Circulo (Rc) y Longitud del Arco Circular (Lc)";
                    //    this.RadioButtonCCCWhollyTransitionalCurve.Text = "Curva Clotoides de V\x00e9rtice: Radio del Circulo (Rc)";
                    //    this.RadioButtonAcuerdoDosPuntosKv.Text = "Dos Puntos y Parametro K";
                    //    this.RadioButtonAcuerdoDosTangentesKv.Text = "Dos Tangentes y Parametro K";
                    //    this.RadioButtonAcuerdoDosPuntosG1.Text = "Dos Puntos y Tangente G1";
                    //    this.RadioButtonAcuerdoDosPuntosG2.Text = "Dos Puntos y Tangente G2";
                    //    this.LabelAcuerdoTexto.Text = "K = L/A donde:" + Environment.NewLine + "L = longitud minima de la curva" + Environment.NewLine + "A = diferencia de pendientes en % (G2-G1)";
                    //    this.RadioButtonCirculosTangentes2ExtInt.Text = "Lineas Tangentes entre 2 Circulos";
                    //    this.RadioButtonCirculosTgCirculoLinea.Text = "Circulo (R) tangente a Linea y Circulo";
                    //    this.RadioButtonCirculosTgCirculoCirculo.Text = "Circulo (R) tangente a 2 Circulos";
                    //    this.RadioButtonIntPuntoPlano.Text = "Distancia e Interseccion Orto. de Punto a Plano (3 puntos)";
                    //    this.RadioButtonIntRectaPlano.Text = "Interseccion o Distancia entre Linea (2 puntos) y Plano (3 puntos)";
                    //    this.RadioButtonDistPuntoRecta.Text = "Distancia e Interseccion Orto. de Punto a Linea (2 puntos)";
                    //    this.RadioButtonIntPlanoPlano.Text = "Interseccion o Distancia entre Plano (3 puntos) y Plano (3 puntos)";
                    //    this.RadioButtonIntLineLine.Text = "Interseccion o Distancia entre Linea (2 puntos) y Linea (2 puntos)";
                    //    this.RadioButtonVectorTangente.Text = "Dibujar Vector Tangente, Normal, Binormal y Circulo Osculador en un punto";
                    //    this.RadioButtonVectorNormal.Text = "Dibujar Vector Normal";
                    //    this.RadioButtonArco3Puntos.Text = "Arco 3 Puntos";
                    //    this.RadioButtonCirculo3Puntos.Text = "Circulo 3 Puntos";
                    //    this.RadioButtonCirculoCentroPunto.Text = "Circulo Centro, Punto";
                    //    this.GroupBoxCatenaryObjectType.Text = "Tipo Objeto Catenaria";
                    //    this.RadioButtonCatenarySpline.Text = "SPLine";
                    //    this.RadioButtonCatenary3DPoly.Text = "3D-Polilinea de Rectas";
                    //    this.RadioButtonCatenaryLWPoly.Text = "LW-Polinea de Arcos";
                    //    this.LabelCatenariaNumeroPuntos.Text = "Numero de Puntos Catenaria";
                    //    this.LabelMaximumIterations.Text = "Iteraciones Maximas";
                    //    this.LabelMaximumError.Text = "Error Maximo";
                    //    this.RadioButtonCatenaryParameter.Text = "Catenaria por Dos Puntos y Parametro: a";
                    //    this.RadioButtonCatenaryCurveLength.Text = "Catenaria por Dos Puntos y Longitud de la Curva: s";
                    //    this.RadioButtonCatenary3Puntos.Text = "Catenaria por Tres Puntos";
                }
            }
            catch (System.Exception exception1)
            {
                Microsoft.VisualBasic.CompilerServices.ProjectData.SetProjectError(exception1);
                System.Exception exception = exception1;
                Microsoft.VisualBasic.Interaction.MsgBox("Error en LanguageCaptions: " + exception.Message, Microsoft.VisualBasic.MsgBoxStyle.Critical, "Message - InnerSoft");
                Microsoft.VisualBasic.CompilerServices.ProjectData.ClearProjectError();
            }
        }

        private string method_38(int int_0)
        {
            cSerial serial = new cSerial();
            string sSerial = null;
            string sModel = null;
            string sFirmware = null;
            string str4 = string.Empty;
            string str5 = string.Empty;
            try
            {
                if ((int_0 == 1) && serial.GetHDData(0, ref sSerial, ref sModel, ref sFirmware))
                {
                    str5 = Strings.LTrim(Strings.RTrim(sSerial));
                }
                if (int_0 != 2)
                {
                    goto Label_0107;
                }
                object objectValue = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(RuntimeHelpers.GetObjectValue(Interaction.GetObject("WinMgmts:", null)), null, "InstancesOf", new object[] { "Win32_PhysicalMedia" }, null, null, null));
                try
                {
                    enumerator2 = ((IEnumerable)objectValue).GetEnumerator();
                    while (enumerator2.MoveNext())
                    {
                        str4 = Conversions.ToString(NewLateBinding.LateGet(RuntimeHelpers.GetObjectValue(enumerator2.Current), null, "SerialNumber", new object[0], null, null, null));
                        if (!string.IsNullOrEmpty(str4))
                        {
                            goto Label_00EB;
                        }
                    }
                }
                finally
                {
                    if (enumerator2 is IDisposable)
                    {
                        (enumerator2 as IDisposable).Dispose();
                    }
                }
            Label_00EB:
                if (!string.IsNullOrEmpty(str4))
                {
                    return Strings.LTrim(Strings.RTrim(str4));
                }
            Label_0107:
                if (int_0 != 3)
                {
                    goto Label_01E1;
                }
                objectValue = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(RuntimeHelpers.GetObjectValue(Interaction.GetObject("WinMgmts:", null)), null, "InstancesOf", new object[] { "Win32_BaseBoard" }, null, null, null));
                try
                {
                    enumerator4 = ((IEnumerable)objectValue).GetEnumerator();
                    while (enumerator4.MoveNext())
                    {
                        str4 = Conversions.ToString(NewLateBinding.LateGet(RuntimeHelpers.GetObjectValue(enumerator4.Current), null, "SerialNumber", new object[0], null, null, null));
                        if (!string.IsNullOrEmpty(str4))
                        {
                            goto Label_01B1;
                        }
                    }
                }
                finally
                {
                    if (enumerator4 is IDisposable)
                    {
                        (enumerator4 as IDisposable).Dispose();
                    }
                }
            Label_01B1:
                if (!string.IsNullOrEmpty(str4) | (str4 == "Base Board Serial Number"))
                {
                    return Strings.LTrim(Strings.RTrim(str4));
                }
            Label_01E1:
                if (int_0 != 4)
                {
                    goto Label_029E;
                }
                object instance = RuntimeHelpers.GetObjectValue(Interaction.GetObject("WinMgmts:", null));
                try
                {
                    enumerator5 = ((IEnumerable)NewLateBinding.LateGet(instance, null, "InstancesOf", new object[] { "Win32_DiskDrive" }, null, null, null)).GetEnumerator();
                    while (enumerator5.MoveNext())
                    {
                        str4 = Conversions.ToString(NewLateBinding.LateGet(RuntimeHelpers.GetObjectValue(enumerator5.Current), null, "Model", new object[0], null, null, null));
                        if (!string.IsNullOrEmpty(str4))
                        {
                            goto Label_0282;
                        }
                    }
                }
                finally
                {
                    if (enumerator5 is IDisposable)
                    {
                        (enumerator5 as IDisposable).Dispose();
                    }
                }
            Label_0282:
                if (!string.IsNullOrEmpty(str4))
                {
                    return Strings.LTrim(Strings.RTrim(str4));
                }
            Label_029E:
                if (int_0 != 5)
                {
                    goto Label_0364;
                }
                objectValue = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(RuntimeHelpers.GetObjectValue(Interaction.GetObject("WinMgmts:", null)), null, "InstancesOf", new object[] { "Win32_NetworkAdapter" }, null, null, null));
                try
                {
                    enumerator3 = ((IEnumerable)objectValue).GetEnumerator();
                    while (enumerator3.MoveNext())
                    {
                        str4 = Conversions.ToString(NewLateBinding.LateGet(RuntimeHelpers.GetObjectValue(enumerator3.Current), null, "MACaddress", new object[0], null, null, null));
                        if (!string.IsNullOrEmpty(str4))
                        {
                            goto Label_0348;
                        }
                    }
                }
                finally
                {                   
                    if (enumerator3 is IDisposable)
                    {
                        (enumerator3 as IDisposable).Dispose();
                    }
                }
            Label_0348:
                if (!string.IsNullOrEmpty(str4))
                {
                    return Strings.LTrim(Strings.RTrim(str4));
                }
            Label_0364:
                if (int_0 != 6)
                {
                    return str5;
                }
                ManagementObject obj2 = new ManagementObject("Win32_LogicalDisk.DeviceID=\"C:\"");
                PropertyDataCollection.PropertyDataEnumerator enumerator = obj2.Properties.GetEnumerator();
                while (enumerator.MoveNext())
                {
                    PropertyData current = enumerator.Current;
                    if (current.Name == "VolumeSerialNumber")
                    {
                        str4 = Conversions.ToString(current.Value);
                    }
                }
                if (!string.IsNullOrEmpty(str4))
                {
                    return Strings.LTrim(Strings.RTrim(str4));
                }
            }
            catch (System.Exception exception1)
            {
                ProjectData.SetProjectError(exception1);
                str5 = string.Empty;
                ProjectData.ClearProjectError();
            }
            return str5;
        }

        private short method_39(ref int int_0)
        {
            clsSHAsha asha = new clsSHAsha();
            short num2 = 0;
            try
            {
                int num3;
                string str2;
                string str5;
                if (dictionary_1 == null)
                {
                    return 0;
                }
                try
                {
                    num3 = Conversions.ToInteger(dictionary_1["ITipo"]);
                }
                catch (System.Exception exception1)
                {
                    ProjectData.SetProjectError(exception1);
                    num2 = 0;
                    ProjectData.ClearProjectError();
                    return num2;
                }
                string str = this.method_38(num3);
                if (string.IsNullOrEmpty(str))
                {
                    return 0;
                }
                try
                {
                    str2 = dictionary_1["IdClient"];
                }
                catch (System.Exception exception2)
                {
                    ProjectData.SetProjectError(exception2);
                    num2 = 0;
                    ProjectData.ClearProjectError();
                    return num2;
                }
                if (!string.IsNullOrEmpty(str2))
                {
                    num2 = (short)(num2 + 20);
                }
                try
                {
                    str5 = dictionary_1["IdGazpacho"];
                }
                catch (System.Exception exception3)
                {
                    ProjectData.SetProjectError(exception3);
                    num2 = 0;
                    ProjectData.ClearProjectError();
                    return num2;
                }
                if (!string.IsNullOrEmpty(str5))
                {
                    num2 = (short)(num2 + 20);
                }
                string valueref = string.Concat("3.7of3", str, str2);
                string expression = asha.SHAsha(ref (valueref));
                if ((Strings.Len(str5) == Strings.Len(expression)) && (str5 == expression))
                {
                    num2 = (short)(num2 + 21);
                }
                asha = null;
            }
            catch (System.Exception exception4)
            {
                Microsoft.VisualBasic.CompilerServices.ProjectData.SetProjectError(exception4);
                num2 = 0;
                Microsoft.VisualBasic.CompilerServices.ProjectData.ClearProjectError();
            }
            return num2;
        }
        
        private Dictionary<string, string> method_40()
        {
            Dictionary<string, string> dictionary2;
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            try
            {
                XmlNodeList list2;
                int num4;
                string path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + @"\SPLASHCAD_Reg.xml";
                if (!System.IO.File.Exists(path))
                {
                    goto Label_011B;
                }
                this.short_0 = 2;
                dictionary2 = null;
                XmlDocument document = new XmlDocument();
                System.IO.FileStream inStream = new System.IO.FileStream(path, System.IO.FileMode.Open, System.IO.FileAccess.Read);
                document.Load(inStream);
                inStream.Close();
                XmlNodeList childNodes = document.DocumentElement.ChildNodes;
                int num2 = childNodes.Count - 1;
                for (int i = 0; i <= num2; i++)
                {
                    if (childNodes[i].Name == "LICENSE")
                    {
                        list2 = childNodes[i].ChildNodes;
                        if (list2.Count == 5)
                        {
                            goto Label_00C2;
                        }
                    }
                }
                return dictionary2;
            Label_00C2:
                num4 = list2.Count - 1;
                for (int j = 0; j <= num4; j++)
                {
                    dictionary.Add(list2[j].Name.ToString(), list2[j].InnerText.Trim().ToString());
                }
                this.short_0 = 3;
                return dictionary;
            Label_011B:
                this.short_0 = 0;
                dictionary2 = null;
            }
            catch (System.Exception exception1)
            {
                Microsoft.VisualBasic.CompilerServices.ProjectData.SetProjectError(exception1);
                this.short_0 = 1;
                dictionary2 = null;
                Microsoft.VisualBasic.CompilerServices.ProjectData.ClearProjectError();
            }
            return dictionary2;
        }

        private bool method_41(short short_1)
        {
            bool flag = false;
            if (short_1 == 1)
            {
               Microsoft.VisualBasic.Interaction.MsgBox(dictionary_0["sR1"], Microsoft.VisualBasic.MsgBoxStyle.Critical, "InnerSoft - Message");
            }
            if (short_1 == 2)
            {
               Microsoft.VisualBasic.Interaction.MsgBox(dictionary_0["sR2"], Microsoft.VisualBasic.MsgBoxStyle.Critical, "InnerSoft - Message");
            }
            return flag;
        }
                
        private Dictionary<string, string> method_42(short short_1)
        {
            Dictionary<string, string> dictionary2;
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            try
            {
                if (Class_7.string_0 == "es")
                {
                    dictionary.Add("sTituloMenu", "Utilidades Geometricas - InnerSoft CAD");
                    dictionary.Add("sR1", "No se han podido verificar los datos de su registro. Compruebe que tiene permisos de lectura/escritura en la carpeta de instalacion de InnerSoft.");
                    dictionary.Add("sR2", "Los datos de su registro son incorrectos. Contacte con nosotros en innersoft@itspanish.org");
                    dictionary.Add("sDecimalSymbol", "El simbolo decimal que usa su Sistema Operativo es: ");
                    dictionary.Add("sSimboloDecimalPunto", "el punto ");
                    dictionary.Add("sSimboloDecimalComa", "la coma ");
                    dictionary.Add("sSimboloDecimalOtro", "el siguiente caracter ");
                    dictionary.Add("sActiveDrawing", "Dibujo Activo: ");
                    dictionary.Add("sActiveDrawingPath", "Ruta Dibujo Activo: ");
                    dictionary.Add("sNumericIndexHeight", "No ha introducido un valor numerico en la casilla de 'Altura Indice'. Se cambiara al valor 1.0");
                    dictionary.Add("sPositiveIndexHeight", "El valor para 'Altura Indice' no puede ser menor que cero. Se cambiara al valor 1.0.");
                    dictionary.Add("sAbort", "O pulsa 'escape' para interrumpir el proceso.");
                    dictionary.Add("sFunctionCancelled", "Ejecucion interrumpida por el usuario.");
                    dictionary.Add("sTwoPoints", "Has de seleccionar al menos dos puntos.");
                    dictionary.Add("sThreePoints", "Has de seleccionar al menos tres puntos.");
                    dictionary.Add("sFourPoints", "Has de seleccionar al menos cuatro puntos.");
                    dictionary.Add("sFrameSCoord1", "Con la Coord. Y (Para misma Coord. X)");
                    dictionary.Add("sFrameSCoord2", "Con la Coord. X (Para misma Coord. Y)");
                    dictionary.Add("sSelectPoints", "Seleccione los puntos a graficar: ");
                    dictionary.Add("sFinGrafica", "Se ha dibujado una grafica a partir de los siguientes puntos: ");
                    dictionary.Add("sInsertingIndexes", "A\x00f1adiendo los Indices.");
                    dictionary.Add("sTakingCoordinates", "Tomando Coordenadas.");
                    dictionary.Add("sNoAbiertoURL", "No se ha podido abrir la pagina web.");
                    dictionary.Add("sNumericParametroCatenaria", "El parametro de la Catenaria debe ser un valor numerico: se ha cambiado a 100");
                    dictionary.Add("sPositiveParametroCatenaria", "El parametro de la Catenaria debe ser un valor positivo: se ha cambiado a 100");
                    dictionary.Add("sNumericLongitudCatenaria", "La longitud de la Catenaria debe ser un valor numerico: se ha cambiado a 100");
                    dictionary.Add("sPositiveLongitudCatenaria", "La longitud de la Catenaria debe ser un valor positivo: se ha cambiado a 100");
                    dictionary.Add("sLimitsNumberPuntosCatenaria", "El Numero de Puntos del Objeto ha de ser un valor entero comprendido entre 20 y 2147483647. Se ha cambiado a 40.");
                    dictionary.Add("sNumberPuntosCatenariaImpar", "Para dibujar una polilinea con arcos el numero de puntos del objeto ha de ser impar: se ha subido el valor una unidad.");
                    dictionary.Add("sSpecifyCatenariaP1", "Seleccione el primer punto de la catenaria:");
                    dictionary.Add("sSpecifyCatenariaP2", "Seleccione el segundo punto de la catenaria:");
                    dictionary.Add("sSpecifyCatenariaP3", "Seleccione el tercer punto de la catenaria:");
                    dictionary.Add("sNoPuntosVerticalCatenaria", "No puede haber dos puntos verticalmente alineados: no se puede dibujar la Catenaria.");
                    dictionary.Add("sPuntoIntermedioEncima", "No se puede crear una catenaria. El punto intermedio ha de estar por debajo de la recta que une los puntos extremos.");
                    dictionary.Add("sMenorLongitudMinima", "No se puede crear una catenaria con la longitud introducida. La longitud minima es la distancia entre los puntos extremos: ");
                    dictionary.Add("sDistancesTooLong", "No se puede empezar a resolver la catenaria. La distancia entre puntos seguramente sea demasiado grande.");
                    dictionary.Add("sIterationsExceeded", "Se ha sobrepasado el maximo de iteraciones. Aumente las iteraciones o el error maximo.");
                    dictionary.Add("sErrorExceeded", "El error es mayor que el error maximo. Aumente las iteraciones o el error maximo.");
                    dictionary.Add("sCatenaryNotSolved", "No se ha podido resolver la catenaria.");
                    dictionary.Add("sCatenaryNotConverge", "La solucion no converge numericamente. Puede que la longitud sea demasiado corta o los puntos esten aproximadamente alineados.");
                    dictionary.Add("sCatenaryLength", "Longitud de la Catenaria: ");
                    dictionary.Add("sCatenaryParameter", "Parametro de la Catenaria: ");
                    dictionary.Add("sCatenaryEquation", "Ecuacion de la Catenaria: ");
                    dictionary.Add("sCatenaryVertex", "Vertice de la Catenaria (punto mas bajo): ");
                    dictionary.Add("sCatenaryOrigin", "Origen de los Ejes naturales: ");
                    dictionary.Add("sFinCatenaria", "Se ha dibujado una catenaria con los siguientes puntos: ");
                    dictionary.Add("sMediaX", "Media de X: ");
                    dictionary.Add("sMediaY", "Media de Y: ");
                    dictionary.Add("sMediaZ", "Media de Z: ");
                    dictionary.Add("sVarianzaX", "Varianza de X: ");
                    dictionary.Add("sVarianzaY", "Varianza de Y: ");
                    dictionary.Add("sCovarianza", "Covarianza: ");
                    dictionary.Add("sRectaRegresion", "Recta de Regresion: ");
                    dictionary.Add("sCoeficienteCorrelacionLineal", "Coeficiente de Correlacion Lineal: ");
                    dictionary.Add("sFinRegresion2D", "Se ha realizado una Regresion 2D con los siguientes puntos: ");
                    dictionary.Add("sFinRegresion3D", "Se ha realizado una Regresion 3D con los siguientes puntos: ");
                    dictionary.Add("sSumaCuadraticaResiduos", "La suma cuadratica de residuos es: ");
                    dictionary.Add("sSumaCuadraticaDistanciasReales", "La suma cuadratica de distancias residuales es: ");
                    dictionary.Add("sCentroRegresionCircular", "El centro del circulo de regresion es: ");
                    dictionary.Add("sRadioRegresionCircular", "El radio del circulo de regresion es: ");
                    dictionary.Add("sUse2DRegression", "Debes de usar un metodo de regresion en 2D.");
                    dictionary.Add("sEcuacionPlanoRegression", "La ecuacion del plano es: ");
                    dictionary.Add("sRadioRegresionEsferica", "El radio de la esfera de regresion es: ");
                    dictionary.Add("sCentroRegresionEsferica", "El centro de la esfera de regresion es: ");
                    dictionary.Add("sFinConvexHull", "Se ha dibujado una Envoltura Convexa a partir de los siguientes puntos: ");
                    dictionary.Add("sFinQuickHull3D", "Se ha dibujado una Envoltura Convexa 3D a partir de los siguientes puntos: ");
                    dictionary.Add("sNoLines", "No has seleccionado ninguna linea o lineas.");
                    dictionary.Add("sEcuacionParabola", "Ecuacion de la Parabola: ");
                    dictionary.Add("sSpecifyParabolaVertex", "Precise el vertice de la Parabola: ");
                    dictionary.Add("sSpecifyParabolaPoint", "Precise un extremo de la Parabola: ");
                    dictionary.Add("sNumericCoefParabola", "El coeficiente de la Parabola debe ser un valor numerico: se ha cambiado a 0.1");
                    dictionary.Add("sNonCeroCoefParabola", "El coeficiente de la Parabola no puede ser cero: se ha cambiado a 0.1");
                    dictionary.Add("sNumericParabolaXCoord", "El Incremento en el Eje X debe ser un valor numerico: se ha cambiado a 20.");
                    dictionary.Add("sNonZeroParabolaXCoord", "El Incremento en el Eje X debe ser distinto a cero: se ha cambiado a 10.");
                    dictionary.Add("sLimitsNumberLineSegments", "El numero de rectas ha de ser un valor entero entre 4 y 2147483647: se ha cambiado a 20.");
                    dictionary.Add("sSpecifyParabolaFirstPoint", "Precise el primer punto de la parabola:");
                    dictionary.Add("sSpecifyParabolaSecondPoint", "Precise el segundo punto de la parabola:");
                    dictionary.Add("sSpecifyParabolaThirdPoint", "Precise el tercer punto de la parabola:");
                    dictionary.Add("sParabolaDosTangentes", "Has de seleccionar dos lineas de tangencia.");
                    dictionary.Add("sParabolaTresTangentes", "Has de seleccionar tres lineas de tangencia.");
                    dictionary.Add("sNoTangentesVerticales", "Las tangentes a la parabola no pueden ser rectas verticales: no se puede crear la parabola.");
                    dictionary.Add("sNoInterseccionTangentes", "Dos de las tangentes no se intersectan entre si: no se puede crear la parabola.");
                    dictionary.Add("sNoTresPuntosAlineadosHorizontalmente", "Los tres puntos no pueden estar alineados horizontalmente: no se puede crear la parabola.");
                    dictionary.Add("sNoPuntosAlineadosVerticalmente", "No puede haber dos puntos alineados verticalmente: no se puede crear la parabola.");
                    dictionary.Add("sNoVerticePuntoAlineados", "El Vertice y Extremo de la Parabola no pueden estar alineados vertical u horizontalmente: no se puede crear la parabola.");
                    dictionary.Add("sSpecifyParabolaTangenteAdyacente", "Seleccione la tangente adyacente:");
                    dictionary.Add("sSpecifyParabolaDosTangentes", "Seleccione dos lineas tangentes:");
                    dictionary.Add("sSpecifyParabolaTresTangentes", "Seleccione tres lineas tangentes:");
                    dictionary.Add("sNumericParametroAcuerdoParabolico", "El parametro del Acuerdo Vertical Parabolico (K) ha de ser un valor numerico: se ha cambiado a 20.");
                    dictionary.Add("sNumericAcuerdoParabolicoG1", "La tangente de entrada (G1) ha de ser un valor numerico: se ha cambiado a 10.");
                    dictionary.Add("sNumericAcuerdoParabolicoG2", "La tangente de entrada (G2) ha de ser un valor numerico: se ha cambiado a 10.");
                    dictionary.Add("sSpecifyAcuerdoVerticalP1", "Se\x00f1ale el punto de entrada del acuerdo vertical (VPC):");
                    dictionary.Add("sSpecifyAcuerdoVerticalP2", "Se\x00f1ale el punto de salida del acuerdo vertical (VPT):");
                    dictionary.Add("sSpecifyAcuerdoTangenteEntrada", "Seleccione una linea como tangente de entrada (G1):");
                    dictionary.Add("sSpecifyAcuerdoTangenteSalida", "Seleccione una linea como tangente de salida (G2):");
                    dictionary.Add("sSpecifyClothoidStarPoint", "Precise el punto de inicio de la clotoide:");
                    dictionary.Add("sNumericRadioCurvaturaClotoide", "El Radio de Curvatura debe ser un valor numerico: se ha cambiado a 50.");
                    dictionary.Add("sPositiveRadioCurvaturaClotoide", "El Radio de Curvatura no puede ser menor que cero: se ha cambiado a 50.");
                    dictionary.Add("sNumericLongitudClotoide", "La Longitud de la Clotoide debe ser un valor numerico: se ha cambiado a 100.");
                    dictionary.Add("sPositiveLongitudClotoide", "La Longitud de la Clotoide no puede ser menor que cero: se ha cambiado a 100.");
                    dictionary.Add("sNumericAnguloTotalClotoide", "El Angulo Total debe ser un valor numerico: se ha cambiado a 60 grados.");
                    dictionary.Add("sPositiveAnguloTotalClotoide", "El Angulo Total no puede ser menor que cero: se ha cambiado a 60 grados.");
                    dictionary.Add("sLimitsNumberPuntosClotoide", "El Numero de Puntos del objeto ha de ser un valor entero comprendido entre 20 y 2147483647. Se ha cambiado a 40.");
                    dictionary.Add("sNumberPuntosClotoideImpar", "Para dibujar una polilinea con arcos el numero de puntos del objeto ha de ser impar: se ha subido el valor una unidad.");
                    dictionary.Add("sFinClotoide", "Se ha dibujado una clotoide con los siguientes puntos: ");
                    dictionary.Add("sClothoidLength", "Longitud de la Clotoide: ");
                    dictionary.Add("sClothoidDeflectionAngle", "Angulo de la Clotoide: ");
                    dictionary.Add("sClothoidParameter", "Parametro de la Clotoide: ");
                    dictionary.Add("sLengthCircularArc", "Longitud del Arco Circular: ");
                    dictionary.Add("sRadiusCircularArc", "Radio del Circulo: ");
                    dictionary.Add("sCircularArcAngle", "Angulo del Arco Circular: ");
                    dictionary.Add("sTangentsDeflectionAngle", "Angulo entre las Tangentes: ");
                    dictionary.Add("sTangentLength", "Longitud de la Tangente: ");
                    dictionary.Add("sShiftCurve", "Retranqueo: ");
                    dictionary.Add("sNumericLongitudArcoCirculo", "La Longitud del Arco Circular (Lc) debe ser un valor numerico: se ha cambiado a 100.");
                    dictionary.Add("sPositiveLongitudArcoCirculo", "La Longitud del Arco Circular (Lc) no puede ser menor que cero: se ha cambiado a 100.");
                    dictionary.Add("sNumericRadioArcoCircular", "El Radio del Arco Circular (Rc) debe ser un valor numerico: se ha cambiado a 50.");
                    dictionary.Add("sPositiveRadioArcoCircular", "El Radio del Arco Circular (Rc) no puede ser menor que cero: se ha cambiado a 50.");
                    dictionary.Add("sPrecisePuntoAlineacionEntrada", "Precise un punto cualquiera de la alineacion de entrada:");
                    dictionary.Add("sPrecisePuntoInterseccionAlineaciones", "Precise el punto de interseccion de las alineaciones:");
                    dictionary.Add("sPrecisePuntoAlineacionSalida", "Precise un punto cualquiera de la alineacion de salida:");
                    dictionary.Add("sNoPuntosConsecutivosIguales", "No puedes seleccionar dos puntos consecutivos iguales.");
                    dictionary.Add("sNoPuntosAlineacionesAlineados", "Los tres puntos de las alineaciones no pueden estar alineados.");
                    dictionary.Add("sSpecifyUnaLinea", "Seleccione una linea:");
                    dictionary.Add("sSpecifyUnCirculo", "Seleccione un circulo:");
                    dictionary.Add("sSpecifyDosCirculos", "Seleccione dos circulos:");
                    dictionary.Add("sNoCirculos", "No ha seleccionado ningun circulo.");
                    dictionary.Add("sNoDosCirculos", "Ha de seleccionar exactamente dos circulos.");
                    dictionary.Add("sNoCirculosPlanos", "Los circulos no son planos: no se puede hallar la solucion.");
                    dictionary.Add("sNoCirculosIgualCota", "Los circulos no estan a igual cota: no se pueden dibujar las tangentes.");
                    dictionary.Add("sCirculosNoTangentes", "Los circulos son interiores: no se pueden dibujar las tangentes.");
                    dictionary.Add("sCirculosTangentesExteriores", "Los circulos se cortan: se han dibujado solo las tangentes exteriores.");
                    dictionary.Add("sCirculosTangentesInterioresExteriores", "Se han dibujado las tangentes exteriores e interiores.");
                    dictionary.Add("sNumericPositiveRadioCirculo", "No has introducido un radio numerico positivo: se ha cambiado el valor a 20.");
                    dictionary.Add("sNoSolucionRadiosEs", "No existe solucion. El radio ha de ser como minimo: ");
                    dictionary.Add("sNoCirculoPlano", "El circulo no es plano: no se puede dibujar el circulo tangente.");
                    dictionary.Add("sNoLineaPlana", "La linea no es plana: no se puede dibujar el circulo tangente.");
                    dictionary.Add("sNoCirculoLineaIgualCota", "El circulo y la linea no estan a igual cota: no se puede dibujar el circulo tangente.");
                    dictionary.Add("sSolucionesCirculosTangentes1", "Se han hallado ");
                    dictionary.Add("sSolucionesCirculosTangentes2", " circulos tangentes de radio: ");
                    dictionary.Add("sPrecisePunto", "Precise el punto:");
                    dictionary.Add("sPrecisePrimerPuntoRecta", "Precise el primer punto de la recta:");
                    dictionary.Add("sPreciseSegundoPuntoRecta", "Precise el segundo punto de la recta:");
                    dictionary.Add("sPrecisePrimerPuntoPrimeraRecta", "Precise el primer punto de la primera recta:");
                    dictionary.Add("sPreciseSegundoPuntoPrimeraRecta", "Precise el segundo punto de la primera recta:");
                    dictionary.Add("sPrecisePrimerPuntoSegundaRecta", "Precise el primer punto de la segunda recta:");
                    dictionary.Add("sPreciseSegundoPuntoSegundaRecta", "Precise el segundo punto de la segunda recta:");
                    dictionary.Add("sPrecisePrimerPuntoPlano", "Precise el primer punto del plano:");
                    dictionary.Add("sPreciseSegundoPuntoPlano", "Precise el segundo punto del plano:");
                    dictionary.Add("sPreciseTercerPuntoPlano", "Precise el tercer punto del plano:");
                    dictionary.Add("sPrecisePrimerPuntoPrimerPlano", "Precise el primer punto del primer plano:");
                    dictionary.Add("sPreciseSegundoPuntoPrimerPlano", "Precise el segundo punto del primer plano:");
                    dictionary.Add("sPreciseTercerPuntoPrimerPlano", "Precise el tercer punto del primer plano:");
                    dictionary.Add("sPrecisePrimerPuntoSegundoPlano", "Precise el primer punto del segundo plano:");
                    dictionary.Add("sPreciseSegundoPuntoSegundoPlano", "Precise el segundo punto del segundo plano:");
                    dictionary.Add("sPreciseTercerPuntoSegundoPlano", "Precise el tercer punto del segundo plano:");
                    dictionary.Add("sRectaPertenecePlano", "La recta esta contenida en el plano: todos los puntos son de interseccion. La distancia de la recta al plano es cero.");
                    dictionary.Add("sRectaParalelaPlanoDistancia", "La recta es paralela al plano: no existe el punto de interseccion. La distancia de la recta al plano es: ");
                    dictionary.Add("sPrimerPuntoPertenecePlano", "El primer punto de la recta pertenece al plano: es el punto de interseccion.");
                    dictionary.Add("sSegundoPuntoPertenecePlano", "El segundo punto de la recta pertenece al plano: es el punto de interseccion.");
                    dictionary.Add("sRectaCortaPlano", "La recta corta al plano.");
                    dictionary.Add("sPlanosCoincidentes", "Los dos planos son el mismo: todos los puntos son de interseccion. La distancia es cero.");
                    dictionary.Add("sPlanosParalelosDistancia", "Los dos planos son paralelos: no existe la interseccion. La distancia entre planos es: ");
                    dictionary.Add("sPlanosSeCortan", "Los dos planos se cortan. Se ha dibujado la recta de interseccion.");
                    dictionary.Add("sPuntoPerteneceRecta", "Los tres puntos estan alineados. La distancia es cero. La interseccion es el punto.");
                    dictionary.Add("sDistanciaPuntoRecta", "La distancia del punto a la recta es: ");
                    dictionary.Add("sRectasIgualesDistancia", "Las dos rectas son iguales. La distancia entre ellas es cero.");
                    dictionary.Add("sRectasParalelasDistancia", "Las dos rectas son paralelas. La distancia entre ellas es: ");
                    dictionary.Add("sRectasSeCortanPtoInterseccion", "Las dos rectas se cortan. El punto de interseccion es");
                    dictionary.Add("sRectasSeCruzanDistancia", "Las dos rectas se cruzan. La distancia entre ellas es: ");
                    dictionary.Add("sEcNormalPlano", "Ecuacion Normal del Plano");
                    dictionary.Add("sVectorDirectorRecta", "Vector director de la Recta");
                    dictionary.Add("sPtoExteriorPlanoDistancia", "El punto es exterior al plano. Se ha dibujado la perpendicular al plano por el punto. La distancia es: ");
                    dictionary.Add("sPuntoPertenecePlano", "Los cuatro puntos son coplanares. La distancia es cero. La interseccion es el punto.");
                    dictionary.Add("sDistanciaPtoPlano", "Distancia del punto al plano: ");
                    dictionary.Add("sVolumenTetraedro", "Volumen del tetraedro: ");
                    dictionary.Add("sPtoInterseccion", "Punto de Interseccion: ");
                    dictionary.Add("sPtoAplicacionRecta", "Punto de Aplicacion de la Recta: ");
                    dictionary.Add("sNoPlanoPuntosAlineados", "No se ha podido definir el plano porque sus tres puntos estan alineados.");
                    dictionary.Add("sNoRectaPuntosIguales", "No se ha podido definir una recta porque los dos puntos son iguales.");
                    dictionary.Add("sOneObject", "Debes seleccionar al menos un objeto.");
                    dictionary.Add("sFinVectorNormal", "Se ha dibujado el vector normal del siguiente numero de objetos: ");
                    dictionary.Add("sSelectObjetosDibujarNormal", "Seleccione los objetos:");
                    dictionary.Add("sSpecifyCurve", "Seleccione una curva:");
                    dictionary.Add("sNoCurve", "No has seleccionado ninguna curva.");
                    dictionary.Add("sPointOnCurve", "Marque un punto sobre la curva:");
                    dictionary.Add("sVectorTangenteUnitario", "Vector Tangente Unitario:");
                    dictionary.Add("sVectorNormalUnitario", "Vector Normal Unitario:");
                    dictionary.Add("sVectorBiNormalUnitario", "Vector BiNormal Unitario:");
                    dictionary.Add("sCurvatura", "Curvatura: ");
                    dictionary.Add("sRadioCurvatura", "Radio de Curvatura: ");
                    dictionary.Add("sPtoAplicacionTriedro", "Pto. de Aplicacion: ");
                    dictionary.Add("sCentroCirculoObsculador", "Centro de curvatura: ");
                    dictionary.Add("sTriedroFrenetSerret", "Se ha dibujado el Triedro de Fr\x00eanet-Serret para el punto: ");
                    dictionary.Add("sPrecisePrimerPuntoArco", "Precise el primer punto del arco:");
                    dictionary.Add("sPreciseSegundoPuntoArco", "Precise el segundo punto del arco:");
                    dictionary.Add("sPreciseTercerPuntoArco", "Precise el tercer punto del arco:");
                    dictionary.Add("sNoArcoPuntosAlineados", "No se puede definir el arco con tres puntos alineados.");
                    dictionary.Add("sPrecisePrimerPuntoCirculo", "Precise el primer punto del Circulo:");
                    dictionary.Add("sPreciseSegundoPuntoCirculo", "Precise el segundo punto del Circulo:");
                    dictionary.Add("sPreciseTercerPuntoCirculo", "Precise el tercer punto del Circulo:");
                    dictionary.Add("sNoCirculoPuntosAlineados", "No se puede definir el circulo con tres puntos alineados.");
                    dictionary.Add("sPreciseCentroCirculo", "Precise el centro del Circulo:");
                    dictionary.Add("sPrecisePuntoCirculo", "Precise un punto del Circulo:");
                    dictionary.Add("sNoCirculoPuntosIguales", "No se puede definir el circulo con dos puntos iguales.");
                }
                else
                {
                    dictionary.Add("sTituloMenu", "Geometric Tools - InnerSoft CAD");
                    dictionary.Add("sR1", "Could not verify your registration data. Check that you have read/write permissions for the installation folder of InnerSoft.");
                    dictionary.Add("sR2", "Your registration data is incorrect. Please, contact us at innersoft@itspanish.org");
                    dictionary.Add("sDecimalSymbol", "Decimal Symbol of your Operating System is: ");
                    dictionary.Add("sSimboloDecimalPunto", "the point ");
                    dictionary.Add("sSimboloDecimalComa", "the comma ");
                    dictionary.Add("sSimboloDecimalOtro", "following symbol ");
                    dictionary.Add("sActiveDrawing", "Active Drawing: ");
                    dictionary.Add("sActiveDrawingPath", "Active Drawing Path: ");
                    dictionary.Add("sNumericIndexHeight", "You did not enter a numeric value for 'Index Height' field. Height is set to 1.0");
                    dictionary.Add("sPositiveIndexHeight", "You did not enter a positive numeric value for 'Index Height' field. Height is set to 1.0");
                    dictionary.Add("sAbort", "Or press 'Esc' key to abort.");
                    dictionary.Add("sFunctionCancelled", "Function cancelled by user.");
                    dictionary.Add("sTwoPoints", "You must select at least two points.");
                    dictionary.Add("sThreePoints", "You must select at least three points.");
                    dictionary.Add("sFourPoints", "You must select at least four points.");
                    dictionary.Add("sFrameSCoord1", "With Coord. Y (If Same Coord. X)");
                    dictionary.Add("sFrameSCoord2", "With Coord. X (If Same Coord. Y)");
                    dictionary.Add("sSelectPoints", "Select the points to graph: ");
                    dictionary.Add("sFinGrafica", "Graph draw from points: ");
                    dictionary.Add("sInsertingIndexes", "Inserting Indices.");
                    dictionary.Add("sTakingCoordinates", "Getting Coordinates.");
                    dictionary.Add("sNoAbiertoURL", "Could not open Web Page.");
                    dictionary.Add("sNumericParametroCatenaria", "Catenary Parameter has to be a numeric value: It has been set to 100.0");
                    dictionary.Add("sPositiveParametroCatenaria", "Catenary Parameter has to be a positive value: It has been set to 100.0");
                    dictionary.Add("sNumericLongitudCatenaria", "Length of the curve has to be a numeric value: It has been set to 100.0");
                    dictionary.Add("sPositiveLongitudCatenaria", "Length of the curve has to be a positive value: It has been set to 100.0");
                    dictionary.Add("sLimitsNumberPuntosCatenaria", "Number of Points of the Object must be an integer between 20 and 2147483647: It's been set to 40.");
                    dictionary.Add("sNumberPuntosCatenariaImpar", "To Draw a Polyline of Arcs the number of points of the Object has to be odd: It's been increased by one.");
                    dictionary.Add("sSpecifyCatenariaP1", "Pick first Catenary point:");
                    dictionary.Add("sSpecifyCatenariaP2", "Pick second Catenary point:");
                    dictionary.Add("sSpecifyCatenariaP3", "Pick third Catenary point:");
                    dictionary.Add("sNoPuntosVerticalCatenaria", "There cannot be two points vertically aligned: cannot draw the Catenary.");
                    dictionary.Add("sPuntoIntermedioEncima", "The point in the midle must be placed below the straight that link the extreme points: cannot draw the Catenary.");
                    dictionary.Add("sMenorLongitudMinima", "The curve length must be greater than the length of the staight that link the extreme points. The minimum length is: ");
                    dictionary.Add("sDistancesTooLong", "Sorry, could not start solving the catenary. Distances between points may be too long.");
                    dictionary.Add("sIterationsExceeded", "Sorry, iterations exceeded the maximum. Increase the Iterations or increase the Maximum Error.");
                    dictionary.Add("sErrorExceeded", "Sorry, error exceeded the maximum. Increase the Iterations or increase the Maximum Error.");
                    dictionary.Add("sCatenaryNotSolved", "Sorry, Could not solve the catenary.");
                    dictionary.Add("sCatenaryNotConverge", "Sorry, the catenary does not converge. The length is too short or points are nearly straight.");
                    dictionary.Add("sCatenaryLength", "Catenary Curve Length: ");
                    dictionary.Add("sCatenaryParameter", "Catenary Parameter: ");
                    dictionary.Add("sCatenaryEquation", "Catenary Equation: ");
                    dictionary.Add("sCatenaryVertex", "Catenary Vertex (lowest point): ");
                    dictionary.Add("sCatenaryOrigin", "Catenary Axes Origin: ");
                    dictionary.Add("sFinCatenaria", "Catenary Draw with points: ");
                    dictionary.Add("sMediaX", "X Mean: ");
                    dictionary.Add("sMediaY", "Y Mean: ");
                    dictionary.Add("sMediaZ", "Z Mean: ");
                    dictionary.Add("sVarianzaX", "X Variance: ");
                    dictionary.Add("sVarianzaY", "Y Variance: ");
                    dictionary.Add("sCovarianza", "Covariance: ");
                    dictionary.Add("sRectaRegresion", "Linear Regression Equation: ");
                    dictionary.Add("sCoeficienteCorrelacionLineal", "Correlation Coefficient: ");
                    dictionary.Add("sFinRegresion2D", "Draw a 2D Regression from points: ");
                    dictionary.Add("sFinRegresion3D", "Draw a 3D Regression from points: ");
                    dictionary.Add("sSumaCuadraticaResiduos", "The sum of the quadratic residues is: ");
                    dictionary.Add("sSumaCuadraticaDistanciasReales", "The sum of the quadratic residual distances is: ");
                    dictionary.Add("sUse2DRegression", "You must use a 2D regression method.");
                    dictionary.Add("sCentroRegresionCircular", "The center of the regression circle is: ");
                    dictionary.Add("sRadioRegresionCircular", "The radius of the regression circle is: ");
                    dictionary.Add("sEcuacionPlanoRegression", "The equation of the plane is: ");
                    dictionary.Add("sRadioRegresionEsferica", "The radius of the regression sphere is: ");
                    dictionary.Add("sCentroRegresionEsferica", "The center of the regression sphere is: ");
                    dictionary.Add("sFinConvexHull", "Draw a Convex Hull from points: ");
                    dictionary.Add("sFinQuickHull3D", "Draw a Convex Hull 3D from points: ");
                    dictionary.Add("sNoLines", "You did not select any line or lines.");
                    dictionary.Add("sEcuacionParabola", "Parabola Equation: ");
                    dictionary.Add("sSpecifyParabolaVertex", "Pick the Parabola Vertex:");
                    dictionary.Add("sSpecifyParabolaPoint", "Pick a Parabola Extreme Point:");
                    dictionary.Add("sNumericCoefParabola", "Parabola Coefficient must be numeric: it has been set to 0.1");
                    dictionary.Add("sNonCeroCoefParabola", "Parabola Coefficient can not be zero: it has been set to 0.1");
                    dictionary.Add("sNumericParabolaXCoord", "Increment on X Axis must be numerical: it has been set to 10");
                    dictionary.Add("sNonZeroParabolaXCoord", "Increment on X Axis can not be zero: it has been set to 10");
                    dictionary.Add("sLimitsNumberLineSegments", "Number of Line Segments must be an integer between 4 to 32767: it has been set to 10");
                    dictionary.Add("sSpecifyParabolaFirstPoint", "Pick first parabola point:");
                    dictionary.Add("sSpecifyParabolaSecondPoint", "Pick second parabola point:");
                    dictionary.Add("sSpecifyParabolaThirdPoint", "Pick third parabola point:");
                    dictionary.Add("sParabolaDosTangentes", "You must select two tangent lines.");
                    dictionary.Add("sParabolaTresTangentes", "You must select three tangent lines.");
                    dictionary.Add("sNoTangentesVerticales", "Tangent lines cannot be vertical lines: cannot draw the parabola.");
                    dictionary.Add("sNoInterseccionTangentes", "Two of the Tangent lines has no intersection: cannot draw the parabola.");
                    dictionary.Add("sNoTresPuntosAlineadosHorizontalmente", "The three points can not be horizontally aligned: cannot draw the parabola.");
                    dictionary.Add("sNoPuntosAlineadosVerticalmente", "There cannot be two of the points vertically aligned: cannot draw the parabola.");
                    dictionary.Add("sNoVerticePuntoAlineados", "Vertex and Extreme Point of the Parabola can not be vertically or horizontally aligned: cannot draw the parabola.");
                    dictionary.Add("sSpecifyParabolaTangenteAdyacente", "Select the Attached Tangent:");
                    dictionary.Add("sSpecifyParabolaDosTangentes", "Select two tangent lines:");
                    dictionary.Add("sSpecifyParabolaTresTangentes", "Select three tangent lines:");
                    dictionary.Add("sNumericParametroAcuerdoParabolico", "Parabolic transition parameter (K) has to be a numeric value: It has been set to 20.");
                    dictionary.Add("sNumericAcuerdoParabolicoG1", "Grade of Tangent in (G1) has to be a numeric value: It has been set to 10.");
                    dictionary.Add("sNumericAcuerdoParabolicoG2", "Grade of Tangent out (G2) has to be a numeric value: It has been set to 10.");
                    dictionary.Add("sSpecifyAcuerdoVerticalP1", "Get tangency point (VPC):");
                    dictionary.Add("sSpecifyAcuerdoVerticalP2", "Get tangency point (VPT):");
                    dictionary.Add("sSpecifyAcuerdoTangenteEntrada", "Select a line as tangent in (G1):");
                    dictionary.Add("sSpecifyAcuerdoTangenteSalida", "Select a line as tangent out (G2):");
                    dictionary.Add("sSpecifyClothoidStarPoint", "Pick the clothoid starting point: ");
                    dictionary.Add("sNumericRadioCurvaturaClotoide", "Radius of Circular curve at the end of the spiral (Rs) has to be a numeric value: It has been set to 50.");
                    dictionary.Add("sPositiveRadioCurvaturaClotoide", "Radius of Circular curve at the end of the spiral (Rs) has to be a positive value: It has been set to 50.");
                    dictionary.Add("sNumericLongitudClotoide", "Length of spiral curve has to be a numeric value: It has been set to 100.");
                    dictionary.Add("sPositiveLongitudClotoide", "Length of spiral curve has to be a positive value: It has been set to 100.");
                    dictionary.Add("sNumericAnguloTotalClotoide", "Angle of full spiral has to be a numeric value: It has been set to 60 degrees.");
                    dictionary.Add("sPositiveAnguloTotalClotoide", "Angle of full spiral curve has to be a positive value: It has been set to 60 degrees.");
                    dictionary.Add("sLimitsNumberPuntosClotoide", "Number of Points of the Object must be an integer between 20 and 2147483647: It has been set to 40.");
                    dictionary.Add("sNumberPuntosClotoideImpar", "To Draw a Polyline of Arcs the number of points of the Object has to be odd: It's been increased by one.");
                    dictionary.Add("sFinClotoide", "Clothoid Draw from points: ");
                    dictionary.Add("sClothoidLength", "Clothoid Length: ");
                    dictionary.Add("sClothoidDeflectionAngle", "Clothoid Deflection Angle: ");
                    dictionary.Add("sClothoidParameter", "Clothoid Parameter: ");
                    dictionary.Add("sLengthCircularArc", "Length of Circular Arc: ");
                    dictionary.Add("sRadiusCircularArc", "Radius of Circular Arc: ");
                    dictionary.Add("sCircularArcAngle", "Circular Arc Angle: ");
                    dictionary.Add("sTangentsDeflectionAngle", "Tangents Deflection Angle: ");
                    dictionary.Add("sTangentLength", "Tangent Length: ");
                    dictionary.Add("sShiftCurve", "Shift of the Curve: ");
                    dictionary.Add("sNumericLongitudArcoCirculo", "The Length of Circular Arc (Lc) has to be a numeric value: It has been set to 100.");
                    dictionary.Add("sPositiveLongitudArcoCirculo", "The Length of Circular Arc (Lc) has to be a positive value: It has been set to 100.");
                    dictionary.Add("sNumericRadioArcoCircular", "The Radius of Circular Arc (Rc) has to be a numeric value: It has been set to 50.");
                    dictionary.Add("sPositiveRadioArcoCircular", "The Radius of Circular Arc (Rc) has to be a positive value: It has been set to 50.");
                    dictionary.Add("sPrecisePuntoAlineacionEntrada", "Pick any point of the entry tangent:");
                    dictionary.Add("sPrecisePuntoInterseccionAlineaciones", "Specify the tangents interseccion point (I):");
                    dictionary.Add("sPrecisePuntoAlineacionSalida", "Pick any point of the exit tangent:");
                    dictionary.Add("sNoPuntosConsecutivosIguales", "Cannot get two consecutive equal points.");
                    dictionary.Add("sNoPuntosAlineacionesAlineados", "The three selected points cannot be aligned.");
                    dictionary.Add("sSpecifyUnaLinea", "Select a line:");
                    dictionary.Add("sSpecifyUnCirculo", "Select a circle:");
                    dictionary.Add("sSpecifyDosCirculos", "Select two circles:");
                    dictionary.Add("sNoCirculos", "You did not select any circle.");
                    dictionary.Add("sNoDosCirculos", "You have to select two circles.");
                    dictionary.Add("sNoCirculosPlanos", "Circles are not planar: can not solve the system.");
                    dictionary.Add("sNoCirculosIgualCota", "Circles have not the same elevation: can not draw the tangent lines.");
                    dictionary.Add("sCirculosNoTangentes", "One circle contains the other: can not draw the tangent lines.");
                    dictionary.Add("sCirculosTangentesExteriores", "The circles intersect: only draw the inner tangents.");
                    dictionary.Add("sCirculosTangentesInterioresExteriores", "Draw the outer and inner tangents.");
                    dictionary.Add("sNumericPositiveRadioCirculo", "You did not input a positive numeric radius: it has been set to 20.");
                    dictionary.Add("sNoSolucionRadiosEs", "Can not solve the system. Radius must be equal or greater than: ");
                    dictionary.Add("sNoCirculoPlano", "Circle is not planar: can not draw the tangent circle.");
                    dictionary.Add("sNoLineaPlana", "Line is not planar: can not draw the tangent circle.");
                    dictionary.Add("sNoCirculoLineaIgualCota", "Circle and line have not the same elevation: can not draw the tangent circle.");
                    dictionary.Add("sSolucionesCirculosTangentes1", "Application found ");
                    dictionary.Add("sSolucionesCirculosTangentes2", " tangent circles of radius: ");
                    dictionary.Add("sPrecisePunto", "Pick the point:");
                    dictionary.Add("sPrecisePrimerPuntoRecta", "Pick the first point of the line:");
                    dictionary.Add("sPreciseSegundoPuntoRecta", "Pick the second point of the line:");
                    dictionary.Add("sPrecisePrimerPuntoPrimeraRecta", "Pick the first point of the first line:");
                    dictionary.Add("sPreciseSegundoPuntoPrimeraRecta", "Pick the second point of the first line:");
                    dictionary.Add("sPrecisePrimerPuntoSegundaRecta", "Pick the first point of the second line:");
                    dictionary.Add("sPreciseSegundoPuntoSegundaRecta", "Pick the second point of the second line:");
                    dictionary.Add("sPrecisePrimerPuntoPlano", "Pick the first point of the plane:");
                    dictionary.Add("sPreciseSegundoPuntoPlano", "Pick the second point of the plane:");
                    dictionary.Add("sPreciseTercerPuntoPlano", "Pick the third point of the plane:");
                    dictionary.Add("sPrecisePrimerPuntoPrimerPlano", "Pick the first point of the first plane:");
                    dictionary.Add("sPreciseSegundoPuntoPrimerPlano", "Pick the second point of the first plane:");
                    dictionary.Add("sPreciseTercerPuntoPrimerPlano", "Pick the third point of the first plane:");
                    dictionary.Add("sPrecisePrimerPuntoSegundoPlano", "Pick the first point of the second plane:");
                    dictionary.Add("sPreciseSegundoPuntoSegundoPlano", "Pick the second point of the second plane:");
                    dictionary.Add("sPreciseTercerPuntoSegundoPlano", "Pick the third point of the second plane:");
                    dictionary.Add("sRectaPertenecePlano", "The line is contained in the plane. Line-Plane Distance is zero.");
                    dictionary.Add("sRectaParalelaPlanoDistancia", "The line is parallel to the plane: there is no point of intersection. Line-Plane Distance is: ");
                    dictionary.Add("sPrimerPuntoPertenecePlano", "The first point of the line lies on the plane: is the point of intersection.");
                    dictionary.Add("sSegundoPuntoPertenecePlano", "The second point of the line lies on the plane: is the point of intersection.");
                    dictionary.Add("sRectaCortaPlano", "The line intersects the plane.");
                    dictionary.Add("sPlanosCoincidentes", "The two planes are equal. The distance between planes is zero.");
                    dictionary.Add("sPlanosParalelosDistancia", "The two planes are parallel: there is no intersection line. The distance between planes is: ");
                    dictionary.Add("sPlanosSeCortan", "The two planes intersect. Was drawn the Line of intersection between two planes.");
                    dictionary.Add("sPuntoPerteneceRecta", "The three points are aligned. The distance is zero. The intersection is the given point.");
                    dictionary.Add("sDistanciaPuntoRecta", "The shortest distance from the point to the line is: ");
                    dictionary.Add("sRectasIgualesDistancia", "The two lines are equal. The distance between lines is zero.");
                    dictionary.Add("sRectasParalelasDistancia", "The two lines are parallel. The distance between lines is: ");
                    dictionary.Add("sRectasSeCortanPtoInterseccion", "The two lines intersect. The point of intersection is ");
                    dictionary.Add("sRectasSeCruzanDistancia", "The two lines are skew. The shortest distance between lines is: ");
                    dictionary.Add("sEcNormalPlano", "Standard Plane Equation");
                    dictionary.Add("sVectorDirectorRecta", "Direction Vector of the line");
                    dictionary.Add("sPtoExteriorPlanoDistancia", "The point lies outside the plane. Was drawn the perpendicular to the plane through the point. The shortest distance is: ");
                    dictionary.Add("sPuntoPertenecePlano", "These four points are coplanar. The distance is zero. The intersection is the point.");
                    dictionary.Add("sDistanciaPtoPlano", "Distance from the point to the plane is: ");
                    dictionary.Add("sVolumenTetraedro", "Volume of the Tetrahedron: ");
                    dictionary.Add("sPtoInterseccion", "Point of Intersection: ");
                    dictionary.Add("sPtoAplicacionRecta", "Pass-Through Point of the Line: ");
                    dictionary.Add("sNoPlanoPuntosAlineados", "Could not define a plane because the three points are collinear.");
                    dictionary.Add("sNoRectaPuntosIguales", "Could not define a line because the two points are equal.");
                    dictionary.Add("sOneObject", "You must select at least one object.");
                    dictionary.Add("sFinVectorNormal", "Has been drawn the normal vector of the following number of objects: ");
                    dictionary.Add("sSelectObjetosDibujarNormal", "Select objects: ");
                    dictionary.Add("sSpecifyCurve", "Select a curve:");
                    dictionary.Add("sNoCurve", "You did not Select any curve.");
                    dictionary.Add("sPointOnCurve", "Pick a point on the curve:");
                    dictionary.Add("sVectorTangenteUnitario", "Unit Tangent Vector:");
                    dictionary.Add("sVectorNormalUnitario", "Unit Normal Vector:");
                    dictionary.Add("sVectorBiNormalUnitario", "Unit Binormal Vector:");
                    dictionary.Add("sCurvatura", "Curvature: ");
                    dictionary.Add("sRadioCurvatura", "Radius of curvature: ");
                    dictionary.Add("sPtoAplicacionTriedro", "Coordinates of Point on the curve: ");
                    dictionary.Add("sCentroCirculoObsculador", "Center of curvature: ");
                    dictionary.Add("sTriedroFrenetSerret", "Draw the Frenet Frame at point: ");
                    dictionary.Add("sPrecisePrimerPuntoArco", "Pick the first point of the arc:");
                    dictionary.Add("sPreciseSegundoPuntoArco", "Pick the second point of the arc:");
                    dictionary.Add("sPreciseTercerPuntoArco", "Pick the third point of the arc:");
                    dictionary.Add("sNoArcoPuntosAlineados", "Cannot define an arc with three aligned points.");
                    dictionary.Add("sPrecisePrimerPuntoCirculo", "Pick the first point of the circle:");
                    dictionary.Add("sPreciseSegundoPuntoCirculo", "Pick the second point of the circle:");
                    dictionary.Add("sPreciseTercerPuntoCirculo", "Pick the third point of the circle:");
                    dictionary.Add("sNoCirculoPuntosAlineados", "Cannot define a circle with three aligned points.");
                    dictionary.Add("sPreciseCentroCirculo", "Pick the center of the circle:");
                    dictionary.Add("sPrecisePuntoCirculo", "Pick a point of the circle:");
                    dictionary.Add("sNoCirculoPuntosIguales", "Cannot define a circle with two equal points.");
                }
                dictionary2 = dictionary;
            }
            catch (System.Exception exception1)
            {
                Microsoft.VisualBasic.CompilerServices.ProjectData.SetProjectError(exception1);
                System.Exception exception = exception1;
                Microsoft.VisualBasic.Interaction.MsgBox("Error en LanguageMessages: " + exception.Message, Microsoft.VisualBasic.MsgBoxStyle.Critical, "Message - InnerSoft");
                dictionary2 = null;
                Microsoft.VisualBasic.CompilerServices.ProjectData.ClearProjectError();
            }
            return dictionary2;
        }
        
        public virtual AcadDocument ThisDrawing
        {
            get
            {
                return this.acadDocument_0;
            }
            set
            {                
                _DAcadDocumentEvents_BeginCloseEventHandler variable =
                    new _DAcadDocumentEvents_BeginCloseEventHandler(this.method_0);
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

        public Autodesk.AutoCAD.ApplicationServices.Application _App_0;

        public Autodesk.AutoCAD.ApplicationServices.Document _doc;

        public event DocumentBeginCloseEventHandler docEventClose;

        public void OnDocHandlerClose(object sender, DocumentBeginCloseEventArgs e)
        {
            this.Close();
        }
             
        public virtual Autodesk.AutoCAD.ApplicationServices.Document Currentdoc
        {
            get
            { return _doc; }
            set
            {
               DocumentBeginCloseEventHandler variabel  =
                    new DocumentBeginCloseEventHandler(this.OnDocHandlerClose);
                if (this._doc != null)
                {
                    variabel -= new DocumentBeginCloseEventHandler(this.OnDocHandlerClose);
                }
                this._doc = value;
                if (this._doc != null)
                {
                    variabel += new DocumentBeginCloseEventHandler(this.OnDocHandlerClose);
                }

            }
        }

        public virtual Autodesk.AutoCAD.ApplicationServices.Application _CurrApp
        {
            get { return _App_0; }
            set
            {
               
            }
        }

        private void FormGrafica_Load(object sender, EventArgs e)
        {
            try
            {

                //Class_7.string_0 = this.classComunes_0.GetSettings();
                //this.method_32();
                dictionary_0 = this.method_42(1);
                //if (dictionary_0 == null)
                //{
                //    RadMessageBox.Show("Error. Kesalahan","Message - SPLASHCAD",MessageBoxButtons.OK,RadMessageIcon.Error,MessageBoxDefaultButton.Button1);
                //    this.Close();
                //}
                //else
                //{                
                //    dictionary_1 = this.method_40();
                //    if (dictionary_1 != null)
                //    {
                //        //if (this.short_0 == 0)
                //        //{
                //        //    this.method_41(1);
                //        //}
                //        //else if (this.short_0 == 1)
                //        //{
                //        //    this.method_42(2);
                //        //}
                //        //else if ((this.short_0 != 2) && (this.short_0 == 3))
                //        //{
                //        //    int num2 = 1;
                //        //    if (this.method_39(ref num2) <= 60)
                //        //    {
                //        //        this.method_41(2);
                //        //        this.Close();
                //        //        return;
                //        //    }
                //        //    this.short_0 = 4;
                //        //}
                //    }
                try
                {
                    //this.xAcad = (Autodesk.AutoCAD.Interop.AcadApplication)Autodesk.AutoCAD.ApplicationServices.
                    //Application.AcadApplication;
                    //this.xAcad = Get_Application();
                    //Document Ed = Autodesk.AutoCAD.ApplicationServices.
                    //    Application.DocumentManager.MdiActiveDocument.Editor.Document.GetAcadDocument();
                    Document doc =
                        Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager.MdiActiveDocument;
                    if (Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager.MdiActiveDocument != null)
                    {
                        LabelDibujoActivo.Text = string.Format("Active Drawing:{0}", doc.Name);
                    }

                    this.Currentdoc = Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager.MdiActiveDocument;
                
                }
                catch (System.Exception exception1)
                {
                    ProjectData.SetProjectError(exception1);
                    System.Exception exception = exception1;
                    Interaction.MsgBox("Error Koneksi AutoCAD: " + exception.Message, MsgBoxStyle.Critical, "Message - InnerSoft");
                    this.Close();
                    ProjectData.ClearProjectError();
                    return;
                }
                                
                //string str = this.ThisDrawing.GetVariable("ACADVER").ToString();
                //if ((str.Substring(0, 4) == "19.1") | (str.Substring(0, 2) == "20"))
                //{
                //    this.classComunes_0.AgregarTrustedPath();
                //}
                this.KeyPreview = true;
                //try
                //{
                //    enumerator = this.ThisDrawing.TextStyles.GetEnumerator();
                //    while (enumerator.MoveNext())
                //    {
                //        AcadTextStyle current = (AcadTextStyle)enumerator.Current;
                //        if (current.Name != string.Empty)
                //        {
                //            this.ComboBoxLetra.Items.Add(current.Name);
                //        }
                //    }
                //}
                //finally
                //{
                //    if (enumerator is IDisposable)
                //    {
                //        (enumerator as IDisposable).Dispose();
                //    }
                //}
                this.ComboBoxLetra.DropDownStyle = RadDropDownStyle.DropDownList;
                this.ComboBoxLetra.SelectedIndex = 0;
                //this.string_2 = this.ThisDrawing.GetVariable("ACADVER").ToString().Substring(0, 4);

                this.string_1 = NumberFormatInfo.CurrentInfo.NumberDecimalSeparator;
                if (this.string_1 == ",")
                {
                    this.LabelInfo.Text = dictionary_0["sDecimalSymbol"] + dictionary_0["sSimboloDecimalComa"] + "(" + this.string_1 + ")";
                }
                else if (this.string_1 == ".")
                {
                    this.LabelInfo.Text = dictionary_0["sDecimalSymbol"] + dictionary_0["sSimboloDecimalPunto"] + "(" + this.string_1 + ")";
                }
                else
                {
                    this.LabelInfo.Text = dictionary_0["sDecimalSymbol"] + dictionary_0["sSimboloDecimalOtro"] + "(" + this.string_1 + ")";
                }
                this.LabelDibujoActivo.Text = dictionary_0["sActiveDrawing"] + this.Currentdoc.Name;
                this.bool_0 = true;

            }
            catch (System.Exception excep)
            {
                ProjectData.SetProjectError(excep);
                System.Exception exception = excep;
                Interaction.MsgBox("Error Koneksi AutoCAD: " + exception.Message, MsgBoxStyle.Critical, "Message - InnerSoft");
                this.Close();
                ProjectData.ClearProjectError();
                return;
            }


            }

        private void radButton1_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (System.Exception excep)
            {
                ProjectData.SetProjectError(excep);
                System.Exception exception = excep;
                MessageBox.Show("Error en Catenaria: " + exception.Message, "SPLASHCAD - Message", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                ProjectData.ClearProjectError();
            }
        }
        
        private AcadApplication acadApplication_0;
        private AcadDocument acadDocument_0;
        private static Dictionary<string, string> dictionary_0;
        private static Dictionary<string, string> dictionary_1;
        private ClassComunes classComunes_0;
        private short short_0;
        private string string_0;
        private string string_1;
        private string string_2;
        private double double_0;
        private bool bool_0;
        private bool bool_1;
        private AcadSelectionSet acadSelectionSet_0;

        IEnumerator enumerator2;
        IEnumerator enumerator3;
        IEnumerator enumerator4;
        IEnumerator enumerator5;
        IEnumerator enumerator;

        private void RadioButtonCCCRadioLCirculo_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            this.TextBoxRadioCirculoCCC.Enabled = true;
            this.TextBoxArcoCirculoCCC.Enabled = true;
            this.TextBoxLongitudClotoideCCC.Enabled = false;
        }

        private void RadioButtonCCCWhollyTransitionalCurve_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            this.TextBoxRadioCirculoCCC.Enabled = true;
            this.TextBoxArcoCirculoCCC.Enabled = false;
            this.TextBoxLongitudClotoideCCC.Enabled = false;
        }

        private void RadioButtonCCCRadioLClotoide_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            this.TextBoxRadioCirculoCCC.Enabled = true;
            this.TextBoxArcoCirculoCCC.Enabled = false;
            this.TextBoxLongitudClotoideCCC.Enabled = true;
        }

        private void RadioButtonClotoideLWPolyCCC_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            int num;
            if (this.RadioButtonClotoideLWPolyCCC.IsChecked)
            {
                if (!int.TryParse(Conversions.ToString(this.NumericUpDownPuntosClotoideCCC.Value), out num))
                {
                    num = 41;
                    this.NumericUpDownPuntosClotoideCCC.Value = new decimal(41L);
                }
                else if (num < 20 | num > 2147483647)
                {
                    num = 41;
                    this.NumericUpDownPuntosClotoideCCC.Value = new decimal(41L);
                }
                if (num % 2 == 0)
                {
                    num++;
                    this.NumericUpDownPuntosClotoideCCC.Value = new decimal(num);
                }
            }
        }

        private void TextBoxAlturaIndice_KeyPress(object sender, KeyPressEventArgs e)
        {
            string str = e.KeyChar.ToString();
            if (!char.IsDigit(e.KeyChar) && !str.Equals(this.string_1))
            {
                if (Operators.CompareString(Conversions.ToString(e.KeyChar), "\b", false) != 0)
                {
                    e.Handled = true;
                }
            }
        }
                

    }
    
    public class Point2D
    {
        public double X;

        public double Y;

        public Point2D(double double_0, double double_1)
        {
            this.X = double_0;
            this.Y = double_1;
        }
    }
    
    public struct stCatenaria
    {
        public double dParametroCatenaria;

        public double xSistemaCoord;

        public double ySistemaCoord;

        public bool bIteracionesSobrepasadas;

        public bool bErrorSobrepasado;
    }
    
}

