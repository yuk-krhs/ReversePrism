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
    // 018 Stage                                    000186572E10 ModelClassType ChallengeTourInGameStageStatus ChallengeTourInGameStageStatus ChallengeTourInGameStageStatus Pointer
    // 000 UnitFieldNumber                          int IL2CPP_TYPE_I4
    // 020 Unit                                     000186573FE0 ModelClassType ChallengeTourInGameUnitStatus ChallengeTourInGameUnitStatus ChallengeTourInGameUnitStatus Pointer
    // 000 RivalUnitFieldNumber                     int IL2CPP_TYPE_I4
    // 028 RivalUnit                                00018657EB90 ModelClassType ChallengeTourRivalUnitStatus ChallengeTourRivalUnitStatus ChallengeTourRivalUnitStatus Pointer
    // 000 OpponentFieldNumber                      int IL2CPP_TYPE_I4
    // 030 Opponent                                 0001865751E0 ModelClassType ChallengeTourOpponentStatus ChallengeTourOpponentStatus ChallengeTourOpponentStatus Pointer
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

            value.Stage                                     = GetObject<ChallengeTourInGameStageStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.ChallengeTourInGameStageStatus.FromPointer); // 024660B50B58 0x18 Stage                       ( 000186572E10 ModelClassType ChallengeTourInGameStageStatus ChallengeTourInGameStageStatus ChallengeTourInGameStageStatus Pointer )
            value.Unit                                      = GetObject<ChallengeTourInGameUnitStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.ChallengeTourInGameUnitStatus.FromPointer); // 024660B50B98 0x20 Unit                        ( 000186573FE0 ModelClassType ChallengeTourInGameUnitStatus ChallengeTourInGameUnitStatus ChallengeTourInGameUnitStatus Pointer )
            value.RivalUnit                                 = GetObject<ChallengeTourRivalUnitStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.ChallengeTourRivalUnitStatus.FromPointer); // 024660B50BD8 0x28 RivalUnit                   ( 00018657EB90 ModelClassType ChallengeTourRivalUnitStatus ChallengeTourRivalUnitStatus ChallengeTourRivalUnitStatus Pointer )
            value.Opponent                                  = GetObject<ChallengeTourOpponentStatus>(new IntPtr(p + 0x030), ReversePrism.DataModels.ChallengeTourOpponentStatus.FromPointer); // 024660B50C18 0x30 Opponent                    ( 0001865751E0 ModelClassType ChallengeTourOpponentStatus ChallengeTourOpponentStatus ChallengeTourOpponentStatus Pointer )

            return value;
        }
    }
}
