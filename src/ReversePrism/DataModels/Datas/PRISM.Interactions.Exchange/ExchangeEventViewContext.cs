using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 040 onClickEvent                             Subject`1<ExchangeEventGridViewModel> IL2CPP_TYPE_GENERICINST
    public partial class ExchangeEventViewContext : DataModel
    {

        public static ExchangeEventViewContext? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ExchangeEventViewContext() { Pointer= p0 };


            return value;
        }
    }
}
