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
    // 018 MentalPoint                              ModelPrimitiveType int int int Int32
    // 000 MentalGuardCountFieldNumber              int IL2CPP_TYPE_I4
    // 01C MentalGuardCount                         ModelPrimitiveType int int int Int32
    // 000 AvoidRateFieldNumber                     int IL2CPP_TYPE_I4
    // 020 AvoidRate                                ModelPrimitiveType int int int Int32
    // 000 HandCardCountFieldNumber                 int IL2CPP_TYPE_I4
    // 024 HandCardCount                            ModelPrimitiveType int int int Int32
    public partial class ChallengeTourInGameClearStatus : DataModel
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
            var value   = new ChallengeTourInGameClearStatus() { Pointer= p0 };

            value.MentalPoint                               = GetInt32(new IntPtr(p + 0x018)); // 0x18 MentalPoint                 ( ModelPrimitiveType int int int Int32 )
            value.MentalGuardCount                          = GetInt32(new IntPtr(p + 0x01C)); // 0x1C MentalGuardCount            ( ModelPrimitiveType int int int Int32 )
            value.AvoidRate                                 = GetInt32(new IntPtr(p + 0x020)); // 0x20 AvoidRate                   ( ModelPrimitiveType int int int Int32 )
            value.HandCardCount                             = GetInt32(new IntPtr(p + 0x024)); // 0x24 HandCardCount               ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
