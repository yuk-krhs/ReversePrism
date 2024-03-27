using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Provider                                 000186637050 ModelClassType ISerializationSurrogateProvider ISerializationSurrogateProvider ISerializationSurrogateProvider Pointer
    public partial class SurrogateProviderAdapter
    {
        public ISerializationSurrogateProvider?         Provider                                { get; set; }

        public static SurrogateProviderAdapter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SurrogateProviderAdapter();

            value.Provider                                  = GetObject<ISerializationSurrogateProvider>(new IntPtr(p + 0x010), ReversePrism.DataModels.ISerializationSurrogateProvider.FromPointer); // 0270D7D74100 0x10 Provider                    ( 000186637050 ModelClassType ISerializationSurrogateProvider ISerializationSurrogateProvider ISerializationSurrogateProvider Pointer )

            return value;
        }
    }
}
