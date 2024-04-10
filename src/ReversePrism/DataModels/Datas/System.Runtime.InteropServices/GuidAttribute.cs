using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Val                                      000186671BA0 ModelPrimitiveType string string string String
    public partial class GuidAttribute : DataModel
    {
        public string                                   Val                                     { get; set; }

        public static GuidAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GuidAttribute() { Pointer= p0 };

            value.Val                                       = GetString(new IntPtr(p + 0x010)); // 024666CF3010 0x10 Val                         ( 000186671BA0 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
