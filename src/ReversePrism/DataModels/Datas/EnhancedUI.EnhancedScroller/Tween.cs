using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 TweenTimeLeft                            ModelPrimitiveType float float float Single
    public partial class Tween : DataModel
    {
        public float                                    TweenTimeLeft                           { get; set; }

        public static Tween? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Tween() { Pointer= p0 };

            value.TweenTimeLeft                             = GetSingle(new IntPtr(p + 0x020)); // 0x20 TweenTimeLeft               ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
