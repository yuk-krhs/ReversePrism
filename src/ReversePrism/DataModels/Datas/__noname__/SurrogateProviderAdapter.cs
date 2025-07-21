using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Provider                                 ModelClassType ISerializationSurrogateProvider ISerializationSurrogateProvider ISerializationSurrogateProvider Pointer
    public partial class SurrogateProviderAdapter : DataModel
    {
        public ISerializationSurrogateProvider?         Provider                                { get; set; }

        public static SurrogateProviderAdapter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SurrogateProviderAdapter() { Pointer= p0 };

            value.Provider                                  = GetObject<ISerializationSurrogateProvider>(new IntPtr(p + 0x010), ReversePrism.DataModels.ISerializationSurrogateProvider.FromPointer); // 0x10 Provider                    ( ModelClassType ISerializationSurrogateProvider ISerializationSurrogateProvider ISerializationSurrogateProvider Pointer )

            return value;
        }
    }
}
