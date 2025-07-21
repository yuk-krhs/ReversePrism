using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 OrderId                                  ModelPrimitiveType string string string String
    // 018 StoreItem                                ModelClassType IStoreItemStatus IStoreItemStatus IStoreItemStatus Pointer
    // 020 OrderState                               ModelEnumType OrderState OrderState OrderState Int32
    // 028 DeferredDocumentBody                     ModelPrimitiveType string string string String
    public partial class VerifyReceiptReply : DataModel
    {
        public string                                   OrderId                                 { get; set; }
        public IStoreItemStatus?                        StoreItem                               { get; set; }
        public OrderState                               OrderState                              { get; set; }
        public string                                   DeferredDocumentBody                    { get; set; }

        public static VerifyReceiptReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new VerifyReceiptReply() { Pointer= p0 };

            value.OrderId                                   = GetString(new IntPtr(p + 0x010)); // 0x10 OrderId                     ( ModelPrimitiveType string string string String )
            value.StoreItem                                 = GetObject<IStoreItemStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.IStoreItemStatus.FromPointer); // 0x18 StoreItem                   ( ModelClassType IStoreItemStatus IStoreItemStatus IStoreItemStatus Pointer )
            value.OrderState                                = (OrderState)GetInt32(new IntPtr(p + 0x020)); // 0x20 OrderState                  ( ModelEnumType OrderState OrderState OrderState Int32 )
            value.DeferredDocumentBody                      = GetString(new IntPtr(p + 0x028)); // 0x28 DeferredDocumentBody        ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
