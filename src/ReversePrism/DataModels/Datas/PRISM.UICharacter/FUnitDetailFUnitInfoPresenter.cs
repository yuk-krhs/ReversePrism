using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 View                                     000186549220 ModelClassType FUnitDetailFUnitInfoView FUnitDetailFUnitInfoView FUnitDetailFUnitInfoView Pointer
    public partial class FUnitDetailFUnitInfoPresenter
    {
        public FUnitDetailFUnitInfoView?                View                                    { get; set; }

        public static FUnitDetailFUnitInfoPresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FUnitDetailFUnitInfoPresenter();

            value.View                                      = GetObject<FUnitDetailFUnitInfoView>(new IntPtr(p + 0x020), ReversePrism.DataModels.FUnitDetailFUnitInfoView.FromPointer); // 0270D5DAD038 0x20 View                        ( 000186549220 ModelClassType FUnitDetailFUnitInfoView FUnitDetailFUnitInfoView FUnitDetailFUnitInfoView Pointer )

            return value;
        }
    }
}
