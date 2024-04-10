using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<StoreItemPurchaseHistoryStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 RecordListFieldNumber                    int IL2CPP_TYPE_I4
    // 008 _repeated_recordList_codec               FieldCodec`1<StoreItemPurchaseHistoryRecordStatus> IL2CPP_TYPE_GENERICINST
    // 018 RecordList                               000185CF2AF8 ModelClassListType RepeatedField`1<StoreItemPurchaseHistoryRecordStatus> RepeatedField`1<StoreItemPurchaseHistoryRecordStatus> List<StoreItemPurchaseHistoryRecordStatus> Pointer
    public partial class StoreItemPurchaseHistoryStatus : DataModel
    {
        public List<StoreItemPurchaseHistoryRecordStatus>? RecordList                              { get; set; }

        public static StoreItemPurchaseHistoryStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StoreItemPurchaseHistoryStatus() { Pointer= p0 };

            value.RecordList                                = GetObjectList<StoreItemPurchaseHistoryRecordStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.StoreItemPurchaseHistoryRecordStatus.FromPointer); // 02466276C568 0x18 RecordList                  ( 000185CF2AF8 ModelClassListType RepeatedField`1<StoreItemPurchaseHistoryRecordStatus> RepeatedField`1<StoreItemPurchaseHistoryRecordStatus> List<StoreItemPurchaseHistoryRecordStatus> Pointer )

            return value;
        }
    }
}
