using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 AnimClip                                 0001866B2300 ModelClassType AnimationClip AnimationClip AnimationClip Pointer
    public partial class DummyModel
    {
        public AnimationClip?                           AnimClip                                { get; set; }

        public static DummyModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DummyModel();

            value.AnimClip                                  = GetObject<AnimationClip>(new IntPtr(p + 0x020), ReversePrism.DataModels.AnimationClip.FromPointer); // 027006B25F38 0x20 AnimClip                    ( 0001866B2300 ModelClassType AnimationClip AnimationClip AnimationClip Pointer )

            return value;
        }
    }
}
