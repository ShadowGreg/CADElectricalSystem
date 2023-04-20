using System.Collections;
using System.Collections.Generic;
using ACadSharp;
using ACadSharp.Entities;
using ACadSharp.IO;
using ACadSharp.Tables;

namespace CADTest
{
    public class ReadDXF
    {
        public static IEnumerable<Entity> GetAllEntitiesInModel(string file)
        {
            // CadDocument doc = DwgReader.Read(file);
            CadDocument doc = DxfReader.Read(file);
            

            // Get the model space where all the drawing entities are
            // BlockRecord modelSpace = doc.BlockRecords["*Model_Space"];
            var modelSpace = doc.Entities;

            // Get all the entities in the model space
            // return modelSpace.Entities;
            return modelSpace;
        }
    }
}