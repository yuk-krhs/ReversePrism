using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 s_cache                                  ConcurrentDictionary`2<Type, SerializationEvents> IL2CPP_TYPE_GENERICINST
    public partial class SerializationEventsCache : DataModel
    {

        public static SerializationEventsCache? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SerializationEventsCache() { Pointer= p0 };


            return value;
        }
    }
}
