using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 KeyName                                  string IL2CPP_TYPE_STRING
    // 000 ValueName                                string IL2CPP_TYPE_STRING
    // 000 ReflectionObjectPerType                  ThreadSafeStore`2<Type, ReflectionObject> IL2CPP_TYPE_GENERICINST
    public partial class KeyValuePairConverter
    {

        public static KeyValuePairConverter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new KeyValuePairConverter();


            return value;
        }
    }
}
