using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 StageStatus                              ModelClassType IChallengeTourStageStatus IChallengeTourStageStatus IChallengeTourStageStatus Pointer
    // 018 UnitId                                   ModelPrimitiveType int int int Int32
    // 01C IsLock                                   ModelPrimitiveType bool bool bool Bool
    // 020 RecommendationStatus                     ModelPrimitiveType int int int Int32
    // 028 RewardViewModels                         ModelClassListType ChallengeTourRewardViewModel[] ChallengeTourRewardViewModel[] List<ChallengeTourRewardViewModel> Pointer
    // 030 <EnemyProduceCards>k__BackingField       IEnumerable`1<IProduceCardStatus> IL2CPP_TYPE_GENERICINST
    // 038 SilhouetteIds                            ModelPrimitiveListType int[] int[] List<int> Pointer
    // 040 EnemySkillModels                         ModelClassListType IngameSkillModel[] IngameSkillModel[] List<IngameSkillModel> Pointer
    // 048 EnemySkillDetailViewModels               ModelClassListType ProduceEnemySkillDetailPopupViewModel[] ProduceEnemySkillDetailPopupViewModel[] List<ProduceEnemySkillDetailPopupViewModel> Pointer
    // 050 Master                                   ModelClassType MstChallengeTourStage MstChallengeTourStage MstChallengeTourStage Pointer
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

            value.StageStatus                               = GetObject<IChallengeTourStageStatus>(new IntPtr(p + 0x010), ReversePrism.DataModels.IChallengeTourStageStatus.FromPointer); // 0x10 StageStatus                 ( ModelClassType IChallengeTourStageStatus IChallengeTourStageStatus IChallengeTourStageStatus Pointer )
            value.UnitId                                    = GetInt32(new IntPtr(p + 0x018)); // 0x18 UnitId                      ( ModelPrimitiveType int int int Int32 )
            value.IsLock                                    = GetBool(new IntPtr(p + 0x01C)); // 0x1C IsLock                      ( ModelPrimitiveType bool bool bool Bool )
            value.RecommendationStatus                      = GetInt32(new IntPtr(p + 0x020)); // 0x20 RecommendationStatus        ( ModelPrimitiveType int int int Int32 )
            value.RewardViewModels                          = GetObjectList<ChallengeTourRewardViewModel>(new IntPtr(p + 0x028), ReversePrism.DataModels.ChallengeTourRewardViewModel.FromPointer); // 0x28 RewardViewModels            ( ModelClassListType ChallengeTourRewardViewModel[] ChallengeTourRewardViewModel[] List<ChallengeTourRewardViewModel> Pointer )
            value.SilhouetteIds                             = GetInt32List(new IntPtr(p + 0x038)); // 0x38 SilhouetteIds               ( ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.EnemySkillModels                          = GetObjectList<IngameSkillModel>(new IntPtr(p + 0x040), ReversePrism.DataModels.IngameSkillModel.FromPointer); // 0x40 EnemySkillModels            ( ModelClassListType IngameSkillModel[] IngameSkillModel[] List<IngameSkillModel> Pointer )
            value.EnemySkillDetailViewModels                = GetObjectList<ProduceEnemySkillDetailPopupViewModel>(new IntPtr(p + 0x048), ReversePrism.DataModels.ProduceEnemySkillDetailPopupViewModel.FromPointer); // 0x48 EnemySkillDetailViewModels  ( ModelClassListType ProduceEnemySkillDetailPopupViewModel[] ProduceEnemySkillDetailPopupViewModel[] List<ProduceEnemySkillDetailPopupViewModel> Pointer )
            value.Master                                    = GetObject<MstChallengeTourStage>(new IntPtr(p + 0x050), ReversePrism.DataModels.MstChallengeTourStage.FromPointer); // 0x50 Master                      ( ModelClassType MstChallengeTourStage MstChallengeTourStage MstChallengeTourStage Pointer )

            return value;
        }
    }
}
