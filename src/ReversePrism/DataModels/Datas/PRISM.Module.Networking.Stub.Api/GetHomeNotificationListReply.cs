using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<GetHomeNotificationListReply> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 NotificationListFieldNumber              int IL2CPP_TYPE_I4
    // 008 _repeated_notificationList_codec         FieldCodec`1<HomeNotificationStatus> IL2CPP_TYPE_GENERICINST
    // 018 NotificationList                         000185CDE8A8 ModelClassListType RepeatedField`1<HomeNotificationStatus> RepeatedField`1<HomeNotificationStatus> List<HomeNotificationStatus> Pointer
    public partial class GetHomeNotificationListReply : DataModel
    {
        public List<HomeNotificationStatus>?            NotificationList                        { get; set; }

        public static GetHomeNotificationListReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GetHomeNotificationListReply() { Pointer= p0 };

            value.NotificationList                          = GetObjectList<HomeNotificationStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.HomeNotificationStatus.FromPointer); // 024662011A58 0x18 NotificationList            ( 000185CDE8A8 ModelClassListType RepeatedField`1<HomeNotificationStatus> RepeatedField`1<HomeNotificationStatus> List<HomeNotificationStatus> Pointer )

            return value;
        }
    }
}
