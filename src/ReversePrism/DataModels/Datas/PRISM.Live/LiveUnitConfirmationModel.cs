using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 028 LiveIdolFactory                          ModelClassType LiveIdolFactory LiveIdolFactory LiveIdolFactory Pointer
    // 030 SaveData                                 ModelClassType LiveUnitConfirmationSaveData LiveUnitConfirmationSaveData LiveUnitConfirmationSaveData Pointer
    // 038 Option                                   ModelClassType RhythmGameOption RhythmGameOption RhythmGameOption Pointer
    // 040 allLiveIdols                             IList`1<LiveIdol> IL2CPP_TYPE_GENERICINST
    // 048 parameterBonusAppliedUnits               HashSet`1<LiveUnit> IL2CPP_TYPE_GENERICINST
    // 050 EventPeriodStatus                        ModelClassType IPeriodStatus IPeriodStatus IPeriodStatus Pointer
    // 058 MusicDifficulty                          ModelEnumType SongDifficultyLevel SongDifficultyLevel SongDifficultyLevel Int32
    // 060 LBModel                                  ModelClassType StaminaModel StaminaModel StaminaModel Pointer
    // 068 <Units>k__BackingField                   IList`1<LiveUnit> IL2CPP_TYPE_GENERICINST
    // 070 AutoLiveStatus                           ModelClassType AutoLiveStatus AutoLiveStatus AutoLiveStatus Pointer
    // 078 LiveBonusUsageSettingStatus              ModelClassType NormalLiveLiveBonusUsageSettingStatus NormalLiveLiveBonusUsageSettingStatus NormalLiveLiveBonusUsageSettingStatus Pointer
    // 080 SkipLiveStatus                           ModelClassType SkipLiveStatus SkipLiveStatus SkipLiveStatus Pointer
    // 088 IsEvent                                  ModelPrimitiveType bool bool bool Bool
    // 08C EventId                                  ModelPrimitiveType int int int Int32
    // 090 EventBreakTime                           ModelClassType IEventBreakTimeStatus IEventBreakTimeStatus IEventBreakTimeStatus Pointer
    public partial class LiveUnitConfirmationModel : DataModel
    {
        public LiveIdolFactory?                         LiveIdolFactory                         { get; set; }
        public LiveUnitConfirmationSaveData?            SaveData                                { get; set; }
        public RhythmGameOption?                        Option                                  { get; set; }
        public IPeriodStatus?                           EventPeriodStatus                       { get; set; }
        public SongDifficultyLevel                      MusicDifficulty                         { get; set; }
        public StaminaModel?                            LBModel                                 { get; set; }
        public AutoLiveStatus?                          AutoLiveStatus                          { get; set; }
        public NormalLiveLiveBonusUsageSettingStatus?   LiveBonusUsageSettingStatus             { get; set; }
        public SkipLiveStatus?                          SkipLiveStatus                          { get; set; }
        public bool                                     IsEvent                                 { get; set; }
        public int                                      EventId                                 { get; set; }
        public IEventBreakTimeStatus?                   EventBreakTime                          { get; set; }

        public static LiveUnitConfirmationModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveUnitConfirmationModel() { Pointer= p0 };

            value.LiveIdolFactory                           = GetObject<LiveIdolFactory>(new IntPtr(p + 0x028), ReversePrism.DataModels.LiveIdolFactory.FromPointer); // 0x28 LiveIdolFactory             ( ModelClassType LiveIdolFactory LiveIdolFactory LiveIdolFactory Pointer )
            value.SaveData                                  = GetObject<LiveUnitConfirmationSaveData>(new IntPtr(p + 0x030), ReversePrism.DataModels.LiveUnitConfirmationSaveData.FromPointer); // 0x30 SaveData                    ( ModelClassType LiveUnitConfirmationSaveData LiveUnitConfirmationSaveData LiveUnitConfirmationSaveData Pointer )
            value.Option                                    = GetObject<RhythmGameOption>(new IntPtr(p + 0x038), ReversePrism.DataModels.RhythmGameOption.FromPointer); // 0x38 Option                      ( ModelClassType RhythmGameOption RhythmGameOption RhythmGameOption Pointer )
            value.EventPeriodStatus                         = GetObject<IPeriodStatus>(new IntPtr(p + 0x050), ReversePrism.DataModels.IPeriodStatus.FromPointer); // 0x50 EventPeriodStatus           ( ModelClassType IPeriodStatus IPeriodStatus IPeriodStatus Pointer )
            value.MusicDifficulty                           = (SongDifficultyLevel)GetInt32(new IntPtr(p + 0x058)); // 0x58 MusicDifficulty             ( ModelEnumType SongDifficultyLevel SongDifficultyLevel SongDifficultyLevel Int32 )
            value.LBModel                                   = GetObject<StaminaModel>(new IntPtr(p + 0x060), ReversePrism.DataModels.StaminaModel.FromPointer); // 0x60 LBModel                     ( ModelClassType StaminaModel StaminaModel StaminaModel Pointer )
            value.AutoLiveStatus                            = GetObject<AutoLiveStatus>(new IntPtr(p + 0x070), ReversePrism.DataModels.AutoLiveStatus.FromPointer); // 0x70 AutoLiveStatus              ( ModelClassType AutoLiveStatus AutoLiveStatus AutoLiveStatus Pointer )
            value.LiveBonusUsageSettingStatus               = GetObject<NormalLiveLiveBonusUsageSettingStatus>(new IntPtr(p + 0x078), ReversePrism.DataModels.NormalLiveLiveBonusUsageSettingStatus.FromPointer); // 0x78 LiveBonusUsageSettingStatus ( ModelClassType NormalLiveLiveBonusUsageSettingStatus NormalLiveLiveBonusUsageSettingStatus NormalLiveLiveBonusUsageSettingStatus Pointer )
            value.SkipLiveStatus                            = GetObject<SkipLiveStatus>(new IntPtr(p + 0x080), ReversePrism.DataModels.SkipLiveStatus.FromPointer); // 0x80 SkipLiveStatus              ( ModelClassType SkipLiveStatus SkipLiveStatus SkipLiveStatus Pointer )
            value.IsEvent                                   = GetBool(new IntPtr(p + 0x088)); // 0x88 IsEvent                     ( ModelPrimitiveType bool bool bool Bool )
            value.EventId                                   = GetInt32(new IntPtr(p + 0x08C)); // 0x8C EventId                     ( ModelPrimitiveType int int int Int32 )
            value.EventBreakTime                            = GetObject<IEventBreakTimeStatus>(new IntPtr(p + 0x090), ReversePrism.DataModels.IEventBreakTimeStatus.FromPointer); // 0x90 EventBreakTime              ( ModelClassType IEventBreakTimeStatus IEventBreakTimeStatus IEventBreakTimeStatus Pointer )

            return value;
        }
    }
}
