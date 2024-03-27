using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Target                                   000186514600 ModelClassType SkinnedMeshRenderer SkinnedMeshRenderer SkinnedMeshRenderer Pointer
    // 018 AIndex                                   0001865F36C0 ModelPrimitiveType int int int Int32
    // 01C IIndex                                   0001865F36C0 ModelPrimitiveType int int int Int32
    // 020 UIndex                                   0001865F36C0 ModelPrimitiveType int int int Int32
    // 024 EIndex                                   0001865F36C0 ModelPrimitiveType int int int Int32
    // 028 OIndex                                   0001865F36C0 ModelPrimitiveType int int int Int32
    // 02C SilenceInfo                              0001866EBE00 ModelEnumType Info Info Info Int32
    public partial class CriLipsMorphBlendShapeJapaneseVowel
    {
        public SkinnedMeshRenderer?                     Target                                  { get; set; }
        public int                                      AIndex                                  { get; set; }
        public int                                      IIndex                                  { get; set; }
        public int                                      UIndex                                  { get; set; }
        public int                                      EIndex                                  { get; set; }
        public int                                      OIndex                                  { get; set; }
        public Info                                     SilenceInfo                             { get; set; }

        public static CriLipsMorphBlendShapeJapaneseVowel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CriLipsMorphBlendShapeJapaneseVowel();

            value.Target                                    = GetObject<SkinnedMeshRenderer>(new IntPtr(p + 0x010), ReversePrism.DataModels.SkinnedMeshRenderer.FromPointer); // 0270DBBA7FC0 0x10 Target                      ( 000186514600 ModelClassType SkinnedMeshRenderer SkinnedMeshRenderer SkinnedMeshRenderer Pointer )
            value.AIndex                                    = GetInt32(new IntPtr(p + 0x018)); // 0270DBBA7FE0 0x18 AIndex                      ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.IIndex                                    = GetInt32(new IntPtr(p + 0x01C)); // 0270DBBA8000 0x1C IIndex                      ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.UIndex                                    = GetInt32(new IntPtr(p + 0x020)); // 0270DBBA8020 0x20 UIndex                      ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.EIndex                                    = GetInt32(new IntPtr(p + 0x024)); // 0270DBBA8040 0x24 EIndex                      ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.OIndex                                    = GetInt32(new IntPtr(p + 0x028)); // 0270DBBA8060 0x28 OIndex                      ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.SilenceInfo                               = (Info)GetInt32(new IntPtr(p + 0x02C)); // 0270DBBA8080 0x2C SilenceInfo                 ( 0001866EBE00 ModelEnumType Info Info Info Int32 )

            return value;
        }
    }
}
