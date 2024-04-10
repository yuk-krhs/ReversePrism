using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 058 ExpandedKey                              000185B83830 ModelPrimitiveListType uint[] uint[] List<uint> Pointer
    // 060 Nk                                       0001865F2AF0 ModelPrimitiveType int int int Int32
    // 064 Nr                                       0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 Rcon                                     uint[] IL2CPP_TYPE_SZARRAY
    // 008 SBox                                     sbyte[] IL2CPP_TYPE_SZARRAY
    // 010 ISBox                                    000185B7A290 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 018 T0                                       000185B83E90 ModelPrimitiveListType uint[] uint[] List<uint> Pointer
    // 020 T1                                       000185B83E90 ModelPrimitiveListType uint[] uint[] List<uint> Pointer
    // 028 T2                                       000185B83E90 ModelPrimitiveListType uint[] uint[] List<uint> Pointer
    // 030 T3                                       000185B83E90 ModelPrimitiveListType uint[] uint[] List<uint> Pointer
    // 038 IT0                                      000185B83E90 ModelPrimitiveListType uint[] uint[] List<uint> Pointer
    // 040 IT1                                      000185B83E90 ModelPrimitiveListType uint[] uint[] List<uint> Pointer
    // 048 IT2                                      000185B83E90 ModelPrimitiveListType uint[] uint[] List<uint> Pointer
    // 050 IT3                                      000185B83E90 ModelPrimitiveListType uint[] uint[] List<uint> Pointer
    public partial class AesTransform : DataModel
    {
        public List<uint>?                              ExpandedKey                             { get; set; }
        public int                                      Nk                                      { get; set; }
        public int                                      Nr                                      { get; set; }
        public List<sbyte>?                             ISBox                                   { get; set; }
        public List<uint>?                              T0                                      { get; set; }
        public List<uint>?                              T1                                      { get; set; }
        public List<uint>?                              T2                                      { get; set; }
        public List<uint>?                              T3                                      { get; set; }
        public List<uint>?                              IT0                                     { get; set; }
        public List<uint>?                              IT1                                     { get; set; }
        public List<uint>?                              IT2                                     { get; set; }
        public List<uint>?                              IT3                                     { get; set; }

        public static AesTransform? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AesTransform() { Pointer= p0 };

            value.ExpandedKey                               = GetUInt32List(new IntPtr(p + 0x058)); // 024661952D78 0x58 ExpandedKey                 ( 000185B83830 ModelPrimitiveListType uint[] uint[] List<uint> Pointer )
            value.Nk                                        = GetInt32(new IntPtr(p + 0x060)); // 024661952D98 0x60 Nk                          ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Nr                                        = GetInt32(new IntPtr(p + 0x064)); // 024661952DB8 0x64 Nr                          ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.ISBox                                     = GetSByteList(new IntPtr(p + 0x010)); // 024661952E18 0x10 ISBox                       ( 000185B7A290 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.T0                                        = GetUInt32List(new IntPtr(p + 0x018)); // 024661952E38 0x18 T0                          ( 000185B83E90 ModelPrimitiveListType uint[] uint[] List<uint> Pointer )
            value.T1                                        = GetUInt32List(new IntPtr(p + 0x020)); // 024661952E58 0x20 T1                          ( 000185B83E90 ModelPrimitiveListType uint[] uint[] List<uint> Pointer )
            value.T2                                        = GetUInt32List(new IntPtr(p + 0x028)); // 024661952E78 0x28 T2                          ( 000185B83E90 ModelPrimitiveListType uint[] uint[] List<uint> Pointer )
            value.T3                                        = GetUInt32List(new IntPtr(p + 0x030)); // 024661952E98 0x30 T3                          ( 000185B83E90 ModelPrimitiveListType uint[] uint[] List<uint> Pointer )
            value.IT0                                       = GetUInt32List(new IntPtr(p + 0x038)); // 024661952EB8 0x38 IT0                         ( 000185B83E90 ModelPrimitiveListType uint[] uint[] List<uint> Pointer )
            value.IT1                                       = GetUInt32List(new IntPtr(p + 0x040)); // 024661952ED8 0x40 IT1                         ( 000185B83E90 ModelPrimitiveListType uint[] uint[] List<uint> Pointer )
            value.IT2                                       = GetUInt32List(new IntPtr(p + 0x048)); // 024661952EF8 0x48 IT2                         ( 000185B83E90 ModelPrimitiveListType uint[] uint[] List<uint> Pointer )
            value.IT3                                       = GetUInt32List(new IntPtr(p + 0x050)); // 024661952F18 0x50 IT3                         ( 000185B83E90 ModelPrimitiveListType uint[] uint[] List<uint> Pointer )

            return value;
        }
    }
}
