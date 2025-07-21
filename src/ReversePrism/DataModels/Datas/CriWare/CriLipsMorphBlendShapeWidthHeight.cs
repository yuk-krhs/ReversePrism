using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Target                                   ModelClassType SkinnedMeshRenderer SkinnedMeshRenderer SkinnedMeshRenderer Pointer
    // 018 LipHeightIndex                           ModelPrimitiveType int int int Int32
    // 01C LipWidthOpenIndex                        ModelPrimitiveType int int int Int32
    // 020 LipWidthCloseIndex                       ModelPrimitiveType int int int Int32
    // 024 TongueUpIndex                            ModelPrimitiveType int int int Int32
    // 028 SilenceInfo                              ModelEnumType Info Info Info Int32
    public partial class CriLipsMorphBlendShapeWidthHeight : DataModel
    {
        public SkinnedMeshRenderer?                     Target                                  { get; set; }
        public int                                      LipHeightIndex                          { get; set; }
        public int                                      LipWidthOpenIndex                       { get; set; }
        public int                                      LipWidthCloseIndex                      { get; set; }
        public int                                      TongueUpIndex                           { get; set; }
        public Info                                     SilenceInfo                             { get; set; }

        public static CriLipsMorphBlendShapeWidthHeight? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CriLipsMorphBlendShapeWidthHeight() { Pointer= p0 };

            value.Target                                    = GetObject<SkinnedMeshRenderer>(new IntPtr(p + 0x010), ReversePrism.DataModels.SkinnedMeshRenderer.FromPointer); // 0x10 Target                      ( ModelClassType SkinnedMeshRenderer SkinnedMeshRenderer SkinnedMeshRenderer Pointer )
            value.LipHeightIndex                            = GetInt32(new IntPtr(p + 0x018)); // 0x18 LipHeightIndex              ( ModelPrimitiveType int int int Int32 )
            value.LipWidthOpenIndex                         = GetInt32(new IntPtr(p + 0x01C)); // 0x1C LipWidthOpenIndex           ( ModelPrimitiveType int int int Int32 )
            value.LipWidthCloseIndex                        = GetInt32(new IntPtr(p + 0x020)); // 0x20 LipWidthCloseIndex          ( ModelPrimitiveType int int int Int32 )
            value.TongueUpIndex                             = GetInt32(new IntPtr(p + 0x024)); // 0x24 TongueUpIndex               ( ModelPrimitiveType int int int Int32 )
            value.SilenceInfo                               = (Info)GetInt32(new IntPtr(p + 0x028)); // 0x28 SilenceInfo                 ( ModelEnumType Info Info Info Int32 )

            return value;
        }
    }
}
