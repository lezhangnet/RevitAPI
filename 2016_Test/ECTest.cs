using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logos.Revit
{
    // GUID: {3B2F57A8-E3E7-4C58-AC3F-3183AAC997B3}
    [Autodesk.Revit.Attributes.Transaction(Autodesk.Revit.Attributes.TransactionMode.Automatic)]
    public class ECTest : Autodesk.Revit.UI.IExternalCommand
    {
        public Autodesk.Revit.UI.Result Execute(
            Autodesk.Revit.UI.ExternalCommandData commandData,
            ref string message,
            Autodesk.Revit.DB.ElementSet elements)
        {
            System.Windows.Forms.MessageBox.Show("Hello RevitAPI World!\n--LeZhang.net");
            return Autodesk.Revit.UI.Result.Succeeded;
        }
    }
}
