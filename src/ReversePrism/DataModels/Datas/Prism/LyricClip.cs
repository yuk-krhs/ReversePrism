using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 Behaviour                                ModelClassType LyricBehaviour LyricBehaviour LyricBehaviour Pointer
    public partial class LyricClip : DataModel
    {
        public LyricBehaviour?                          Behaviour                               { get; set; }

        public static LyricClip? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LyricClip() { Pointer= p0 };

            value.Behaviour                                 = GetObject<LyricBehaviour>(new IntPtr(p + 0x018), ReversePrism.DataModels.LyricBehaviour.FromPointer); // 0x18 Behaviour                   ( ModelClassType LyricBehaviour LyricBehaviour LyricBehaviour Pointer )

            return value;
        }
    }
}
