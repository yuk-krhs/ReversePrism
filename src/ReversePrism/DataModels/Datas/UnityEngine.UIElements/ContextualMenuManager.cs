using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 DisplayMenuHandledOSX                    000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class ContextualMenuManager
    {
        public bool                                     DisplayMenuHandledOSX                   { get; set; }

        public static ContextualMenuManager? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ContextualMenuManager();

            value.DisplayMenuHandledOSX                     = GetBool(new IntPtr(p + 0x010)); // 0270066EE268 0x10 DisplayMenuHandledOSX       ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
