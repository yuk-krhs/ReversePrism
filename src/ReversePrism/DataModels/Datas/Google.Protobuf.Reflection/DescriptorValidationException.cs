using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 090 Name                                     000186672F10 ModelPrimitiveType string string string String
    // 098 Description                              000186672F10 ModelPrimitiveType string string string String
    public partial class DescriptorValidationException
    {
        public string                                   Name                                    { get; set; }
        public string                                   Description                             { get; set; }

        public static DescriptorValidationException? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DescriptorValidationException();

            value.Name                                      = GetString(new IntPtr(p + 0x090)); // 0270DA580E80 0x90 Name                        ( 000186672F10 ModelPrimitiveType string string string String )
            value.Description                               = GetString(new IntPtr(p + 0x098)); // 0270DA580EA0 0x98 Description                 ( 000186672F10 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
