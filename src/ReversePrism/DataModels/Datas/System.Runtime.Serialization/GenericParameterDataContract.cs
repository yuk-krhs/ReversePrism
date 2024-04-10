using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 028 Helper                                   00018672D950 ModelClassType GenericParameterDataContractCriticalHelper GenericParameterDataContractCriticalHelper GenericParameterDataContractCriticalHelper Pointer
    public partial class GenericParameterDataContract : DataModel
    {
        public GenericParameterDataContractCriticalHelper? Helper                                  { get; set; }

        public static GenericParameterDataContract? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GenericParameterDataContract() { Pointer= p0 };

            value.Helper                                    = GetObject<GenericParameterDataContractCriticalHelper>(new IntPtr(p + 0x028), ReversePrism.DataModels.GenericParameterDataContractCriticalHelper.FromPointer); // 0245A4CC2B08 0x28 Helper                      ( 00018672D950 ModelClassType GenericParameterDataContractCriticalHelper GenericParameterDataContractCriticalHelper GenericParameterDataContractCriticalHelper Pointer )

            return value;
        }
    }
}
