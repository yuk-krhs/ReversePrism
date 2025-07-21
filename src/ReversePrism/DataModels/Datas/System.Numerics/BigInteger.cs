using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Sign                                     ModelPrimitiveType int int int Int32
    // 018 Bits                                     ModelPrimitiveListType uint[] uint[] List<uint> Pointer
    // 000 s_bnMinInt                               BigInteger IL2CPP_TYPE_VALUETYPE
    // 010 S_bnOneInt                               ModelEnumType BigInteger BigInteger BigInteger Int32
    // 020 S_bnZeroInt                              ModelEnumType BigInteger BigInteger BigInteger Int32
    // 030 S_bnMinusOneInt                          ModelEnumType BigInteger BigInteger BigInteger Int32
    // 040 S_success                                ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
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

            value.Sign                                      = GetInt32(new IntPtr(p + 0x010)); // 0x10 Sign                        ( ModelPrimitiveType int int int Int32 )
            value.Bits                                      = GetUInt32List(new IntPtr(p + 0x018)); // 0x18 Bits                        ( ModelPrimitiveListType uint[] uint[] List<uint> Pointer )
            value.S_bnOneInt                                = (BigInteger)GetInt32(new IntPtr(p + 0x010)); // 0x10 S_bnOneInt                  ( ModelEnumType BigInteger BigInteger BigInteger Int32 )
            value.S_bnZeroInt                               = (BigInteger)GetInt32(new IntPtr(p + 0x020)); // 0x20 S_bnZeroInt                 ( ModelEnumType BigInteger BigInteger BigInteger Int32 )
            value.S_bnMinusOneInt                           = (BigInteger)GetInt32(new IntPtr(p + 0x030)); // 0x30 S_bnMinusOneInt             ( ModelEnumType BigInteger BigInteger BigInteger Int32 )
            value.S_success                                 = GetSByteList(new IntPtr(p + 0x040)); // 0x40 S_success                   ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )

            return value;
        }
    }
}
