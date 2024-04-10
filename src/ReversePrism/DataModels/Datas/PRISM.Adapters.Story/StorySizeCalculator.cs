using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 TotalSize                                0001865F8300 ModelPrimitiveType long long long Int64
    // 018 NoVoiceSize                              0001865F8300 ModelPrimitiveType long long long Int64
    public partial class StorySizeCalculator : DataModel
    {
        public long                                     TotalSize                               { get; set; }
        public long                                     NoVoiceSize                             { get; set; }

        public static StorySizeCalculator? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StorySizeCalculator() { Pointer= p0 };

            value.TotalSize                                 = GetInt64(new IntPtr(p + 0x010)); // 0246668405D0 0x10 TotalSize                   ( 0001865F8300 ModelPrimitiveType long long long Int64 )
            value.NoVoiceSize                               = GetInt64(new IntPtr(p + 0x018)); // 0246668405F0 0x18 NoVoiceSize                 ( 0001865F8300 ModelPrimitiveType long long long Int64 )

            return value;
        }
    }
}
