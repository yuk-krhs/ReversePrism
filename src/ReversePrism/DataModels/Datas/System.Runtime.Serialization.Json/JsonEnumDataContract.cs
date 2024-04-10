using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 Helper                                   000186660610 ModelClassType JsonEnumDataContractCriticalHelper JsonEnumDataContractCriticalHelper JsonEnumDataContractCriticalHelper Pointer
    public partial class JsonEnumDataContract : DataModel
    {
        public JsonEnumDataContractCriticalHelper?      Helper                                  { get; set; }

        public static JsonEnumDataContract? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new JsonEnumDataContract() { Pointer= p0 };

            value.Helper                                    = GetObject<JsonEnumDataContractCriticalHelper>(new IntPtr(p + 0x018), ReversePrism.DataModels.JsonEnumDataContractCriticalHelper.FromPointer); // 0245A4D784C0 0x18 Helper                      ( 000186660610 ModelClassType JsonEnumDataContractCriticalHelper JsonEnumDataContractCriticalHelper JsonEnumDataContractCriticalHelper Pointer )

            return value;
        }
    }
}
