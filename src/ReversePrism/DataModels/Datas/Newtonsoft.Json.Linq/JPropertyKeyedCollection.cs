using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 Comparer                                 IEqualityComparer`1<string> IL2CPP_TYPE_GENERICINST
    // 018 _dictionary                              Dictionary`2<string, JToken> IL2CPP_TYPE_GENERICINST
    public partial class JPropertyKeyedCollection
    {

        public static JPropertyKeyedCollection? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new JPropertyKeyedCollection();


            return value;
        }
    }
}
