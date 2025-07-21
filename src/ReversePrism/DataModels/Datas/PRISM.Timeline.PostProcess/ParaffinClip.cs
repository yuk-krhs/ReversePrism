using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 Behaviour                                ModelClassType ParaffinBehaviour ParaffinBehaviour ParaffinBehaviour Pointer
    public partial class ParaffinClip : DataModel
    {
        public ParaffinBehaviour?                       Behaviour                               { get; set; }

        public static ParaffinClip? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ParaffinClip() { Pointer= p0 };

            value.Behaviour                                 = GetObject<ParaffinBehaviour>(new IntPtr(p + 0x018), ReversePrism.DataModels.ParaffinBehaviour.FromPointer); // 0x18 Behaviour                   ( ModelClassType ParaffinBehaviour ParaffinBehaviour ParaffinBehaviour Pointer )

            return value;
        }
    }
}
