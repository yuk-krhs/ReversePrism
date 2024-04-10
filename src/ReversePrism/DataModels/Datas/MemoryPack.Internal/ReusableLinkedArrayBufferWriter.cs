using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 InitialBufferSize                        int IL2CPP_TYPE_I4
    // 000 noUseFirstBufferSentinel                 sbyte[] IL2CPP_TYPE_SZARRAY
    // 010 Buffers                                  000185CD00E8 ModelEnumListType List`1<BufferSegment> List`1<BufferSegment> List<BufferSegment> Pointer
    // 018 FirstBuffer                              000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 020 FirstBufferWritten                       0001865F2AF0 ModelPrimitiveType int int int Int32
    // 028 Current                                  00018650AEB0 ModelEnumType BufferSegment BufferSegment BufferSegment Int32
    // 038 NextBufferSize                           0001865F2AF0 ModelPrimitiveType int int int Int32
    // 03C TotalWritten                             0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class ReusableLinkedArrayBufferWriter : DataModel
    {
        public List<BufferSegment>?                     Buffers                                 { get; set; }
        public List<sbyte>?                             FirstBuffer                             { get; set; }
        public int                                      FirstBufferWritten                      { get; set; }
        public BufferSegment                            Current                                 { get; set; }
        public int                                      NextBufferSize                          { get; set; }
        public int                                      TotalWritten                            { get; set; }

        public static ReusableLinkedArrayBufferWriter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ReusableLinkedArrayBufferWriter() { Pointer= p0 };

            value.Buffers                                   = GetEnumList<BufferSegment>(new IntPtr(p + 0x010)); // 02466AFA2218 0x10 Buffers                     ( 000185CD00E8 ModelEnumListType List`1<BufferSegment> List`1<BufferSegment> List<BufferSegment> Pointer )
            value.FirstBuffer                               = GetSByteList(new IntPtr(p + 0x018)); // 02466AFA2238 0x18 FirstBuffer                 ( 000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.FirstBufferWritten                        = GetInt32(new IntPtr(p + 0x020)); // 02466AFA2258 0x20 FirstBufferWritten          ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Current                                   = (BufferSegment)GetInt32(new IntPtr(p + 0x028)); // 02466AFA2278 0x28 Current                     ( 00018650AEB0 ModelEnumType BufferSegment BufferSegment BufferSegment Int32 )
            value.NextBufferSize                            = GetInt32(new IntPtr(p + 0x038)); // 02466AFA2298 0x38 NextBufferSize              ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.TotalWritten                              = GetInt32(new IntPtr(p + 0x03C)); // 02466AFA22B8 0x3C TotalWritten                ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
