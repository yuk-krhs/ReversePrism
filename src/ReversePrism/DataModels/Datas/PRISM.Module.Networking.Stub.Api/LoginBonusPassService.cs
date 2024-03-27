using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 __ServiceName                            string IL2CPP_TYPE_STRING
    // 008 __Marshaller_api_ExecuteLoginBonusPassArgs Marshaller`1<ExecuteLoginBonusPassArgs> IL2CPP_TYPE_GENERICINST
    // 010 __Marshaller_api_ExecuteLoginBonusPassReply Marshaller`1<ExecuteLoginBonusPassReply> IL2CPP_TYPE_GENERICINST
    // 018 __Method_ExecuteLoginBonusPass           Method`2<ExecuteLoginBonusPassArgs, ExecuteLoginBonusPassReply> IL2CPP_TYPE_GENERICINST
    public partial class LoginBonusPassService
    {

        public static LoginBonusPassService? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LoginBonusPassService();


            return value;
        }
    }
}
