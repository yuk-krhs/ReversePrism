using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 SplitByColon                             char[] IL2CPP_TYPE_SZARRAY
    // 008 logTable                                 sbyte[] IL2CPP_TYPE_SZARRAY
    // 010 G_PowerOf10_U32                          000185B83E90 ModelPrimitiveListType uint[] uint[] List<uint> Pointer
    // 018 InfinityString                           000185B7A290 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 020 NanString                                000185B7A290 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 000 SinglePrecision                          int IL2CPP_TYPE_I4
    // 000 DoublePrecision                          int IL2CPP_TYPE_I4
    // 000 SingleNumberBufferLength                 int IL2CPP_TYPE_I4
    // 000 DoubleNumberBufferLength                 int IL2CPP_TYPE_I4
    // 000 SinglePrecisionCustomFormat              int IL2CPP_TYPE_I4
    // 000 DoublePrecisionCustomFormat              int IL2CPP_TYPE_I4
    public partial class BurstString
    {
        public List<uint>?                              G_PowerOf10_U32                         { get; set; }
        public List<sbyte>?                             InfinityString                          { get; set; }
        public List<sbyte>?                             NanString                               { get; set; }

        public static BurstString? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BurstString();

            value.G_PowerOf10_U32                           = GetUInt32List(new IntPtr(p + 0x010)); // 0270DA8AA1B0 0x10 G_PowerOf10_U32             ( 000185B83E90 ModelPrimitiveListType uint[] uint[] List<uint> Pointer )
            value.InfinityString                            = GetSByteList(new IntPtr(p + 0x018)); // 0270DA8AA1D0 0x18 InfinityString              ( 000185B7A290 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.NanString                                 = GetSByteList(new IntPtr(p + 0x020)); // 0270DA8AA1F0 0x20 NanString                   ( 000185B7A290 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )

            return value;
        }
    }
}
