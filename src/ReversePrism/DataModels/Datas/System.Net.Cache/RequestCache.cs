using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 LineSplits                               char[] IL2CPP_TYPE_SZARRAY
    // 010 IsPrivateCache                           ModelPrimitiveType bool bool bool Bool
    // 011 CanWrite                                 ModelPrimitiveType bool bool bool Bool
    public partial class RequestCache : DataModel
    {
        public bool                                     IsPrivateCache                          { get; set; }
        public bool                                     CanWrite                                { get; set; }

        public static RequestCache? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RequestCache() { Pointer= p0 };

            value.IsPrivateCache                            = GetBool(new IntPtr(p + 0x010)); // 0x10 IsPrivateCache              ( ModelPrimitiveType bool bool bool Bool )
            value.CanWrite                                  = GetBool(new IntPtr(p + 0x011)); // 0x11 CanWrite                    ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
