using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 TransitionAnimationPlayerAssetKey        ModelPrimitiveType string string string String
    // 028 ResourceLoader                           ModelClassType IResourceLoader IResourceLoader IResourceLoader Pointer
    // 030 TransitionAnimationPlayer                ModelClassType TransitionAnimationPlayer TransitionAnimationPlayer TransitionAnimationPlayer Pointer
    public partial class SpecialLoadingContentView : DataModel
    {
        public string                                   TransitionAnimationPlayerAssetKey       { get; set; }
        public IResourceLoader?                         ResourceLoader                          { get; set; }
        public TransitionAnimationPlayer?               TransitionAnimationPlayer               { get; set; }

        public static SpecialLoadingContentView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SpecialLoadingContentView() { Pointer= p0 };

            value.TransitionAnimationPlayerAssetKey         = GetString(new IntPtr(p + 0x020)); // 0x20 TransitionAnimationPlayerAssetKey ( ModelPrimitiveType string string string String )
            value.ResourceLoader                            = GetObject<IResourceLoader>(new IntPtr(p + 0x028), ReversePrism.DataModels.IResourceLoader.FromPointer); // 0x28 ResourceLoader              ( ModelClassType IResourceLoader IResourceLoader IResourceLoader Pointer )
            value.TransitionAnimationPlayer                 = GetObject<TransitionAnimationPlayer>(new IntPtr(p + 0x030), ReversePrism.DataModels.TransitionAnimationPlayer.FromPointer); // 0x30 TransitionAnimationPlayer   ( ModelClassType TransitionAnimationPlayer TransitionAnimationPlayer TransitionAnimationPlayer Pointer )

            return value;
        }
    }
}
