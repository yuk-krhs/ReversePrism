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
    public partial class AesTransform
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
            var value   = new AesTransform();

            value.ExpandedKey                               = GetUInt32List(new IntPtr(p + 0x058)); // 0270D1997980 0x58 ExpandedKey                 ( 000185B83830 ModelPrimitiveListType uint[] uint[] List<uint> Pointer )
            value.Nk                                        = GetInt32(new IntPtr(p + 0x060)); // 0270D19979A0 0x60 Nk                          ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Nr                                        = GetInt32(new IntPtr(p + 0x064)); // 0270D19979C0 0x64 Nr                          ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.ISBox                                     = GetSByteList(new IntPtr(p + 0x010)); // 0270D1997A20 0x10 ISBox                       ( 000185B7A290 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.T0                                        = GetUInt32List(new IntPtr(p + 0x018)); // 0270D1997A40 0x18 T0                          ( 000185B83E90 ModelPrimitiveListType uint[] uint[] List<uint> Pointer )
            value.T1                                        = GetUInt32List(new IntPtr(p + 0x020)); // 0270D1997A60 0x20 T1                          ( 000185B83E90 ModelPrimitiveListType uint[] uint[] List<uint> Pointer )
            value.T2                                        = GetUInt32List(new IntPtr(p + 0x028)); // 0270D1997A80 0x28 T2                          ( 000185B83E90 ModelPrimitiveListType uint[] uint[] List<uint> Pointer )
            value.T3                                        = GetUInt32List(new IntPtr(p + 0x030)); // 0270D1997AA0 0x30 T3                          ( 000185B83E90 ModelPrimitiveListType uint[] uint[] List<uint> Pointer )
            value.IT0                                       = GetUInt32List(new IntPtr(p + 0x038)); // 0270D1997AC0 0x38 IT0                         ( 000185B83E90 ModelPrimitiveListType uint[] uint[] List<uint> Pointer )
            value.IT1                                       = GetUInt32List(new IntPtr(p + 0x040)); // 0270D1997AE0 0x40 IT1                         ( 000185B83E90 ModelPrimitiveListType uint[] uint[] List<uint> Pointer )
            value.IT2                                       = GetUInt32List(new IntPtr(p + 0x048)); // 0270D1997B00 0x48 IT2                         ( 000185B83E90 ModelPrimitiveListType uint[] uint[] List<uint> Pointer )
            value.IT3                                       = GetUInt32List(new IntPtr(p + 0x050)); // 0270D1997B20 0x50 IT3                         ( 000185B83E90 ModelPrimitiveListType uint[] uint[] List<uint> Pointer )

            return value;
        }
    }
}
