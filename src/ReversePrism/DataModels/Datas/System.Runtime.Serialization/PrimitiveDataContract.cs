using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 028 Helper                                   0001865AA0D0 ModelClassType PrimitiveDataContractCriticalHelper PrimitiveDataContractCriticalHelper PrimitiveDataContractCriticalHelper Pointer
    public partial class PrimitiveDataContract : DataModel
    {
        public PrimitiveDataContractCriticalHelper?     Helper                                  { get; set; }

        public static PrimitiveDataContract? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PrimitiveDataContract() { Pointer= p0 };

            value.Helper                                    = GetObject<PrimitiveDataContractCriticalHelper>(new IntPtr(p + 0x028), ReversePrism.DataModels.PrimitiveDataContractCriticalHelper.FromPointer); // 0245A4CC8B48 0x28 Helper                      ( 0001865AA0D0 ModelClassType PrimitiveDataContractCriticalHelper PrimitiveDataContractCriticalHelper PrimitiveDataContractCriticalHelper Pointer )

            return value;
        }
    }
}
