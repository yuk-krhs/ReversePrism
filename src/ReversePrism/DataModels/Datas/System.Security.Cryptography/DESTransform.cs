using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 KEY_BIT_SIZE                             int IL2CPP_TYPE_I4
    // 004 KEY_BYTE_SIZE                            int IL2CPP_TYPE_I4
    // 008 BLOCK_BIT_SIZE                           int IL2CPP_TYPE_I4
    // 00C BLOCK_BYTE_SIZE                          int IL2CPP_TYPE_I4
    // 058 KeySchedule                              000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 060 ByteBuff                                 000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 068 DwordBuff                                000185B83830 ModelPrimitiveListType uint[] uint[] List<uint> Pointer
    // 010 SpBoxes                                  000185B83E90 ModelPrimitiveListType uint[] uint[] List<uint> Pointer
    // 018 PC1                                      000185B7A290 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 020 LeftRotTotal                             000185B7A290 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 028 PC2                                      000185B7A290 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 030 IpTab                                    000185B83FB0 ModelPrimitiveListType uint[] uint[] List<uint> Pointer
    // 038 FpTab                                    000185B83FB0 ModelPrimitiveListType uint[] uint[] List<uint> Pointer
    public partial class DESTransform : DataModel
    {
        public List<sbyte>?                             KeySchedule                             { get; set; }
        public List<sbyte>?                             ByteBuff                                { get; set; }
        public List<uint>?                              DwordBuff                               { get; set; }
        public List<uint>?                              SpBoxes                                 { get; set; }
        public List<sbyte>?                             PC1                                     { get; set; }
        public List<sbyte>?                             LeftRotTotal                            { get; set; }
        public List<sbyte>?                             PC2                                     { get; set; }
        public List<uint>?                              IpTab                                   { get; set; }
        public List<uint>?                              FpTab                                   { get; set; }

        public static DESTransform? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DESTransform() { Pointer= p0 };

            value.KeySchedule                               = GetSByteList(new IntPtr(p + 0x058)); // 024666C286F0 0x58 KeySchedule                 ( 000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.ByteBuff                                  = GetSByteList(new IntPtr(p + 0x060)); // 024666C28710 0x60 ByteBuff                    ( 000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.DwordBuff                                 = GetUInt32List(new IntPtr(p + 0x068)); // 024666C28730 0x68 DwordBuff                   ( 000185B83830 ModelPrimitiveListType uint[] uint[] List<uint> Pointer )
            value.SpBoxes                                   = GetUInt32List(new IntPtr(p + 0x010)); // 024666C28750 0x10 SpBoxes                     ( 000185B83E90 ModelPrimitiveListType uint[] uint[] List<uint> Pointer )
            value.PC1                                       = GetSByteList(new IntPtr(p + 0x018)); // 024666C28770 0x18 PC1                         ( 000185B7A290 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.LeftRotTotal                              = GetSByteList(new IntPtr(p + 0x020)); // 024666C28790 0x20 LeftRotTotal                ( 000185B7A290 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.PC2                                       = GetSByteList(new IntPtr(p + 0x028)); // 024666C287B0 0x28 PC2                         ( 000185B7A290 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.IpTab                                     = GetUInt32List(new IntPtr(p + 0x030)); // 024666C287D0 0x30 IpTab                       ( 000185B83FB0 ModelPrimitiveListType uint[] uint[] List<uint> Pointer )
            value.FpTab                                     = GetUInt32List(new IntPtr(p + 0x038)); // 024666C287F0 0x38 FpTab                       ( 000185B83FB0 ModelPrimitiveListType uint[] uint[] List<uint> Pointer )

            return value;
        }
    }
}
