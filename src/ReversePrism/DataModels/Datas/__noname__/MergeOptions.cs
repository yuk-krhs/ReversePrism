using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ReplaceMessageFields                     000186594D10 ModelPrimitiveType bool bool bool Bool
    // 011 ReplaceRepeatedFields                    000186594D10 ModelPrimitiveType bool bool bool Bool
    // 012 ReplacePrimitiveFields                   000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class MergeOptions : DataModel
    {
        public bool                                     ReplaceMessageFields                    { get; set; }
        public bool                                     ReplaceRepeatedFields                   { get; set; }
        public bool                                     ReplacePrimitiveFields                  { get; set; }

        public static MergeOptions? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MergeOptions() { Pointer= p0 };

            value.ReplaceMessageFields                      = GetBool(new IntPtr(p + 0x010)); // 02466A45D428 0x10 ReplaceMessageFields        ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.ReplaceRepeatedFields                     = GetBool(new IntPtr(p + 0x011)); // 02466A45D448 0x11 ReplaceRepeatedFields       ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.ReplacePrimitiveFields                    = GetBool(new IntPtr(p + 0x012)); // 02466A45D468 0x12 ReplacePrimitiveFields      ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
