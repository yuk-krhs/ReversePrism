using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Input                                    ModelClassType Input Input Input Pointer
    public partial class Variables : DataModel
    {
        public Input?                                   Input                                   { get; set; }

        public static Variables? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Variables() { Pointer= p0 };

            value.Input                                     = GetObject<Input>(new IntPtr(p + 0x010), ReversePrism.DataModels.Input.FromPointer); // 0x10 Input                       ( ModelClassType Input Input Input Pointer )

            return value;
        }
    }
}
