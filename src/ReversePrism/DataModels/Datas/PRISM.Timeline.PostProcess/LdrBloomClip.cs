using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 Behaviour                                000186510C30 ModelClassType LdrBloomBehaviour LdrBloomBehaviour LdrBloomBehaviour Pointer
    public partial class LdrBloomClip : DataModel
    {
        public LdrBloomBehaviour?                       Behaviour                               { get; set; }

        public static LdrBloomClip? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LdrBloomClip() { Pointer= p0 };

            value.Behaviour                                 = GetObject<LdrBloomBehaviour>(new IntPtr(p + 0x018), ReversePrism.DataModels.LdrBloomBehaviour.FromPointer); // 0246650D8FC0 0x18 Behaviour                   ( 000186510C30 ModelClassType LdrBloomBehaviour LdrBloomBehaviour LdrBloomBehaviour Pointer )

            return value;
        }
    }
}
