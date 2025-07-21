using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 T                                        ModelClassType Tween Tween Tween Pointer
    public partial class WaitForStart : DataModel
    {
        public Tween?                                   T                                       { get; set; }

        public static WaitForStart? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new WaitForStart() { Pointer= p0 };

            value.T                                         = GetObject<Tween>(new IntPtr(p + 0x010), ReversePrism.DataModels.Tween.FromPointer); // 0x10 T                           ( ModelClassType Tween Tween Tween Pointer )

            return value;
        }
    }
}
