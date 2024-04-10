using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 AdditiveAnimationData                    000185CB5818 ModelClassListType AdditiveAnimationData[] AdditiveAnimationData[] List<AdditiveAnimationData> Pointer
    // 028 CurentAdditiveAnimList                   000185CB5818 ModelClassListType AdditiveAnimationData[] AdditiveAnimationData[] List<AdditiveAnimationData> Pointer
    // 030 Character                                000186596FD0 ModelClassType Character Character Character Pointer
    // 038 Animator                                 0001866B8DE0 ModelClassType Animator Animator Animator Pointer
    // 040 IgnoreOverwriteAnimFrame                 000186594D10 ModelPrimitiveType bool bool bool Bool
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

            value.AdditiveAnimationData                     = GetObjectList<AdditiveAnimationData>(new IntPtr(p + 0x020), ReversePrism.DataModels.AdditiveAnimationData.FromPointer); // 0245A69CE798 0x20 AdditiveAnimationData       ( 000185CB5818 ModelClassListType AdditiveAnimationData[] AdditiveAnimationData[] List<AdditiveAnimationData> Pointer )
            value.CurentAdditiveAnimList                    = GetObjectList<AdditiveAnimationData>(new IntPtr(p + 0x028), ReversePrism.DataModels.AdditiveAnimationData.FromPointer); // 0245A69CE7B8 0x28 CurentAdditiveAnimList      ( 000185CB5818 ModelClassListType AdditiveAnimationData[] AdditiveAnimationData[] List<AdditiveAnimationData> Pointer )
            value.Character                                 = GetObject<Character>(new IntPtr(p + 0x030), ReversePrism.DataModels.Character.FromPointer); // 0245A69CE7D8 0x30 Character                   ( 000186596FD0 ModelClassType Character Character Character Pointer )
            value.Animator                                  = GetObject<Animator>(new IntPtr(p + 0x038), ReversePrism.DataModels.Animator.FromPointer); // 0245A69CE7F8 0x38 Animator                    ( 0001866B8DE0 ModelClassType Animator Animator Animator Pointer )
            value.IgnoreOverwriteAnimFrame                  = GetBool(new IntPtr(p + 0x040)); // 0245A69CE818 0x40 IgnoreOverwriteAnimFrame    ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
