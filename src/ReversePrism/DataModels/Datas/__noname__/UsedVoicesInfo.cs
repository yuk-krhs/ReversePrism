using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 NumUsedVoices                            0001865F36C0 ModelPrimitiveType int int int Int32
    // 014 NumPoolVoices                            0001865F36C0 ModelPrimitiveType int int int Int32
    public partial class UsedVoicesInfo
    {
        public int                                      NumUsedVoices                           { get; set; }
        public int                                      NumPoolVoices                           { get; set; }

        public static UsedVoicesInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UsedVoicesInfo();

            value.NumUsedVoices                             = GetInt32(new IntPtr(p + 0x010)); // 0270DAC79B80 0x10 NumUsedVoices               ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.NumPoolVoices                             = GetInt32(new IntPtr(p + 0x014)); // 0270DAC79BA0 0x14 NumPoolVoices               ( 0001865F36C0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
