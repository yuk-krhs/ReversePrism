using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ProduceCard                              ModelClassType IngamePCardModel IngamePCardModel IngamePCardModel Pointer
    // 018 CardEffect                               ModelClassType IngameActionEffectModel IngameActionEffectModel IngameActionEffectModel Pointer
    // 020 IsPlayer                                 ModelPrimitiveType bool bool bool Bool
    // 024 UseTiming                                ModelEnumType CardUseTiming CardUseTiming CardUseTiming Int32
    public partial class ShowProduceCardDetailParam : DataModel
    {
        public IngamePCardModel?                        ProduceCard                             { get; set; }
        public IngameActionEffectModel?                 CardEffect                              { get; set; }
        public bool                                     IsPlayer                                { get; set; }
        public CardUseTiming                            UseTiming                               { get; set; }

        public static ShowProduceCardDetailParam? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ShowProduceCardDetailParam() { Pointer= p0 };

            value.ProduceCard                               = GetObject<IngamePCardModel>(new IntPtr(p + 0x010), ReversePrism.DataModels.IngamePCardModel.FromPointer); // 0x10 ProduceCard                 ( ModelClassType IngamePCardModel IngamePCardModel IngamePCardModel Pointer )
            value.CardEffect                                = GetObject<IngameActionEffectModel>(new IntPtr(p + 0x018), ReversePrism.DataModels.IngameActionEffectModel.FromPointer); // 0x18 CardEffect                  ( ModelClassType IngameActionEffectModel IngameActionEffectModel IngameActionEffectModel Pointer )
            value.IsPlayer                                  = GetBool(new IntPtr(p + 0x020)); // 0x20 IsPlayer                    ( ModelPrimitiveType bool bool bool Bool )
            value.UseTiming                                 = (CardUseTiming)GetInt32(new IntPtr(p + 0x024)); // 0x24 UseTiming                   ( ModelEnumType CardUseTiming CardUseTiming CardUseTiming Int32 )

            return value;
        }
    }
}
