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
    public partial class MemoryPackWriterOptionalState : DataModel
    {
        public uint                                     NextId                                  { get; set; }
        public MemoryPackSerializerOptions?             Options                                 { get; set; }

        public static MemoryPackWriterOptionalState? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MemoryPackWriterOptionalState() { Pointer= p0 };

            value.NextId                                    = GetUInt32(new IntPtr(p + 0x010)); // 02466AF990B8 0x10 NextId                      ( 000186698B70 ModelPrimitiveType uint uint uint UInt32 )
            value.Options                                   = GetObject<MemoryPackSerializerOptions>(new IntPtr(p + 0x020), ReversePrism.DataModels.MemoryPackSerializerOptions.FromPointer); // 02466AF990F8 0x20 Options                     ( 0001865F8FC0 ModelClassType MemoryPackSerializerOptions MemoryPackSerializerOptions MemoryPackSerializerOptions Pointer )

            return value;
        }
    }
}
