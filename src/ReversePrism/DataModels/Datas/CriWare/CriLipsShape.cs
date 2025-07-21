using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 030 UserModifyDelegate                       ModelClassType UserModifyDelegateFunction UserModifyDelegateFunction UserModifyDelegateFunction Pointer
    // 038 MorphingTargetType                       ModelEnumType MorphingTargetType MorphingTargetType MorphingTargetType Int32
    // 03C BlendShapeType                           ModelEnumType BlendShapeType BlendShapeType BlendShapeType Int32
    // 040 SkinnedMeshRenderer                      ModelClassType SkinnedMeshRenderer SkinnedMeshRenderer SkinnedMeshRenderer Pointer
    // 048 NameMapping                              ModelEnumType BlendShapeNameMapping BlendShapeNameMapping BlendShapeNameMapping Int32
    // 090 Animator                                 ModelClassType Animator Animator Animator Pointer
    // 098 AnimationStateNameMapping                ModelEnumType BlendShapeNameMapping BlendShapeNameMapping BlendShapeNameMapping Int32
    // 0E0 MeshMorphing                             ModelClassType CriLipsMeshMorph CriLipsMeshMorph CriLipsMeshMorph Pointer
    // 0E8 Info                                     ModelEnumType Info Info Info Int32
    // 0F8 BlendAmount                              ModelEnumType MorphTargetBlendAmountAsJapanese MorphTargetBlendAmountAsJapanese MorphTargetBlendAmountAsJapanese Int32
    // 110 AnalyzeModule                            ModelClassType ICriLipsAnalyzeModule ICriLipsAnalyzeModule ICriLipsAnalyzeModule Pointer
    public partial class CriLipsShape : DataModel
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
            var value   = new CriLipsShape() { Pointer= p0 };

            value.UserModifyDelegate                        = GetObject<UserModifyDelegateFunction>(new IntPtr(p + 0x030), ReversePrism.DataModels.UserModifyDelegateFunction.FromPointer); // 0x30 UserModifyDelegate          ( ModelClassType UserModifyDelegateFunction UserModifyDelegateFunction UserModifyDelegateFunction Pointer )
            value.MorphingTargetType                        = (MorphingTargetType)GetInt32(new IntPtr(p + 0x038)); // 0x38 MorphingTargetType          ( ModelEnumType MorphingTargetType MorphingTargetType MorphingTargetType Int32 )
            value.BlendShapeType                            = (BlendShapeType)GetInt32(new IntPtr(p + 0x03C)); // 0x3C BlendShapeType              ( ModelEnumType BlendShapeType BlendShapeType BlendShapeType Int32 )
            value.SkinnedMeshRenderer                       = GetObject<SkinnedMeshRenderer>(new IntPtr(p + 0x040), ReversePrism.DataModels.SkinnedMeshRenderer.FromPointer); // 0x40 SkinnedMeshRenderer         ( ModelClassType SkinnedMeshRenderer SkinnedMeshRenderer SkinnedMeshRenderer Pointer )
            value.NameMapping                               = (BlendShapeNameMapping)GetInt32(new IntPtr(p + 0x048)); // 0x48 NameMapping                 ( ModelEnumType BlendShapeNameMapping BlendShapeNameMapping BlendShapeNameMapping Int32 )
            value.Animator                                  = GetObject<Animator>(new IntPtr(p + 0x090), ReversePrism.DataModels.Animator.FromPointer); // 0x90 Animator                    ( ModelClassType Animator Animator Animator Pointer )
            value.AnimationStateNameMapping                 = (BlendShapeNameMapping)GetInt32(new IntPtr(p + 0x098)); // 0x98 AnimationStateNameMapping   ( ModelEnumType BlendShapeNameMapping BlendShapeNameMapping BlendShapeNameMapping Int32 )
            value.MeshMorphing                              = GetObject<CriLipsMeshMorph>(new IntPtr(p + 0x0E0), ReversePrism.DataModels.CriLipsMeshMorph.FromPointer); // 0xE0 MeshMorphing                ( ModelClassType CriLipsMeshMorph CriLipsMeshMorph CriLipsMeshMorph Pointer )
            value.Info                                      = (Info)GetInt32(new IntPtr(p + 0x0E8)); // 0xE8 Info                        ( ModelEnumType Info Info Info Int32 )
            value.BlendAmount                               = (MorphTargetBlendAmountAsJapanese)GetInt32(new IntPtr(p + 0x0F8)); // 0xF8 BlendAmount                 ( ModelEnumType MorphTargetBlendAmountAsJapanese MorphTargetBlendAmountAsJapanese MorphTargetBlendAmountAsJapanese Int32 )
            value.AnalyzeModule                             = GetObject<ICriLipsAnalyzeModule>(new IntPtr(p + 0x110), ReversePrism.DataModels.ICriLipsAnalyzeModule.FromPointer); // 0x110 AnalyzeModule               ( ModelClassType ICriLipsAnalyzeModule ICriLipsAnalyzeModule ICriLipsAnalyzeModule Pointer )

            return value;
        }
    }
}
