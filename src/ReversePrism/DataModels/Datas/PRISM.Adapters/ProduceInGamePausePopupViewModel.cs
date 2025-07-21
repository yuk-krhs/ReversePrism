using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 getChallengeMissionProgress              Func`2<int, int> IL2CPP_TYPE_GENERICINST
    // 018 EnemySkillViewModels                     ModelClassListType IReadOnlyList`1<EnemySkillContentViewModel> IReadOnlyList`1<EnemySkillContentViewModel> List<EnemySkillContentViewModel> Pointer
    // 020 InGameType                               ModelEnumType InGameType InGameType InGameType Int32
    // 028 ChallengeMission                         ModelClassType IChallengeMissionStatus IChallengeMissionStatus IChallengeMissionStatus Pointer
    // 030 MissionTargetPIdol                       ModelClassType IInProduceIdolStatus IInProduceIdolStatus IInProduceIdolStatus Pointer
    // 038 MissionUpParameter                       ModelClassType IBuildUpParameterValueStatus IBuildUpParameterValueStatus IBuildUpParameterValueStatus Pointer
    // 040 IsShowChallengeMissionProgress           ModelPrimitiveType bool bool bool Bool
    public partial class ProduceInGamePausePopupViewModel : DataModel
    {
        public List<EnemySkillContentViewModel>?        EnemySkillViewModels                    { get; set; }
        public InGameType                               InGameType                              { get; set; }
        public IChallengeMissionStatus?                 ChallengeMission                        { get; set; }
        public IInProduceIdolStatus?                    MissionTargetPIdol                      { get; set; }
        public IBuildUpParameterValueStatus?            MissionUpParameter                      { get; set; }
        public bool                                     IsShowChallengeMissionProgress          { get; set; }

        public static ProduceInGamePausePopupViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceInGamePausePopupViewModel() { Pointer= p0 };

            value.EnemySkillViewModels                      = GetObjectList<EnemySkillContentViewModel>(new IntPtr(p + 0x018), ReversePrism.DataModels.EnemySkillContentViewModel.FromPointer); // 0x18 EnemySkillViewModels        ( ModelClassListType IReadOnlyList`1<EnemySkillContentViewModel> IReadOnlyList`1<EnemySkillContentViewModel> List<EnemySkillContentViewModel> Pointer )
            value.InGameType                                = (InGameType)GetInt32(new IntPtr(p + 0x020)); // 0x20 InGameType                  ( ModelEnumType InGameType InGameType InGameType Int32 )
            value.ChallengeMission                          = GetObject<IChallengeMissionStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.IChallengeMissionStatus.FromPointer); // 0x28 ChallengeMission            ( ModelClassType IChallengeMissionStatus IChallengeMissionStatus IChallengeMissionStatus Pointer )
            value.MissionTargetPIdol                        = GetObject<IInProduceIdolStatus>(new IntPtr(p + 0x030), ReversePrism.DataModels.IInProduceIdolStatus.FromPointer); // 0x30 MissionTargetPIdol          ( ModelClassType IInProduceIdolStatus IInProduceIdolStatus IInProduceIdolStatus Pointer )
            value.MissionUpParameter                        = GetObject<IBuildUpParameterValueStatus>(new IntPtr(p + 0x038), ReversePrism.DataModels.IBuildUpParameterValueStatus.FromPointer); // 0x38 MissionUpParameter          ( ModelClassType IBuildUpParameterValueStatus IBuildUpParameterValueStatus IBuildUpParameterValueStatus Pointer )
            value.IsShowChallengeMissionProgress            = GetBool(new IntPtr(p + 0x040)); // 0x40 IsShowChallengeMissionProgress ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
