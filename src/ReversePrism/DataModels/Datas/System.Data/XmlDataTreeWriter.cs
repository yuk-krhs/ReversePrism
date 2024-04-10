using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Xmlw                                     0001865D6BE0 ModelClassType XmlWriter XmlWriter XmlWriter Pointer
    // 018 Ds                                       000186680790 ModelClassType DataSet DataSet DataSet Pointer
    // 020 Dt                                       0001865B7E00 ModelClassType DataTable DataTable DataTable Pointer
    // 028 DTables                                  00018658A070 ModelClassType ArrayList ArrayList ArrayList Pointer
    // 030 TopLevelTables                           000185B79420 ModelClassListType DataTable[] DataTable[] List<DataTable> Pointer
    // 038 FFromTable                               000186594D10 ModelPrimitiveType bool bool bool Bool
    // 039 IsDiffgram                               000186594D10 ModelPrimitiveType bool bool bool Bool
    // 040 RowsOrder                                0001865DE360 ModelClassType Hashtable Hashtable Hashtable Pointer
    // 048 WriteHierarchy                           000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class XmlDataTreeWriter : DataModel
    {
        public XmlWriter?                               Xmlw                                    { get; set; }
        public DataSet?                                 Ds                                      { get; set; }
        public DataTable?                               Dt                                      { get; set; }
        public ArrayList?                               DTables                                 { get; set; }
        public List<DataTable>?                         TopLevelTables                          { get; set; }
        public bool                                     FFromTable                              { get; set; }
        public bool                                     IsDiffgram                              { get; set; }
        public Hashtable?                               RowsOrder                               { get; set; }
        public bool                                     WriteHierarchy                          { get; set; }

        public static XmlDataTreeWriter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlDataTreeWriter() { Pointer= p0 };

            value.Xmlw                                      = GetObject<XmlWriter>(new IntPtr(p + 0x010), ReversePrism.DataModels.XmlWriter.FromPointer); // 0246689E6238 0x10 Xmlw                        ( 0001865D6BE0 ModelClassType XmlWriter XmlWriter XmlWriter Pointer )
            value.Ds                                        = GetObject<DataSet>(new IntPtr(p + 0x018), ReversePrism.DataModels.DataSet.FromPointer); // 0246689E6258 0x18 Ds                          ( 000186680790 ModelClassType DataSet DataSet DataSet Pointer )
            value.Dt                                        = GetObject<DataTable>(new IntPtr(p + 0x020), ReversePrism.DataModels.DataTable.FromPointer); // 0246689E6278 0x20 Dt                          ( 0001865B7E00 ModelClassType DataTable DataTable DataTable Pointer )
            value.DTables                                   = GetObject<ArrayList>(new IntPtr(p + 0x028), ReversePrism.DataModels.ArrayList.FromPointer); // 0246689E6298 0x28 DTables                     ( 00018658A070 ModelClassType ArrayList ArrayList ArrayList Pointer )
            value.TopLevelTables                            = GetObjectList<DataTable>(new IntPtr(p + 0x030), ReversePrism.DataModels.DataTable.FromPointer); // 0246689E62B8 0x30 TopLevelTables              ( 000185B79420 ModelClassListType DataTable[] DataTable[] List<DataTable> Pointer )
            value.FFromTable                                = GetBool(new IntPtr(p + 0x038)); // 0246689E62D8 0x38 FFromTable                  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsDiffgram                                = GetBool(new IntPtr(p + 0x039)); // 0246689E62F8 0x39 IsDiffgram                  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.RowsOrder                                 = GetObject<Hashtable>(new IntPtr(p + 0x040), ReversePrism.DataModels.Hashtable.FromPointer); // 0246689E6318 0x40 RowsOrder                   ( 0001865DE360 ModelClassType Hashtable Hashtable Hashtable Pointer )
            value.WriteHierarchy                            = GetBool(new IntPtr(p + 0x048)); // 0246689E6338 0x48 WriteHierarchy              ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
