using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 Behaviour                                0001866C26E0 ModelClassType DepthOfFieldBehaviour DepthOfFieldBehaviour DepthOfFieldBehaviour Pointer
    public partial class DepthOfFieldClip
    {
        public DepthOfFieldBehaviour?                   Behaviour                               { get; set; }

        public static DepthOfFieldClip? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DepthOfFieldClip();

            value.Behaviour                                 = GetObject<DepthOfFieldBehaviour>(new IntPtr(p + 0x018), ReversePrism.DataModels.DepthOfFieldBehaviour.FromPointer); // 027006B64E18 0x18 Behaviour                   ( 0001866C26E0 ModelClassType DepthOfFieldBehaviour DepthOfFieldBehaviour DepthOfFieldBehaviour Pointer )

            return value;
        }
    }
}
