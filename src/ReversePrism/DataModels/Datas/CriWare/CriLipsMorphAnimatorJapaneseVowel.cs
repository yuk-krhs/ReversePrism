using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Target                                   0001866B8DE0 ModelClassType Animator Animator Animator Pointer
    // 018 AStateHash                               0001865F36C0 ModelPrimitiveType int int int Int32
    // 01C IStateHash                               0001865F36C0 ModelPrimitiveType int int int Int32
    // 020 UStateHash                               0001865F36C0 ModelPrimitiveType int int int Int32
    // 024 EStateHash                               0001865F36C0 ModelPrimitiveType int int int Int32
    // 028 OStateHash                               0001865F36C0 ModelPrimitiveType int int int Int32
    // 02C SilenceInfo                              0001866EBE00 ModelEnumType Info Info Info Int32
    public partial class CriLipsMorphAnimatorJapaneseVowel : DataModel
    {
        public Animator?                                Target                                  { get; set; }
        public int                                      AStateHash                              { get; set; }
        public int                                      IStateHash                              { get; set; }
        public int                                      UStateHash                              { get; set; }
        public int                                      EStateHash                              { get; set; }
        public int                                      OStateHash                              { get; set; }
        public Info                                     SilenceInfo                             { get; set; }

        public static CriLipsMorphAnimatorJapaneseVowel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CriLipsMorphAnimatorJapaneseVowel() { Pointer= p0 };

            value.Target                                    = GetObject<Animator>(new IntPtr(p + 0x010), ReversePrism.DataModels.Animator.FromPointer); // 02466BC27AC8 0x10 Target                      ( 0001866B8DE0 ModelClassType Animator Animator Animator Pointer )
            value.AStateHash                                = GetInt32(new IntPtr(p + 0x018)); // 02466BC27AE8 0x18 AStateHash                  ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.IStateHash                                = GetInt32(new IntPtr(p + 0x01C)); // 02466BC27B08 0x1C IStateHash                  ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.UStateHash                                = GetInt32(new IntPtr(p + 0x020)); // 02466BC27B28 0x20 UStateHash                  ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.EStateHash                                = GetInt32(new IntPtr(p + 0x024)); // 02466BC27B48 0x24 EStateHash                  ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.OStateHash                                = GetInt32(new IntPtr(p + 0x028)); // 02466BC27B68 0x28 OStateHash                  ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.SilenceInfo                               = (Info)GetInt32(new IntPtr(p + 0x02C)); // 02466BC27B88 0x2C SilenceInfo                 ( 0001866EBE00 ModelEnumType Info Info Info Int32 )

            return value;
        }
    }
}
