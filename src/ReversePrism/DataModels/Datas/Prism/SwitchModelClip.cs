using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 Behaviour                                0001865FDE50 ModelClassType SwitchModelBehaviour SwitchModelBehaviour SwitchModelBehaviour Pointer
    public partial class SwitchModelClip
    {
        public SwitchModelBehaviour?                    Behaviour                               { get; set; }

        public static SwitchModelClip? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SwitchModelClip();

            value.Behaviour                                 = GetObject<SwitchModelBehaviour>(new IntPtr(p + 0x018), ReversePrism.DataModels.SwitchModelBehaviour.FromPointer); // 027006B64F88 0x18 Behaviour                   ( 0001865FDE50 ModelClassType SwitchModelBehaviour SwitchModelBehaviour SwitchModelBehaviour Pointer )

            return value;
        }
    }
}
