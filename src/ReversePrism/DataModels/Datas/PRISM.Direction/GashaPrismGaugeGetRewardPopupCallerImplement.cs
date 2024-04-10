using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 gashaPrismGaugeGetRewardPopupViewFactory PopupViewFactory`1<IGashaPrismGaugeGetRewardPopupView> IL2CPP_TYPE_GENERICINST
    public partial class GashaPrismGaugeGetRewardPopupCallerImplement : DataModel
    {

        public static GashaPrismGaugeGetRewardPopupCallerImplement? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GashaPrismGaugeGetRewardPopupCallerImplement() { Pointer= p0 };


            return value;
        }
    }
}
