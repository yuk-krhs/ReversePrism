using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<ShopItemPurchaseHistoryStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 RecordListFieldNumber                    int IL2CPP_TYPE_I4
    // 008 _repeated_recordList_codec               FieldCodec`1<ShopItemPurchaseHistoryRecordStatus> IL2CPP_TYPE_GENERICINST
    // 018 RecordList                               000185CF13E8 ModelClassListType RepeatedField`1<ShopItemPurchaseHistoryRecordStatus> RepeatedField`1<ShopItemPurchaseHistoryRecordStatus> List<ShopItemPurchaseHistoryRecordStatus> Pointer
    public partial class ShopItemPurchaseHistoryStatus
    {
        public List<ShopItemPurchaseHistoryRecordStatus>? RecordList                              { get; set; }

        public static ShopItemPurchaseHistoryStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ShopItemPurchaseHistoryStatus();

            value.RecordList                                = GetObjectList<ShopItemPurchaseHistoryRecordStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.ShopItemPurchaseHistoryRecordStatus.FromPointer); // 0270D2809A68 0x18 RecordList                  ( 000185CF13E8 ModelClassListType RepeatedField`1<ShopItemPurchaseHistoryRecordStatus> RepeatedField`1<ShopItemPurchaseHistoryRecordStatus> List<ShopItemPurchaseHistoryRecordStatus> Pointer )

            return value;
        }
    }
}
