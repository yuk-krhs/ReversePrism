using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 BlockSizeValue                           ModelPrimitiveType int int int Int32
    // 014 FeedbackSizeValue                        ModelPrimitiveType int int int Int32
    // 018 IVValue                                  ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 020 KeyValue                                 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 028 LegalBlockSizesValue                     ModelClassListType KeySizes[] KeySizes[] List<KeySizes> Pointer
    // 030 LegalKeySizesValue                       ModelClassListType KeySizes[] KeySizes[] List<KeySizes> Pointer
    // 038 KeySizeValue                             ModelPrimitiveType int int int Int32
    // 03C ModeValue                                ModelEnumType CipherMode CipherMode CipherMode Int32
    // 040 PaddingValue                             ModelEnumType PaddingMode PaddingMode PaddingMode Int32
    public partial class SymmetricAlgorithm : DataModel
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
            var value   = new SymmetricAlgorithm() { Pointer= p0 };

            value.BlockSizeValue                            = GetInt32(new IntPtr(p + 0x010)); // 0x10 BlockSizeValue              ( ModelPrimitiveType int int int Int32 )
            value.FeedbackSizeValue                         = GetInt32(new IntPtr(p + 0x014)); // 0x14 FeedbackSizeValue           ( ModelPrimitiveType int int int Int32 )
            value.IVValue                                   = GetSByteList(new IntPtr(p + 0x018)); // 0x18 IVValue                     ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.KeyValue                                  = GetSByteList(new IntPtr(p + 0x020)); // 0x20 KeyValue                    ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.LegalBlockSizesValue                      = GetObjectList<KeySizes>(new IntPtr(p + 0x028), ReversePrism.DataModels.KeySizes.FromPointer); // 0x28 LegalBlockSizesValue        ( ModelClassListType KeySizes[] KeySizes[] List<KeySizes> Pointer )
            value.LegalKeySizesValue                        = GetObjectList<KeySizes>(new IntPtr(p + 0x030), ReversePrism.DataModels.KeySizes.FromPointer); // 0x30 LegalKeySizesValue          ( ModelClassListType KeySizes[] KeySizes[] List<KeySizes> Pointer )
            value.KeySizeValue                              = GetInt32(new IntPtr(p + 0x038)); // 0x38 KeySizeValue                ( ModelPrimitiveType int int int Int32 )
            value.ModeValue                                 = (CipherMode)GetInt32(new IntPtr(p + 0x03C)); // 0x3C ModeValue                   ( ModelEnumType CipherMode CipherMode CipherMode Int32 )
            value.PaddingValue                              = (PaddingMode)GetInt32(new IntPtr(p + 0x040)); // 0x40 PaddingValue                ( ModelEnumType PaddingMode PaddingMode PaddingMode Int32 )

            return value;
        }
    }
}
