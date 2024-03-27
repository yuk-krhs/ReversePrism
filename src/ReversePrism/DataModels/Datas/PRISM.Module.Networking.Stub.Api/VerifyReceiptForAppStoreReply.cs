using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<VerifyReceiptForAppStoreReply> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 OrderIdFieldNumber                       int IL2CPP_TYPE_I4
    // 018 OrderId                                  000186671910 ModelPrimitiveType string string string String
    // 000 StoreItemFieldNumber                     int IL2CPP_TYPE_I4
    // 020 StoreItem                                000186591EC0 ModelClassType StoreItemStatus StoreItemStatus StoreItemStatus Pointer
    // 000 OrderStateFieldNumber                    int IL2CPP_TYPE_I4
    // 028 OrderState                               0001866E92E0 ModelEnumType OrderState OrderState OrderState Int32
    public partial class VerifyReceiptForAppStoreReply
    {
        public string                                   OrderId                                 { get; set; }
        public StoreItemStatus?                         StoreItem                               { get; set; }
        public OrderState                               OrderState                              { get; set; }

        public static VerifyReceiptForAppStoreReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new VerifyReceiptForAppStoreReply();

            value.OrderId                                   = GetString(new IntPtr(p + 0x018)); // 0270D0B50258 0x18 OrderId                     ( 000186671910 ModelPrimitiveType string string string String )
            value.StoreItem                                 = GetObject<StoreItemStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.StoreItemStatus.FromPointer); // 0270D0B50298 0x20 StoreItem                   ( 000186591EC0 ModelClassType StoreItemStatus StoreItemStatus StoreItemStatus Pointer )
            value.OrderState                                = (OrderState)GetInt32(new IntPtr(p + 0x028)); // 0270D0B502D8 0x28 OrderState                  ( 0001866E92E0 ModelEnumType OrderState OrderState OrderState Int32 )

            return value;
        }
    }
}
