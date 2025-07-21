using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Target                                   ModelClassType Animator Animator Animator Pointer
    // 018 LipHeightStateHash                       ModelPrimitiveType int int int Int32
    // 01C LipWidthOpenStateHash                    ModelPrimitiveType int int int Int32
    // 020 LipWidthCloseStateHash                   ModelPrimitiveType int int int Int32
    // 024 TongueUpStateHash                        ModelPrimitiveType int int int Int32
    // 028 SilenceInfo                              ModelEnumType Info Info Info Int32
    public partial class CriLipsMorphAnimatorWidthHeight : DataModel
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
            var value   = new CriLipsMorphAnimatorWidthHeight() { Pointer= p0 };

            value.Target                                    = GetObject<Animator>(new IntPtr(p + 0x010), ReversePrism.DataModels.Animator.FromPointer); // 0x10 Target                      ( ModelClassType Animator Animator Animator Pointer )
            value.LipHeightStateHash                        = GetInt32(new IntPtr(p + 0x018)); // 0x18 LipHeightStateHash          ( ModelPrimitiveType int int int Int32 )
            value.LipWidthOpenStateHash                     = GetInt32(new IntPtr(p + 0x01C)); // 0x1C LipWidthOpenStateHash       ( ModelPrimitiveType int int int Int32 )
            value.LipWidthCloseStateHash                    = GetInt32(new IntPtr(p + 0x020)); // 0x20 LipWidthCloseStateHash      ( ModelPrimitiveType int int int Int32 )
            value.TongueUpStateHash                         = GetInt32(new IntPtr(p + 0x024)); // 0x24 TongueUpStateHash           ( ModelPrimitiveType int int int Int32 )
            value.SilenceInfo                               = (Info)GetInt32(new IntPtr(p + 0x028)); // 0x28 SilenceInfo                 ( ModelEnumType Info Info Info Int32 )

            return value;
        }
    }
}
