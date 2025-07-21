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
    // 010 Buffers                                  ModelEnumListType List`1<BufferSegment> List`1<BufferSegment> List<BufferSegment> Pointer
    // 018 FirstBuffer                              ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 020 FirstBufferWritten                       ModelPrimitiveType int int int Int32
    // 028 Current                                  ModelEnumType BufferSegment BufferSegment BufferSegment Int32
    // 038 NextBufferSize                           ModelPrimitiveType int int int Int32
    // 03C TotalWritten                             ModelPrimitiveType int int int Int32
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

            value.Buffers                                   = GetEnumList<BufferSegment>(new IntPtr(p + 0x010)); // 0x10 Buffers                     ( ModelEnumListType List`1<BufferSegment> List`1<BufferSegment> List<BufferSegment> Pointer )
            value.FirstBuffer                               = GetSByteList(new IntPtr(p + 0x018)); // 0x18 FirstBuffer                 ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.FirstBufferWritten                        = GetInt32(new IntPtr(p + 0x020)); // 0x20 FirstBufferWritten          ( ModelPrimitiveType int int int Int32 )
            value.Current                                   = (BufferSegment)GetInt32(new IntPtr(p + 0x028)); // 0x28 Current                     ( ModelEnumType BufferSegment BufferSegment BufferSegment Int32 )
            value.NextBufferSize                            = GetInt32(new IntPtr(p + 0x038)); // 0x38 NextBufferSize              ( ModelPrimitiveType int int int Int32 )
            value.TotalWritten                              = GetInt32(new IntPtr(p + 0x03C)); // 0x3C TotalWritten                ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
