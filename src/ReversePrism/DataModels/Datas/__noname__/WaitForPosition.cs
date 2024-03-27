using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 T                                        0001866BF4B0 ModelClassType Tween Tween Tween Pointer
    // 018 Position                                 000186666CB0 ModelPrimitiveType float float float Single
    public partial class WaitForPosition
    {
        public Tween?                                   T                                       { get; set; }
        public float                                    Position                                { get; set; }

        public static WaitForPosition? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new WaitForPosition();

            value.T                                         = GetObject<Tween>(new IntPtr(p + 0x010), ReversePrism.DataModels.Tween.FromPointer); // 0270DBD467E8 0x10 T                           ( 0001866BF4B0 ModelClassType Tween Tween Tween Pointer )
            value.Position                                  = GetSingle(new IntPtr(p + 0x018)); // 0270DBD46808 0x18 Position                    ( 000186666CB0 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
