using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Name                                     000186671910 ModelPrimitiveType string string string String
    // 018 Version                                  000186671910 ModelPrimitiveType string string string String
    public partial class ProductHeaderValue
    {
        public string                                   Name                                    { get; set; }
        public string                                   Version                                 { get; set; }

        public static ProductHeaderValue? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProductHeaderValue();

            value.Name                                      = GetString(new IntPtr(p + 0x010)); // 0270DB8860C8 0x10 Name                        ( 000186671910 ModelPrimitiveType string string string String )
            value.Version                                   = GetString(new IntPtr(p + 0x018)); // 0270DB8860E8 0x18 Version                     ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
