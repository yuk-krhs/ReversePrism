using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_AnimatedSprites                        000185CA4898 ModelClassListType Sprite[] Sprite[] List<Sprite> Pointer
    // 018 M_AnimationSpeed                         0001866656B0 ModelPrimitiveType float float float Single
    // 01C M_AnimationStartTime                     0001866656B0 ModelPrimitiveType float float float Single
    // 020 M_Flags                                  000186663CD0 ModelEnumType TileAnimationFlags TileAnimationFlags TileAnimationFlags Int32
    public partial class TileAnimationData : DataModel
    {
        public List<Sprite>?                            M_AnimatedSprites                       { get; set; }
        public float                                    M_AnimationSpeed                        { get; set; }
        public float                                    M_AnimationStartTime                    { get; set; }
        public TileAnimationFlags                       M_Flags                                 { get; set; }

        public static TileAnimationData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TileAnimationData() { Pointer= p0 };

            value.M_AnimatedSprites                         = GetObjectList<Sprite>(new IntPtr(p + 0x010), ReversePrism.DataModels.Sprite.FromPointer); // 0245A2217098 0x10 M_AnimatedSprites           ( 000185CA4898 ModelClassListType Sprite[] Sprite[] List<Sprite> Pointer )
            value.M_AnimationSpeed                          = GetSingle(new IntPtr(p + 0x018)); // 0245A22170B8 0x18 M_AnimationSpeed            ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.M_AnimationStartTime                      = GetSingle(new IntPtr(p + 0x01C)); // 0245A22170D8 0x1C M_AnimationStartTime        ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.M_Flags                                   = (TileAnimationFlags)GetInt32(new IntPtr(p + 0x020)); // 0245A22170F8 0x20 M_Flags                     ( 000186663CD0 ModelEnumType TileAnimationFlags TileAnimationFlags TileAnimationFlags Int32 )

            return value;
        }
    }
}
