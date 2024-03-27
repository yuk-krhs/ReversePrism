using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 030 UserModifyDelegate                       000186561BE0 ModelClassType UserModifyDelegateFunction UserModifyDelegateFunction UserModifyDelegateFunction Pointer
    // 038 MorphingTargetType                       000186561440 ModelEnumType MorphingTargetType MorphingTargetType MorphingTargetType Int32
    // 03C BlendShapeType                           000186560C80 ModelEnumType BlendShapeType BlendShapeType BlendShapeType Int32
    // 040 SkinnedMeshRenderer                      000186514880 ModelClassType SkinnedMeshRenderer SkinnedMeshRenderer SkinnedMeshRenderer Pointer
    // 048 NameMapping                              0001866EAF80 ModelEnumType BlendShapeNameMapping BlendShapeNameMapping BlendShapeNameMapping Int32
    // 090 Animator                                 0001866B92A0 ModelClassType Animator Animator Animator Pointer
    // 098 AnimationStateNameMapping                0001866EAF80 ModelEnumType BlendShapeNameMapping BlendShapeNameMapping BlendShapeNameMapping Int32
    // 0E0 MeshMorphing                             000186655D40 ModelClassType CriLipsMeshMorph CriLipsMeshMorph CriLipsMeshMorph Pointer
    // 0E8 Info                                     0001866EC0D0 ModelEnumType Info Info Info Int32
    // 0F8 BlendAmount                              0001866ECA70 ModelEnumType MorphTargetBlendAmountAsJapanese MorphTargetBlendAmountAsJapanese MorphTargetBlendAmountAsJapanese Int32
    // 110 AnalyzeModule                            000186746040 ModelClassType ICriLipsAnalyzeModule ICriLipsAnalyzeModule ICriLipsAnalyzeModule Pointer
    public partial class CriLipsShape
    {
        public UserModifyDelegateFunction?              UserModifyDelegate                      { get; set; }
        public MorphingTargetType                       MorphingTargetType                      { get; set; }
        public BlendShapeType                           BlendShapeType                          { get; set; }
        public SkinnedMeshRenderer?                     SkinnedMeshRenderer                     { get; set; }
        public BlendShapeNameMapping                    NameMapping                             { get; set; }
        public Animator?                                Animator                                { get; set; }
        public BlendShapeNameMapping                    AnimationStateNameMapping               { get; set; }
        public CriLipsMeshMorph?                        MeshMorphing                            { get; set; }
        public Info                                     Info                                    { get; set; }
        public MorphTargetBlendAmountAsJapanese         BlendAmount                             { get; set; }
        public ICriLipsAnalyzeModule?                   AnalyzeModule                           { get; set; }

        public static CriLipsShape? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CriLipsShape();

            value.UserModifyDelegate                        = GetObject<UserModifyDelegateFunction>(new IntPtr(p + 0x030), ReversePrism.DataModels.UserModifyDelegateFunction.FromPointer); // 0270DBBA6EA0 0x30 UserModifyDelegate          ( 000186561BE0 ModelClassType UserModifyDelegateFunction UserModifyDelegateFunction UserModifyDelegateFunction Pointer )
            value.MorphingTargetType                        = (MorphingTargetType)GetInt32(new IntPtr(p + 0x038)); // 0270DBBA6EC0 0x38 MorphingTargetType          ( 000186561440 ModelEnumType MorphingTargetType MorphingTargetType MorphingTargetType Int32 )
            value.BlendShapeType                            = (BlendShapeType)GetInt32(new IntPtr(p + 0x03C)); // 0270DBBA6EE0 0x3C BlendShapeType              ( 000186560C80 ModelEnumType BlendShapeType BlendShapeType BlendShapeType Int32 )
            value.SkinnedMeshRenderer                       = GetObject<SkinnedMeshRenderer>(new IntPtr(p + 0x040), ReversePrism.DataModels.SkinnedMeshRenderer.FromPointer); // 0270DBBA6F00 0x40 SkinnedMeshRenderer         ( 000186514880 ModelClassType SkinnedMeshRenderer SkinnedMeshRenderer SkinnedMeshRenderer Pointer )
            value.NameMapping                               = (BlendShapeNameMapping)GetInt32(new IntPtr(p + 0x048)); // 0270DBBA6F20 0x48 NameMapping                 ( 0001866EAF80 ModelEnumType BlendShapeNameMapping BlendShapeNameMapping BlendShapeNameMapping Int32 )
            value.Animator                                  = GetObject<Animator>(new IntPtr(p + 0x090), ReversePrism.DataModels.Animator.FromPointer); // 0270DBBA6F40 0x90 Animator                    ( 0001866B92A0 ModelClassType Animator Animator Animator Pointer )
            value.AnimationStateNameMapping                 = (BlendShapeNameMapping)GetInt32(new IntPtr(p + 0x098)); // 0270DBBA6F60 0x98 AnimationStateNameMapping   ( 0001866EAF80 ModelEnumType BlendShapeNameMapping BlendShapeNameMapping BlendShapeNameMapping Int32 )
            value.MeshMorphing                              = GetObject<CriLipsMeshMorph>(new IntPtr(p + 0x0E0), ReversePrism.DataModels.CriLipsMeshMorph.FromPointer); // 0270DBBA6F80 0xE0 MeshMorphing                ( 000186655D40 ModelClassType CriLipsMeshMorph CriLipsMeshMorph CriLipsMeshMorph Pointer )
            value.Info                                      = (Info)GetInt32(new IntPtr(p + 0x0E8)); // 0270DBBA6FA0 0xE8 Info                        ( 0001866EC0D0 ModelEnumType Info Info Info Int32 )
            value.BlendAmount                               = (MorphTargetBlendAmountAsJapanese)GetInt32(new IntPtr(p + 0x0F8)); // 0270DBBA6FC0 0xF8 BlendAmount                 ( 0001866ECA70 ModelEnumType MorphTargetBlendAmountAsJapanese MorphTargetBlendAmountAsJapanese MorphTargetBlendAmountAsJapanese Int32 )
            value.AnalyzeModule                             = GetObject<ICriLipsAnalyzeModule>(new IntPtr(p + 0x110), ReversePrism.DataModels.ICriLipsAnalyzeModule.FromPointer); // 0270DBBA6FE0 0x110 AnalyzeModule               ( 000186746040 ModelClassType ICriLipsAnalyzeModule ICriLipsAnalyzeModule ICriLipsAnalyzeModule Pointer )

            return value;
        }
    }
}
