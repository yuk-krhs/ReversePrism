using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Value                                    0001865F7700 ModelPrimitiveType long long long Int64
    // 018 Count                                    0001865F7700 ModelPrimitiveType long long long Int64
    // 020 RefValue                                 0001865F7700 ModelPrimitiveType long long long Int64
    public partial class ProfilerRecorderSample : DataModel
    {
        public long                                     Value                                   { get; set; }
        public long                                     Count                                   { get; set; }
        public long                                     RefValue                                { get; set; }

        public static ProfilerRecorderSample? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProfilerRecorderSample() { Pointer= p0 };

            value.Value                                     = GetInt64(new IntPtr(p + 0x010)); // 0245A23171D8 0x10 Value                       ( 0001865F7700 ModelPrimitiveType long long long Int64 )
            value.Count                                     = GetInt64(new IntPtr(p + 0x018)); // 0245A23171F8 0x18 Count                       ( 0001865F7700 ModelPrimitiveType long long long Int64 )
            value.RefValue                                  = GetInt64(new IntPtr(p + 0x020)); // 0245A2317218 0x20 RefValue                    ( 0001865F7700 ModelPrimitiveType long long long Int64 )

            return value;
        }
    }
}
