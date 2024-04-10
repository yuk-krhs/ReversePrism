using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 Helper                                   00018665F070 ModelClassType JsonCollectionDataContractCriticalHelper JsonCollectionDataContractCriticalHelper JsonCollectionDataContractCriticalHelper Pointer
    public partial class JsonCollectionDataContract : DataModel
    {
        public JsonCollectionDataContractCriticalHelper? Helper                                  { get; set; }

        public static JsonCollectionDataContract? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new JsonCollectionDataContract() { Pointer= p0 };

            value.Helper                                    = GetObject<JsonCollectionDataContractCriticalHelper>(new IntPtr(p + 0x018), ReversePrism.DataModels.JsonCollectionDataContractCriticalHelper.FromPointer); // 0245A4D78228 0x18 Helper                      ( 00018665F070 ModelClassType JsonCollectionDataContractCriticalHelper JsonCollectionDataContractCriticalHelper JsonCollectionDataContractCriticalHelper Pointer )

            return value;
        }
    }
}
