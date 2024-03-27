using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Helper                                   00018665FA00 ModelClassType JsonDataContractCriticalHelper JsonDataContractCriticalHelper JsonDataContractCriticalHelper Pointer
    public partial class JsonDataContract
    {
        public JsonDataContractCriticalHelper?          Helper                                  { get; set; }

        public static JsonDataContract? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new JsonDataContract();

            value.Helper                                    = GetObject<JsonDataContractCriticalHelper>(new IntPtr(p + 0x010), ReversePrism.DataModels.JsonDataContractCriticalHelper.FromPointer); // 027004D382A0 0x10 Helper                      ( 00018665FA00 ModelClassType JsonDataContractCriticalHelper JsonDataContractCriticalHelper JsonDataContractCriticalHelper Pointer )

            return value;
        }
    }
}
