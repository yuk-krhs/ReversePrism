using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 Behaviour                                ModelClassType HighlightShakeBehaviour HighlightShakeBehaviour HighlightShakeBehaviour Pointer
    public partial class HighlightShakeClip : DataModel
    {
        public HighlightShakeBehaviour?                 Behaviour                               { get; set; }

        public static HighlightShakeClip? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new HighlightShakeClip() { Pointer= p0 };

            value.Behaviour                                 = GetObject<HighlightShakeBehaviour>(new IntPtr(p + 0x018), ReversePrism.DataModels.HighlightShakeBehaviour.FromPointer); // 0x18 Behaviour                   ( ModelClassType HighlightShakeBehaviour HighlightShakeBehaviour HighlightShakeBehaviour Pointer )

            return value;
        }
    }
}
