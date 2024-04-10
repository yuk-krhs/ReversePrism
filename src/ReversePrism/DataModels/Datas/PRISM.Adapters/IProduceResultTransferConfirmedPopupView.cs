using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public partial class IProduceResultTransferConfirmedPopupView : DataModel
    {

        public static IProduceResultTransferConfirmedPopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IProduceResultTransferConfirmedPopupView() { Pointer= p0 };


            return value;
        }
    }
}
