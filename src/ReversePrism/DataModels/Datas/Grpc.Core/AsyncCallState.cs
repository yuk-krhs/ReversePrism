using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 responseHeadersAsync                     <object> IL2CPP_TYPE_OBJECT
    // 018 getStatusFunc                            <object> IL2CPP_TYPE_OBJECT
    // 020 getTrailersFunc                          <object> IL2CPP_TYPE_OBJECT
    // 028 disposeAction                            <object> IL2CPP_TYPE_OBJECT
    // 030 callbackState                            <object> IL2CPP_TYPE_OBJECT
    public partial class AsyncCallState : DataModel
    {

        public static AsyncCallState? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AsyncCallState() { Pointer= p0 };


            return value;
        }
    }
}
