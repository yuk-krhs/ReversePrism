using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Tongue                                   ModelPrimitiveType float float float Single
    // 014 A                                        ModelPrimitiveType float float float Single
    // 018 I                                        ModelPrimitiveType float float float Single
    // 01C U                                        ModelPrimitiveType float float float Single
    // 020 E                                        ModelPrimitiveType float float float Single
    // 024 O                                        ModelPrimitiveType float float float Single
    // 028 Db                                       ModelPrimitiveType float float float Single
    public partial class LipData : DataModel
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
            var value   = new LipData() { Pointer= p0 };

            value.Tongue                                    = GetSingle(new IntPtr(p + 0x010)); // 0x10 Tongue                      ( ModelPrimitiveType float float float Single )
            value.A                                         = GetSingle(new IntPtr(p + 0x014)); // 0x14 A                           ( ModelPrimitiveType float float float Single )
            value.I                                         = GetSingle(new IntPtr(p + 0x018)); // 0x18 I                           ( ModelPrimitiveType float float float Single )
            value.U                                         = GetSingle(new IntPtr(p + 0x01C)); // 0x1C U                           ( ModelPrimitiveType float float float Single )
            value.E                                         = GetSingle(new IntPtr(p + 0x020)); // 0x20 E                           ( ModelPrimitiveType float float float Single )
            value.O                                         = GetSingle(new IntPtr(p + 0x024)); // 0x24 O                           ( ModelPrimitiveType float float float Single )
            value.Db                                        = GetSingle(new IntPtr(p + 0x028)); // 0x28 Db                          ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
