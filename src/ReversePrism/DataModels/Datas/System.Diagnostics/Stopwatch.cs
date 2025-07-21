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
    // 010 Elapsed                                  ModelPrimitiveType long long long Int64
    // 018 Started                                  ModelPrimitiveType long long long Int64
    // 020 Is_running                               ModelPrimitiveType bool bool bool Bool
    public partial class Stopwatch : DataModel
    {
        public long                                     Elapsed                                 { get; set; }
        public long                                     Started                                 { get; set; }
        public bool                                     Is_running                              { get; set; }

        public static Stopwatch? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Stopwatch() { Pointer= p0 };

            value.Elapsed                                   = GetInt64(new IntPtr(p + 0x010)); // 0x10 Elapsed                     ( ModelPrimitiveType long long long Int64 )
            value.Started                                   = GetInt64(new IntPtr(p + 0x018)); // 0x18 Started                     ( ModelPrimitiveType long long long Int64 )
            value.Is_running                                = GetBool(new IntPtr(p + 0x020)); // 0x20 Is_running                  ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
