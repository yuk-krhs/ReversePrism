using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Name                                     000186672F10 ModelPrimitiveType string string string String
    // 000 Default                                  DefaultPropertyAttribute IL2CPP_TYPE_CLASS
    public partial class DefaultPropertyAttribute
    {
        public string                                   Name                                    { get; set; }

        public static DefaultPropertyAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DefaultPropertyAttribute();

            value.Name                                      = GetString(new IntPtr(p + 0x010)); // 0270D7B1B6D0 0x10 Name                        ( 000186672F10 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
