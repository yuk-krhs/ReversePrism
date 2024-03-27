using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_cipherMode                             0001865AD2E0 ModelEnumType CipherMode CipherMode CipherMode Int32
    // 014 M_paddingValue                           000186713390 ModelEnumType PaddingMode PaddingMode PaddingMode Int32
    // 018 M_transformMode                          0001866902D0 ModelEnumType RijndaelManagedTransformMode RijndaelManagedTransformMode RijndaelManagedTransformMode Int32
    // 01C M_blockSizeBits                          0001865F2AF0 ModelPrimitiveType int int int Int32
    // 020 M_blockSizeBytes                         0001865F2AF0 ModelPrimitiveType int int int Int32
    // 024 M_inputBlockSize                         0001865F2AF0 ModelPrimitiveType int int int Int32
    // 028 M_outputBlockSize                        0001865F2AF0 ModelPrimitiveType int int int Int32
    // 030 M_encryptKeyExpansion                    000185B7D2C0 ModelPrimitiveListType int[] int[] List<int> Pointer
    // 038 M_decryptKeyExpansion                    000185B7D2C0 ModelPrimitiveListType int[] int[] List<int> Pointer
    // 040 M_Nr                                     0001865F2AF0 ModelPrimitiveType int int int Int32
    // 044 M_Nb                                     0001865F2AF0 ModelPrimitiveType int int int Int32
    // 048 M_Nk                                     0001865F2AF0 ModelPrimitiveType int int int Int32
    // 050 M_encryptindex                           000185B7D2C0 ModelPrimitiveListType int[] int[] List<int> Pointer
    // 058 M_decryptindex                           000185B7D2C0 ModelPrimitiveListType int[] int[] List<int> Pointer
    // 060 M_IV                                     000185B7D2C0 ModelPrimitiveListType int[] int[] List<int> Pointer
    // 068 M_lastBlockBuffer                        000185B7D2C0 ModelPrimitiveListType int[] int[] List<int> Pointer
    // 070 M_depadBuffer                            000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 078 M_shiftRegister                          000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 000 s_Sbox                                   sbyte[] IL2CPP_TYPE_SZARRAY
    // 008 s_Rcon                                   int[] IL2CPP_TYPE_SZARRAY
    // 010 S_T                                      000185B7DCD0 ModelPrimitiveListType int[] int[] List<int> Pointer
    // 018 S_TF                                     000185B7DCD0 ModelPrimitiveListType int[] int[] List<int> Pointer
    // 020 S_iT                                     000185B7DCD0 ModelPrimitiveListType int[] int[] List<int> Pointer
    // 028 S_iTF                                    000185B7DCD0 ModelPrimitiveListType int[] int[] List<int> Pointer
    public partial class RijndaelManagedTransform
    {
        public CipherMode                               M_cipherMode                            { get; set; }
        public PaddingMode                              M_paddingValue                          { get; set; }
        public RijndaelManagedTransformMode             M_transformMode                         { get; set; }
        public int                                      M_blockSizeBits                         { get; set; }
        public int                                      M_blockSizeBytes                        { get; set; }
        public int                                      M_inputBlockSize                        { get; set; }
        public int                                      M_outputBlockSize                       { get; set; }
        public List<int>?                               M_encryptKeyExpansion                   { get; set; }
        public List<int>?                               M_decryptKeyExpansion                   { get; set; }
        public int                                      M_Nr                                    { get; set; }
        public int                                      M_Nb                                    { get; set; }
        public int                                      M_Nk                                    { get; set; }
        public List<int>?                               M_encryptindex                          { get; set; }
        public List<int>?                               M_decryptindex                          { get; set; }
        public List<int>?                               M_IV                                    { get; set; }
        public List<int>?                               M_lastBlockBuffer                       { get; set; }
        public List<sbyte>?                             M_depadBuffer                           { get; set; }
        public List<sbyte>?                             M_shiftRegister                         { get; set; }
        public List<int>?                               S_T                                     { get; set; }
        public List<int>?                               S_TF                                    { get; set; }
        public List<int>?                               S_iT                                    { get; set; }
        public List<int>?                               S_iTF                                   { get; set; }

        public static RijndaelManagedTransform? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RijndaelManagedTransform();

            value.M_cipherMode                              = (CipherMode)GetInt32(new IntPtr(p + 0x010)); // 0270D6B6EDE8 0x10 M_cipherMode                ( 0001865AD2E0 ModelEnumType CipherMode CipherMode CipherMode Int32 )
            value.M_paddingValue                            = (PaddingMode)GetInt32(new IntPtr(p + 0x014)); // 0270D6B6EE08 0x14 M_paddingValue              ( 000186713390 ModelEnumType PaddingMode PaddingMode PaddingMode Int32 )
            value.M_transformMode                           = (RijndaelManagedTransformMode)GetInt32(new IntPtr(p + 0x018)); // 0270D6B6EE28 0x18 M_transformMode             ( 0001866902D0 ModelEnumType RijndaelManagedTransformMode RijndaelManagedTransformMode RijndaelManagedTransformMode Int32 )
            value.M_blockSizeBits                           = GetInt32(new IntPtr(p + 0x01C)); // 0270D6B6EE48 0x1C M_blockSizeBits             ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_blockSizeBytes                          = GetInt32(new IntPtr(p + 0x020)); // 0270D6B6EE68 0x20 M_blockSizeBytes            ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_inputBlockSize                          = GetInt32(new IntPtr(p + 0x024)); // 0270D6B6EE88 0x24 M_inputBlockSize            ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_outputBlockSize                         = GetInt32(new IntPtr(p + 0x028)); // 0270D6B6EEA8 0x28 M_outputBlockSize           ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_encryptKeyExpansion                     = GetInt32List(new IntPtr(p + 0x030)); // 0270D6B6EEC8 0x30 M_encryptKeyExpansion       ( 000185B7D2C0 ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.M_decryptKeyExpansion                     = GetInt32List(new IntPtr(p + 0x038)); // 0270D6B6EEE8 0x38 M_decryptKeyExpansion       ( 000185B7D2C0 ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.M_Nr                                      = GetInt32(new IntPtr(p + 0x040)); // 0270D6B6EF08 0x40 M_Nr                        ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_Nb                                      = GetInt32(new IntPtr(p + 0x044)); // 0270D6B6EF28 0x44 M_Nb                        ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_Nk                                      = GetInt32(new IntPtr(p + 0x048)); // 0270D6B6EF48 0x48 M_Nk                        ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_encryptindex                            = GetInt32List(new IntPtr(p + 0x050)); // 0270D6B6EF68 0x50 M_encryptindex              ( 000185B7D2C0 ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.M_decryptindex                            = GetInt32List(new IntPtr(p + 0x058)); // 0270D6B6EF88 0x58 M_decryptindex              ( 000185B7D2C0 ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.M_IV                                      = GetInt32List(new IntPtr(p + 0x060)); // 0270D6B6EFA8 0x60 M_IV                        ( 000185B7D2C0 ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.M_lastBlockBuffer                         = GetInt32List(new IntPtr(p + 0x068)); // 0270D6B6EFC8 0x68 M_lastBlockBuffer           ( 000185B7D2C0 ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.M_depadBuffer                             = GetSByteList(new IntPtr(p + 0x070)); // 0270D6B6EFE8 0x70 M_depadBuffer               ( 000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.M_shiftRegister                           = GetSByteList(new IntPtr(p + 0x078)); // 0270D6B6F008 0x78 M_shiftRegister             ( 000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.S_T                                       = GetInt32List(new IntPtr(p + 0x010)); // 0270D6B6F068 0x10 S_T                         ( 000185B7DCD0 ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.S_TF                                      = GetInt32List(new IntPtr(p + 0x018)); // 0270D6B6F088 0x18 S_TF                        ( 000185B7DCD0 ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.S_iT                                      = GetInt32List(new IntPtr(p + 0x020)); // 0270D6B6F0A8 0x20 S_iT                        ( 000185B7DCD0 ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.S_iTF                                     = GetInt32List(new IntPtr(p + 0x028)); // 0270D6B6F0C8 0x28 S_iTF                       ( 000185B7DCD0 ModelPrimitiveListType int[] int[] List<int> Pointer )

            return value;
        }
    }
}
