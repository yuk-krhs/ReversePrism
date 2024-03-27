using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 Helper                                   00018665EBC0 ModelClassType JsonClassDataContractCriticalHelper JsonClassDataContractCriticalHelper JsonClassDataContractCriticalHelper Pointer
    public partial class JsonClassDataContract
    {
        public JsonClassDataContractCriticalHelper?     Helper                                  { get; set; }

        public static JsonClassDataContract? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new JsonClassDataContract();

            value.Helper                                    = GetObject<JsonClassDataContractCriticalHelper>(new IntPtr(p + 0x018), ReversePrism.DataModels.JsonClassDataContractCriticalHelper.FromPointer); // 027004D3A6A0 0x18 Helper                      ( 00018665EBC0 ModelClassType JsonClassDataContractCriticalHelper JsonClassDataContractCriticalHelper JsonClassDataContractCriticalHelper Pointer )

            return value;
        }
    }
}
