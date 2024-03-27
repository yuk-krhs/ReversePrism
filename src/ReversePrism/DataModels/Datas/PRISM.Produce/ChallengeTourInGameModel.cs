using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 168 EnemySkillExecuteTime                    000185B80520 ModelPrimitiveListType float[] float[] List<float> Pointer
    // 170 Opponent                                 0001867230B0 ModelClassType IChallengeTourOpponentStatus IChallengeTourOpponentStatus IChallengeTourOpponentStatus Pointer
    // 178 InGameTallyModel                         000186573AA0 ModelClassType ChallengeTourInGameTallyModel ChallengeTourInGameTallyModel ChallengeTourInGameTallyModel Pointer
    public partial class ChallengeTourInGameModel
    {
        public List<float>?                             EnemySkillExecuteTime                   { get; set; }
        public IChallengeTourOpponentStatus?            Opponent                                { get; set; }
        public ChallengeTourInGameTallyModel?           InGameTallyModel                        { get; set; }

        public static ChallengeTourInGameModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ChallengeTourInGameModel();

            value.EnemySkillExecuteTime                     = GetSingleList(new IntPtr(p + 0x168)); // 0270D5AD6FE0 0x168 EnemySkillExecuteTime       ( 000185B80520 ModelPrimitiveListType float[] float[] List<float> Pointer )
            value.Opponent                                  = GetObject<IChallengeTourOpponentStatus>(new IntPtr(p + 0x170), ReversePrism.DataModels.IChallengeTourOpponentStatus.FromPointer); // 0270D5AD7000 0x170 Opponent                    ( 0001867230B0 ModelClassType IChallengeTourOpponentStatus IChallengeTourOpponentStatus IChallengeTourOpponentStatus Pointer )
            value.InGameTallyModel                          = GetObject<ChallengeTourInGameTallyModel>(new IntPtr(p + 0x178), ReversePrism.DataModels.ChallengeTourInGameTallyModel.FromPointer); // 0270D5AD7020 0x178 InGameTallyModel            ( 000186573AA0 ModelClassType ChallengeTourInGameTallyModel ChallengeTourInGameTallyModel ChallengeTourInGameTallyModel Pointer )

            return value;
        }
    }
}
