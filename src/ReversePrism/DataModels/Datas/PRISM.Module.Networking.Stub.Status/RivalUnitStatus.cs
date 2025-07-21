using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<RivalUnitStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 RivalListFieldNumber                     int IL2CPP_TYPE_I4
    // 008 _repeated_rivalList_codec                FieldCodec`1<RivalStatus> IL2CPP_TYPE_GENERICINST
    // 018 RivalList                                ModelClassListType RepeatedField`1<RivalStatus> RepeatedField`1<RivalStatus> List<RivalStatus> Pointer
    // 000 ProduceCardDeckFieldNumber               int IL2CPP_TYPE_I4
    // 020 ProduceCardDeck                          ModelClassType ProduceCardDeckStatus ProduceCardDeckStatus ProduceCardDeckStatus Pointer
    // 000 AppealCorrectionFieldNumber              int IL2CPP_TYPE_I4
    // 028 AppealCorrection                         ModelClassType AppealCorrectionStatus AppealCorrectionStatus AppealCorrectionStatus Pointer
    public partial class RivalUnitStatus : DataModel
    {
        public List<RivalStatus>?                       RivalList                               { get; set; }
        public ProduceCardDeckStatus?                   ProduceCardDeck                         { get; set; }
        public AppealCorrectionStatus?                  AppealCorrection                        { get; set; }

        public static RivalUnitStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RivalUnitStatus() { Pointer= p0 };

            value.RivalList                                 = GetObjectList<RivalStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.RivalStatus.FromPointer); // 0x18 RivalList                   ( ModelClassListType RepeatedField`1<RivalStatus> RepeatedField`1<RivalStatus> List<RivalStatus> Pointer )
            value.ProduceCardDeck                           = GetObject<ProduceCardDeckStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.ProduceCardDeckStatus.FromPointer); // 0x20 ProduceCardDeck             ( ModelClassType ProduceCardDeckStatus ProduceCardDeckStatus ProduceCardDeckStatus Pointer )
            value.AppealCorrection                          = GetObject<AppealCorrectionStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.AppealCorrectionStatus.FromPointer); // 0x28 AppealCorrection            ( ModelClassType AppealCorrectionStatus AppealCorrectionStatus AppealCorrectionStatus Pointer )

            return value;
        }
    }
}
