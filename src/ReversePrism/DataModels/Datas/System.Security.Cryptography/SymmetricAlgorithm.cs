using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 BlockSizeValue                           0001865F3220 ModelPrimitiveType int int int Int32
    // 014 FeedbackSizeValue                        0001865F3220 ModelPrimitiveType int int int Int32
    // 018 IVValue                                  000185B79A50 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 020 KeyValue                                 000185B79A50 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 028 LegalBlockSizesValue                     000185B8F970 ModelClassListType KeySizes[] KeySizes[] List<KeySizes> Pointer
    // 030 LegalKeySizesValue                       000185B8F970 ModelClassListType KeySizes[] KeySizes[] List<KeySizes> Pointer
    // 038 KeySizeValue                             0001865F3220 ModelPrimitiveType int int int Int32
    // 03C ModeValue                                0001865AD570 ModelEnumType CipherMode CipherMode CipherMode Int32
    // 040 PaddingValue                             000186713600 ModelEnumType PaddingMode PaddingMode PaddingMode Int32
    public partial class SymmetricAlgorithm
    {
        public int                                      BlockSizeValue                          { get; set; }
        public int                                      FeedbackSizeValue                       { get; set; }
        public List<sbyte>?                             IVValue                                 { get; set; }
        public List<sbyte>?                             KeyValue                                { get; set; }
        public List<KeySizes>?                          LegalBlockSizesValue                    { get; set; }
        public List<KeySizes>?                          LegalKeySizesValue                      { get; set; }
        public int                                      KeySizeValue                            { get; set; }
        public CipherMode                               ModeValue                               { get; set; }
        public PaddingMode                              PaddingValue                            { get; set; }

        public static SymmetricAlgorithm? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SymmetricAlgorithm();

            value.BlockSizeValue                            = GetInt32(new IntPtr(p + 0x010)); // 0270D197ADC8 0x10 BlockSizeValue              ( 0001865F3220 ModelPrimitiveType int int int Int32 )
            value.FeedbackSizeValue                         = GetInt32(new IntPtr(p + 0x014)); // 0270D197ADE8 0x14 FeedbackSizeValue           ( 0001865F3220 ModelPrimitiveType int int int Int32 )
            value.IVValue                                   = GetSByteList(new IntPtr(p + 0x018)); // 0270D197AE08 0x18 IVValue                     ( 000185B79A50 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.KeyValue                                  = GetSByteList(new IntPtr(p + 0x020)); // 0270D197AE28 0x20 KeyValue                    ( 000185B79A50 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.LegalBlockSizesValue                      = GetObjectList<KeySizes>(new IntPtr(p + 0x028), ReversePrism.DataModels.KeySizes.FromPointer); // 0270D197AE48 0x28 LegalBlockSizesValue        ( 000185B8F970 ModelClassListType KeySizes[] KeySizes[] List<KeySizes> Pointer )
            value.LegalKeySizesValue                        = GetObjectList<KeySizes>(new IntPtr(p + 0x030), ReversePrism.DataModels.KeySizes.FromPointer); // 0270D197AE68 0x30 LegalKeySizesValue          ( 000185B8F970 ModelClassListType KeySizes[] KeySizes[] List<KeySizes> Pointer )
            value.KeySizeValue                              = GetInt32(new IntPtr(p + 0x038)); // 0270D197AE88 0x38 KeySizeValue                ( 0001865F3220 ModelPrimitiveType int int int Int32 )
            value.ModeValue                                 = (CipherMode)GetInt32(new IntPtr(p + 0x03C)); // 0270D197AEA8 0x3C ModeValue                   ( 0001865AD570 ModelEnumType CipherMode CipherMode CipherMode Int32 )
            value.PaddingValue                              = (PaddingMode)GetInt32(new IntPtr(p + 0x040)); // 0270D197AEC8 0x40 PaddingValue                ( 000186713600 ModelEnumType PaddingMode PaddingMode PaddingMode Int32 )

            return value;
        }
    }
}
