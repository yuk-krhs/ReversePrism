using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 bufferSource                             ReadOnlySequence`1<sbyte> IL2CPP_TYPE_GENERICINST
    // 028 TotalLength                              0001865F8300 ModelPrimitiveType long long long Int64
    // 030 bufferReference                          ReadOnlySpan`1<sbyte> IL2CPP_TYPE_GENERICINST
    // 040 BufferLength                             0001865F2AF0 ModelPrimitiveType int int int Int32
    // 048 RentBuffer                               000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 050 AdvancedCount                            0001865F2AF0 ModelPrimitiveType int int int Int32
    // 054 Consumed                                 0001865F2AF0 ModelPrimitiveType int int int Int32
    // 058 OptionalState                            0001865F8420 ModelClassType MemoryPackReaderOptionalState MemoryPackReaderOptionalState MemoryPackReaderOptionalState Pointer
    public partial class MemoryPackReader
    {
        public long                                     TotalLength                             { get; set; }
        public int                                      BufferLength                            { get; set; }
        public List<sbyte>?                             RentBuffer                              { get; set; }
        public int                                      AdvancedCount                           { get; set; }
        public int                                      Consumed                                { get; set; }
        public MemoryPackReaderOptionalState?           OptionalState                           { get; set; }

        public static MemoryPackReader? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MemoryPackReader();

            value.TotalLength                               = GetInt64(new IntPtr(p + 0x028)); // 0270DAAA2480 0x28 TotalLength                 ( 0001865F8300 ModelPrimitiveType long long long Int64 )
            value.BufferLength                              = GetInt32(new IntPtr(p + 0x040)); // 0270DAAA24C0 0x40 BufferLength                ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.RentBuffer                                = GetSByteList(new IntPtr(p + 0x048)); // 0270DAAA24E0 0x48 RentBuffer                  ( 000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.AdvancedCount                             = GetInt32(new IntPtr(p + 0x050)); // 0270DAAA2500 0x50 AdvancedCount               ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Consumed                                  = GetInt32(new IntPtr(p + 0x054)); // 0270DAAA2520 0x54 Consumed                    ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.OptionalState                             = GetObject<MemoryPackReaderOptionalState>(new IntPtr(p + 0x058), ReversePrism.DataModels.MemoryPackReaderOptionalState.FromPointer); // 0270DAAA2540 0x58 OptionalState               ( 0001865F8420 ModelClassType MemoryPackReaderOptionalState MemoryPackReaderOptionalState MemoryPackReaderOptionalState Pointer )

            return value;
        }
    }
}
