using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 IsFromTitle                              000186594D10 ModelPrimitiveType bool bool bool Bool
    // 011 IsFromOurStream                          000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class HomeArgument : DataModel
    {
        public bool                                     IsFromTitle                             { get; set; }
        public bool                                     IsFromOurStream                         { get; set; }

        public static HomeArgument? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new HomeArgument() { Pointer= p0 };

            value.IsFromTitle                               = GetBool(new IntPtr(p + 0x010)); // 0245A5B39B10 0x10 IsFromTitle                 ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsFromOurStream                           = GetBool(new IntPtr(p + 0x011)); // 0245A5B39B30 0x11 IsFromOurStream             ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
