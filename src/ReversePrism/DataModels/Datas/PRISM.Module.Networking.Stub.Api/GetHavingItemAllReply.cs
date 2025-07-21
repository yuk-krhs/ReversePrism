using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<GetHavingItemAllReply> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 HavingItemListFieldNumber                int IL2CPP_TYPE_I4
    // 008 _repeated_havingItemList_codec           FieldCodec`1<HavingProductStatus> IL2CPP_TYPE_GENERICINST
    // 018 HavingItemList                           ModelClassListType RepeatedField`1<HavingProductStatus> RepeatedField`1<HavingProductStatus> List<HavingProductStatus> Pointer
    public partial class GetHavingItemAllReply : DataModel
    {
        public List<HavingProductStatus>?               HavingItemList                          { get; set; }

        public static GetHavingItemAllReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GetHavingItemAllReply() { Pointer= p0 };

            value.HavingItemList                            = GetObjectList<HavingProductStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.HavingProductStatus.FromPointer); // 0x18 HavingItemList              ( ModelClassListType RepeatedField`1<HavingProductStatus> RepeatedField`1<HavingProductStatus> List<HavingProductStatus> Pointer )

            return value;
        }
    }
}
