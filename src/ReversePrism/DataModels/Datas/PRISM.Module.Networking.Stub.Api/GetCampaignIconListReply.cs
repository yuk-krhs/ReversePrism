using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<GetCampaignIconListReply> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 CampaignIconListFieldNumber              int IL2CPP_TYPE_I4
    // 008 _repeated_campaignIconList_codec         FieldCodec`1<CampaignIconStatus> IL2CPP_TYPE_GENERICINST
    // 018 CampaignIconList                         000185CD0408 ModelClassListType RepeatedField`1<CampaignIconStatus> RepeatedField`1<CampaignIconStatus> List<CampaignIconStatus> Pointer
    public partial class GetCampaignIconListReply
    {
        public List<CampaignIconStatus>?                CampaignIconList                        { get; set; }

        public static GetCampaignIconListReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GetCampaignIconListReply();

            value.CampaignIconList                          = GetObjectList<CampaignIconStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.CampaignIconStatus.FromPointer); // 0270D0B28048 0x18 CampaignIconList            ( 000185CD0408 ModelClassListType RepeatedField`1<CampaignIconStatus> RepeatedField`1<CampaignIconStatus> List<CampaignIconStatus> Pointer )

            return value;
        }
    }
}
