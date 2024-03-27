using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<FinishChallengeTourStageArgs> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 InGameResultFieldNumber                  int IL2CPP_TYPE_I4
    // 018 InGameResult                             000186572650 ModelClassType ChallengeTourInGameResultStatus ChallengeTourInGameResultStatus ChallengeTourInGameResultStatus Pointer
    public partial class FinishChallengeTourStageArgs
    {
        public ChallengeTourInGameResultStatus?         InGameResult                            { get; set; }

        public static FinishChallengeTourStageArgs? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FinishChallengeTourStageArgs();

            value.InGameResult                              = GetObject<ChallengeTourInGameResultStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.ChallengeTourInGameResultStatus.FromPointer); // 0270D0B3BBE0 0x18 InGameResult                ( 000186572650 ModelClassType ChallengeTourInGameResultStatus ChallengeTourInGameResultStatus ChallengeTourInGameResultStatus Pointer )

            return value;
        }
    }
}
