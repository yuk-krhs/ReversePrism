using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 KeySizeValue                             ModelPrimitiveType int int int Int32
    // 018 LegalKeySizesValue                       ModelClassListType KeySizes[] KeySizes[] List<KeySizes> Pointer
    public partial class AsymmetricAlgorithm : DataModel
    {
        public int                                      KeySizeValue                            { get; set; }
        public List<KeySizes>?                          LegalKeySizesValue                      { get; set; }

        public static AsymmetricAlgorithm? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AsymmetricAlgorithm() { Pointer= p0 };

            value.KeySizeValue                              = GetInt32(new IntPtr(p + 0x010)); // 0x10 KeySizeValue                ( ModelPrimitiveType int int int Int32 )
            value.LegalKeySizesValue                        = GetObjectList<KeySizes>(new IntPtr(p + 0x018), ReversePrism.DataModels.KeySizes.FromPointer); // 0x18 LegalKeySizesValue          ( ModelClassListType KeySizes[] KeySizes[] List<KeySizes> Pointer )

            return value;
        }
    }
}
