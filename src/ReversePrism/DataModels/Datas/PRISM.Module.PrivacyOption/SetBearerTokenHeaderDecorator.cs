using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Token                                    000186672F10 ModelPrimitiveType string string string String
    public partial class SetBearerTokenHeaderDecorator : DataModel
    {
        public string                                   Token                                   { get; set; }

        public static SetBearerTokenHeaderDecorator? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SetBearerTokenHeaderDecorator() { Pointer= p0 };

            value.Token                                     = GetString(new IntPtr(p + 0x010)); // 0245A4E4E860 0x10 Token                       ( 000186672F10 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
