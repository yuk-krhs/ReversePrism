using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 M_encoding                               00018672D9E0 ModelClassType Encoding Encoding Encoding Pointer
    // 028 M_hasInitializedEncoding                 0001865974C0 ModelPrimitiveType bool bool bool Bool
    public partial class DefaultDecoder
    {
        public Encoding?                                M_encoding                              { get; set; }
        public bool                                     M_hasInitializedEncoding                { get; set; }

        public static DefaultDecoder? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DefaultDecoder();

            value.M_encoding                                = GetObject<Encoding>(new IntPtr(p + 0x020), ReversePrism.DataModels.Encoding.FromPointer); // 0270D6B66290 0x20 M_encoding                  ( 00018672D9E0 ModelClassType Encoding Encoding Encoding Pointer )
            value.M_hasInitializedEncoding                  = GetBool(new IntPtr(p + 0x028)); // 0270D6B662B0 0x28 M_hasInitializedEncoding    ( 0001865974C0 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
