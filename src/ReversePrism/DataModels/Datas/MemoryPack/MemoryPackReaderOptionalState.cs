using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 refToObject                              Dictionary`2<uint, <object>> IL2CPP_TYPE_GENERICINST
    // 018 Options                                  ModelClassType MemoryPackSerializerOptions MemoryPackSerializerOptions MemoryPackSerializerOptions Pointer
    public partial class MemoryPackReaderOptionalState : DataModel
    {
        public MemoryPackSerializerOptions?             Options                                 { get; set; }

        public static MemoryPackReaderOptionalState? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MemoryPackReaderOptionalState() { Pointer= p0 };

            value.Options                                   = GetObject<MemoryPackSerializerOptions>(new IntPtr(p + 0x018), ReversePrism.DataModels.MemoryPackSerializerOptions.FromPointer); // 0x18 Options                     ( ModelClassType MemoryPackSerializerOptions MemoryPackSerializerOptions MemoryPackSerializerOptions Pointer )

            return value;
        }
    }
}
