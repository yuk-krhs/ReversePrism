using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 028 H                                        000185B83830 ModelPrimitiveListType uint[] uint[] List<uint> Pointer
    // 030 Buff                                     000185B83830 ModelPrimitiveListType uint[] uint[] List<uint> Pointer
    // 038 Count                                    00018669B890 ModelPrimitiveType ulong ulong ulong UInt64
    // 040 ProcessingBuffer                         000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 048 ProcessingBufferCount                    0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 K                                        uint[] IL2CPP_TYPE_SZARRAY
    public partial class MD5CryptoServiceProvider
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
            var value   = new MD5CryptoServiceProvider();

            value.H                                         = GetUInt32List(new IntPtr(p + 0x028)); // 027003D05D78 0x28 H                           ( 000185B83830 ModelPrimitiveListType uint[] uint[] List<uint> Pointer )
            value.Buff                                      = GetUInt32List(new IntPtr(p + 0x030)); // 027003D05D98 0x30 Buff                        ( 000185B83830 ModelPrimitiveListType uint[] uint[] List<uint> Pointer )
            value.Count                                     = GetUInt64(new IntPtr(p + 0x038)); // 027003D05DB8 0x38 Count                       ( 00018669B890 ModelPrimitiveType ulong ulong ulong UInt64 )
            value.ProcessingBuffer                          = GetSByteList(new IntPtr(p + 0x040)); // 027003D05DD8 0x40 ProcessingBuffer            ( 000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.ProcessingBufferCount                     = GetInt32(new IntPtr(p + 0x048)); // 027003D05DF8 0x48 ProcessingBufferCount       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
