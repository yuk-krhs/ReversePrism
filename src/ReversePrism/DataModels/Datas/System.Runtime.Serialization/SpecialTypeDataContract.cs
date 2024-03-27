using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 028 Helper                                   000186560530 ModelClassType SpecialTypeDataContractCriticalHelper SpecialTypeDataContractCriticalHelper SpecialTypeDataContractCriticalHelper Pointer
    public partial class SpecialTypeDataContract
    {
        public SpecialTypeDataContractCriticalHelper?   Helper                                  { get; set; }

        public static SpecialTypeDataContract? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SpecialTypeDataContract();

            value.Helper                                    = GetObject<SpecialTypeDataContractCriticalHelper>(new IntPtr(p + 0x028), ReversePrism.DataModels.SpecialTypeDataContractCriticalHelper.FromPointer); // 027004C8F500 0x28 Helper                      ( 000186560530 ModelClassType SpecialTypeDataContractCriticalHelper SpecialTypeDataContractCriticalHelper SpecialTypeDataContractCriticalHelper Pointer )

            return value;
        }
    }
}
