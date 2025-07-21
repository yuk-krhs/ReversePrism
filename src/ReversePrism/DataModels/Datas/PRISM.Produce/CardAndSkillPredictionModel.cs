using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Opponent                                 ModelClassType CardAndSkillPlayerPredictionModel CardAndSkillPlayerPredictionModel CardAndSkillPlayerPredictionModel Pointer
    // 018 Executor                                 ModelClassType CardAndSkillPlayerPredictionModel CardAndSkillPlayerPredictionModel CardAndSkillPlayerPredictionModel Pointer
    // 020 DisplayValue                             ModelPrimitiveType int int int Int32
    // 024 IsOverrideDisplayValue                   ModelPrimitiveType bool bool bool Bool
    public partial class CardAndSkillPredictionModel : DataModel
    {
        public CardAndSkillPlayerPredictionModel?       Opponent                                { get; set; }
        public CardAndSkillPlayerPredictionModel?       Executor                                { get; set; }
        public int                                      DisplayValue                            { get; set; }
        public bool                                     IsOverrideDisplayValue                  { get; set; }

        public static CardAndSkillPredictionModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CardAndSkillPredictionModel() { Pointer= p0 };

            value.Opponent                                  = GetObject<CardAndSkillPlayerPredictionModel>(new IntPtr(p + 0x010), ReversePrism.DataModels.CardAndSkillPlayerPredictionModel.FromPointer); // 0x10 Opponent                    ( ModelClassType CardAndSkillPlayerPredictionModel CardAndSkillPlayerPredictionModel CardAndSkillPlayerPredictionModel Pointer )
            value.Executor                                  = GetObject<CardAndSkillPlayerPredictionModel>(new IntPtr(p + 0x018), ReversePrism.DataModels.CardAndSkillPlayerPredictionModel.FromPointer); // 0x18 Executor                    ( ModelClassType CardAndSkillPlayerPredictionModel CardAndSkillPlayerPredictionModel CardAndSkillPlayerPredictionModel Pointer )
            value.DisplayValue                              = GetInt32(new IntPtr(p + 0x020)); // 0x20 DisplayValue                ( ModelPrimitiveType int int int Int32 )
            value.IsOverrideDisplayValue                    = GetBool(new IntPtr(p + 0x024)); // 0x24 IsOverrideDisplayValue      ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
