using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 060 SerializationSurrogate                   000186636940 ModelClassType ISerializationSurrogate ISerializationSurrogate ISerializationSurrogate Pointer
    public partial class SurrogateDataContractCriticalHelper : DataModel
    {
        public ISerializationSurrogate?                 SerializationSurrogate                  { get; set; }

        public static SurrogateDataContractCriticalHelper? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SurrogateDataContractCriticalHelper() { Pointer= p0 };

            value.SerializationSurrogate                    = GetObject<ISerializationSurrogate>(new IntPtr(p + 0x060), ReversePrism.DataModels.ISerializationSurrogate.FromPointer); // 024667DD4678 0x60 SerializationSurrogate      ( 000186636940 ModelClassType ISerializationSurrogate ISerializationSurrogate ISerializationSurrogate Pointer )

            return value;
        }
    }
}
