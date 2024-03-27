using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Left                                   0001866656B0 ModelPrimitiveType float float float Single
    // 014 M_Right                                  0001866656B0 ModelPrimitiveType float float float Single
    // 018 M_Top                                    0001866656B0 ModelPrimitiveType float float float Single
    // 01C M_Bottom                                 0001866656B0 ModelPrimitiveType float float float Single
    // 000 k_ZeroOffset                             TMP_Offset IL2CPP_TYPE_VALUETYPE
    public partial class TMP_Offset
    {
        public float                                    M_Left                                  { get; set; }
        public float                                    M_Right                                 { get; set; }
        public float                                    M_Top                                   { get; set; }
        public float                                    M_Bottom                                { get; set; }

        public static TMP_Offset? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TMP_Offset();

            value.M_Left                                    = GetSingle(new IntPtr(p + 0x010)); // 0270D0955418 0x10 M_Left                      ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.M_Right                                   = GetSingle(new IntPtr(p + 0x014)); // 0270D0955438 0x14 M_Right                     ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.M_Top                                     = GetSingle(new IntPtr(p + 0x018)); // 0270D0955458 0x18 M_Top                       ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.M_Bottom                                  = GetSingle(new IntPtr(p + 0x01C)); // 0270D0955478 0x1C M_Bottom                    ( 0001866656B0 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
