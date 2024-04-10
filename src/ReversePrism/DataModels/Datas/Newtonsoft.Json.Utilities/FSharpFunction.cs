using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 _instance                                <object> IL2CPP_TYPE_OBJECT
    // 018 _invoker                                 MethodCall`2<<object>, <object>> IL2CPP_TYPE_GENERICINST
    public partial class FSharpFunction : DataModel
    {

        public static FSharpFunction? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FSharpFunction() { Pointer= p0 };


            return value;
        }
    }
}
