using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 StageStatus                              0001867270C0 ModelClassType IChallengeTourStageStatus IChallengeTourStageStatus IChallengeTourStageStatus Pointer
    // 018 UnitId                                   0001865F4260 ModelPrimitiveType int int int Int32
    // 01C IsLock                                   0001865965D0 ModelPrimitiveType bool bool bool Bool
    // 020 RecommendationStatus                     0001865F4260 ModelPrimitiveType int int int Int32
    // 028 RewardViewModels                         000185B74740 ModelClassListType ChallengeTourRewardViewModel[] ChallengeTourRewardViewModel[] List<ChallengeTourRewardViewModel> Pointer
    // 030 <EnemyProduceCards>k__BackingField       IEnumerable`1<IProduceCardStatus> IL2CPP_TYPE_GENERICINST
    // 038 SilhouetteIds                            000185B7D9E0 ModelPrimitiveListType int[] int[] List<int> Pointer
    // 040 EnemySkillModels                         000185B8B940 ModelClassListType IngameSkillModel[] IngameSkillModel[] List<IngameSkillModel> Pointer
    // 048 EnemySkillDetailViewModels               000185B9C960 ModelClassListType ProduceEnemySkillDetailPopupViewModel[] ProduceEnemySkillDetailPopupViewModel[] List<ProduceEnemySkillDetailPopupViewModel> Pointer
    // 050 Master                                   00018661B630 ModelClassType MstChallengeTourStage MstChallengeTourStage MstChallengeTourStage Pointer
    public partial class ChallengeTourStageViewModel : DataModel
    {
        public IChallengeTourStageStatus?               StageStatus                             { get; set; }
        public int                                      UnitId                                  { get; set; }
        public bool                                     IsLock                                  { get; set; }
        public int                                      RecommendationStatus                    { get; set; }
        public List<ChallengeTourRewardViewModel>?      RewardViewModels                        { get; set; }
        public List<int>?                               SilhouetteIds                           { get; set; }
        public List<IngameSkillModel>?                  EnemySkillModels                        { get; set; }
        public List<ProduceEnemySkillDetailPopupViewModel>? EnemySkillDetailViewModels              { get; set; }
        public MstChallengeTourStage?                   Master                                  { get; set; }

        public static ChallengeTourStageViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ChallengeTourStageViewModel() { Pointer= p0 };

            value.StageStatus                               = GetObject<IChallengeTourStageStatus>(new IntPtr(p + 0x010), ReversePrism.DataModels.IChallengeTourStageStatus.FromPointer); // 024666500138 0x10 StageStatus                 ( 0001867270C0 ModelClassType IChallengeTourStageStatus IChallengeTourStageStatus IChallengeTourStageStatus Pointer )
            value.UnitId                                    = GetInt32(new IntPtr(p + 0x018)); // 024666500158 0x18 UnitId                      ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.IsLock                                    = GetBool(new IntPtr(p + 0x01C)); // 024666500178 0x1C IsLock                      ( 0001865965D0 ModelPrimitiveType bool bool bool Bool )
            value.RecommendationStatus                      = GetInt32(new IntPtr(p + 0x020)); // 024666500198 0x20 RecommendationStatus        ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.RewardViewModels                          = GetObjectList<ChallengeTourRewardViewModel>(new IntPtr(p + 0x028), ReversePrism.DataModels.ChallengeTourRewardViewModel.FromPointer); // 0246665001B8 0x28 RewardViewModels            ( 000185B74740 ModelClassListType ChallengeTourRewardViewModel[] ChallengeTourRewardViewModel[] List<ChallengeTourRewardViewModel> Pointer )
            value.SilhouetteIds                             = GetInt32List(new IntPtr(p + 0x038)); // 0246665001F8 0x38 SilhouetteIds               ( 000185B7D9E0 ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.EnemySkillModels                          = GetObjectList<IngameSkillModel>(new IntPtr(p + 0x040), ReversePrism.DataModels.IngameSkillModel.FromPointer); // 024666500218 0x40 EnemySkillModels            ( 000185B8B940 ModelClassListType IngameSkillModel[] IngameSkillModel[] List<IngameSkillModel> Pointer )
            value.EnemySkillDetailViewModels                = GetObjectList<ProduceEnemySkillDetailPopupViewModel>(new IntPtr(p + 0x048), ReversePrism.DataModels.ProduceEnemySkillDetailPopupViewModel.FromPointer); // 024666500238 0x48 EnemySkillDetailViewModels  ( 000185B9C960 ModelClassListType ProduceEnemySkillDetailPopupViewModel[] ProduceEnemySkillDetailPopupViewModel[] List<ProduceEnemySkillDetailPopupViewModel> Pointer )
            value.Master                                    = GetObject<MstChallengeTourStage>(new IntPtr(p + 0x050), ReversePrism.DataModels.MstChallengeTourStage.FromPointer); // 024666500258 0x50 Master                      ( 00018661B630 ModelClassType MstChallengeTourStage MstChallengeTourStage MstChallengeTourStage Pointer )

            return value;
        }
    }
}
