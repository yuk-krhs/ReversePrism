using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 040 Response                                 00018660B580 ModelClassType MessageResult MessageResult MessageResult Pointer
    public partial class OsapiMessageResult
    {
        public MessageResult?                           Response                                { get; set; }

        public static OsapiMessageResult? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new OsapiMessageResult();

            value.Response                                  = GetObject<MessageResult>(new IntPtr(p + 0x040), ReversePrism.DataModels.MessageResult.FromPointer); // 0270DB4993F0 0x40 Response                    ( 00018660B580 ModelClassType MessageResult MessageResult MessageResult Pointer )

            return value;
        }
    }
}
