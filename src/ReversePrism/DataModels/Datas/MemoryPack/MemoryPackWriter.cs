using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 DepthLimit                               int IL2CPP_TYPE_I4
    // 010 bufferWriter                             IBufferWriter`1<sbyte> IL2CPP_TYPE_GENERICINST
    // 018 bufferReference                          Span`1<sbyte> IL2CPP_TYPE_GENERICINST
    // 028 BufferLength                             0001865F2AF0 ModelPrimitiveType int int int Int32
    // 02C AdvancedCount                            0001865F2AF0 ModelPrimitiveType int int int Int32
    // 030 Depth                                    0001865F2AF0 ModelPrimitiveType int int int Int32
    // 034 WrittenCount                             0001865F2AF0 ModelPrimitiveType int int int Int32
    // 038 SerializeStringAsUtf8                    0001865965D0 ModelPrimitiveType bool bool bool Bool
    // 040 OptionalState                            0001865FA4C0 ModelClassType MemoryPackWriterOptionalState MemoryPackWriterOptionalState MemoryPackWriterOptionalState Pointer
    public partial class MemoryPackWriter
    {
        public int                                      BufferLength                            { get; set; }
        public int                                      AdvancedCount                           { get; set; }
        public int                                      Depth                                   { get; set; }
        public int                                      WrittenCount                            { get; set; }
        public bool                                     SerializeStringAsUtf8                   { get; set; }
        public MemoryPackWriterOptionalState?           OptionalState                           { get; set; }

        public static MemoryPackWriter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MemoryPackWriter();

            value.BufferLength                              = GetInt32(new IntPtr(p + 0x028)); // 0270DAAA2300 0x28 BufferLength                ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.AdvancedCount                             = GetInt32(new IntPtr(p + 0x02C)); // 0270DAAA2320 0x2C AdvancedCount               ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Depth                                     = GetInt32(new IntPtr(p + 0x030)); // 0270DAAA2340 0x30 Depth                       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.WrittenCount                              = GetInt32(new IntPtr(p + 0x034)); // 0270DAAA2360 0x34 WrittenCount                ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.SerializeStringAsUtf8                     = GetBool(new IntPtr(p + 0x038)); // 0270DAAA2380 0x38 SerializeStringAsUtf8       ( 0001865965D0 ModelPrimitiveType bool bool bool Bool )
            value.OptionalState                             = GetObject<MemoryPackWriterOptionalState>(new IntPtr(p + 0x040), ReversePrism.DataModels.MemoryPackWriterOptionalState.FromPointer); // 0270DAAA23A0 0x40 OptionalState               ( 0001865FA4C0 ModelClassType MemoryPackWriterOptionalState MemoryPackWriterOptionalState MemoryPackWriterOptionalState Pointer )

            return value;
        }
    }
}
