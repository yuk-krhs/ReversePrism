using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public partial class IExchangeSelectionTicketArgs : DataModel
    {

        public static IExchangeSelectionTicketArgs? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IExchangeSelectionTicketArgs() { Pointer= p0 };


            return value;
        }
    }
}
