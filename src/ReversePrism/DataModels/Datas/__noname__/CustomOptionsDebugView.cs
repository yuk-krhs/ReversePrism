using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CustomOptions                            ModelClassType CustomOptions CustomOptions CustomOptions Pointer
    public partial class CustomOptionsDebugView : DataModel
    {
        public CustomOptions?                           CustomOptions                           { get; set; }

        public static CustomOptionsDebugView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CustomOptionsDebugView() { Pointer= p0 };

            value.CustomOptions                             = GetObject<CustomOptions>(new IntPtr(p + 0x010), ReversePrism.DataModels.CustomOptions.FromPointer); // 0x10 CustomOptions               ( ModelClassType CustomOptions CustomOptions CustomOptions Pointer )

            return value;
        }
    }
}
