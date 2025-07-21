using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 Behaviour                                ModelClassType CyalumeBehaviour CyalumeBehaviour CyalumeBehaviour Pointer
    public partial class CyalumeClip : DataModel
    {
        public CyalumeBehaviour?                        Behaviour                               { get; set; }

        public static CyalumeClip? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CyalumeClip() { Pointer= p0 };

            value.Behaviour                                 = GetObject<CyalumeBehaviour>(new IntPtr(p + 0x018), ReversePrism.DataModels.CyalumeBehaviour.FromPointer); // 0x18 Behaviour                   ( ModelClassType CyalumeBehaviour CyalumeBehaviour CyalumeBehaviour Pointer )

            return value;
        }
    }
}
