using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 OpenExchangeExpiryDateCheckTime          0001865B9010 ModelPrimitiveType DateTime DateTime DateTime DateTime
    public partial class GashaCashe
    {
        public DateTime                                 OpenExchangeExpiryDateCheckTime         { get; set; }

        public static GashaCashe? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GashaCashe();

            value.OpenExchangeExpiryDateCheckTime           = GetDateTime(new IntPtr(p + 0x010)); // 027004A87978 0x10 OpenExchangeExpiryDateCheckTime ( 0001865B9010 ModelPrimitiveType DateTime DateTime DateTime DateTime )

            return value;
        }
    }
}
