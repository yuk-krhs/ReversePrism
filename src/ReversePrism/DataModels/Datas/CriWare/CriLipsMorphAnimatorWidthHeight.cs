using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Target                                   0001866B8DE0 ModelClassType Animator Animator Animator Pointer
    // 018 LipHeightStateHash                       0001865F36C0 ModelPrimitiveType int int int Int32
    // 01C LipWidthOpenStateHash                    0001865F36C0 ModelPrimitiveType int int int Int32
    // 020 LipWidthCloseStateHash                   0001865F36C0 ModelPrimitiveType int int int Int32
    // 024 TongueUpStateHash                        0001865F36C0 ModelPrimitiveType int int int Int32
    // 028 SilenceInfo                              0001866EBE00 ModelEnumType Info Info Info Int32
    public partial class CriLipsMorphAnimatorWidthHeight
    {
        public Animator?                                Target                                  { get; set; }
        public int                                      LipHeightStateHash                      { get; set; }
        public int                                      LipWidthOpenStateHash                   { get; set; }
        public int                                      LipWidthCloseStateHash                  { get; set; }
        public int                                      TongueUpStateHash                       { get; set; }
        public Info                                     SilenceInfo                             { get; set; }

        public static CriLipsMorphAnimatorWidthHeight? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CriLipsMorphAnimatorWidthHeight();

            value.Target                                    = GetObject<Animator>(new IntPtr(p + 0x010), ReversePrism.DataModels.Animator.FromPointer); // 0270DBBA70E8 0x10 Target                      ( 0001866B8DE0 ModelClassType Animator Animator Animator Pointer )
            value.LipHeightStateHash                        = GetInt32(new IntPtr(p + 0x018)); // 0270DBBA7108 0x18 LipHeightStateHash          ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.LipWidthOpenStateHash                     = GetInt32(new IntPtr(p + 0x01C)); // 0270DBBA7128 0x1C LipWidthOpenStateHash       ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.LipWidthCloseStateHash                    = GetInt32(new IntPtr(p + 0x020)); // 0270DBBA7148 0x20 LipWidthCloseStateHash      ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.TongueUpStateHash                         = GetInt32(new IntPtr(p + 0x024)); // 0270DBBA7168 0x24 TongueUpStateHash           ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.SilenceInfo                               = (Info)GetInt32(new IntPtr(p + 0x028)); // 0270DBBA7188 0x28 SilenceInfo                 ( 0001866EBE00 ModelEnumType Info Info Info Int32 )

            return value;
        }
    }
}
