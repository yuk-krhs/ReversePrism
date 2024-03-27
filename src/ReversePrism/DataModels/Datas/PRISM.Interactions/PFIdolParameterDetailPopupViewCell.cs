using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Icon                                     000186703B70 ModelClassType PFIdolIconRectView PFIdolIconRectView PFIdolIconRectView Pointer
    // 028 ParameterView                            000186530E30 ModelClassType VoDaViMeRankView VoDaViMeRankView VoDaViMeRankView Pointer
    // 030 BaseParameterView                        000186531810 ModelClassType VoDaViMeView VoDaViMeView VoDaViMeView Pointer
    public partial class PFIdolParameterDetailPopupViewCell
    {
        public PFIdolIconRectView?                      Icon                                    { get; set; }
        public VoDaViMeRankView?                        ParameterView                           { get; set; }
        public VoDaViMeView?                            BaseParameterView                       { get; set; }

        public static PFIdolParameterDetailPopupViewCell? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PFIdolParameterDetailPopupViewCell();

            value.Icon                                      = GetObject<PFIdolIconRectView>(new IntPtr(p + 0x020), ReversePrism.DataModels.PFIdolIconRectView.FromPointer); // 0270DA305258 0x20 Icon                        ( 000186703B70 ModelClassType PFIdolIconRectView PFIdolIconRectView PFIdolIconRectView Pointer )
            value.ParameterView                             = GetObject<VoDaViMeRankView>(new IntPtr(p + 0x028), ReversePrism.DataModels.VoDaViMeRankView.FromPointer); // 0270DA305278 0x28 ParameterView               ( 000186530E30 ModelClassType VoDaViMeRankView VoDaViMeRankView VoDaViMeRankView Pointer )
            value.BaseParameterView                         = GetObject<VoDaViMeView>(new IntPtr(p + 0x030), ReversePrism.DataModels.VoDaViMeView.FromPointer); // 0270DA305298 0x30 BaseParameterView           ( 000186531810 ModelClassType VoDaViMeView VoDaViMeView VoDaViMeView Pointer )

            return value;
        }
    }
}
