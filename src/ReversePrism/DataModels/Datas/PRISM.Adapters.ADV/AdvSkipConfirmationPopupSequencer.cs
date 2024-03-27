using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 factory                                  IPopupViewFactory`1<IAdvSkipConfirmationPopupView> IL2CPP_TYPE_GENERICINST
    public partial class AdvSkipConfirmationPopupSequencer
    {

        public static AdvSkipConfirmationPopupSequencer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AdvSkipConfirmationPopupSequencer();


            return value;
        }
    }
}
