using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 OnOverrideControllerDirty                0001866A4BA0 ModelClassType OnOverrideControllerDirtyCallback OnOverrideControllerDirtyCallback OnOverrideControllerDirtyCallback Pointer
    public partial class AnimatorOverrideController
    {
        public OnOverrideControllerDirtyCallback?       OnOverrideControllerDirty               { get; set; }

        public static AnimatorOverrideController? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AnimatorOverrideController();

            value.OnOverrideControllerDirty                 = GetObject<OnOverrideControllerDirtyCallback>(new IntPtr(p + 0x018), ReversePrism.DataModels.OnOverrideControllerDirtyCallback.FromPointer); // 027002273F68 0x18 OnOverrideControllerDirty   ( 0001866A4BA0 ModelClassType OnOverrideControllerDirtyCallback OnOverrideControllerDirtyCallback OnOverrideControllerDirtyCallback Pointer )

            return value;
        }
    }
}
