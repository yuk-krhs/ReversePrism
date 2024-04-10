using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 GetDirectMessageList                     Method`2<IGetDirectMessageListArgs, IGetDirectMessageListReply> IL2CPP_TYPE_GENERICINST
    // 018 ReadDirectMessage                        Method`2<IReadDirectMessageArgs, IReadDirectMessageReply> IL2CPP_TYPE_GENERICINST
    public partial class DirectMessageServiceMethods : DataModel
    {

        public static DirectMessageServiceMethods? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DirectMessageServiceMethods() { Pointer= p0 };


            return value;
        }
    }
}
