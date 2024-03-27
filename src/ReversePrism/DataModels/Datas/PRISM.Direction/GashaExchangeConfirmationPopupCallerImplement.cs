using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 factory                                  PopupViewFactory`1<IGashaExchangeConfirmationPopupView> IL2CPP_TYPE_GENERICINST
    public partial class GashaExchangeConfirmationPopupCallerImplement
    {

        public static GashaExchangeConfirmationPopupCallerImplement? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GashaExchangeConfirmationPopupCallerImplement();


            return value;
        }
    }
}
