using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 setValueDelegate                         Action`2<IMessage, <object>> IL2CPP_TYPE_GENERICINST
    // 028 clearDelegate                            Action`1<IMessage> IL2CPP_TYPE_GENERICINST
    // 030 hasDelegate                              Func`2<IMessage, bool> IL2CPP_TYPE_GENERICINST
    public partial class SingleFieldAccessor
    {

        public static SingleFieldAccessor? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SingleFieldAccessor();


            return value;
        }
    }
}
