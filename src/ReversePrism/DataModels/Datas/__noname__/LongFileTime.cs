using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 TicksSince1601                           0001865F79C0 ModelPrimitiveType long long long Int64
    public partial class LongFileTime : DataModel
    {
        public long                                     TicksSince1601                          { get; set; }

        public static LongFileTime? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LongFileTime() { Pointer= p0 };

            value.TicksSince1601                            = GetInt64(new IntPtr(p + 0x010)); // 0246669A1540 0x10 TicksSince1601              ( 0001865F79C0 ModelPrimitiveType long long long Int64 )

            return value;
        }
    }
}
