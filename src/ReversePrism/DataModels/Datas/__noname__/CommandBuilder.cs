using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Builder                                  000186676650 ModelClassType StringBuilder StringBuilder StringBuilder Pointer
    // 018 HasArgs                                  000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class CommandBuilder
    {
        public StringBuilder?                           Builder                                 { get; set; }
        public bool                                     HasArgs                                 { get; set; }

        public static CommandBuilder? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CommandBuilder();

            value.Builder                                   = GetObject<StringBuilder>(new IntPtr(p + 0x010), ReversePrism.DataModels.StringBuilder.FromPointer); // 0270DA8A6A58 0x10 Builder                     ( 000186676650 ModelClassType StringBuilder StringBuilder StringBuilder Pointer )
            value.HasArgs                                   = GetBool(new IntPtr(p + 0x018)); // 0270DA8A6A78 0x18 HasArgs                     ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
