using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 NullState                                MemoryPackWriterOptionalState IL2CPP_TYPE_CLASS
    // 010 NextId                                   000186698B70 ModelPrimitiveType uint uint uint UInt32
    // 018 objectToRef                              Dictionary`2<<object>, uint> IL2CPP_TYPE_GENERICINST
    // 020 Options                                  0001865F8FC0 ModelClassType MemoryPackSerializerOptions MemoryPackSerializerOptions MemoryPackSerializerOptions Pointer
    public partial class MemoryPackWriterOptionalState
    {
        public uint                                     NextId                                  { get; set; }
        public MemoryPackSerializerOptions?             Options                                 { get; set; }

        public static MemoryPackWriterOptionalState? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MemoryPackWriterOptionalState();

            value.NextId                                    = GetUInt32(new IntPtr(p + 0x010)); // 0270DAF290B8 0x10 NextId                      ( 000186698B70 ModelPrimitiveType uint uint uint UInt32 )
            value.Options                                   = GetObject<MemoryPackSerializerOptions>(new IntPtr(p + 0x020), ReversePrism.DataModels.MemoryPackSerializerOptions.FromPointer); // 0270DAF290F8 0x20 Options                     ( 0001865F8FC0 ModelClassType MemoryPackSerializerOptions MemoryPackSerializerOptions MemoryPackSerializerOptions Pointer )

            return value;
        }
    }
}
