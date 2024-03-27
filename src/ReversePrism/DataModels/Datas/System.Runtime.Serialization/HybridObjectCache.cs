using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 objectDictionary                         Dictionary`2<string, <object>> IL2CPP_TYPE_GENERICINST
    // 018 referencedObjectDictionary               Dictionary`2<string, <object>> IL2CPP_TYPE_GENERICINST
    public partial class HybridObjectCache
    {

        public static HybridObjectCache? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new HybridObjectCache();


            return value;
        }
    }
}
