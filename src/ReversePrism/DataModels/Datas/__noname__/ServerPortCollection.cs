using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Server                                   ModelClassType Server Server Server Pointer
    public partial class ServerPortCollection : DataModel
    {
        public Server?                                  Server                                  { get; set; }

        public static ServerPortCollection? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ServerPortCollection() { Pointer= p0 };

            value.Server                                    = GetObject<Server>(new IntPtr(p + 0x010), ReversePrism.DataModels.Server.FromPointer); // 0x10 Server                      ( ModelClassType Server Server Server Pointer )

            return value;
        }
    }
}
