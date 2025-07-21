using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 028 H                                        ModelPrimitiveListType uint[] uint[] List<uint> Pointer
    // 030 Buff                                     ModelPrimitiveListType uint[] uint[] List<uint> Pointer
    // 038 Count                                    ModelPrimitiveType ulong ulong ulong UInt64
    // 040 ProcessingBuffer                         ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 048 ProcessingBufferCount                    ModelPrimitiveType int int int Int32
    // 000 K                                        uint[] IL2CPP_TYPE_SZARRAY
    public partial class MD5CryptoServiceProvider : DataModel
    {
        public List<uint>?                              H                                       { get; set; }
        public List<uint>?                              Buff                                    { get; set; }
        public ulong                                    Count                                   { get; set; }
        public List<sbyte>?                             ProcessingBuffer                        { get; set; }
        public int                                      ProcessingBufferCount                   { get; set; }

        public static MD5CryptoServiceProvider? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MD5CryptoServiceProvider() { Pointer= p0 };

            value.H                                         = GetUInt32List(new IntPtr(p + 0x028)); // 0x28 H                           ( ModelPrimitiveListType uint[] uint[] List<uint> Pointer )
            value.Buff                                      = GetUInt32List(new IntPtr(p + 0x030)); // 0x30 Buff                        ( ModelPrimitiveListType uint[] uint[] List<uint> Pointer )
            value.Count                                     = GetUInt64(new IntPtr(p + 0x038)); // 0x38 Count                       ( ModelPrimitiveType ulong ulong ulong UInt64 )
            value.ProcessingBuffer                          = GetSByteList(new IntPtr(p + 0x040)); // 0x40 ProcessingBuffer            ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.ProcessingBufferCount                     = GetInt32(new IntPtr(p + 0x048)); // 0x48 ProcessingBufferCount       ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
