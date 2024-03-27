using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 knownTypes                               Collection`1<Type> IL2CPP_TYPE_GENERICINST
    // 018 DataContractSurrogate                    00018674A640 ModelClassType IDataContractSurrogate IDataContractSurrogate IDataContractSurrogate Pointer
    public partial class ExportOptions
    {
        public IDataContractSurrogate?                  DataContractSurrogate                   { get; set; }

        public static ExportOptions? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ExportOptions();

            value.DataContractSurrogate                     = GetObject<IDataContractSurrogate>(new IntPtr(p + 0x018), ReversePrism.DataModels.IDataContractSurrogate.FromPointer); // 0270D7CB70B8 0x18 DataContractSurrogate       ( 00018674A640 ModelClassType IDataContractSurrogate IDataContractSurrogate IDataContractSurrogate Pointer )

            return value;
        }
    }
}
