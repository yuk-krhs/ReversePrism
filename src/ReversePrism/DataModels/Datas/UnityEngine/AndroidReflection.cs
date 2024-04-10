using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 s_ReflectionHelperClass                  GlobalJavaObjectRef IL2CPP_TYPE_CLASS
    // 008 s_ReflectionHelperGetConstructorID       <int> IL2CPP_TYPE_I
    // 010 s_ReflectionHelperGetMethodID            <int> IL2CPP_TYPE_I
    // 018 s_ReflectionHelperGetFieldID             <int> IL2CPP_TYPE_I
    // 020 s_ReflectionHelperGetFieldSignature      <int> IL2CPP_TYPE_I
    // 028 s_ReflectionHelperNewProxyInstance       <int> IL2CPP_TYPE_I
    // 030 s_ReflectionHelperSetNativeExceptionOnProxy <int> IL2CPP_TYPE_I
    // 038 s_FieldGetDeclaringClass                 <int> IL2CPP_TYPE_I
    public partial class AndroidReflection : DataModel
    {

        public static AndroidReflection? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AndroidReflection() { Pointer= p0 };


            return value;
        }
    }
}
