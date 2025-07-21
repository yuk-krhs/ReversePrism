using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Doc                                      ModelClassType XmlDocument XmlDocument XmlDocument Pointer
    // 018 Ds                                       ModelClassType DataSet DataSet DataSet Pointer
    // 020 Dt                                       ModelClassType DataTable DataTable DataTable Pointer
    // 028 Xmlw                                     ModelClassType XmlWriter XmlWriter XmlWriter Pointer
    // 030 FBefore                                  ModelPrimitiveType bool bool bool Bool
    // 031 FErrors                                  ModelPrimitiveType bool bool bool Bool
    // 038 RowsOrder                                ModelClassType Hashtable Hashtable Hashtable Pointer
    // 040 Tables                                   ModelClassType ArrayList ArrayList ArrayList Pointer
    // 048 WriteHierarchy                           ModelPrimitiveType bool bool bool Bool
    public partial class NewDiffgramGen : DataModel
    {
        public XmlDocument?                             Doc                                     { get; set; }
        public DataSet?                                 Ds                                      { get; set; }
        public DataTable?                               Dt                                      { get; set; }
        public XmlWriter?                               Xmlw                                    { get; set; }
        public bool                                     FBefore                                 { get; set; }
        public bool                                     FErrors                                 { get; set; }
        public Hashtable?                               RowsOrder                               { get; set; }
        public ArrayList?                               Tables                                  { get; set; }
        public bool                                     WriteHierarchy                          { get; set; }

        public static NewDiffgramGen? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new NewDiffgramGen() { Pointer= p0 };

            value.Doc                                       = GetObject<XmlDocument>(new IntPtr(p + 0x010), ReversePrism.DataModels.XmlDocument.FromPointer); // 0x10 Doc                         ( ModelClassType XmlDocument XmlDocument XmlDocument Pointer )
            value.Ds                                        = GetObject<DataSet>(new IntPtr(p + 0x018), ReversePrism.DataModels.DataSet.FromPointer); // 0x18 Ds                          ( ModelClassType DataSet DataSet DataSet Pointer )
            value.Dt                                        = GetObject<DataTable>(new IntPtr(p + 0x020), ReversePrism.DataModels.DataTable.FromPointer); // 0x20 Dt                          ( ModelClassType DataTable DataTable DataTable Pointer )
            value.Xmlw                                      = GetObject<XmlWriter>(new IntPtr(p + 0x028), ReversePrism.DataModels.XmlWriter.FromPointer); // 0x28 Xmlw                        ( ModelClassType XmlWriter XmlWriter XmlWriter Pointer )
            value.FBefore                                   = GetBool(new IntPtr(p + 0x030)); // 0x30 FBefore                     ( ModelPrimitiveType bool bool bool Bool )
            value.FErrors                                   = GetBool(new IntPtr(p + 0x031)); // 0x31 FErrors                     ( ModelPrimitiveType bool bool bool Bool )
            value.RowsOrder                                 = GetObject<Hashtable>(new IntPtr(p + 0x038), ReversePrism.DataModels.Hashtable.FromPointer); // 0x38 RowsOrder                   ( ModelClassType Hashtable Hashtable Hashtable Pointer )
            value.Tables                                    = GetObject<ArrayList>(new IntPtr(p + 0x040), ReversePrism.DataModels.ArrayList.FromPointer); // 0x40 Tables                      ( ModelClassType ArrayList ArrayList ArrayList Pointer )
            value.WriteHierarchy                            = GetBool(new IntPtr(p + 0x048)); // 0x48 WriteHierarchy              ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
