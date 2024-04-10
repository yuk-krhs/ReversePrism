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
    // 018 SelfMentalBreakCount                     0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 SelfMentalRecoveryCountFieldNumber       int IL2CPP_TYPE_I4
    // 01C SelfMentalRecoveryCount                  0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 OpponentMentalBreakCountFieldNumber      int IL2CPP_TYPE_I4
    // 020 OpponentMentalBreakCount                 0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 OpponentMentalDecreaseCountFieldNumber   int IL2CPP_TYPE_I4
    // 024 OpponentMentalDecreaseCount              0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 AvoidCountFieldNumber                    int IL2CPP_TYPE_I4
    // 028 AvoidCount                               0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 CardActionFieldNumber                    int IL2CPP_TYPE_I4
    // 030 CardAction                               00018656F3B0 ModelClassType ChallengeTourInGameCardActionStatus ChallengeTourInGameCardActionStatus ChallengeTourInGameCardActionStatus Pointer
    // 000 CounterFieldNumber                       int IL2CPP_TYPE_I4
    // 038 Counter                                  0001865702E0 ModelClassType ChallengeTourInGameCounterStatus ChallengeTourInGameCounterStatus ChallengeTourInGameCounterStatus Pointer
    // 000 SelfMentalDecreaseCountFieldNumber       int IL2CPP_TYPE_I4
    // 040 SelfMentalDecreaseCount                  0001865F2AF0 ModelPrimitiveType int int int Int32
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

            value.SelfMentalBreakCount                      = GetInt32(new IntPtr(p + 0x018)); // 024660ECF070 0x18 SelfMentalBreakCount        ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.SelfMentalRecoveryCount                   = GetInt32(new IntPtr(p + 0x01C)); // 024660ECF0B0 0x1C SelfMentalRecoveryCount     ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.OpponentMentalBreakCount                  = GetInt32(new IntPtr(p + 0x020)); // 024660ECF0F0 0x20 OpponentMentalBreakCount    ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.OpponentMentalDecreaseCount               = GetInt32(new IntPtr(p + 0x024)); // 024660ECF130 0x24 OpponentMentalDecreaseCount ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.AvoidCount                                = GetInt32(new IntPtr(p + 0x028)); // 024660ECF170 0x28 AvoidCount                  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.CardAction                                = GetObject<ChallengeTourInGameCardActionStatus>(new IntPtr(p + 0x030), ReversePrism.DataModels.ChallengeTourInGameCardActionStatus.FromPointer); // 024660ECF1B0 0x30 CardAction                  ( 00018656F3B0 ModelClassType ChallengeTourInGameCardActionStatus ChallengeTourInGameCardActionStatus ChallengeTourInGameCardActionStatus Pointer )
            value.Counter                                   = GetObject<ChallengeTourInGameCounterStatus>(new IntPtr(p + 0x038), ReversePrism.DataModels.ChallengeTourInGameCounterStatus.FromPointer); // 024660ECF1F0 0x38 Counter                     ( 0001865702E0 ModelClassType ChallengeTourInGameCounterStatus ChallengeTourInGameCounterStatus ChallengeTourInGameCounterStatus Pointer )
            value.SelfMentalDecreaseCount                   = GetInt32(new IntPtr(p + 0x040)); // 024660ECF230 0x40 SelfMentalDecreaseCount     ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
