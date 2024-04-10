using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<ReserveStoreItemReply> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 OrderIdFieldNumber                       int IL2CPP_TYPE_I4
    // 018 OrderId                                  000186671910 ModelPrimitiveType string string string String
    // 000 StoreItemFieldNumber                     int IL2CPP_TYPE_I4
    // 020 StoreItem                                000186591EC0 ModelClassType StoreItemStatus StoreItemStatus StoreItemStatus Pointer
    public partial class ReserveStoreItemReply : DataModel
    {
        public string                                   OrderId                                 { get; set; }
        public StoreItemStatus?                         StoreItem                               { get; set; }

        public static ReserveStoreItemReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ReserveStoreItemReply() { Pointer= p0 };

            value.OrderId                                   = GetString(new IntPtr(p + 0x018)); // 024660B3BA50 0x18 OrderId                     ( 000186671910 ModelPrimitiveType string string string String )
            value.StoreItem                                 = GetObject<StoreItemStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.StoreItemStatus.FromPointer); // 024660B3BA90 0x20 StoreItem                   ( 000186591EC0 ModelClassType StoreItemStatus StoreItemStatus StoreItemStatus Pointer )

            return value;
        }
    }
}
