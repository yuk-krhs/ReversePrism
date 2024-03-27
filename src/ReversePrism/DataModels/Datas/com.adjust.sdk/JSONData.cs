using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Data                                   000186671910 ModelPrimitiveType string string string String
    public partial class JSONData
    {
        public string                                   M_Data                                  { get; set; }

        public static JSONData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new JSONData();

            value.M_Data                                    = GetString(new IntPtr(p + 0x010)); // 0270DBB0BEC0 0x10 M_Data                      ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
