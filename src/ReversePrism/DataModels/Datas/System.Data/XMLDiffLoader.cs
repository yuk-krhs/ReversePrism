using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Tables                                   ModelClassType ArrayList ArrayList ArrayList Pointer
    // 018 DataSet                                  ModelClassType DataSet DataSet DataSet Pointer
    // 020 DataTable                                ModelClassType DataTable DataTable DataTable Pointer
    public partial class XMLDiffLoader : DataModel
    {
        public ArrayList?                               Tables                                  { get; set; }
        public DataSet?                                 DataSet                                 { get; set; }
        public DataTable?                               DataTable                               { get; set; }

        public static XMLDiffLoader? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XMLDiffLoader() { Pointer= p0 };

            value.Tables                                    = GetObject<ArrayList>(new IntPtr(p + 0x010), ReversePrism.DataModels.ArrayList.FromPointer); // 0x10 Tables                      ( ModelClassType ArrayList ArrayList ArrayList Pointer )
            value.DataSet                                   = GetObject<DataSet>(new IntPtr(p + 0x018), ReversePrism.DataModels.DataSet.FromPointer); // 0x18 DataSet                     ( ModelClassType DataSet DataSet DataSet Pointer )
            value.DataTable                                 = GetObject<DataTable>(new IntPtr(p + 0x020), ReversePrism.DataModels.DataTable.FromPointer); // 0x20 DataTable                   ( ModelClassType DataTable DataTable DataTable Pointer )

            return value;
        }
    }
}
