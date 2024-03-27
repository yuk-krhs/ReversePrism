using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Opponent                                 000186545540 ModelClassType CardAndSkillPlayerPredictionModel CardAndSkillPlayerPredictionModel CardAndSkillPlayerPredictionModel Pointer
    // 018 Executor                                 000186545540 ModelClassType CardAndSkillPlayerPredictionModel CardAndSkillPlayerPredictionModel CardAndSkillPlayerPredictionModel Pointer
    // 020 DisplayValue                             0001865F2AF0 ModelPrimitiveType int int int Int32
    // 024 IsOverrideDisplayValue                   000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class CardAndSkillPredictionModel
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
            var value   = new CardAndSkillPredictionModel();

            value.Opponent                                  = GetObject<CardAndSkillPlayerPredictionModel>(new IntPtr(p + 0x010), ReversePrism.DataModels.CardAndSkillPlayerPredictionModel.FromPointer); // 0270D59D80F0 0x10 Opponent                    ( 000186545540 ModelClassType CardAndSkillPlayerPredictionModel CardAndSkillPlayerPredictionModel CardAndSkillPlayerPredictionModel Pointer )
            value.Executor                                  = GetObject<CardAndSkillPlayerPredictionModel>(new IntPtr(p + 0x018), ReversePrism.DataModels.CardAndSkillPlayerPredictionModel.FromPointer); // 0270D59D8110 0x18 Executor                    ( 000186545540 ModelClassType CardAndSkillPlayerPredictionModel CardAndSkillPlayerPredictionModel CardAndSkillPlayerPredictionModel Pointer )
            value.DisplayValue                              = GetInt32(new IntPtr(p + 0x020)); // 0270D59D8130 0x20 DisplayValue                ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.IsOverrideDisplayValue                    = GetBool(new IntPtr(p + 0x024)); // 0270D59D8150 0x24 IsOverrideDisplayValue      ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
