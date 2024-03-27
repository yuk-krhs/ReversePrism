using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 receiptIdHashKey                         string IL2CPP_TYPE_STRING
    // 010 StoreController                          000186659910 ModelClassType IStoreController IStoreController IStoreController Pointer
    // 018 ExtensionProvider                        000186771950 ModelClassType IExtensionProvider IExtensionProvider IExtensionProvider Pointer
    // 020 VerifyReceiptDataList                    000185D1B5C8 ModelClassListType List`1<VerifyReceiptData> List`1<VerifyReceiptData> List<VerifyReceiptData> Pointer
    // 028 RefreshReceiptState                      000186688180 ModelEnumType RefreshReceiptState RefreshReceiptState RefreshReceiptState Int32
    // 02C PrepareErrorCode                         000186744160 ModelEnumType ErrorCode ErrorCode ErrorCode Int32
    // 030 PurchaseErrorCode                        000186744160 ModelEnumType ErrorCode ErrorCode ErrorCode Int32
    // 038 PurchaseErrorMessage                     000186671910 ModelPrimitiveType string string string String
    // 040 NotifyPrepareSuccess                     0001866792B0 ModelClassType Action Action Action Pointer
    // 048 <NotifyPrepareError>k__BackingField      Action`1<int> IL2CPP_TYPE_GENERICINST
    // 050 InitializeState                          000186682EA0 ModelEnumType InitializeState InitializeState InitializeState Int32
    // 054 BillingState                             000186682750 ModelEnumType BillingState BillingState BillingState Int32
    public partial class PurchaseUnityIAPBase
    {
        public IStoreController?                        StoreController                         { get; set; }
        public IExtensionProvider?                      ExtensionProvider                       { get; set; }
        public List<VerifyReceiptData>?                 VerifyReceiptDataList                   { get; set; }
        public RefreshReceiptState                      RefreshReceiptState                     { get; set; }
        public ErrorCode                                PrepareErrorCode                        { get; set; }
        public ErrorCode                                PurchaseErrorCode                       { get; set; }
        public string                                   PurchaseErrorMessage                    { get; set; }
        public Action?                                  NotifyPrepareSuccess                    { get; set; }
        public InitializeState                          InitializeState                         { get; set; }
        public BillingState                             BillingState                            { get; set; }

        public static PurchaseUnityIAPBase? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PurchaseUnityIAPBase();

            value.StoreController                           = GetObject<IStoreController>(new IntPtr(p + 0x010), ReversePrism.DataModels.IStoreController.FromPointer); // 027004B7B808 0x10 StoreController             ( 000186659910 ModelClassType IStoreController IStoreController IStoreController Pointer )
            value.ExtensionProvider                         = GetObject<IExtensionProvider>(new IntPtr(p + 0x018), ReversePrism.DataModels.IExtensionProvider.FromPointer); // 027004B7B828 0x18 ExtensionProvider           ( 000186771950 ModelClassType IExtensionProvider IExtensionProvider IExtensionProvider Pointer )
            value.VerifyReceiptDataList                     = GetObjectList<VerifyReceiptData>(new IntPtr(p + 0x020), ReversePrism.DataModels.VerifyReceiptData.FromPointer); // 027004B7B848 0x20 VerifyReceiptDataList       ( 000185D1B5C8 ModelClassListType List`1<VerifyReceiptData> List`1<VerifyReceiptData> List<VerifyReceiptData> Pointer )
            value.RefreshReceiptState                       = (RefreshReceiptState)GetInt32(new IntPtr(p + 0x028)); // 027004B7B868 0x28 RefreshReceiptState         ( 000186688180 ModelEnumType RefreshReceiptState RefreshReceiptState RefreshReceiptState Int32 )
            value.PrepareErrorCode                          = (ErrorCode)GetInt32(new IntPtr(p + 0x02C)); // 027004B7B888 0x2C PrepareErrorCode            ( 000186744160 ModelEnumType ErrorCode ErrorCode ErrorCode Int32 )
            value.PurchaseErrorCode                         = (ErrorCode)GetInt32(new IntPtr(p + 0x030)); // 027004B7B8A8 0x30 PurchaseErrorCode           ( 000186744160 ModelEnumType ErrorCode ErrorCode ErrorCode Int32 )
            value.PurchaseErrorMessage                      = GetString(new IntPtr(p + 0x038)); // 027004B7B8C8 0x38 PurchaseErrorMessage        ( 000186671910 ModelPrimitiveType string string string String )
            value.NotifyPrepareSuccess                      = GetObject<Action>(new IntPtr(p + 0x040), ReversePrism.DataModels.Action.FromPointer); // 027004B7B8E8 0x40 NotifyPrepareSuccess        ( 0001866792B0 ModelClassType Action Action Action Pointer )
            value.InitializeState                           = (InitializeState)GetInt32(new IntPtr(p + 0x050)); // 027004B7B928 0x50 InitializeState             ( 000186682EA0 ModelEnumType InitializeState InitializeState InitializeState Int32 )
            value.BillingState                              = (BillingState)GetInt32(new IntPtr(p + 0x054)); // 027004B7B948 0x54 BillingState                ( 000186682750 ModelEnumType BillingState BillingState BillingState Int32 )

            return value;
        }
    }
}
