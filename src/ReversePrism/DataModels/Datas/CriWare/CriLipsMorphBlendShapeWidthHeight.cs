using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Target                                   000186514600 ModelClassType SkinnedMeshRenderer SkinnedMeshRenderer SkinnedMeshRenderer Pointer
    // 018 LipHeightIndex                           0001865F36C0 ModelPrimitiveType int int int Int32
    // 01C LipWidthOpenIndex                        0001865F36C0 ModelPrimitiveType int int int Int32
    // 020 LipWidthCloseIndex                       0001865F36C0 ModelPrimitiveType int int int Int32
    // 024 TongueUpIndex                            0001865F36C0 ModelPrimitiveType int int int Int32
    // 028 SilenceInfo                              0001866EBE00 ModelEnumType Info Info Info Int32
    public partial class CriLipsMorphBlendShapeWidthHeight
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
            var value   = new CriLipsMorphBlendShapeWidthHeight();

            value.Target                                    = GetObject<SkinnedMeshRenderer>(new IntPtr(p + 0x010), ReversePrism.DataModels.SkinnedMeshRenderer.FromPointer); // 0270DBBA7B00 0x10 Target                      ( 000186514600 ModelClassType SkinnedMeshRenderer SkinnedMeshRenderer SkinnedMeshRenderer Pointer )
            value.LipHeightIndex                            = GetInt32(new IntPtr(p + 0x018)); // 0270DBBA7B20 0x18 LipHeightIndex              ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.LipWidthOpenIndex                         = GetInt32(new IntPtr(p + 0x01C)); // 0270DBBA7B40 0x1C LipWidthOpenIndex           ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.LipWidthCloseIndex                        = GetInt32(new IntPtr(p + 0x020)); // 0270DBBA7B60 0x20 LipWidthCloseIndex          ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.TongueUpIndex                             = GetInt32(new IntPtr(p + 0x024)); // 0270DBBA7B80 0x24 TongueUpIndex               ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.SilenceInfo                               = (Info)GetInt32(new IntPtr(p + 0x028)); // 0270DBBA7BA0 0x28 SilenceInfo                 ( 0001866EBE00 ModelEnumType Info Info Info Int32 )

            return value;
        }
    }
}
