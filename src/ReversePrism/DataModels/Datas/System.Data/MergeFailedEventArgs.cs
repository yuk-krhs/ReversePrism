using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Table                                    0001865B8520 ModelClassType DataTable DataTable DataTable Pointer
    // 018 Conflict                                 000186672F10 ModelPrimitiveType string string string String
    public partial class MergeFailedEventArgs : DataModel
    {
        public DataTable?                               Table                                   { get; set; }
        public string                                   Conflict                                { get; set; }

        public static MergeFailedEventArgs? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MergeFailedEventArgs() { Pointer= p0 };

            value.Table                                     = GetObject<DataTable>(new IntPtr(p + 0x010), ReversePrism.DataModels.DataTable.FromPointer); // 024668958B48 0x10 Table                       ( 0001865B8520 ModelClassType DataTable DataTable DataTable Pointer )
            value.Conflict                                  = GetString(new IntPtr(p + 0x018)); // 024668958B68 0x18 Conflict                    ( 000186672F10 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
