using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autodesk.AutoCAD.Runtime;
using Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.EditorInput;
using System.ComponentModel;

[assembly: ExtensionApplication(typeof(SPC.cMenu))]
[assembly: CommandClass(typeof(SPC.cMenu))]
namespace SPC
{

    public class cMenu : IExtensionApplication

    {

        void IExtensionApplication.Initialize()
        {
            Editor ed = Application.DocumentManager.MdiActiveDocument.Editor;
            ed.WriteMessage("Loading AecPropertyGridMgd...\r\n");
        }
        void IExtensionApplication.Terminate() { }


        [CommandMethod("SPCGEOM", CommandFlags.Modal)]
        public void Grafica()
        {
            FormGrafica rForm = new FormGrafica();
            rForm.Show();
        }
        
        #region Command
        [Autodesk.AutoCAD.Runtime.CommandMethod("PropertyGridS", CommandFlags.Modal)]
        public void PropertyGridS()
        {
            Editor ed = Application.DocumentManager.MdiActiveDocument.Editor;

            PromptSelectionOptions options = new PromptSelectionOptions();
            options.SingleOnly = true;
            options.MessageForAdding = "Pick an entity: ";

            PromptSelectionResult res1 = ed.GetSelection(options);

            if (res1.Status != PromptStatus.OK)
                return;

            ObjectId[] selSet = res1.Value.GetObjectIds();

            Database db = Application.DocumentManager.MdiActiveDocument.Database;
            Autodesk.AutoCAD.DatabaseServices.TransactionManager tm = db.TransactionManager;
            Transaction trans = tm.StartTransaction();

            System.Windows.Forms.DialogResult res2 = System.Windows.Forms.DialogResult.None;

            try
            {
                Object obj = tm.GetObject(selSet[0], OpenMode.ForWrite, false, false);

                ObjectId styleId;
                try
                {
                    Object obj2 = obj.GetType().InvokeMember("StyleId", System.Reflection.BindingFlags.GetProperty, null, obj, null);
                    if (!(obj2 is ObjectId))
                        return;

                    styleId = (ObjectId)obj2;
                }
                catch
                {
                    styleId = ObjectId.Null;
                }

                if (!styleId.IsNull)
                {
                    PromptResult res3 = ed.GetString("Option [Object/Style]: ");
                    if (res3.StringResult.StartsWith("S") || res3.StringResult.StartsWith("s"))
                        obj = tm.GetObject(styleId, OpenMode.ForWrite, false, false);
                }

#if DEBUG_CM
			// check for Aec properties that are not categorized
			CheckCategories(obj);
#endif

                Form1 form = new Form1();
                form.SetObjects(obj);

                res2 = form.ShowDialog();

                // free up the object owned by the property grid
                form.ResetObjects();
            }
            catch
            {
                trans.Abort();
                trans.Dispose();
            }
            finally
            {
                if (res2 == System.Windows.Forms.DialogResult.OK)
                    trans.Commit();

                trans.Dispose();

            }
        }
        #endregion

        #region CheckCategories
        private void CheckCategories(Object obj)
        {
            String results = "";

            PropertyDescriptorCollection props = TypeDescriptor.GetProperties(obj);
            foreach (PropertyDescriptor prop in props)
            {
                if (prop.Category == "Misc")
                {
                    if (prop.ComponentType.Namespace.StartsWith("Autodesk.Aec"))
                        results = results + prop.Name + " (" + prop.ComponentType.Name + ")" + "\r\n";
                }
            }

            if (results != "")
                System.Windows.Forms.MessageBox.Show(results, "Category missing!", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
        }
        #endregion
    }
}
