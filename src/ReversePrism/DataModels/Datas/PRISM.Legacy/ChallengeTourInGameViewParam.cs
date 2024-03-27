using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Unit                                     000186722BE0 ModelClassType IChallengeTourInGameUnitStatus IChallengeTourInGameUnitStatus IChallengeTourInGameUnitStatus Pointer
    // 018 RivalUnit                                0001867255E0 ModelClassType IChallengeTourRivalUnitStatus IChallengeTourRivalUnitStatus IChallengeTourRivalUnitStatus Pointer
    // 020 Stage                                    000186722490 ModelClassType IChallengeTourInGameStageStatus IChallengeTourInGameStageStatus IChallengeTourInGameStageStatus Pointer
    // 028 Opponent                                 000186723380 ModelClassType IChallengeTourOpponentStatus IChallengeTourOpponentStatus IChallengeTourOpponentStatus Pointer
    // 030 UnitIdols                                000185CAF558 ModelClassListType UnitIdol[] UnitIdol[] List<UnitIdol> Pointer
    // 038 UnitIndex                                0001865F4940 ModelPrimitiveType int int int Int32
    // 03C StageIndex                               0001865F4940 ModelPrimitiveType int int int Int32
    // 040 UnitId                                   0001865F4940 ModelPrimitiveType int int int Int32
    public partial class ChallengeTourInGameViewParam
    {
        public IChallengeTourInGameUnitStatus?          Unit                                    { get; set; }
        public IChallengeTourRivalUnitStatus?           RivalUnit                               { get; set; }
        public IChallengeTourInGameStageStatus?         Stage                                   { get; set; }
        public IChallengeTourOpponentStatus?            Opponent                                { get; set; }
        public List<UnitIdol>?                          UnitIdols                               { get; set; }
        public int                                      UnitIndex                               { get; set; }
        public int                                      StageIndex                              { get; set; }
        public int                                      UnitId                                  { get; set; }

        public static ChallengeTourInGameViewParam? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ChallengeTourInGameViewParam();

            value.Unit                                      = GetObject<IChallengeTourInGameUnitStatus>(new IntPtr(p + 0x010), ReversePrism.DataModels.IChallengeTourInGameUnitStatus.FromPointer); // 0270D5B02168 0x10 Unit                        ( 000186722BE0 ModelClassType IChallengeTourInGameUnitStatus IChallengeTourInGameUnitStatus IChallengeTourInGameUnitStatus Pointer )
            value.RivalUnit                                 = GetObject<IChallengeTourRivalUnitStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.IChallengeTourRivalUnitStatus.FromPointer); // 0270D5B02188 0x18 RivalUnit                   ( 0001867255E0 ModelClassType IChallengeTourRivalUnitStatus IChallengeTourRivalUnitStatus IChallengeTourRivalUnitStatus Pointer )
            value.Stage                                     = GetObject<IChallengeTourInGameStageStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.IChallengeTourInGameStageStatus.FromPointer); // 0270D5B021A8 0x20 Stage                       ( 000186722490 ModelClassType IChallengeTourInGameStageStatus IChallengeTourInGameStageStatus IChallengeTourInGameStageStatus Pointer )
            value.Opponent                                  = GetObject<IChallengeTourOpponentStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.IChallengeTourOpponentStatus.FromPointer); // 0270D5B021C8 0x28 Opponent                    ( 000186723380 ModelClassType IChallengeTourOpponentStatus IChallengeTourOpponentStatus IChallengeTourOpponentStatus Pointer )
            value.UnitIdols                                 = GetObjectList<UnitIdol>(new IntPtr(p + 0x030), ReversePrism.DataModels.UnitIdol.FromPointer); // 0270D5B021E8 0x30 UnitIdols                   ( 000185CAF558 ModelClassListType UnitIdol[] UnitIdol[] List<UnitIdol> Pointer )
            value.UnitIndex                                 = GetInt32(new IntPtr(p + 0x038)); // 0270D5B02208 0x38 UnitIndex                   ( 0001865F4940 ModelPrimitiveType int int int Int32 )
            value.StageIndex                                = GetInt32(new IntPtr(p + 0x03C)); // 0270D5B02228 0x3C StageIndex                  ( 0001865F4940 ModelPrimitiveType int int int Int32 )
            value.UnitId                                    = GetInt32(new IntPtr(p + 0x040)); // 0270D5B02248 0x40 UnitId                      ( 0001865F4940 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
