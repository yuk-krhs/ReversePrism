using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 TimestampToTicks                         double IL2CPP_TYPE_R8
    // 010 StartTimestamp                           0001865F8300 ModelPrimitiveType long long long Int64
    public partial class ValueStopwatch : DataModel
    {
        public long                                     StartTimestamp                          { get; set; }

        public static ValueStopwatch? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ValueStopwatch() { Pointer= p0 };

            value.StartTimestamp                            = GetInt64(new IntPtr(p + 0x010)); // 0245A4E56F68 0x10 StartTimestamp              ( 0001865F8300 ModelPrimitiveType long long long Int64 )

            return value;
        }
    }
}
