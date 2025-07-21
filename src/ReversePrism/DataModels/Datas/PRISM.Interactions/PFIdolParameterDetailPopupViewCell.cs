using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Icon                                     ModelClassType PFIdolIconRectView PFIdolIconRectView PFIdolIconRectView Pointer
    // 028 ParameterView                            ModelClassType VoDaViMeRankView VoDaViMeRankView VoDaViMeRankView Pointer
    // 030 BaseParameterView                        ModelClassType VoDaViMeView VoDaViMeView VoDaViMeView Pointer
    public partial class PFIdolParameterDetailPopupViewCell : DataModel
    {
        public PFIdolIconRectView?                      Icon                                    { get; set; }
        public VoDaViMeRankView?                        ParameterView                           { get; set; }
        public VoDaViMeView?                            BaseParameterView                       { get; set; }

        public static PFIdolParameterDetailPopupViewCell? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PFIdolParameterDetailPopupViewCell() { Pointer= p0 };

            value.Icon                                      = GetObject<PFIdolIconRectView>(new IntPtr(p + 0x020), ReversePrism.DataModels.PFIdolIconRectView.FromPointer); // 0x20 Icon                        ( ModelClassType PFIdolIconRectView PFIdolIconRectView PFIdolIconRectView Pointer )
            value.ParameterView                             = GetObject<VoDaViMeRankView>(new IntPtr(p + 0x028), ReversePrism.DataModels.VoDaViMeRankView.FromPointer); // 0x28 ParameterView               ( ModelClassType VoDaViMeRankView VoDaViMeRankView VoDaViMeRankView Pointer )
            value.BaseParameterView                         = GetObject<VoDaViMeView>(new IntPtr(p + 0x030), ReversePrism.DataModels.VoDaViMeView.FromPointer); // 0x30 BaseParameterView           ( ModelClassType VoDaViMeView VoDaViMeView VoDaViMeView Pointer )

            return value;
        }
    }
}
