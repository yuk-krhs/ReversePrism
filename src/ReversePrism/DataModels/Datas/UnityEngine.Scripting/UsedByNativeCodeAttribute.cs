using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Name                                     000186671910 ModelPrimitiveType string string string String
    public partial class UsedByNativeCodeAttribute
    {
        public string                                   Name                                    { get; set; }

        public static UsedByNativeCodeAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UsedByNativeCodeAttribute();

            value.Name                                      = GetString(new IntPtr(p + 0x010)); // 027006979BC8 0x10 Name                        ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
