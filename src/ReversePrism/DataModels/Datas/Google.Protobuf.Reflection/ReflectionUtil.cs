using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 EmptyTypes                               Type[] IL2CPP_TYPE_SZARRAY
    // 008 <CanConvertEnumFuncToInt32Func>k__BackingField bool IL2CPP_TYPE_BOOLEAN
    public partial class ReflectionUtil : DataModel
    {

        public static ReflectionUtil? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ReflectionUtil() { Pointer= p0 };


            return value;
        }
    }
}
