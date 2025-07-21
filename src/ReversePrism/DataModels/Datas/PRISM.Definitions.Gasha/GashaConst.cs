using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 PrismGaugeHelpId                         int IL2CPP_TYPE_I4
    // 000 ExchangePointHelpId                      int IL2CPP_TYPE_I4
    // 000 SeCueSheetName                           string IL2CPP_TYPE_STRING
    public partial class GashaConst : DataModel
    {

        public static GashaConst? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GashaConst() { Pointer= p0 };


            return value;
        }
    }
}
