using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Tongue                                   000186666050 ModelPrimitiveType float float float Single
    // 014 A                                        000186666050 ModelPrimitiveType float float float Single
    // 018 I                                        000186666050 ModelPrimitiveType float float float Single
    // 01C U                                        000186666050 ModelPrimitiveType float float float Single
    // 020 E                                        000186666050 ModelPrimitiveType float float float Single
    // 024 O                                        000186666050 ModelPrimitiveType float float float Single
    // 028 Db                                       000186666050 ModelPrimitiveType float float float Single
    public partial class LipData
    {
        public float                                    Tongue                                  { get; set; }
        public float                                    A                                       { get; set; }
        public float                                    I                                       { get; set; }
        public float                                    U                                       { get; set; }
        public float                                    E                                       { get; set; }
        public float                                    O                                       { get; set; }
        public float                                    Db                                      { get; set; }

        public static LipData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LipData();

            value.Tongue                                    = GetSingle(new IntPtr(p + 0x010)); // 0270D4DFB080 0x10 Tongue                      ( 000186666050 ModelPrimitiveType float float float Single )
            value.A                                         = GetSingle(new IntPtr(p + 0x014)); // 0270D4DFB0A0 0x14 A                           ( 000186666050 ModelPrimitiveType float float float Single )
            value.I                                         = GetSingle(new IntPtr(p + 0x018)); // 0270D4DFB0C0 0x18 I                           ( 000186666050 ModelPrimitiveType float float float Single )
            value.U                                         = GetSingle(new IntPtr(p + 0x01C)); // 0270D4DFB0E0 0x1C U                           ( 000186666050 ModelPrimitiveType float float float Single )
            value.E                                         = GetSingle(new IntPtr(p + 0x020)); // 0270D4DFB100 0x20 E                           ( 000186666050 ModelPrimitiveType float float float Single )
            value.O                                         = GetSingle(new IntPtr(p + 0x024)); // 0270D4DFB120 0x24 O                           ( 000186666050 ModelPrimitiveType float float float Single )
            value.Db                                        = GetSingle(new IntPtr(p + 0x028)); // 0270D4DFB140 0x28 Db                          ( 000186666050 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
