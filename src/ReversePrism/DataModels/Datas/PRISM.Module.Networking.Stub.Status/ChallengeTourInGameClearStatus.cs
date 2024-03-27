using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<ChallengeTourInGameClearStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 MentalPointFieldNumber                   int IL2CPP_TYPE_I4
    // 018 MentalPoint                              0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 MentalGuardCountFieldNumber              int IL2CPP_TYPE_I4
    // 01C MentalGuardCount                         0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 AvoidRateFieldNumber                     int IL2CPP_TYPE_I4
    // 020 AvoidRate                                0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 HandCardCountFieldNumber                 int IL2CPP_TYPE_I4
    // 024 HandCardCount                            0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class ChallengeTourInGameClearStatus
    {
        public int                                      MentalPoint                             { get; set; }
        public int                                      MentalGuardCount                        { get; set; }
        public int                                      AvoidRate                               { get; set; }
        public int                                      HandCardCount                           { get; set; }

        public static ChallengeTourInGameClearStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ChallengeTourInGameClearStatus();

            value.MentalPoint                               = GetInt32(new IntPtr(p + 0x018)); // 027004154230 0x18 MentalPoint                 ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.MentalGuardCount                          = GetInt32(new IntPtr(p + 0x01C)); // 027004154270 0x1C MentalGuardCount            ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.AvoidRate                                 = GetInt32(new IntPtr(p + 0x020)); // 0270041542B0 0x20 AvoidRate                   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.HandCardCount                             = GetInt32(new IntPtr(p + 0x024)); // 0270041542F0 0x24 HandCardCount               ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
