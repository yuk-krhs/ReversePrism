using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 InnerSurrogate                           000186636940 ModelClassType ISerializationSurrogate ISerializationSurrogate ISerializationSurrogate Pointer
    public partial class SurrogateForCyclicalReference
    {
        public ISerializationSurrogate?                 InnerSurrogate                          { get; set; }

        public static SurrogateForCyclicalReference? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SurrogateForCyclicalReference();

            value.InnerSurrogate                            = GetObject<ISerializationSurrogate>(new IntPtr(p + 0x010), ReversePrism.DataModels.ISerializationSurrogate.FromPointer); // 0270D6C1CFB8 0x10 InnerSurrogate              ( 000186636940 ModelClassType ISerializationSurrogate ISerializationSurrogate ISerializationSurrogate Pointer )

            return value;
        }
    }
}
