using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Xmlw                                     ModelClassType XmlWriter XmlWriter XmlWriter Pointer
    // 018 Ds                                       ModelClassType DataSet DataSet DataSet Pointer
    // 020 Dt                                       ModelClassType DataTable DataTable DataTable Pointer
    // 028 DTables                                  ModelClassType ArrayList ArrayList ArrayList Pointer
    // 030 TopLevelTables                           ModelClassListType DataTable[] DataTable[] List<DataTable> Pointer
    // 038 FFromTable                               ModelPrimitiveType bool bool bool Bool
    // 039 IsDiffgram                               ModelPrimitiveType bool bool bool Bool
    // 040 RowsOrder                                ModelClassType Hashtable Hashtable Hashtable Pointer
    // 048 WriteHierarchy                           ModelPrimitiveType bool bool bool Bool
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

            value.Xmlw                                      = GetObject<XmlWriter>(new IntPtr(p + 0x010), ReversePrism.DataModels.XmlWriter.FromPointer); // 0x10 Xmlw                        ( ModelClassType XmlWriter XmlWriter XmlWriter Pointer )
            value.Ds                                        = GetObject<DataSet>(new IntPtr(p + 0x018), ReversePrism.DataModels.DataSet.FromPointer); // 0x18 Ds                          ( ModelClassType DataSet DataSet DataSet Pointer )
            value.Dt                                        = GetObject<DataTable>(new IntPtr(p + 0x020), ReversePrism.DataModels.DataTable.FromPointer); // 0x20 Dt                          ( ModelClassType DataTable DataTable DataTable Pointer )
            value.DTables                                   = GetObject<ArrayList>(new IntPtr(p + 0x028), ReversePrism.DataModels.ArrayList.FromPointer); // 0x28 DTables                     ( ModelClassType ArrayList ArrayList ArrayList Pointer )
            value.TopLevelTables                            = GetObjectList<DataTable>(new IntPtr(p + 0x030), ReversePrism.DataModels.DataTable.FromPointer); // 0x30 TopLevelTables              ( ModelClassListType DataTable[] DataTable[] List<DataTable> Pointer )
            value.FFromTable                                = GetBool(new IntPtr(p + 0x038)); // 0x38 FFromTable                  ( ModelPrimitiveType bool bool bool Bool )
            value.IsDiffgram                                = GetBool(new IntPtr(p + 0x039)); // 0x39 IsDiffgram                  ( ModelPrimitiveType bool bool bool Bool )
            value.RowsOrder                                 = GetObject<Hashtable>(new IntPtr(p + 0x040), ReversePrism.DataModels.Hashtable.FromPointer); // 0x40 RowsOrder                   ( ModelClassType Hashtable Hashtable Hashtable Pointer )
            value.WriteHierarchy                            = GetBool(new IntPtr(p + 0x048)); // 0x48 WriteHierarchy              ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
