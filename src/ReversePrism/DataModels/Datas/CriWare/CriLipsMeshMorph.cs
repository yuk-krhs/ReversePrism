using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 MorphingTargetType                       000186561440 ModelEnumType MorphingTargetType MorphingTargetType MorphingTargetType Int32
    // 018 SkinnedMeshRenderer                      000186514880 ModelClassType SkinnedMeshRenderer SkinnedMeshRenderer SkinnedMeshRenderer Pointer
    // 020 Animator                                 0001866B92A0 ModelClassType Animator Animator Animator Pointer
    // 028 NameMappingGetBlendShapeIndexs           000185B7D2C0 ModelPrimitiveListType int[] int[] List<int> Pointer
    // 030 SilenceWidthPosition                     0001866656B0 ModelPrimitiveType float float float Single
    public partial class CriLipsMeshMorph
    {
        public MorphingTargetType                       MorphingTargetType                      { get; set; }
        public SkinnedMeshRenderer?                     SkinnedMeshRenderer                     { get; set; }
        public Animator?                                Animator                                { get; set; }
        public List<int>?                               NameMappingGetBlendShapeIndexs          { get; set; }
        public float                                    SilenceWidthPosition                    { get; set; }

        public static CriLipsMeshMorph? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CriLipsMeshMorph();

            value.MorphingTargetType                        = (MorphingTargetType)GetInt32(new IntPtr(p + 0x010)); // 0270DBBA6C40 0x10 MorphingTargetType          ( 000186561440 ModelEnumType MorphingTargetType MorphingTargetType MorphingTargetType Int32 )
            value.SkinnedMeshRenderer                       = GetObject<SkinnedMeshRenderer>(new IntPtr(p + 0x018), ReversePrism.DataModels.SkinnedMeshRenderer.FromPointer); // 0270DBBA6C60 0x18 SkinnedMeshRenderer         ( 000186514880 ModelClassType SkinnedMeshRenderer SkinnedMeshRenderer SkinnedMeshRenderer Pointer )
            value.Animator                                  = GetObject<Animator>(new IntPtr(p + 0x020), ReversePrism.DataModels.Animator.FromPointer); // 0270DBBA6C80 0x20 Animator                    ( 0001866B92A0 ModelClassType Animator Animator Animator Pointer )
            value.NameMappingGetBlendShapeIndexs            = GetInt32List(new IntPtr(p + 0x028)); // 0270DBBA6CA0 0x28 NameMappingGetBlendShapeIndexs ( 000185B7D2C0 ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.SilenceWidthPosition                      = GetSingle(new IntPtr(p + 0x030)); // 0270DBBA6CC0 0x30 SilenceWidthPosition        ( 0001866656B0 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
