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
    // 058 KeySchedule                              ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 060 ByteBuff                                 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 068 DwordBuff                                ModelPrimitiveListType uint[] uint[] List<uint> Pointer
    // 010 SpBoxes                                  ModelPrimitiveListType uint[] uint[] List<uint> Pointer
    // 018 PC1                                      ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 020 LeftRotTotal                             ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 028 PC2                                      ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 030 IpTab                                    ModelPrimitiveListType uint[] uint[] List<uint> Pointer
    // 038 FpTab                                    ModelPrimitiveListType uint[] uint[] List<uint> Pointer
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

            value.KeySchedule                               = GetSByteList(new IntPtr(p + 0x058)); // 0x58 KeySchedule                 ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.ByteBuff                                  = GetSByteList(new IntPtr(p + 0x060)); // 0x60 ByteBuff                    ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.DwordBuff                                 = GetUInt32List(new IntPtr(p + 0x068)); // 0x68 DwordBuff                   ( ModelPrimitiveListType uint[] uint[] List<uint> Pointer )
            value.SpBoxes                                   = GetUInt32List(new IntPtr(p + 0x010)); // 0x10 SpBoxes                     ( ModelPrimitiveListType uint[] uint[] List<uint> Pointer )
            value.PC1                                       = GetSByteList(new IntPtr(p + 0x018)); // 0x18 PC1                         ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.LeftRotTotal                              = GetSByteList(new IntPtr(p + 0x020)); // 0x20 LeftRotTotal                ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.PC2                                       = GetSByteList(new IntPtr(p + 0x028)); // 0x28 PC2                         ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.IpTab                                     = GetUInt32List(new IntPtr(p + 0x030)); // 0x30 IpTab                       ( ModelPrimitiveListType uint[] uint[] List<uint> Pointer )
            value.FpTab                                     = GetUInt32List(new IntPtr(p + 0x038)); // 0x38 FpTab                       ( ModelPrimitiveListType uint[] uint[] List<uint> Pointer )

            return value;
        }
    }
}
