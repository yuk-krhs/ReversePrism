using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Sign                                     0001865F44E0 ModelPrimitiveType int int int Int32
    // 018 Bits                                     000185B83D70 ModelPrimitiveListType uint[] uint[] List<uint> Pointer
    // 000 s_bnMinInt                               BigInteger IL2CPP_TYPE_VALUETYPE
    // 010 S_bnOneInt                               000186592310 ModelEnumType BigInteger BigInteger BigInteger Int32
    // 020 S_bnZeroInt                              000186592310 ModelEnumType BigInteger BigInteger BigInteger Int32
    // 030 S_bnMinusOneInt                          000186592310 ModelEnumType BigInteger BigInteger BigInteger Int32
    // 040 S_success                                000185B7A290 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    public partial class BigInteger : DataModel
    {
        public int                                      Sign                                    { get; set; }
        public List<uint>?                              Bits                                    { get; set; }
        public BigInteger                               S_bnOneInt                              { get; set; }
        public BigInteger                               S_bnZeroInt                             { get; set; }
        public BigInteger                               S_bnMinusOneInt                         { get; set; }
        public List<sbyte>?                             S_success                               { get; set; }

        public static BigInteger? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BigInteger() { Pointer= p0 };

            value.Sign                                      = GetInt32(new IntPtr(p + 0x010)); // 0245A44E5F08 0x10 Sign                        ( 0001865F44E0 ModelPrimitiveType int int int Int32 )
            value.Bits                                      = GetUInt32List(new IntPtr(p + 0x018)); // 0245A44E5F28 0x18 Bits                        ( 000185B83D70 ModelPrimitiveListType uint[] uint[] List<uint> Pointer )
            value.S_bnOneInt                                = (BigInteger)GetInt32(new IntPtr(p + 0x010)); // 0245A44E5F68 0x10 S_bnOneInt                  ( 000186592310 ModelEnumType BigInteger BigInteger BigInteger Int32 )
            value.S_bnZeroInt                               = (BigInteger)GetInt32(new IntPtr(p + 0x020)); // 0245A44E5F88 0x20 S_bnZeroInt                 ( 000186592310 ModelEnumType BigInteger BigInteger BigInteger Int32 )
            value.S_bnMinusOneInt                           = (BigInteger)GetInt32(new IntPtr(p + 0x030)); // 0245A44E5FA8 0x30 S_bnMinusOneInt             ( 000186592310 ModelEnumType BigInteger BigInteger BigInteger Int32 )
            value.S_success                                 = GetSByteList(new IntPtr(p + 0x040)); // 0245A44E5FC8 0x40 S_success                   ( 000185B7A290 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )

            return value;
        }
    }
}
