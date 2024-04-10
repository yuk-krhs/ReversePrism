using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ContentType                              000186672F10 ModelPrimitiveType string string string String
    public partial class SetContentTypeHeaderDecorator : DataModel
    {
        public string                                   ContentType                             { get; set; }

        public static SetContentTypeHeaderDecorator? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SetContentTypeHeaderDecorator() { Pointer= p0 };

            value.ContentType                               = GetString(new IntPtr(p + 0x010)); // 02466BF34AA0 0x10 ContentType                 ( 000186672F10 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
