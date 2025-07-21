using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 TallyModel                               ModelClassType IngameTallyModel IngameTallyModel IngameTallyModel Pointer
    // 018 ChallengeTourTallyModel                  ModelClassType ChallengeTourInGameTallyModel ChallengeTourInGameTallyModel ChallengeTourInGameTallyModel Pointer
    // 020 PlayerModel                              ModelClassType IngamePlayerModel IngamePlayerModel IngamePlayerModel Pointer
    // 028 EnemyModel                               ModelClassType IngamePlayerModel IngamePlayerModel IngamePlayerModel Pointer
    public partial class ChallengeTourMissionProgressCalcModel : DataModel
    {
        public IngameTallyModel?                        TallyModel                              { get; set; }
        public ChallengeTourInGameTallyModel?           ChallengeTourTallyModel                 { get; set; }
        public IngamePlayerModel?                       PlayerModel                             { get; set; }
        public IngamePlayerModel?                       EnemyModel                              { get; set; }

        public static ChallengeTourMissionProgressCalcModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ChallengeTourMissionProgressCalcModel() { Pointer= p0 };

            value.TallyModel                                = GetObject<IngameTallyModel>(new IntPtr(p + 0x010), ReversePrism.DataModels.IngameTallyModel.FromPointer); // 0x10 TallyModel                  ( ModelClassType IngameTallyModel IngameTallyModel IngameTallyModel Pointer )
            value.ChallengeTourTallyModel                   = GetObject<ChallengeTourInGameTallyModel>(new IntPtr(p + 0x018), ReversePrism.DataModels.ChallengeTourInGameTallyModel.FromPointer); // 0x18 ChallengeTourTallyModel     ( ModelClassType ChallengeTourInGameTallyModel ChallengeTourInGameTallyModel ChallengeTourInGameTallyModel Pointer )
            value.PlayerModel                               = GetObject<IngamePlayerModel>(new IntPtr(p + 0x020), ReversePrism.DataModels.IngamePlayerModel.FromPointer); // 0x20 PlayerModel                 ( ModelClassType IngamePlayerModel IngamePlayerModel IngamePlayerModel Pointer )
            value.EnemyModel                                = GetObject<IngamePlayerModel>(new IntPtr(p + 0x028), ReversePrism.DataModels.IngamePlayerModel.FromPointer); // 0x28 EnemyModel                  ( ModelClassType IngamePlayerModel IngamePlayerModel IngamePlayerModel Pointer )

            return value;
        }
    }
}
