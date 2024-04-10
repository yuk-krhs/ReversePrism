using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 Behaviour                                000186524670 ModelClassType VignetteBehaviour VignetteBehaviour VignetteBehaviour Pointer
    public partial class VignetteClip : DataModel
    {
        public VignetteBehaviour?                       Behaviour                               { get; set; }

        public static VignetteClip? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new VignetteClip() { Pointer= p0 };

            value.Behaviour                                 = GetObject<VignetteBehaviour>(new IntPtr(p + 0x018), ReversePrism.DataModels.VignetteBehaviour.FromPointer); // 0246650D9CF0 0x18 Behaviour                   ( 000186524670 ModelClassType VignetteBehaviour VignetteBehaviour VignetteBehaviour Pointer )

            return value;
        }
    }
}
