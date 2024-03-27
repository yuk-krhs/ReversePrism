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
    public partial class MergeOptions
    {
        public bool                                     ReplaceMessageFields                    { get; set; }
        public bool                                     ReplaceRepeatedFields                   { get; set; }
        public bool                                     ReplacePrimitiveFields                  { get; set; }

        public static MergeOptions? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MergeOptions();

            value.ReplaceMessageFields                      = GetBool(new IntPtr(p + 0x010)); // 0270DA3F9BB0 0x10 ReplaceMessageFields        ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.ReplaceRepeatedFields                     = GetBool(new IntPtr(p + 0x011)); // 0270DA3F9BD0 0x11 ReplaceRepeatedFields       ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.ReplacePrimitiveFields                    = GetBool(new IntPtr(p + 0x012)); // 0270DA3F9BF0 0x12 ReplacePrimitiveFields      ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
