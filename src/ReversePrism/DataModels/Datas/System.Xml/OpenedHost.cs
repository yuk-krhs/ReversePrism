using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 NonCachedConnectionsCount                ModelPrimitiveType int int int Int32
    public partial class OpenedHost : DataModel
    {
        public int                                      NonCachedConnectionsCount               { get; set; }

        public static OpenedHost? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new OpenedHost() { Pointer= p0 };

            value.NonCachedConnectionsCount                 = GetInt32(new IntPtr(p + 0x010)); // 0x10 NonCachedConnectionsCount   ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
