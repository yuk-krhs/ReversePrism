using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 DisplayMenuHandledOSX                    000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class ContextualMenuManager : DataModel
    {
        public bool                                     DisplayMenuHandledOSX                   { get; set; }

        public static ContextualMenuManager? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ContextualMenuManager() { Pointer= p0 };

            value.DisplayMenuHandledOSX                     = GetBool(new IntPtr(p + 0x010)); // 0245A66B11F0 0x10 DisplayMenuHandledOSX       ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
