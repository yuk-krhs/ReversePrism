using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 AdditiveAnimationData                    ModelClassListType AdditiveAnimationData[] AdditiveAnimationData[] List<AdditiveAnimationData> Pointer
    // 028 CurentAdditiveAnimList                   ModelClassListType List`1<AdditiveAnimationData> List`1<AdditiveAnimationData> List<AdditiveAnimationData> Pointer
    // 030 Character                                ModelClassType Character Character Character Pointer
    // 038 Animator                                 ModelClassType Animator Animator Animator Pointer
    // 040 IgnoreOverwriteAnimFrame                 ModelPrimitiveType bool bool bool Bool
    // 000 additiveAnimationList                    List`1<AdditiveAnimation> IL2CPP_TYPE_GENERICINST
    public partial class AdditiveAnimation : DataModel
    {
        public List<AdditiveAnimationData>?             AdditiveAnimationData                   { get; set; }
        public List<AdditiveAnimationData>?             CurentAdditiveAnimList                  { get; set; }
        public Character?                               Character                               { get; set; }
        public Animator?                                Animator                                { get; set; }
        public bool                                     IgnoreOverwriteAnimFrame                { get; set; }

        public static AdditiveAnimation? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AdditiveAnimation() { Pointer= p0 };

            value.AdditiveAnimationData                     = GetObjectList<AdditiveAnimationData>(new IntPtr(p + 0x020), ReversePrism.DataModels.AdditiveAnimationData.FromPointer); // 0x20 AdditiveAnimationData       ( ModelClassListType AdditiveAnimationData[] AdditiveAnimationData[] List<AdditiveAnimationData> Pointer )
            value.CurentAdditiveAnimList                    = GetObjectList<AdditiveAnimationData>(new IntPtr(p + 0x028), ReversePrism.DataModels.AdditiveAnimationData.FromPointer); // 0x28 CurentAdditiveAnimList      ( ModelClassListType List`1<AdditiveAnimationData> List`1<AdditiveAnimationData> List<AdditiveAnimationData> Pointer )
            value.Character                                 = GetObject<Character>(new IntPtr(p + 0x030), ReversePrism.DataModels.Character.FromPointer); // 0x30 Character                   ( ModelClassType Character Character Character Pointer )
            value.Animator                                  = GetObject<Animator>(new IntPtr(p + 0x038), ReversePrism.DataModels.Animator.FromPointer); // 0x38 Animator                    ( ModelClassType Animator Animator Animator Pointer )
            value.IgnoreOverwriteAnimFrame                  = GetBool(new IntPtr(p + 0x040)); // 0x40 IgnoreOverwriteAnimFrame    ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
