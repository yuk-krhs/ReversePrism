using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Length                                   ModelPrimitiveType uint uint uint UInt32
    // 018 Data                                     ModelPrimitiveListType uint[] uint[] List<uint> Pointer
    // 000 smallPrimes                              uint[] IL2CPP_TYPE_SZARRAY
    // 008 rng                                      RandomNumberGenerator IL2CPP_TYPE_CLASS
    public partial class BigInteger : DataModel
    {
        public uint                                     Length                                  { get; set; }
        public List<uint>?                              Data                                    { get; set; }

        public static BigInteger? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BigInteger() { Pointer= p0 };

            value.Length                                    = GetUInt32(new IntPtr(p + 0x010)); // 0x10 Length                      ( ModelPrimitiveType uint uint uint UInt32 )
            value.Data                                      = GetUInt32List(new IntPtr(p + 0x018)); // 0x18 Data                        ( ModelPrimitiveListType uint[] uint[] List<uint> Pointer )

            return value;
        }
    }
}
