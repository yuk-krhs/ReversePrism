using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 Behaviour                                0001865FAD70 ModelClassType SwayBoneRateBehaviour SwayBoneRateBehaviour SwayBoneRateBehaviour Pointer
    public partial class SwayBoneRateClip : DataModel
    {
        public SwayBoneRateBehaviour?                   Behaviour                               { get; set; }

        public static SwayBoneRateClip? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SwayBoneRateClip() { Pointer= p0 };

            value.Behaviour                                 = GetObject<SwayBoneRateBehaviour>(new IntPtr(p + 0x018), ReversePrism.DataModels.SwayBoneRateBehaviour.FromPointer); // 024664E74D48 0x18 Behaviour                   ( 0001865FAD70 ModelClassType SwayBoneRateBehaviour SwayBoneRateBehaviour SwayBoneRateBehaviour Pointer )

            return value;
        }
    }
}
