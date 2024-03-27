using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 InsecureInstance                         ServerCredentials IL2CPP_TYPE_CLASS
    public partial class ServerCredentials
    {

        public static ServerCredentials? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ServerCredentials();


            return value;
        }
    }
}
