using ACadSharp;
using ACadSharp.Entities;
using ACadSharp.IO;
using ACadSharp.IO.DXF;
using CSMath;

namespace CADTest
{
    // https://products.fileformat.com/cad/net/acadsharp/
    public class Class1
    {
        public void Write(string fileName)
        {
            CadDocument doc = new CadDocument();
            
            Line line = new Line();
            line.StartPoint = new XYZ(15,15,15);
            line.EndPoint = new XYZ(115,115,115);


            doc.Entities.Add(line);


            DxfWriter writer = new DxfWriter(fileName, doc, false);
            
            writer.Write();
        }
    }
}