using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<GetChallengeTourReply> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 ChallengeTourListFieldNumber             int IL2CPP_TYPE_I4
    // 008 _repeated_challengeTourList_codec        FieldCodec`1<ChallengeTourStatus> IL2CPP_TYPE_GENERICINST
    // 018 ChallengeTourList                        ModelClassListType RepeatedField`1<ChallengeTourStatus> RepeatedField`1<ChallengeTourStatus> List<ChallengeTourStatus> Pointer
    public partial class GetChallengeTourReply : DataModel
    {
        public List<ChallengeTourStatus>?               ChallengeTourList                       { get; set; }

        public static GetChallengeTourReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GetChallengeTourReply() { Pointer= p0 };

            value.ChallengeTourList                         = GetObjectList<ChallengeTourStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.ChallengeTourStatus.FromPointer); // 0x18 ChallengeTourList           ( ModelClassListType RepeatedField`1<ChallengeTourStatus> RepeatedField`1<ChallengeTourStatus> List<ChallengeTourStatus> Pointer )

            return value;
        }
    }
}
