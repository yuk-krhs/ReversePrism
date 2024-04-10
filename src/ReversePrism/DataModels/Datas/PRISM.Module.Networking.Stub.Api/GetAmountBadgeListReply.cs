using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<GetAmountBadgeListReply> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 AmountBadgeListFieldNumber               int IL2CPP_TYPE_I4
    // 008 _repeated_amountBadgeList_codec          FieldCodec`1<AmountBadgeStatus> IL2CPP_TYPE_GENERICINST
    // 018 AmountBadgeList                          000185CCDD38 ModelClassListType RepeatedField`1<AmountBadgeStatus> RepeatedField`1<AmountBadgeStatus> List<AmountBadgeStatus> Pointer
    public partial class GetAmountBadgeListReply : DataModel
    {
        public List<AmountBadgeStatus>?                 AmountBadgeList                         { get; set; }

        public static GetAmountBadgeListReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GetAmountBadgeListReply() { Pointer= p0 };

            value.AmountBadgeList                           = GetObjectList<AmountBadgeStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.AmountBadgeStatus.FromPointer); // 024660B147D8 0x18 AmountBadgeList             ( 000185CCDD38 ModelClassListType RepeatedField`1<AmountBadgeStatus> RepeatedField`1<AmountBadgeStatus> List<AmountBadgeStatus> Pointer )

            return value;
        }
    }
}
