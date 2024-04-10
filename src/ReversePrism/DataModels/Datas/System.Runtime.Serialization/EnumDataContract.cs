using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 028 Helper                                   0001865E0310 ModelClassType EnumDataContractCriticalHelper EnumDataContractCriticalHelper EnumDataContractCriticalHelper Pointer
    public partial class EnumDataContract : DataModel
    {
        public EnumDataContractCriticalHelper?          Helper                                  { get; set; }

        public static EnumDataContract? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EnumDataContract() { Pointer= p0 };

            value.Helper                                    = GetObject<EnumDataContractCriticalHelper>(new IntPtr(p + 0x028), ReversePrism.DataModels.EnumDataContractCriticalHelper.FromPointer); // 0245A4CC2818 0x28 Helper                      ( 0001865E0310 ModelClassType EnumDataContractCriticalHelper EnumDataContractCriticalHelper EnumDataContractCriticalHelper Pointer )

            return value;
        }
    }
}
