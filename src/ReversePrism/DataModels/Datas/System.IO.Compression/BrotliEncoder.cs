using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 State                                    0001866B78D0 ModelClassType SafeBrotliEncoderHandle SafeBrotliEncoderHandle SafeBrotliEncoderHandle Pointer
    // 018 Disposed                                 000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class BrotliEncoder : DataModel
    {
        public SafeBrotliEncoderHandle?                 State                                   { get; set; }
        public bool                                     Disposed                                { get; set; }

        public static BrotliEncoder? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BrotliEncoder() { Pointer= p0 };

            value.State                                     = GetObject<SafeBrotliEncoderHandle>(new IntPtr(p + 0x010), ReversePrism.DataModels.SafeBrotliEncoderHandle.FromPointer); // 02466B057B58 0x10 State                       ( 0001866B78D0 ModelClassType SafeBrotliEncoderHandle SafeBrotliEncoderHandle SafeBrotliEncoderHandle Pointer )
            value.Disposed                                  = GetBool(new IntPtr(p + 0x018)); // 02466B057B78 0x18 Disposed                    ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
