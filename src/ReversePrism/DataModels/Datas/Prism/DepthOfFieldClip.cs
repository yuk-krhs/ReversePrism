using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 Behaviour                                ModelClassType DepthOfFieldBehaviour DepthOfFieldBehaviour DepthOfFieldBehaviour Pointer
    public partial class DepthOfFieldClip : DataModel
    {
        public DepthOfFieldBehaviour?                   Behaviour                               { get; set; }

        public static DepthOfFieldClip? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DepthOfFieldClip() { Pointer= p0 };

            value.Behaviour                                 = GetObject<DepthOfFieldBehaviour>(new IntPtr(p + 0x018), ReversePrism.DataModels.DepthOfFieldBehaviour.FromPointer); // 0x18 Behaviour                   ( ModelClassType DepthOfFieldBehaviour DepthOfFieldBehaviour DepthOfFieldBehaviour Pointer )

            return value;
        }
    }
}
