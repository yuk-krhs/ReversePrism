using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Target                                   ModelClassType Animator Animator Animator Pointer
    // 018 AStateHash                               ModelPrimitiveType int int int Int32
    // 01C IStateHash                               ModelPrimitiveType int int int Int32
    // 020 UStateHash                               ModelPrimitiveType int int int Int32
    // 024 EStateHash                               ModelPrimitiveType int int int Int32
    // 028 OStateHash                               ModelPrimitiveType int int int Int32
    // 02C SilenceInfo                              ModelEnumType Info Info Info Int32
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

            value.Target                                    = GetObject<Animator>(new IntPtr(p + 0x010), ReversePrism.DataModels.Animator.FromPointer); // 0x10 Target                      ( ModelClassType Animator Animator Animator Pointer )
            value.AStateHash                                = GetInt32(new IntPtr(p + 0x018)); // 0x18 AStateHash                  ( ModelPrimitiveType int int int Int32 )
            value.IStateHash                                = GetInt32(new IntPtr(p + 0x01C)); // 0x1C IStateHash                  ( ModelPrimitiveType int int int Int32 )
            value.UStateHash                                = GetInt32(new IntPtr(p + 0x020)); // 0x20 UStateHash                  ( ModelPrimitiveType int int int Int32 )
            value.EStateHash                                = GetInt32(new IntPtr(p + 0x024)); // 0x24 EStateHash                  ( ModelPrimitiveType int int int Int32 )
            value.OStateHash                                = GetInt32(new IntPtr(p + 0x028)); // 0x28 OStateHash                  ( ModelPrimitiveType int int int Int32 )
            value.SilenceInfo                               = (Info)GetInt32(new IntPtr(p + 0x02C)); // 0x2C SilenceInfo                 ( ModelEnumType Info Info Info Int32 )

            return value;
        }
    }
}
