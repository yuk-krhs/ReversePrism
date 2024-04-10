using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 SystemMaxDBCSCharSize                    int IL2CPP_TYPE_I4
    // 004 SystemDefaultCharSize                    int IL2CPP_TYPE_I4
    // 008 MarshalerInstanceCache                   Dictionary`2<ValueTuple`2<Type, string>, ICustomMarshaler> IL2CPP_TYPE_GENERICINST
    // 010 MarshalerInstanceCacheLock               <object> IL2CPP_TYPE_OBJECT
    public partial class Marshal : DataModel
    {

        public static Marshal? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Marshal() { Pointer= p0 };


            return value;
        }
    }
}
