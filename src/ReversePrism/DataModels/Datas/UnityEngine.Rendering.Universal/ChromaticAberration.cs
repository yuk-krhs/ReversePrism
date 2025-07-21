using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 038 Intensity                                ModelClassType ClampedFloatParameter ClampedFloatParameter ClampedFloatParameter Pointer
    public partial class ChromaticAberration : DataModel
    {
        public ClampedFloatParameter?                   Intensity                               { get; set; }

        public static ChromaticAberration? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ChromaticAberration() { Pointer= p0 };

            value.Intensity                                 = GetObject<ClampedFloatParameter>(new IntPtr(p + 0x038), ReversePrism.DataModels.ClampedFloatParameter.FromPointer); // 0x38 Intensity                   ( ModelClassType ClampedFloatParameter ClampedFloatParameter ClampedFloatParameter Pointer )

            return value;
        }
    }
}
