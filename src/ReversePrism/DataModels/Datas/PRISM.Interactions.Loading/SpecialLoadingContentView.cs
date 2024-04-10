using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 TransitionAnimationPlayerAssetKey        000186671910 ModelPrimitiveType string string string String
    // 028 ResourceTag                              00018661C240 ModelClassType IResourceTag IResourceTag IResourceTag Pointer
    // 030 TransitionAnimationPlayer                0001866AC610 ModelClassType TransitionAnimationPlayer TransitionAnimationPlayer TransitionAnimationPlayer Pointer
    public partial class SpecialLoadingContentView : DataModel
    {
        public string                                   TransitionAnimationPlayerAssetKey       { get; set; }
        public IResourceTag?                            ResourceTag                             { get; set; }
        public TransitionAnimationPlayer?               TransitionAnimationPlayer               { get; set; }

        public static SpecialLoadingContentView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SpecialLoadingContentView() { Pointer= p0 };

            value.TransitionAnimationPlayerAssetKey         = GetString(new IntPtr(p + 0x020)); // 0245A1E9C7D0 0x20 TransitionAnimationPlayerAssetKey ( 000186671910 ModelPrimitiveType string string string String )
            value.ResourceTag                               = GetObject<IResourceTag>(new IntPtr(p + 0x028), ReversePrism.DataModels.IResourceTag.FromPointer); // 0245A1E9C7F0 0x28 ResourceTag                 ( 00018661C240 ModelClassType IResourceTag IResourceTag IResourceTag Pointer )
            value.TransitionAnimationPlayer                 = GetObject<TransitionAnimationPlayer>(new IntPtr(p + 0x030), ReversePrism.DataModels.TransitionAnimationPlayer.FromPointer); // 0245A1E9C810 0x30 TransitionAnimationPlayer   ( 0001866AC610 ModelClassType TransitionAnimationPlayer TransitionAnimationPlayer TransitionAnimationPlayer Pointer )

            return value;
        }
    }
}
