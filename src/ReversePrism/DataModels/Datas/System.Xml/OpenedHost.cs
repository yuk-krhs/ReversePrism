using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 NonCachedConnectionsCount                0001865F2F90 ModelPrimitiveType int int int Int32
    public partial class OpenedHost
    {
        public int                                      NonCachedConnectionsCount               { get; set; }

        public static OpenedHost? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new OpenedHost();

            value.NonCachedConnectionsCount                 = GetInt32(new IntPtr(p + 0x010)); // 0270D74942A8 0x10 NonCachedConnectionsCount   ( 0001865F2F90 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
