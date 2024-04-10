using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 CachedPowersDecimalExponentDistance      int IL2CPP_TYPE_I4
    // 000 CachedPowersMinDecimalExponent           int IL2CPP_TYPE_I4
    // 000 CachedPowersPowerMaxDecimalExponent      int IL2CPP_TYPE_I4
    // 000 CachedPowersOffset                       int IL2CPP_TYPE_I4
    // 000 D1Log210                                 double IL2CPP_TYPE_R8
    // 000 MaximalTargetExponent                    int IL2CPP_TYPE_I4
    // 000 MinimalTargetExponent                    int IL2CPP_TYPE_I4
    // 000 s_CachedPowersBinaryExponent             short[] IL2CPP_TYPE_SZARRAY
    // 008 s_CachedPowersDecimalExponent            short[] IL2CPP_TYPE_SZARRAY
    // 010 S_CachedPowersSignificand                000185B84A20 ModelPrimitiveListType ulong[] ulong[] List<ulong> Pointer
    // 018 S_SmallPowersOfTen                       000185B83E90 ModelPrimitiveListType uint[] uint[] List<uint> Pointer
    public partial class Grisu3 : DataModel
    {
        public List<ulong>?                             S_CachedPowersSignificand               { get; set; }
        public List<uint>?                              S_SmallPowersOfTen                      { get; set; }

        public static Grisu3? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Grisu3() { Pointer= p0 };

            value.S_CachedPowersSignificand                 = GetUInt64List(new IntPtr(p + 0x010)); // 02466AB841C0 0x10 S_CachedPowersSignificand   ( 000185B84A20 ModelPrimitiveListType ulong[] ulong[] List<ulong> Pointer )
            value.S_SmallPowersOfTen                        = GetUInt32List(new IntPtr(p + 0x018)); // 02466AB841E0 0x18 S_SmallPowersOfTen          ( 000185B83E90 ModelPrimitiveListType uint[] uint[] List<uint> Pointer )

            return value;
        }
    }
}
