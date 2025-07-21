using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 GashaExchangeIds                         ModelPrimitiveListType string[] string[] List<string> Pointer
    public partial class GashaExchangeExpiryDateInfoSave : DataModel
    {
        public List<string>?                            GashaExchangeIds                        { get; set; }

        public static GashaExchangeExpiryDateInfoSave? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GashaExchangeExpiryDateInfoSave() { Pointer= p0 };

            value.GashaExchangeIds                          = GetStringList(new IntPtr(p + 0x020)); // 0x20 GashaExchangeIds            ( ModelPrimitiveListType string[] string[] List<string> Pointer )

            return value;
        }
    }
}
