using Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Interop;
using Autodesk.AutoCAD.Interop.Common;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

[assembly: Autodesk.AutoCAD.Runtime.CommandClass(typeof(SPC.ClassComunes))]
namespace SPC
{
    class ClassComunes
    {
        private AcadApplication acadApplication_0;
        private AcadDocument acadDocument_0;

        public virtual AcadApplication xAcad
        {
            get
            {return this.acadApplication_0;}
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {this.acadApplication_0 = value;}
        }
         
        public virtual AcadDocument ThisDrawing
        {
            get
            {return this.acadDocument_0;}
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {this.acadDocument_0 = value;}
        }

        public string GetSettings()
        {
            string str3;
            new Dictionary<string, string>();
            try
            {
                string path = System.IO.Path.GetDirectoryName(
                    System.Reflection.Assembly.GetExecutingAssembly(). 
                    Location) + @"\SPLASHCAD_Config.xml";
                if (System.IO.File.Exists(path))
                {
                    System.Xml.XmlDocument document = new System.Xml.XmlDocument();
                    System.IO.FileStream inStream = new System.IO.FileStream(path, 
                        System.IO.FileMode.Open, System.IO.FileAccess.Read);
                    document.Load(inStream);
                    inStream.Close();
                    return document.GetElementsByTagName("GENERAL")[0].
                        ChildNodes.Item(0).InnerText.Trim();
                }
                str3 = "en";
            }
            catch (Exception exception)
            {
                ProjectData.SetProjectError(exception);
                str3 = "en";
                ProjectData.ClearProjectError();
            }
            return str3;
        }

        public void AgregarActivarCapa(string sCapa)
        {
            try
            {
                AcadLayer layer = this.ThisDrawing.Layers.Add(sCapa);
                if (!layer.LayerOn)
                {
                    layer.LayerOn = true;
                }
                if (layer.Lock)
                {
                    layer.Lock = false;
                }
                if (layer.Freeze)
                {
                    layer.Freeze = false;
                }
                layer.Description = "SPLASH CAD";
                this.ThisDrawing.ActiveLayer = layer;
            }
            catch (Exception exception1)
            {
                ProjectData.SetProjectError(exception1);
                Exception exception = exception1;
                Interaction.MsgBox("Error en AgregarActivarCapa: " + exception.Message, MsgBoxStyle.Critical, "SPLASH - Message");
                ProjectData.ClearProjectError();
            }
        }

        public void AgregarActivarCapaNET(string sLayerName)
        {
            Document mdiActiveDocument = Application.DocumentManager.MdiActiveDocument;
            Database database = mdiActiveDocument.Database;
            using (mdiActiveDocument.LockDocument())
            {
                using (Transaction transaction = database.TransactionManager.StartTransaction())
                {
                    LayerTable table = (LayerTable)transaction.GetObject(database.LayerTableId, Autodesk.AutoCAD.DatabaseServices.OpenMode.ForRead);
                    if (!table.Has(sLayerName))
                    {
                        LayerTableRecord record = new LayerTableRecord
                        {
                            Name = sLayerName,
                            Description = "SPLASH CAD"
                        };
                        table.UpgradeOpen();
                        table.Add(record);
                        transaction.AddNewlyCreatedDBObject(record, true);
                    }
                    else
                    {
                        LayerTableRecord record2 = (LayerTableRecord)transaction.
                            GetObject(table[sLayerName], Autodesk.AutoCAD.DatabaseServices.
                            OpenMode.ForWrite);
                        try
                        {
                            record2.IsLocked = false;
                            record2.IsOff = false;
                            record2.IsHidden = false;
                            record2.IsFrozen = false;
                        }
                        catch (Exception exception1)
                        {
                            ProjectData.SetProjectError(exception1);
                            ProjectData.ClearProjectError();
                        }
                    }
                    database.Clayer = table[sLayerName];
                    transaction.Commit();
                }
            }
        }
        
        public void AgregarTrustedPath()
        {
            string str = this.ThisDrawing.GetVariable("TRUSTEDPATHS").ToString();
            string directoryName = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            if (string.IsNullOrEmpty(str))
            {
                this.ThisDrawing.SetVariable("TRUSTEDPATHS", directoryName + ";");
            }
            else if (!str.Contains(directoryName + ";"))
            {
                this.ThisDrawing.SetVariable("TRUSTEDPATHS", str + ";" + directoryName + ";");
            }
        }






    }
}
