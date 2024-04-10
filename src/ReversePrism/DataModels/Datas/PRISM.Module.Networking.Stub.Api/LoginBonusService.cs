using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 __ServiceName                            string IL2CPP_TYPE_STRING
    // 008 __Marshaller_api_ExecuteLoginBonusArgs   Marshaller`1<ExecuteLoginBonusArgs> IL2CPP_TYPE_GENERICINST
    // 010 __Marshaller_api_ExecuteLoginBonusReply  Marshaller`1<ExecuteLoginBonusReply> IL2CPP_TYPE_GENERICINST
    // 018 __Method_ExecuteLoginBonus               Method`2<ExecuteLoginBonusArgs, ExecuteLoginBonusReply> IL2CPP_TYPE_GENERICINST
    public partial class LoginBonusService : DataModel
    {

        public static LoginBonusService? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LoginBonusService() { Pointer= p0 };


            return value;
        }
    }
}
