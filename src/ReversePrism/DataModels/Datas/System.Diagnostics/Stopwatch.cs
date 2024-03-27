using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 Frequency                                long IL2CPP_TYPE_I8
    // 008 IsHighResolution                         bool IL2CPP_TYPE_BOOLEAN
    // 010 Elapsed                                  0001865F7700 ModelPrimitiveType long long long Int64
    // 018 Started                                  0001865F7700 ModelPrimitiveType long long long Int64
    // 020 Is_running                               000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class Stopwatch
    {
        public long                                     Elapsed                                 { get; set; }
        public long                                     Started                                 { get; set; }
        public bool                                     Is_running                              { get; set; }

        public static Stopwatch? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Stopwatch();

            value.Elapsed                                   = GetInt64(new IntPtr(p + 0x010)); // 027003B5A190 0x10 Elapsed                     ( 0001865F7700 ModelPrimitiveType long long long Int64 )
            value.Started                                   = GetInt64(new IntPtr(p + 0x018)); // 027003B5A1B0 0x18 Started                     ( 0001865F7700 ModelPrimitiveType long long long Int64 )
            value.Is_running                                = GetBool(new IntPtr(p + 0x020)); // 027003B5A1D0 0x20 Is_running                  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
