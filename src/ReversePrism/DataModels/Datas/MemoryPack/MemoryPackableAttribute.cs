using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 GenerateType                             000186622530 ModelEnumType GenerateType GenerateType GenerateType Int32
    // 014 SerializeLayout                          0001867305D0 ModelEnumType SerializeLayout SerializeLayout SerializeLayout Int32
    public partial class MemoryPackableAttribute
    {
        public GenerateType                             GenerateType                            { get; set; }
        public SerializeLayout                          SerializeLayout                         { get; set; }

        public static MemoryPackableAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MemoryPackableAttribute();

            value.GenerateType                              = (GenerateType)GetInt32(new IntPtr(p + 0x010)); // 0270DAF06A18 0x10 GenerateType                ( 000186622530 ModelEnumType GenerateType GenerateType GenerateType Int32 )
            value.SerializeLayout                           = (SerializeLayout)GetInt32(new IntPtr(p + 0x014)); // 0270DAF06A38 0x14 SerializeLayout             ( 0001867305D0 ModelEnumType SerializeLayout SerializeLayout SerializeLayout Int32 )

            return value;
        }
    }
}
