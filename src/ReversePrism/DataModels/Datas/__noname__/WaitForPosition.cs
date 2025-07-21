using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 T                                        ModelClassType Tween Tween Tween Pointer
    // 018 Position                                 ModelPrimitiveType float float float Single
    public partial class WaitForPosition : DataModel
    {
        public Tween?                                   T                                       { get; set; }
        public float                                    Position                                { get; set; }

        public static WaitForPosition? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new WaitForPosition() { Pointer= p0 };

            value.T                                         = GetObject<Tween>(new IntPtr(p + 0x010), ReversePrism.DataModels.Tween.FromPointer); // 0x10 T                           ( ModelClassType Tween Tween Tween Pointer )
            value.Position                                  = GetSingle(new IntPtr(p + 0x018)); // 0x18 Position                    ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
