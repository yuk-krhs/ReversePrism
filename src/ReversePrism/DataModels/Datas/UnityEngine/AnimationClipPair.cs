using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 OriginalClip                             0001866B2800 ModelClassType AnimationClip AnimationClip AnimationClip Pointer
    // 018 OverrideClip                             0001866B2800 ModelClassType AnimationClip AnimationClip AnimationClip Pointer
    public partial class AnimationClipPair
    {
        public AnimationClip?                           OriginalClip                            { get; set; }
        public AnimationClip?                           OverrideClip                            { get; set; }

        public static AnimationClipPair? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AnimationClipPair();

            value.OriginalClip                              = GetObject<AnimationClip>(new IntPtr(p + 0x010), ReversePrism.DataModels.AnimationClip.FromPointer); // 027006943728 0x10 OriginalClip                ( 0001866B2800 ModelClassType AnimationClip AnimationClip AnimationClip Pointer )
            value.OverrideClip                              = GetObject<AnimationClip>(new IntPtr(p + 0x018), ReversePrism.DataModels.AnimationClip.FromPointer); // 027006943748 0x18 OverrideClip                ( 0001866B2800 ModelClassType AnimationClip AnimationClip AnimationClip Pointer )

            return value;
        }
    }
}
