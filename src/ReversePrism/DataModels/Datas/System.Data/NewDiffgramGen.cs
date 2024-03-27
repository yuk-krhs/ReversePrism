using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Doc                                      000186595C60 ModelClassType XmlDocument XmlDocument XmlDocument Pointer
    // 018 Ds                                       0001866809A0 ModelClassType DataSet DataSet DataSet Pointer
    // 020 Dt                                       0001865B8050 ModelClassType DataTable DataTable DataTable Pointer
    // 028 Xmlw                                     0001865D6E40 ModelClassType XmlWriter XmlWriter XmlWriter Pointer
    // 030 FBefore                                  000186594D10 ModelPrimitiveType bool bool bool Bool
    // 031 FErrors                                  000186594D10 ModelPrimitiveType bool bool bool Bool
    // 038 RowsOrder                                0001865DE5A0 ModelClassType Hashtable Hashtable Hashtable Pointer
    // 040 Tables                                   00018658A070 ModelClassType ArrayList ArrayList ArrayList Pointer
    // 048 WriteHierarchy                           000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class NewDiffgramGen
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
            var value   = new NewDiffgramGen();

            value.Doc                                       = GetObject<XmlDocument>(new IntPtr(p + 0x010), ReversePrism.DataModels.XmlDocument.FromPointer); // 0270D897B1C8 0x10 Doc                         ( 000186595C60 ModelClassType XmlDocument XmlDocument XmlDocument Pointer )
            value.Ds                                        = GetObject<DataSet>(new IntPtr(p + 0x018), ReversePrism.DataModels.DataSet.FromPointer); // 0270D897B1E8 0x18 Ds                          ( 0001866809A0 ModelClassType DataSet DataSet DataSet Pointer )
            value.Dt                                        = GetObject<DataTable>(new IntPtr(p + 0x020), ReversePrism.DataModels.DataTable.FromPointer); // 0270D897B208 0x20 Dt                          ( 0001865B8050 ModelClassType DataTable DataTable DataTable Pointer )
            value.Xmlw                                      = GetObject<XmlWriter>(new IntPtr(p + 0x028), ReversePrism.DataModels.XmlWriter.FromPointer); // 0270D897B228 0x28 Xmlw                        ( 0001865D6E40 ModelClassType XmlWriter XmlWriter XmlWriter Pointer )
            value.FBefore                                   = GetBool(new IntPtr(p + 0x030)); // 0270D897B248 0x30 FBefore                     ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.FErrors                                   = GetBool(new IntPtr(p + 0x031)); // 0270D897B268 0x31 FErrors                     ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.RowsOrder                                 = GetObject<Hashtable>(new IntPtr(p + 0x038), ReversePrism.DataModels.Hashtable.FromPointer); // 0270D897B288 0x38 RowsOrder                   ( 0001865DE5A0 ModelClassType Hashtable Hashtable Hashtable Pointer )
            value.Tables                                    = GetObject<ArrayList>(new IntPtr(p + 0x040), ReversePrism.DataModels.ArrayList.FromPointer); // 0270D897B2A8 0x40 Tables                      ( 00018658A070 ModelClassType ArrayList ArrayList ArrayList Pointer )
            value.WriteHierarchy                            = GetBool(new IntPtr(p + 0x048)); // 0270D897B2C8 0x48 WriteHierarchy              ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
