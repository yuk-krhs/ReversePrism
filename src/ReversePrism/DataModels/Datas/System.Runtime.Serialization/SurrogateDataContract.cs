using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 028 Helper                                   ModelClassType SurrogateDataContractCriticalHelper SurrogateDataContractCriticalHelper SurrogateDataContractCriticalHelper Pointer
    public partial class SurrogateDataContract : DataModel
    {
        public SurrogateDataContractCriticalHelper?     Helper                                  { get; set; }

        public static SurrogateDataContract? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SurrogateDataContract() { Pointer= p0 };

            value.Helper                                    = GetObject<SurrogateDataContractCriticalHelper>(new IntPtr(p + 0x028), ReversePrism.DataModels.SurrogateDataContractCriticalHelper.FromPointer); // 0x28 Helper                      ( ModelClassType SurrogateDataContractCriticalHelper SurrogateDataContractCriticalHelper SurrogateDataContractCriticalHelper Pointer )

            return value;
        }
    }
}
