using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<ExchangeProductPurchaseLimitStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 PurchaseCountLimitFieldNumber            int IL2CPP_TYPE_I4
    // 018 PurchaseCountLimit                       0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 ResetPurchaseCountTypeFieldNumber        int IL2CPP_TYPE_I4
    // 01C ResetPurchaseCountType                   000186513980 ModelEnumType ExchangeProductResetPurchaseCountType ExchangeProductResetPurchaseCountType ExchangeProductResetPurchaseCountType Int32
    // 000 CurrentCountFieldNumber                  int IL2CPP_TYPE_I4
    // 020 CurrentCount                             0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class ExchangeProductPurchaseLimitStatus
    {
        public int                                      PurchaseCountLimit                      { get; set; }
        public ExchangeProductResetPurchaseCountType    ResetPurchaseCountType                  { get; set; }
        public int                                      CurrentCount                            { get; set; }

        public static ExchangeProductPurchaseLimitStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ExchangeProductPurchaseLimitStatus();

            value.PurchaseCountLimit                        = GetInt32(new IntPtr(p + 0x018)); // 0270D12276B0 0x18 PurchaseCountLimit          ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.ResetPurchaseCountType                    = (ExchangeProductResetPurchaseCountType)GetInt32(new IntPtr(p + 0x01C)); // 0270D12276F0 0x1C ResetPurchaseCountType      ( 000186513980 ModelEnumType ExchangeProductResetPurchaseCountType ExchangeProductResetPurchaseCountType ExchangeProductResetPurchaseCountType Int32 )
            value.CurrentCount                              = GetInt32(new IntPtr(p + 0x020)); // 0270D1227730 0x20 CurrentCount                ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
