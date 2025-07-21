using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 receiptIdHashKey                         string IL2CPP_TYPE_STRING
    // 010 StoreController                          ModelClassType IStoreController IStoreController IStoreController Pointer
    // 018 ExtensionProvider                        ModelClassType IExtensionProvider IExtensionProvider IExtensionProvider Pointer
    // 020 VerifyReceiptDataList                    ModelClassListType List`1<VerifyReceiptData> List`1<VerifyReceiptData> List<VerifyReceiptData> Pointer
    // 028 RefreshReceiptState                      ModelEnumType RefreshReceiptState RefreshReceiptState RefreshReceiptState Int32
    // 02C PrepareErrorCode                         ModelEnumType ErrorCode ErrorCode ErrorCode Int32
    // 030 PurchaseErrorCode                        ModelEnumType ErrorCode ErrorCode ErrorCode Int32
    // 038 PurchaseErrorMessage                     ModelPrimitiveType string string string String
    // 040 NotifyPrepareSuccess                     ModelClassType Action Action Action Pointer
    // 048 <NotifyPrepareError>k__BackingField      Action`1<int> IL2CPP_TYPE_GENERICINST
    // 050 InitializeState                          ModelEnumType InitializeState InitializeState InitializeState Int32
    // 054 BillingState                             ModelEnumType BillingState BillingState BillingState Int32
    public partial class PurchaseUnityIAPBase : DataModel
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
            var value   = new PurchaseUnityIAPBase() { Pointer= p0 };

            value.StoreController                           = GetObject<IStoreController>(new IntPtr(p + 0x010), ReversePrism.DataModels.IStoreController.FromPointer); // 0x10 StoreController             ( ModelClassType IStoreController IStoreController IStoreController Pointer )
            value.ExtensionProvider                         = GetObject<IExtensionProvider>(new IntPtr(p + 0x018), ReversePrism.DataModels.IExtensionProvider.FromPointer); // 0x18 ExtensionProvider           ( ModelClassType IExtensionProvider IExtensionProvider IExtensionProvider Pointer )
            value.VerifyReceiptDataList                     = GetObjectList<VerifyReceiptData>(new IntPtr(p + 0x020), ReversePrism.DataModels.VerifyReceiptData.FromPointer); // 0x20 VerifyReceiptDataList       ( ModelClassListType List`1<VerifyReceiptData> List`1<VerifyReceiptData> List<VerifyReceiptData> Pointer )
            value.RefreshReceiptState                       = (RefreshReceiptState)GetInt32(new IntPtr(p + 0x028)); // 0x28 RefreshReceiptState         ( ModelEnumType RefreshReceiptState RefreshReceiptState RefreshReceiptState Int32 )
            value.PrepareErrorCode                          = (ErrorCode)GetInt32(new IntPtr(p + 0x02C)); // 0x2C PrepareErrorCode            ( ModelEnumType ErrorCode ErrorCode ErrorCode Int32 )
            value.PurchaseErrorCode                         = (ErrorCode)GetInt32(new IntPtr(p + 0x030)); // 0x30 PurchaseErrorCode           ( ModelEnumType ErrorCode ErrorCode ErrorCode Int32 )
            value.PurchaseErrorMessage                      = GetString(new IntPtr(p + 0x038)); // 0x38 PurchaseErrorMessage        ( ModelPrimitiveType string string string String )
            value.NotifyPrepareSuccess                      = GetObject<Action>(new IntPtr(p + 0x040), ReversePrism.DataModels.Action.FromPointer); // 0x40 NotifyPrepareSuccess        ( ModelClassType Action Action Action Pointer )
            value.InitializeState                           = (InitializeState)GetInt32(new IntPtr(p + 0x050)); // 0x50 InitializeState             ( ModelEnumType InitializeState InitializeState InitializeState Int32 )
            value.BillingState                              = (BillingState)GetInt32(new IntPtr(p + 0x054)); // 0x54 BillingState                ( ModelEnumType BillingState BillingState BillingState Int32 )

            return value;
        }
    }
}
