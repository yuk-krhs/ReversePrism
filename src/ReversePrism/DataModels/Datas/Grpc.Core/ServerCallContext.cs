using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 userState                                Dictionary`2<<object>, <object>> IL2CPP_TYPE_GENERICINST
    public partial class ServerCallContext : DataModel
    {

        public static ServerCallContext? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ServerCallContext() { Pointer= p0 };


            return value;
        }
    }
}
