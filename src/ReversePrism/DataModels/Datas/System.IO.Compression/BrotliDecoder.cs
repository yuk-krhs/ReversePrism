using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 State                                    0001866B7410 ModelClassType SafeBrotliDecoderHandle SafeBrotliDecoderHandle SafeBrotliDecoderHandle Pointer
    // 018 Disposed                                 000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class BrotliDecoder : DataModel
    {
        public SafeBrotliDecoderHandle?                 State                                   { get; set; }
        public bool                                     Disposed                                { get; set; }

        public static BrotliDecoder? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BrotliDecoder() { Pointer= p0 };

            value.State                                     = GetObject<SafeBrotliDecoderHandle>(new IntPtr(p + 0x010), ReversePrism.DataModels.SafeBrotliDecoderHandle.FromPointer); // 02466B058D98 0x10 State                       ( 0001866B7410 ModelClassType SafeBrotliDecoderHandle SafeBrotliDecoderHandle SafeBrotliDecoderHandle Pointer )
            value.Disposed                                  = GetBool(new IntPtr(p + 0x018)); // 02466B058DB8 0x18 Disposed                    ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
