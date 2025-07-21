using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Data                                     ModelClassType ByteString ByteString ByteString Pointer
    public partial class ByteStringDebugView : DataModel
    {
        public ByteString?                              Data                                    { get; set; }

        public static ByteStringDebugView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ByteStringDebugView() { Pointer= p0 };

            value.Data                                      = GetObject<ByteString>(new IntPtr(p + 0x010), ReversePrism.DataModels.ByteString.FromPointer); // 0x10 Data                        ( ModelClassType ByteString ByteString ByteString Pointer )

            return value;
        }
    }
}
