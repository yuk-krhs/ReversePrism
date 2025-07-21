using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 H                                        ModelPrimitiveListType uint[] uint[] List<uint> Pointer
    // 018 Count                                    ModelPrimitiveType ulong ulong ulong UInt64
    // 020 ProcessingBuffer                         ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 028 ProcessingBufferCount                    ModelPrimitiveType int int int Int32
    // 030 Buff                                     ModelPrimitiveListType uint[] uint[] List<uint> Pointer
    public partial class SHA1Internal : DataModel
    {
        public List<uint>?                              H                                       { get; set; }
        public ulong                                    Count                                   { get; set; }
        public List<sbyte>?                             ProcessingBuffer                        { get; set; }
        public int                                      ProcessingBufferCount                   { get; set; }
        public List<uint>?                              Buff                                    { get; set; }

        public static SHA1Internal? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SHA1Internal() { Pointer= p0 };

            value.H                                         = GetUInt32List(new IntPtr(p + 0x010)); // 0x10 H                           ( ModelPrimitiveListType uint[] uint[] List<uint> Pointer )
            value.Count                                     = GetUInt64(new IntPtr(p + 0x018)); // 0x18 Count                       ( ModelPrimitiveType ulong ulong ulong UInt64 )
            value.ProcessingBuffer                          = GetSByteList(new IntPtr(p + 0x020)); // 0x20 ProcessingBuffer            ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.ProcessingBufferCount                     = GetInt32(new IntPtr(p + 0x028)); // 0x28 ProcessingBufferCount       ( ModelPrimitiveType int int int Int32 )
            value.Buff                                      = GetUInt32List(new IntPtr(p + 0x030)); // 0x30 Buff                        ( ModelPrimitiveListType uint[] uint[] List<uint> Pointer )

            return value;
        }
    }
}
