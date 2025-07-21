using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<GetGashaBonusRateReply> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 RateListFieldNumber                      int IL2CPP_TYPE_I4
    // 008 _repeated_rateList_codec                 FieldCodec`1<GashaBonusRateStatus> IL2CPP_TYPE_GENERICINST
    // 018 RateList                                 ModelClassListType RepeatedField`1<GashaBonusRateStatus> RepeatedField`1<GashaBonusRateStatus> List<GashaBonusRateStatus> Pointer
    public partial class GetGashaBonusRateReply : DataModel
    {
        public List<GashaBonusRateStatus>?              RateList                                { get; set; }

        public static GetGashaBonusRateReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GetGashaBonusRateReply() { Pointer= p0 };

            value.RateList                                  = GetObjectList<GashaBonusRateStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.GashaBonusRateStatus.FromPointer); // 0x18 RateList                    ( ModelClassListType RepeatedField`1<GashaBonusRateStatus> RepeatedField`1<GashaBonusRateStatus> List<GashaBonusRateStatus> Pointer )

            return value;
        }
    }
}
