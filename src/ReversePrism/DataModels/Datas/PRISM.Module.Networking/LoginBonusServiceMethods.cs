using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 ExecuteLoginBonus                        Method`2<IExecuteLoginBonusArgs, IExecuteLoginBonusReply> IL2CPP_TYPE_GENERICINST
    public partial class LoginBonusServiceMethods
    {

        public static LoginBonusServiceMethods? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LoginBonusServiceMethods();


            return value;
        }
    }
}
