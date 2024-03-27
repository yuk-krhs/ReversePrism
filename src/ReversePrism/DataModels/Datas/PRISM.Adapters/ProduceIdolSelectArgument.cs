using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 EpisodeData                              000186761B50 ModelClassType IEpisodeStatus IEpisodeStatus IEpisodeStatus Pointer
    // 018 EpisodeSelectModel                       000186520000 ModelClassType ViewProducePreparationEpisodeSelectModel ViewProducePreparationEpisodeSelectModel ViewProducePreparationEpisodeSelectModel Pointer
    // 020 Difficulty                               00018660C140 ModelEnumType ProduceDifficultyType ProduceDifficultyType ProduceDifficultyType Int32
    // 024 IsAnyEpisodeCleared                      000186595960 ModelPrimitiveType bool bool bool Bool
    // 025 IsSelectUnitAnyEpisodeCleared            000186595960 ModelPrimitiveType bool bool bool Bool
    // 028 HowToPlayPopupResourceConfigRef          0001866722E0 ModelPrimitiveType string string string String
    public partial class ProduceIdolSelectArgument
    {
        public IEpisodeStatus?                          EpisodeData                             { get; set; }
        public ViewProducePreparationEpisodeSelectModel? EpisodeSelectModel                      { get; set; }
        public ProduceDifficultyType                    Difficulty                              { get; set; }
        public bool                                     IsAnyEpisodeCleared                     { get; set; }
        public bool                                     IsSelectUnitAnyEpisodeCleared           { get; set; }
        public string                                   HowToPlayPopupResourceConfigRef         { get; set; }

        public static ProduceIdolSelectArgument? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceIdolSelectArgument();

            value.EpisodeData                               = GetObject<IEpisodeStatus>(new IntPtr(p + 0x010), ReversePrism.DataModels.IEpisodeStatus.FromPointer); // 0270D655DB88 0x10 EpisodeData                 ( 000186761B50 ModelClassType IEpisodeStatus IEpisodeStatus IEpisodeStatus Pointer )
            value.EpisodeSelectModel                        = GetObject<ViewProducePreparationEpisodeSelectModel>(new IntPtr(p + 0x018), ReversePrism.DataModels.ViewProducePreparationEpisodeSelectModel.FromPointer); // 0270D655DBA8 0x18 EpisodeSelectModel          ( 000186520000 ModelClassType ViewProducePreparationEpisodeSelectModel ViewProducePreparationEpisodeSelectModel ViewProducePreparationEpisodeSelectModel Pointer )
            value.Difficulty                                = (ProduceDifficultyType)GetInt32(new IntPtr(p + 0x020)); // 0270D655DBC8 0x20 Difficulty                  ( 00018660C140 ModelEnumType ProduceDifficultyType ProduceDifficultyType ProduceDifficultyType Int32 )
            value.IsAnyEpisodeCleared                       = GetBool(new IntPtr(p + 0x024)); // 0270D655DBE8 0x24 IsAnyEpisodeCleared         ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.IsSelectUnitAnyEpisodeCleared             = GetBool(new IntPtr(p + 0x025)); // 0270D655DC08 0x25 IsSelectUnitAnyEpisodeCleared ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.HowToPlayPopupResourceConfigRef           = GetString(new IntPtr(p + 0x028)); // 0270D655DC28 0x28 HowToPlayPopupResourceConfigRef ( 0001866722E0 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
