using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 OriginalClip                             ModelClassType AnimationClip AnimationClip AnimationClip Pointer
    // 018 OverrideClip                             ModelClassType AnimationClip AnimationClip AnimationClip Pointer
    public partial class AnimationClipPair : DataModel
    {
        public AnimationClip?                           OriginalClip                            { get; set; }
        public AnimationClip?                           OverrideClip                            { get; set; }

        public static AnimationClipPair? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AnimationClipPair() { Pointer= p0 };

            value.OriginalClip                              = GetObject<AnimationClip>(new IntPtr(p + 0x010), ReversePrism.DataModels.AnimationClip.FromPointer); // 0x10 OriginalClip                ( ModelClassType AnimationClip AnimationClip AnimationClip Pointer )
            value.OverrideClip                              = GetObject<AnimationClip>(new IntPtr(p + 0x018), ReversePrism.DataModels.AnimationClip.FromPointer); // 0x18 OverrideClip                ( ModelClassType AnimationClip AnimationClip AnimationClip Pointer )

            return value;
        }
    }
}
