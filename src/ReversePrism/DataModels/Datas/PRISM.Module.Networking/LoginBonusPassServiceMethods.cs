using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 ExecuteLoginBonusPass                    Method`2<IExecuteLoginBonusPassArgs, IExecuteLoginBonusPassReply> IL2CPP_TYPE_GENERICINST
    public partial class LoginBonusPassServiceMethods
    {

        public static LoginBonusPassServiceMethods? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LoginBonusPassServiceMethods();


            return value;
        }
    }
}
