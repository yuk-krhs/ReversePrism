using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 EndDate                                  000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 000 _parser                                  MessageParser`1<GetExchangeSelectionTicketListReply> IL2CPP_TYPE_GENERICINST
    // 020 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 SelectionTicketListFieldNumber           int IL2CPP_TYPE_I4
    // 008 _repeated_selectionTicketList_codec      FieldCodec`1<SelectionTicketStatus> IL2CPP_TYPE_GENERICINST
    // 028 SelectionTicketList                      000185CF0848 ModelClassListType RepeatedField`1<SelectionTicketStatus> RepeatedField`1<SelectionTicketStatus> List<SelectionTicketStatus> Pointer
    // 000 EndDateFieldNumber                       int IL2CPP_TYPE_I4
    // 030 _EndDate                                 000186675810 ModelClassType Timestamp Timestamp Timestamp Pointer
    public partial class GetExchangeSelectionTicketListReply
    {
        public DateTime                                 EndDate                                 { get; set; }
        public List<SelectionTicketStatus>?             SelectionTicketList                     { get; set; }
        public Timestamp?                               _EndDate                                { get; set; }

        public static GetExchangeSelectionTicketListReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GetExchangeSelectionTicketListReply();

            value.EndDate                                   = GetDateTime(new IntPtr(p + 0x010)); // 0270D1221A20 0x10 EndDate                     ( 000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.SelectionTicketList                       = GetObjectList<SelectionTicketStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.SelectionTicketStatus.FromPointer); // 0270D1221AC0 0x28 SelectionTicketList         ( 000185CF0848 ModelClassListType RepeatedField`1<SelectionTicketStatus> RepeatedField`1<SelectionTicketStatus> List<SelectionTicketStatus> Pointer )
            value._EndDate                                  = GetObject<Timestamp>(new IntPtr(p + 0x030), ReversePrism.DataModels.Timestamp.FromPointer); // 0270D1221B00 0x30 _EndDate                    ( 000186675810 ModelClassType Timestamp Timestamp Timestamp Pointer )
            value.EndDate                       = ToDateTime(value._EndDate);

            return value;
        }
    }
}
