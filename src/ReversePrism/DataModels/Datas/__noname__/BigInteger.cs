using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 BitsForLongestBinaryMantissa             int IL2CPP_TYPE_I4
    // 000 BitsForLongestDigitSequence              int IL2CPP_TYPE_I4
    // 000 MaxBits                                  int IL2CPP_TYPE_I4
    // 000 BitsPerBlock                             int IL2CPP_TYPE_I4
    // 000 MaxBlockCount                            int IL2CPP_TYPE_I4
    // 000 s_Pow10UInt32Table                       uint[] IL2CPP_TYPE_SZARRAY
    // 008 s_Pow10BigNumTableIndices                int[] IL2CPP_TYPE_SZARRAY
    // 010 S_Pow10BigNumTable                       000185B83E90 ModelPrimitiveListType uint[] uint[] List<uint> Pointer
    // 010 Length                                   0001865F2AF0 ModelPrimitiveType int int int Int32
    // 014 Blocks                                   000186566240 ModelEnumType <_blocks>e__FixedBuffer <_blocks>e__FixedBuffer <_blocks>e__FixedBuffer Int32
    public partial class BigInteger : DataModel
    {
        public List<uint>?                              S_Pow10BigNumTable                      { get; set; }
        public int                                      Length                                  { get; set; }
        public <_blocks>e__FixedBuffer                  Blocks                                  { get; set; }

        public static BigInteger? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BigInteger() { Pointer= p0 };

            value.S_Pow10BigNumTable                        = GetUInt32List(new IntPtr(p + 0x010)); // 02466AB0F278 0x10 S_Pow10BigNumTable          ( 000185B83E90 ModelPrimitiveListType uint[] uint[] List<uint> Pointer )
            value.Length                                    = GetInt32(new IntPtr(p + 0x010)); // 02466AB0F298 0x10 Length                      ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Blocks                                    = (<_blocks>e__FixedBuffer)GetInt32(new IntPtr(p + 0x014)); // 02466AB0F2B8 0x14 Blocks                      ( 000186566240 ModelEnumType <_blocks>e__FixedBuffer <_blocks>e__FixedBuffer <_blocks>e__FixedBuffer Int32 )

            return value;
        }
    }
}
