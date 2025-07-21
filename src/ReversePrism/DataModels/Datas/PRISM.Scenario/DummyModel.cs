using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 AnimClip                                 ModelClassType AnimationClip AnimationClip AnimationClip Pointer
    public partial class DummyModel : DataModel
    {
        public AnimationClip?                           AnimClip                                { get; set; }

        public static DummyModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DummyModel() { Pointer= p0 };

            value.AnimClip                                  = GetObject<AnimationClip>(new IntPtr(p + 0x020), ReversePrism.DataModels.AnimationClip.FromPointer); // 0x20 AnimClip                    ( ModelClassType AnimationClip AnimationClip AnimationClip Pointer )

            return value;
        }
    }
}
