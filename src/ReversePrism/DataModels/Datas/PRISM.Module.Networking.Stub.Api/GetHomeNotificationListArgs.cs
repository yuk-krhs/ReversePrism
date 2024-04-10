using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 NeedPlaceList                            000185D185B8 ModelEnumListType IReadOnlyList`1<NotificationPlace> IReadOnlyList`1<NotificationPlace> List<NotificationPlace> Pointer
    // 000 _parser                                  MessageParser`1<GetHomeNotificationListArgs> IL2CPP_TYPE_GENERICINST
    // 018 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 NeedPlaceListFieldNumber                 int IL2CPP_TYPE_I4
    // 008 _repeated_needPlaceList_codec            FieldCodec`1<NotificationPlace> IL2CPP_TYPE_GENERICINST
    // 020 NeedPlaceList                            000185CE7F18 ModelEnumListType RepeatedField`1<NotificationPlace> RepeatedField`1<NotificationPlace> List<NotificationPlace> Pointer
    public partial class GetHomeNotificationListArgs : DataModel
    {
        public List<NotificationPlace>?                 NeedPlaceList                           { get; set; }

        public static GetHomeNotificationListArgs? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GetHomeNotificationListArgs() { Pointer= p0 };

            value.NeedPlaceList                             = GetEnumList<NotificationPlace>(new IntPtr(p + 0x020)); // 024662011038 0x20 NeedPlaceList               ( 000185CE7F18 ModelEnumListType RepeatedField`1<NotificationPlace> RepeatedField`1<NotificationPlace> List<NotificationPlace> Pointer )

            return value;
        }
    }
}
