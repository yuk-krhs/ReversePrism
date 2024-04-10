using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 030 SaveData                                 00018658A490 ModelClassType LiveUnitConfirmationSaveData LiveUnitConfirmationSaveData LiveUnitConfirmationSaveData Pointer
    // 038 Option                                   000186685BF0 ModelClassType RhythmGameOption RhythmGameOption RhythmGameOption Pointer
    // 040 IdolService                              000186716AD0 ModelClassType ICachedIdolService ICachedIdolService ICachedIdolService Pointer
    // 048 allLiveIdols                             IList`1<LiveIdol> IL2CPP_TYPE_GENERICINST
    // 050 parameterBonusAppliedUnits               HashSet`1<LiveUnit> IL2CPP_TYPE_GENERICINST
    // 058 EventPeriodStatus                        0001865D4260 ModelClassType IPeriodStatus IPeriodStatus IPeriodStatus Pointer
    // 060 MusicDifficulty                          00018661C990 ModelEnumType SongDifficultyLevel SongDifficultyLevel SongDifficultyLevel Int32
    // 068 LBModel                                  000186565050 ModelClassType StaminaModel StaminaModel StaminaModel Pointer
    // 070 <Units>k__BackingField                   IList`1<LiveUnit> IL2CPP_TYPE_GENERICINST
    // 078 AutoLiveStatus                           000186726BE0 ModelClassType AutoLiveStatus AutoLiveStatus AutoLiveStatus Pointer
    // 080 LiveBonusUsageSettingStatus              0001866A8B40 ModelClassType NormalLiveLiveBonusUsageSettingStatus NormalLiveLiveBonusUsageSettingStatus NormalLiveLiveBonusUsageSettingStatus Pointer
    // 088 SkipLiveStatus                           0001865178E0 ModelClassType SkipLiveStatus SkipLiveStatus SkipLiveStatus Pointer
    // 090 IsEvent                                  0001865965D0 ModelPrimitiveType bool bool bool Bool
    public partial class LiveUnitConfirmationModel : DataModel
    {
        public LiveUnitConfirmationSaveData?            SaveData                                { get; set; }
        public RhythmGameOption?                        Option                                  { get; set; }
        public ICachedIdolService?                      IdolService                             { get; set; }
        public IPeriodStatus?                           EventPeriodStatus                       { get; set; }
        public SongDifficultyLevel                      MusicDifficulty                         { get; set; }
        public StaminaModel?                            LBModel                                 { get; set; }
        public AutoLiveStatus?                          AutoLiveStatus                          { get; set; }
        public NormalLiveLiveBonusUsageSettingStatus?   LiveBonusUsageSettingStatus             { get; set; }
        public SkipLiveStatus?                          SkipLiveStatus                          { get; set; }
        public bool                                     IsEvent                                 { get; set; }

        public static LiveUnitConfirmationModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveUnitConfirmationModel() { Pointer= p0 };

            value.SaveData                                  = GetObject<LiveUnitConfirmationSaveData>(new IntPtr(p + 0x030), ReversePrism.DataModels.LiveUnitConfirmationSaveData.FromPointer); // 02466529F8A0 0x30 SaveData                    ( 00018658A490 ModelClassType LiveUnitConfirmationSaveData LiveUnitConfirmationSaveData LiveUnitConfirmationSaveData Pointer )
            value.Option                                    = GetObject<RhythmGameOption>(new IntPtr(p + 0x038), ReversePrism.DataModels.RhythmGameOption.FromPointer); // 02466529F8C0 0x38 Option                      ( 000186685BF0 ModelClassType RhythmGameOption RhythmGameOption RhythmGameOption Pointer )
            value.IdolService                               = GetObject<ICachedIdolService>(new IntPtr(p + 0x040), ReversePrism.DataModels.ICachedIdolService.FromPointer); // 02466529F8E0 0x40 IdolService                 ( 000186716AD0 ModelClassType ICachedIdolService ICachedIdolService ICachedIdolService Pointer )
            value.EventPeriodStatus                         = GetObject<IPeriodStatus>(new IntPtr(p + 0x058), ReversePrism.DataModels.IPeriodStatus.FromPointer); // 02466529F940 0x58 EventPeriodStatus           ( 0001865D4260 ModelClassType IPeriodStatus IPeriodStatus IPeriodStatus Pointer )
            value.MusicDifficulty                           = (SongDifficultyLevel)GetInt32(new IntPtr(p + 0x060)); // 02466529F960 0x60 MusicDifficulty             ( 00018661C990 ModelEnumType SongDifficultyLevel SongDifficultyLevel SongDifficultyLevel Int32 )
            value.LBModel                                   = GetObject<StaminaModel>(new IntPtr(p + 0x068), ReversePrism.DataModels.StaminaModel.FromPointer); // 02466529F980 0x68 LBModel                     ( 000186565050 ModelClassType StaminaModel StaminaModel StaminaModel Pointer )
            value.AutoLiveStatus                            = GetObject<AutoLiveStatus>(new IntPtr(p + 0x078), ReversePrism.DataModels.AutoLiveStatus.FromPointer); // 02466529F9C0 0x78 AutoLiveStatus              ( 000186726BE0 ModelClassType AutoLiveStatus AutoLiveStatus AutoLiveStatus Pointer )
            value.LiveBonusUsageSettingStatus               = GetObject<NormalLiveLiveBonusUsageSettingStatus>(new IntPtr(p + 0x080), ReversePrism.DataModels.NormalLiveLiveBonusUsageSettingStatus.FromPointer); // 02466529F9E0 0x80 LiveBonusUsageSettingStatus ( 0001866A8B40 ModelClassType NormalLiveLiveBonusUsageSettingStatus NormalLiveLiveBonusUsageSettingStatus NormalLiveLiveBonusUsageSettingStatus Pointer )
            value.SkipLiveStatus                            = GetObject<SkipLiveStatus>(new IntPtr(p + 0x088), ReversePrism.DataModels.SkipLiveStatus.FromPointer); // 02466529FA00 0x88 SkipLiveStatus              ( 0001865178E0 ModelClassType SkipLiveStatus SkipLiveStatus SkipLiveStatus Pointer )
            value.IsEvent                                   = GetBool(new IntPtr(p + 0x090)); // 02466529FA20 0x90 IsEvent                     ( 0001865965D0 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
