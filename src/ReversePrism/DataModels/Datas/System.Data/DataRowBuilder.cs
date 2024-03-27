using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Table                                    0001865B87B0 ModelClassType DataTable DataTable DataTable Pointer
    // 018 Record                                   0001865F2F90 ModelPrimitiveType int int int Int32
    public partial class DataRowBuilder
    {
        public DataTable?                               Table                                   { get; set; }
        public int                                      Record                                  { get; set; }

        public static DataRowBuilder? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DataRowBuilder();

            value.Table                                     = GetObject<DataTable>(new IntPtr(p + 0x010), ReversePrism.DataModels.DataTable.FromPointer); // 0270D88D3140 0x10 Table                       ( 0001865B87B0 ModelClassType DataTable DataTable DataTable Pointer )
            value.Record                                    = GetInt32(new IntPtr(p + 0x018)); // 0270D88D3160 0x18 Record                      ( 0001865F2F90 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
