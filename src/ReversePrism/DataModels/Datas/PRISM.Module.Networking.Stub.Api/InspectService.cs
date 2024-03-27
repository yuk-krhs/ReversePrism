using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 __ServiceName                            string IL2CPP_TYPE_STRING
    // 008 __Marshaller_api_CheckNGWordArgs         Marshaller`1<CheckNGWordArgs> IL2CPP_TYPE_GENERICINST
    // 010 __Marshaller_api_CheckNGWordReply        Marshaller`1<CheckNGWordReply> IL2CPP_TYPE_GENERICINST
    // 018 __Marshaller_api_CheckErrorArgs          Marshaller`1<CheckErrorArgs> IL2CPP_TYPE_GENERICINST
    // 020 __Marshaller_api_CheckErrorReply         Marshaller`1<CheckErrorReply> IL2CPP_TYPE_GENERICINST
    // 028 __Method_CheckNGWord                     Method`2<CheckNGWordArgs, CheckNGWordReply> IL2CPP_TYPE_GENERICINST
    // 030 __Method_CheckError                      Method`2<CheckErrorArgs, CheckErrorReply> IL2CPP_TYPE_GENERICINST
    public partial class InspectService
    {

        public static InspectService? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new InspectService();


            return value;
        }
    }
}
