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
    // 158 ChallengeMissionProgressCalcModel        ModelClassType IngameChallengeMissionProgressCalcModel IngameChallengeMissionProgressCalcModel IngameChallengeMissionProgressCalcModel Pointer
    // 160 OpponentData                             ModelClassType IOpponentStatus IOpponentStatus IOpponentStatus Pointer
    // 168 InGameType                               ModelEnumType InGameType InGameType InGameType Int32
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

            value.ChallengeMissionProgressCalcModel         = GetObject<IngameChallengeMissionProgressCalcModel>(new IntPtr(p + 0x158), ReversePrism.DataModels.IngameChallengeMissionProgressCalcModel.FromPointer); // 0x158 ChallengeMissionProgressCalcModel ( ModelClassType IngameChallengeMissionProgressCalcModel IngameChallengeMissionProgressCalcModel IngameChallengeMissionProgressCalcModel Pointer )
            value.OpponentData                              = GetObject<IOpponentStatus>(new IntPtr(p + 0x160), ReversePrism.DataModels.IOpponentStatus.FromPointer); // 0x160 OpponentData                ( ModelClassType IOpponentStatus IOpponentStatus IOpponentStatus Pointer )
            value.InGameType                                = (InGameType)GetInt32(new IntPtr(p + 0x168)); // 0x168 InGameType                  ( ModelEnumType InGameType InGameType InGameType Int32 )

            return value;
        }
    }
}
