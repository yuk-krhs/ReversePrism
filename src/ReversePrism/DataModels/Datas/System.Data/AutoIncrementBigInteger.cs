using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 Current                                  ModelEnumType BigInteger BigInteger BigInteger Int32
    // 028 Seed                                     ModelPrimitiveType long long long Int64
    // 030 Step                                     ModelEnumType BigInteger BigInteger BigInteger Int32
    public partial class AutoIncrementBigInteger : DataModel
    {
        public BigInteger                               Current                                 { get; set; }
        public long                                     Seed                                    { get; set; }
        public BigInteger                               Step                                    { get; set; }

        public static AutoIncrementBigInteger? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AutoIncrementBigInteger() { Pointer= p0 };

            value.Current                                   = (BigInteger)GetInt32(new IntPtr(p + 0x018)); // 0x18 Current                     ( ModelEnumType BigInteger BigInteger BigInteger Int32 )
            value.Seed                                      = GetInt64(new IntPtr(p + 0x028)); // 0x28 Seed                        ( ModelPrimitiveType long long long Int64 )
            value.Step                                      = (BigInteger)GetInt32(new IntPtr(p + 0x030)); // 0x30 Step                        ( ModelEnumType BigInteger BigInteger BigInteger Int32 )

            return value;
        }
    }
}
