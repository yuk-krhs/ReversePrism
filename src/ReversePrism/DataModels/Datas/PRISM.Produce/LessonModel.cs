using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 enemySkillExecutePlayerMental            int IL2CPP_TYPE_I4
    // 000 lessonUnitSkillExecuteTime               float IL2CPP_TYPE_R4
    // 168 ChallengeMissionProgressCalcModel        0001866E3130 ModelClassType IngameChallengeMissionProgressCalcModel IngameChallengeMissionProgressCalcModel IngameChallengeMissionProgressCalcModel Pointer
    // 170 OpponentData                             0001865C9720 ModelClassType IOpponentStatus IOpponentStatus IOpponentStatus Pointer
    // 178 InGameType                               000186602330 ModelEnumType InGameType InGameType InGameType Int32
    public partial class LessonModel : DataModel
    {
        public IngameChallengeMissionProgressCalcModel? ChallengeMissionProgressCalcModel       { get; set; }
        public IOpponentStatus?                         OpponentData                            { get; set; }
        public InGameType                               InGameType                              { get; set; }

        public static LessonModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LessonModel() { Pointer= p0 };

            value.ChallengeMissionProgressCalcModel         = GetObject<IngameChallengeMissionProgressCalcModel>(new IntPtr(p + 0x168), ReversePrism.DataModels.IngameChallengeMissionProgressCalcModel.FromPointer); // 024665C63A18 0x168 ChallengeMissionProgressCalcModel ( 0001866E3130 ModelClassType IngameChallengeMissionProgressCalcModel IngameChallengeMissionProgressCalcModel IngameChallengeMissionProgressCalcModel Pointer )
            value.OpponentData                              = GetObject<IOpponentStatus>(new IntPtr(p + 0x170), ReversePrism.DataModels.IOpponentStatus.FromPointer); // 024665C63A38 0x170 OpponentData                ( 0001865C9720 ModelClassType IOpponentStatus IOpponentStatus IOpponentStatus Pointer )
            value.InGameType                                = (InGameType)GetInt32(new IntPtr(p + 0x178)); // 024665C63A58 0x178 InGameType                  ( 000186602330 ModelEnumType InGameType InGameType InGameType Int32 )

            return value;
        }
    }
}
