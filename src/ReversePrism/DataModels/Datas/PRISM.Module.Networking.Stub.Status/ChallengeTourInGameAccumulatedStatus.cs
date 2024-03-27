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
    public partial class ChallengeTourInGameAccumulatedStatus
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
            var value   = new ChallengeTourInGameAccumulatedStatus();

            value.SelfMentalBreakCount                      = GetInt32(new IntPtr(p + 0x018)); // 0270041526D0 0x18 SelfMentalBreakCount        ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.SelfMentalRecoveryCount                   = GetInt32(new IntPtr(p + 0x01C)); // 027004152710 0x1C SelfMentalRecoveryCount     ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.OpponentMentalBreakCount                  = GetInt32(new IntPtr(p + 0x020)); // 027004152750 0x20 OpponentMentalBreakCount    ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.OpponentMentalDecreaseCount               = GetInt32(new IntPtr(p + 0x024)); // 027004152790 0x24 OpponentMentalDecreaseCount ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.AvoidCount                                = GetInt32(new IntPtr(p + 0x028)); // 0270041527D0 0x28 AvoidCount                  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.CardAction                                = GetObject<ChallengeTourInGameCardActionStatus>(new IntPtr(p + 0x030), ReversePrism.DataModels.ChallengeTourInGameCardActionStatus.FromPointer); // 027004152810 0x30 CardAction                  ( 00018656F3B0 ModelClassType ChallengeTourInGameCardActionStatus ChallengeTourInGameCardActionStatus ChallengeTourInGameCardActionStatus Pointer )
            value.Counter                                   = GetObject<ChallengeTourInGameCounterStatus>(new IntPtr(p + 0x038), ReversePrism.DataModels.ChallengeTourInGameCounterStatus.FromPointer); // 027004152850 0x38 Counter                     ( 0001865702E0 ModelClassType ChallengeTourInGameCounterStatus ChallengeTourInGameCounterStatus ChallengeTourInGameCounterStatus Pointer )
            value.SelfMentalDecreaseCount                   = GetInt32(new IntPtr(p + 0x040)); // 027004152890 0x40 SelfMentalDecreaseCount     ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
