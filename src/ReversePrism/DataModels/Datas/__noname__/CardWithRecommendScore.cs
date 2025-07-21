using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 SupportCharacter                         ModelClassType ISupportCharacterStatus ISupportCharacterStatus ISupportCharacterStatus Pointer
    // 018 Score                                    ModelPrimitiveType int int int Int32
    public partial class CardWithRecommendScore : DataModel
    {
        public ISupportCharacterStatus?                 SupportCharacter                        { get; set; }
        public int                                      Score                                   { get; set; }

        public static CardWithRecommendScore? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CardWithRecommendScore() { Pointer= p0 };

            value.SupportCharacter                          = GetObject<ISupportCharacterStatus>(new IntPtr(p + 0x010), ReversePrism.DataModels.ISupportCharacterStatus.FromPointer); // 0x10 SupportCharacter            ( ModelClassType ISupportCharacterStatus ISupportCharacterStatus ISupportCharacterStatus Pointer )
            value.Score                                     = GetInt32(new IntPtr(p + 0x018)); // 0x18 Score                       ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
