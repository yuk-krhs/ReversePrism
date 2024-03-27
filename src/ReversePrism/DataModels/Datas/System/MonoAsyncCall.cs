using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 msg                                      <object> IL2CPP_TYPE_OBJECT
    // 018 cb_method                                <int> IL2CPP_TYPE_I
    // 020 cb_target                                <object> IL2CPP_TYPE_OBJECT
    // 028 state                                    <object> IL2CPP_TYPE_OBJECT
    // 030 res                                      <object> IL2CPP_TYPE_OBJECT
    // 038 out_args                                 <object> IL2CPP_TYPE_OBJECT
    public partial class MonoAsyncCall
    {

        public static MonoAsyncCall? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MonoAsyncCall();


            return value;
        }
    }
}
