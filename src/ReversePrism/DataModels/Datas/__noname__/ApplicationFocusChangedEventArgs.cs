using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 HasFocus                                 000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class ApplicationFocusChangedEventArgs
    {
        public bool                                     HasFocus                                { get; set; }

        public static ApplicationFocusChangedEventArgs? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ApplicationFocusChangedEventArgs();

            value.HasFocus                                  = GetBool(new IntPtr(p + 0x010)); // 0270DBCEF588 0x10 HasFocus                    ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
