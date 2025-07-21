using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 090 EpisodeData                              ModelClassType IEpisodeStatus IEpisodeStatus IEpisodeStatus Pointer
    // 098 Difficulty                               ModelEnumType ProduceDifficultyType ProduceDifficultyType ProduceDifficultyType Int32
    // 0A0 FriendIcon                               ModelClassType SCharaIcon SCharaIcon SCharaIcon Pointer
    // 0A8 InheritanceUnitIcon                      ModelClassType FUnitIcon FUnitIcon FUnitIcon Pointer
    // 0B0 InheritanceUnit                          ModelClassType IFesUnitStatus IFesUnitStatus IFesUnitStatus Pointer
    // 0B8 StaminaModel                             ModelClassType StaminaModel StaminaModel StaminaModel Pointer
    // 0C0 IsAutoPlay                               ModelPrimitiveType bool bool bool Bool
    // 0C8 StaminaUsageValueGetter                  ModelClassType IProduceStaminaUsageGetter IProduceStaminaUsageGetter IProduceStaminaUsageGetter Pointer
    public partial class ProducePreparationConfirmPopupParam : DataModel
    {
        public IEpisodeStatus?                          EpisodeData                             { get; set; }
        public ProduceDifficultyType                    Difficulty                              { get; set; }
        public SCharaIcon?                              FriendIcon                              { get; set; }
        public FUnitIcon?                               InheritanceUnitIcon                     { get; set; }
        public IFesUnitStatus?                          InheritanceUnit                         { get; set; }
        public StaminaModel?                            StaminaModel                            { get; set; }
        public bool                                     IsAutoPlay                              { get; set; }
        public IProduceStaminaUsageGetter?              StaminaUsageValueGetter                 { get; set; }

        public static ProducePreparationConfirmPopupParam? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProducePreparationConfirmPopupParam() { Pointer= p0 };

            value.EpisodeData                               = GetObject<IEpisodeStatus>(new IntPtr(p + 0x090), ReversePrism.DataModels.IEpisodeStatus.FromPointer); // 0x90 EpisodeData                 ( ModelClassType IEpisodeStatus IEpisodeStatus IEpisodeStatus Pointer )
            value.Difficulty                                = (ProduceDifficultyType)GetInt32(new IntPtr(p + 0x098)); // 0x98 Difficulty                  ( ModelEnumType ProduceDifficultyType ProduceDifficultyType ProduceDifficultyType Int32 )
            value.FriendIcon                                = GetObject<SCharaIcon>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.SCharaIcon.FromPointer); // 0xA0 FriendIcon                  ( ModelClassType SCharaIcon SCharaIcon SCharaIcon Pointer )
            value.InheritanceUnitIcon                       = GetObject<FUnitIcon>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.FUnitIcon.FromPointer); // 0xA8 InheritanceUnitIcon         ( ModelClassType FUnitIcon FUnitIcon FUnitIcon Pointer )
            value.InheritanceUnit                           = GetObject<IFesUnitStatus>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.IFesUnitStatus.FromPointer); // 0xB0 InheritanceUnit             ( ModelClassType IFesUnitStatus IFesUnitStatus IFesUnitStatus Pointer )
            value.StaminaModel                              = GetObject<StaminaModel>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.StaminaModel.FromPointer); // 0xB8 StaminaModel                ( ModelClassType StaminaModel StaminaModel StaminaModel Pointer )
            value.IsAutoPlay                                = GetBool(new IntPtr(p + 0x0C0)); // 0xC0 IsAutoPlay                  ( ModelPrimitiveType bool bool bool Bool )
            value.StaminaUsageValueGetter                   = GetObject<IProduceStaminaUsageGetter>(new IntPtr(p + 0x0C8), ReversePrism.DataModels.IProduceStaminaUsageGetter.FromPointer); // 0xC8 StaminaUsageValueGetter     ( ModelClassType IProduceStaminaUsageGetter IProduceStaminaUsageGetter IProduceStaminaUsageGetter Pointer )

            return value;
        }
    }
}
