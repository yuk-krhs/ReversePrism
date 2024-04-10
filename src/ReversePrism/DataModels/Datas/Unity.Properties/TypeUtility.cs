using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 s_TypeConstructors                       ConcurrentDictionary`2<Type, ITypeConstructor> IL2CPP_TYPE_GENERICINST
    // 008 s_CreateTypeConstructor                  MethodInfo IL2CPP_TYPE_CLASS
    // 010 s_CachedResolvedName                     ConcurrentDictionary`2<Type, string> IL2CPP_TYPE_GENERICINST
    // 018 s_Builders                               ObjectPool`1<StringBuilder> IL2CPP_TYPE_GENERICINST
    // 020 syncedPoolObject                         <object> IL2CPP_TYPE_OBJECT
    public partial class TypeUtility : DataModel
    {

        public static TypeUtility? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TypeUtility() { Pointer= p0 };


            return value;
        }
    }
}
