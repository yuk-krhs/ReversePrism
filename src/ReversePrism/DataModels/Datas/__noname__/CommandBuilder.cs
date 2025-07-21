using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Builder                                  ModelClassType StringBuilder StringBuilder StringBuilder Pointer
    // 018 HasArgs                                  ModelPrimitiveType bool bool bool Bool
    public partial class CommandBuilder : DataModel
    {
        public StringBuilder?                           Builder                                 { get; set; }
        public bool                                     HasArgs                                 { get; set; }

        public static CommandBuilder? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CommandBuilder() { Pointer= p0 };

            value.Builder                                   = GetObject<StringBuilder>(new IntPtr(p + 0x010), ReversePrism.DataModels.StringBuilder.FromPointer); // 0x10 Builder                     ( ModelClassType StringBuilder StringBuilder StringBuilder Pointer )
            value.HasArgs                                   = GetBool(new IntPtr(p + 0x018)); // 0x18 HasArgs                     ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
