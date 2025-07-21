using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<ChallengeTourInGameAccumulatedStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 SelfMentalBreakCountFieldNumber          int IL2CPP_TYPE_I4
    // 018 SelfMentalBreakCount                     ModelPrimitiveType int int int Int32
    // 000 SelfMentalRecoveryCountFieldNumber       int IL2CPP_TYPE_I4
    // 01C SelfMentalRecoveryCount                  ModelPrimitiveType int int int Int32
    // 000 OpponentMentalBreakCountFieldNumber      int IL2CPP_TYPE_I4
    // 020 OpponentMentalBreakCount                 ModelPrimitiveType int int int Int32
    // 000 OpponentMentalDecreaseCountFieldNumber   int IL2CPP_TYPE_I4
    // 024 OpponentMentalDecreaseCount              ModelPrimitiveType int int int Int32
    // 000 AvoidCountFieldNumber                    int IL2CPP_TYPE_I4
    // 028 AvoidCount                               ModelPrimitiveType int int int Int32
    // 000 CardActionFieldNumber                    int IL2CPP_TYPE_I4
    // 030 CardAction                               ModelClassType ChallengeTourInGameCardActionStatus ChallengeTourInGameCardActionStatus ChallengeTourInGameCardActionStatus Pointer
    // 000 CounterFieldNumber                       int IL2CPP_TYPE_I4
    // 038 Counter                                  ModelClassType ChallengeTourInGameCounterStatus ChallengeTourInGameCounterStatus ChallengeTourInGameCounterStatus Pointer
    // 000 SelfMentalDecreaseCountFieldNumber       int IL2CPP_TYPE_I4
    // 040 SelfMentalDecreaseCount                  ModelPrimitiveType int int int Int32
    public partial class ChallengeTourInGameAccumulatedStatus : DataModel
    {
        public int                                      SelfMentalBreakCount                    { get; set; }
        public int                                      SelfMentalRecoveryCount                 { get; set; }
        public int                                      OpponentMentalBreakCount                { get; set; }
        public int                                      OpponentMentalDecreaseCount             { get; set; }
        public int                                      AvoidCount                              { get; set; }
        public ChallengeTourInGameCardActionStatus?     CardAction                              { get; set; }
        public ChallengeTourInGameCounterStatus?        Counter                                 { get; set; }
        public int                                      SelfMentalDecreaseCount                 { get; set; }

        public static ChallengeTourInGameAccumulatedStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ChallengeTourInGameAccumulatedStatus() { Pointer= p0 };

            value.SelfMentalBreakCount                      = GetInt32(new IntPtr(p + 0x018)); // 0x18 SelfMentalBreakCount        ( ModelPrimitiveType int int int Int32 )
            value.SelfMentalRecoveryCount                   = GetInt32(new IntPtr(p + 0x01C)); // 0x1C SelfMentalRecoveryCount     ( ModelPrimitiveType int int int Int32 )
            value.OpponentMentalBreakCount                  = GetInt32(new IntPtr(p + 0x020)); // 0x20 OpponentMentalBreakCount    ( ModelPrimitiveType int int int Int32 )
            value.OpponentMentalDecreaseCount               = GetInt32(new IntPtr(p + 0x024)); // 0x24 OpponentMentalDecreaseCount ( ModelPrimitiveType int int int Int32 )
            value.AvoidCount                                = GetInt32(new IntPtr(p + 0x028)); // 0x28 AvoidCount                  ( ModelPrimitiveType int int int Int32 )
            value.CardAction                                = GetObject<ChallengeTourInGameCardActionStatus>(new IntPtr(p + 0x030), ReversePrism.DataModels.ChallengeTourInGameCardActionStatus.FromPointer); // 0x30 CardAction                  ( ModelClassType ChallengeTourInGameCardActionStatus ChallengeTourInGameCardActionStatus ChallengeTourInGameCardActionStatus Pointer )
            value.Counter                                   = GetObject<ChallengeTourInGameCounterStatus>(new IntPtr(p + 0x038), ReversePrism.DataModels.ChallengeTourInGameCounterStatus.FromPointer); // 0x38 Counter                     ( ModelClassType ChallengeTourInGameCounterStatus ChallengeTourInGameCounterStatus ChallengeTourInGameCounterStatus Pointer )
            value.SelfMentalDecreaseCount                   = GetInt32(new IntPtr(p + 0x040)); // 0x40 SelfMentalDecreaseCount     ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
