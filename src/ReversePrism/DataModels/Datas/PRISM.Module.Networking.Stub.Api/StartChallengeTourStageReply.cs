using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<StartChallengeTourStageReply> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 StageFieldNumber                         int IL2CPP_TYPE_I4
    // 018 Stage                                    ModelClassType ChallengeTourInGameStageStatus ChallengeTourInGameStageStatus ChallengeTourInGameStageStatus Pointer
    // 000 UnitFieldNumber                          int IL2CPP_TYPE_I4
    // 020 Unit                                     ModelClassType ChallengeTourInGameUnitStatus ChallengeTourInGameUnitStatus ChallengeTourInGameUnitStatus Pointer
    // 000 RivalUnitFieldNumber                     int IL2CPP_TYPE_I4
    // 028 RivalUnit                                ModelClassType ChallengeTourRivalUnitStatus ChallengeTourRivalUnitStatus ChallengeTourRivalUnitStatus Pointer
    // 000 OpponentFieldNumber                      int IL2CPP_TYPE_I4
    // 030 Opponent                                 ModelClassType ChallengeTourOpponentStatus ChallengeTourOpponentStatus ChallengeTourOpponentStatus Pointer
    public partial class StartChallengeTourStageReply : DataModel
    {
        public ChallengeTourInGameStageStatus?          Stage                                   { get; set; }
        public ChallengeTourInGameUnitStatus?           Unit                                    { get; set; }
        public ChallengeTourRivalUnitStatus?            RivalUnit                               { get; set; }
        public ChallengeTourOpponentStatus?             Opponent                                { get; set; }

        public static StartChallengeTourStageReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StartChallengeTourStageReply() { Pointer= p0 };

            value.Stage                                     = GetObject<ChallengeTourInGameStageStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.ChallengeTourInGameStageStatus.FromPointer); // 0x18 Stage                       ( ModelClassType ChallengeTourInGameStageStatus ChallengeTourInGameStageStatus ChallengeTourInGameStageStatus Pointer )
            value.Unit                                      = GetObject<ChallengeTourInGameUnitStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.ChallengeTourInGameUnitStatus.FromPointer); // 0x20 Unit                        ( ModelClassType ChallengeTourInGameUnitStatus ChallengeTourInGameUnitStatus ChallengeTourInGameUnitStatus Pointer )
            value.RivalUnit                                 = GetObject<ChallengeTourRivalUnitStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.ChallengeTourRivalUnitStatus.FromPointer); // 0x28 RivalUnit                   ( ModelClassType ChallengeTourRivalUnitStatus ChallengeTourRivalUnitStatus ChallengeTourRivalUnitStatus Pointer )
            value.Opponent                                  = GetObject<ChallengeTourOpponentStatus>(new IntPtr(p + 0x030), ReversePrism.DataModels.ChallengeTourOpponentStatus.FromPointer); // 0x30 Opponent                    ( ModelClassType ChallengeTourOpponentStatus ChallengeTourOpponentStatus ChallengeTourOpponentStatus Pointer )

            return value;
        }
    }
}
