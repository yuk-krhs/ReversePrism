using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 LastUpdateDate                           ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 000 _parser                                  MessageParser`1<HomeNotificationStatus> IL2CPP_TYPE_GENERICINST
    // 020 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 PlaceFieldNumber                         int IL2CPP_TYPE_I4
    // 028 Place                                    ModelEnumType NotificationPlace NotificationPlace NotificationPlace Int32
    // 000 BadgeTypeFieldNumber                     int IL2CPP_TYPE_I4
    // 02C BadgeType                                ModelEnumType BadgeType BadgeType BadgeType Int32
    // 000 AmountFieldNumber                        int IL2CPP_TYPE_I4
    // 030 Amount                                   ModelPrimitiveType int int int Int32
    // 000 EventIconFieldNumber                     int IL2CPP_TYPE_I4
    // 038 EventIcon                                ModelClassType EventIconStatus EventIconStatus EventIconStatus Pointer
    // 000 LastUpdateDateFieldNumber                int IL2CPP_TYPE_I4
    // 040 _LastUpdateDate                          ModelClassType Timestamp Timestamp Timestamp Pointer
    // 000 MstSongIdListFieldNumber                 int IL2CPP_TYPE_I4
    // 008 _repeated_mstSongIdList_codec            FieldCodec`1<int> IL2CPP_TYPE_GENERICINST
    // 048 MstSongIdList                            ModelPrimitiveListType RepeatedField`1<int> RepeatedField`1<int> List<int> Pointer
    // 000 GashaIdListFieldNumber                   int IL2CPP_TYPE_I4
    // 010 _repeated_gashaIdList_codec              FieldCodec`1<string> IL2CPP_TYPE_GENERICINST
    // 050 GashaIdList                              ModelPrimitiveListType RepeatedField`1<string> RepeatedField`1<string> List<string> Pointer
    // 000 ShopNotificationFieldNumber              int IL2CPP_TYPE_I4
    // 058 ShopNotification                         ModelClassType HomeShopNotificationStatus HomeShopNotificationStatus HomeShopNotificationStatus Pointer
    // 000 ExchangeNotificationListFieldNumber      int IL2CPP_TYPE_I4
    // 018 _repeated_exchangeNotificationList_codec FieldCodec`1<HomeExchangeNotificationStatus> IL2CPP_TYPE_GENERICINST
    // 060 ExchangeNotificationList                 ModelClassListType RepeatedField`1<HomeExchangeNotificationStatus> RepeatedField`1<HomeExchangeNotificationStatus> List<HomeExchangeNotificationStatus> Pointer
    // 000 MstSpecialMissionIdFieldNumber           int IL2CPP_TYPE_I4
    // 068 MstSpecialMissionId                      ModelPrimitiveType int int int Int32
    public partial class HomeNotificationStatus : DataModel
    {
        public DateTime                                 LastUpdateDate                          { get; set; }
        public NotificationPlace                        Place                                   { get; set; }
        public BadgeType                                BadgeType                               { get; set; }
        public int                                      Amount                                  { get; set; }
        public EventIconStatus?                         EventIcon                               { get; set; }
        public Timestamp?                               _LastUpdateDate                         { get; set; }
        public List<int>?                               MstSongIdList                           { get; set; }
        public List<string>?                            GashaIdList                             { get; set; }
        public HomeShopNotificationStatus?              ShopNotification                        { get; set; }
        public List<HomeExchangeNotificationStatus>?    ExchangeNotificationList                { get; set; }
        public int                                      MstSpecialMissionId                     { get; set; }

        public static HomeNotificationStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new HomeNotificationStatus() { Pointer= p0 };

            value.LastUpdateDate                            = GetDateTime(new IntPtr(p + 0x010)); // 0x10 LastUpdateDate              ( ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.Place                                     = (NotificationPlace)GetInt32(new IntPtr(p + 0x028)); // 0x28 Place                       ( ModelEnumType NotificationPlace NotificationPlace NotificationPlace Int32 )
            value.BadgeType                                 = (BadgeType)GetInt32(new IntPtr(p + 0x02C)); // 0x2C BadgeType                   ( ModelEnumType BadgeType BadgeType BadgeType Int32 )
            value.Amount                                    = GetInt32(new IntPtr(p + 0x030)); // 0x30 Amount                      ( ModelPrimitiveType int int int Int32 )
            value.EventIcon                                 = GetObject<EventIconStatus>(new IntPtr(p + 0x038), ReversePrism.DataModels.EventIconStatus.FromPointer); // 0x38 EventIcon                   ( ModelClassType EventIconStatus EventIconStatus EventIconStatus Pointer )
            value._LastUpdateDate                           = GetObject<Timestamp>(new IntPtr(p + 0x040), ReversePrism.DataModels.Timestamp.FromPointer); // 0x40 _LastUpdateDate             ( ModelClassType Timestamp Timestamp Timestamp Pointer )
            value.MstSongIdList                             = GetInt32List(new IntPtr(p + 0x048)); // 0x48 MstSongIdList               ( ModelPrimitiveListType RepeatedField`1<int> RepeatedField`1<int> List<int> Pointer )
            value.GashaIdList                               = GetStringList(new IntPtr(p + 0x050)); // 0x50 GashaIdList                 ( ModelPrimitiveListType RepeatedField`1<string> RepeatedField`1<string> List<string> Pointer )
            value.ShopNotification                          = GetObject<HomeShopNotificationStatus>(new IntPtr(p + 0x058), ReversePrism.DataModels.HomeShopNotificationStatus.FromPointer); // 0x58 ShopNotification            ( ModelClassType HomeShopNotificationStatus HomeShopNotificationStatus HomeShopNotificationStatus Pointer )
            value.ExchangeNotificationList                  = GetObjectList<HomeExchangeNotificationStatus>(new IntPtr(p + 0x060), ReversePrism.DataModels.HomeExchangeNotificationStatus.FromPointer); // 0x60 ExchangeNotificationList    ( ModelClassListType RepeatedField`1<HomeExchangeNotificationStatus> RepeatedField`1<HomeExchangeNotificationStatus> List<HomeExchangeNotificationStatus> Pointer )
            value.MstSpecialMissionId                       = GetInt32(new IntPtr(p + 0x068)); // 0x68 MstSpecialMissionId         ( ModelPrimitiveType int int int Int32 )
            value.LastUpdateDate                = ToDateTime(value._LastUpdateDate);

            return value;
        }
    }
}
