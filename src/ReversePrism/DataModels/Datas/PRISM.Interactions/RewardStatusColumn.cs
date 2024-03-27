using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 VoDaViMeView                             000186531D10 ModelClassType VoDaViMeView VoDaViMeView VoDaViMeView Pointer
    public partial class RewardStatusColumn
    {
        public VoDaViMeView?                            VoDaViMeView                            { get; set; }

        public static RewardStatusColumn? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RewardStatusColumn();

            value.VoDaViMeView                              = GetObject<VoDaViMeView>(new IntPtr(p + 0x020), ReversePrism.DataModels.VoDaViMeView.FromPointer); // 0270DA3190C0 0x20 VoDaViMeView                ( 000186531D10 ModelClassType VoDaViMeView VoDaViMeView VoDaViMeView Pointer )

            return value;
        }
    }
}
