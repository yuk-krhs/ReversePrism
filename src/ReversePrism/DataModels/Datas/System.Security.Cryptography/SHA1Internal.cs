using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 H                                        000185B83830 ModelPrimitiveListType uint[] uint[] List<uint> Pointer
    // 018 Count                                    00018669B890 ModelPrimitiveType ulong ulong ulong UInt64
    // 020 ProcessingBuffer                         000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 028 ProcessingBufferCount                    0001865F2AF0 ModelPrimitiveType int int int Int32
    // 030 Buff                                     000185B83830 ModelPrimitiveListType uint[] uint[] List<uint> Pointer
    public partial class SHA1Internal
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
            var value   = new SHA1Internal();

            value.H                                         = GetUInt32List(new IntPtr(p + 0x010)); // 027003E1D420 0x10 H                           ( 000185B83830 ModelPrimitiveListType uint[] uint[] List<uint> Pointer )
            value.Count                                     = GetUInt64(new IntPtr(p + 0x018)); // 027003E1D440 0x18 Count                       ( 00018669B890 ModelPrimitiveType ulong ulong ulong UInt64 )
            value.ProcessingBuffer                          = GetSByteList(new IntPtr(p + 0x020)); // 027003E1D460 0x20 ProcessingBuffer            ( 000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.ProcessingBufferCount                     = GetInt32(new IntPtr(p + 0x028)); // 027003E1D480 0x28 ProcessingBufferCount       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Buff                                      = GetUInt32List(new IntPtr(p + 0x030)); // 027003E1D4A0 0x30 Buff                        ( 000185B83830 ModelPrimitiveListType uint[] uint[] List<uint> Pointer )

            return value;
        }
    }
}
