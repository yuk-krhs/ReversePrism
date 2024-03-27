using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 A                                        000186666050 ModelPrimitiveType float float float Single
    // 014 I                                        000186666050 ModelPrimitiveType float float float Single
    // 018 U                                        000186666050 ModelPrimitiveType float float float Single
    // 01C E                                        000186666050 ModelPrimitiveType float float float Single
    // 020 O                                        000186666050 ModelPrimitiveType float float float Single
    public partial class MorphTargetBlendAmountAsJapanese
    {
        public float                                    A                                       { get; set; }
        public float                                    I                                       { get; set; }
        public float                                    U                                       { get; set; }
        public float                                    E                                       { get; set; }
        public float                                    O                                       { get; set; }

        public static MorphTargetBlendAmountAsJapanese? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MorphTargetBlendAmountAsJapanese();

            value.A                                         = GetSingle(new IntPtr(p + 0x010)); // 0270DBBA4F70 0x10 A                           ( 000186666050 ModelPrimitiveType float float float Single )
            value.I                                         = GetSingle(new IntPtr(p + 0x014)); // 0270DBBA4F90 0x14 I                           ( 000186666050 ModelPrimitiveType float float float Single )
            value.U                                         = GetSingle(new IntPtr(p + 0x018)); // 0270DBBA4FB0 0x18 U                           ( 000186666050 ModelPrimitiveType float float float Single )
            value.E                                         = GetSingle(new IntPtr(p + 0x01C)); // 0270DBBA4FD0 0x1C E                           ( 000186666050 ModelPrimitiveType float float float Single )
            value.O                                         = GetSingle(new IntPtr(p + 0x020)); // 0270DBBA4FF0 0x20 O                           ( 000186666050 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
