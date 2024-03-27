using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Column                                   000186675CB0 ModelClassType DataColumn DataColumn DataColumn Pointer
    // 018 Error                                    000186671BA0 ModelPrimitiveType string string string String
    public partial class ColumnError
    {
        public DataColumn?                              Column                                  { get; set; }
        public string                                   Error                                   { get; set; }

        public static ColumnError? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ColumnError();

            value.Column                                    = GetObject<DataColumn>(new IntPtr(p + 0x010), ReversePrism.DataModels.DataColumn.FromPointer); // 0270D88BDC80 0x10 Column                      ( 000186675CB0 ModelClassType DataColumn DataColumn DataColumn Pointer )
            value.Error                                     = GetString(new IntPtr(p + 0x018)); // 0270D88BDCA0 0x18 Error                       ( 000186671BA0 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
