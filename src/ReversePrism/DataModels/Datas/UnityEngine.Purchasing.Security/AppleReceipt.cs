using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 BundleID                                 ModelPrimitiveType string string string String
    // 018 AppVersion                               ModelPrimitiveType string string string String
    // 020 ExpirationDate                           ModelPrimitiveType DateTime DateTime DateTime DateTime
    // 028 Opaque                                   ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 030 Hash                                     ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 038 OriginalApplicationVersion               ModelPrimitiveType string string string String
    // 040 ReceiptCreationDate                      ModelPrimitiveType DateTime DateTime DateTime DateTime
    // 048 InAppPurchaseReceipts                    ModelClassListType AppleInAppPurchaseReceipt[] AppleInAppPurchaseReceipt[] List<AppleInAppPurchaseReceipt> Pointer
    public partial class AppleReceipt : DataModel
    {
        public string                                   BundleID                                { get; set; }
        public string                                   AppVersion                              { get; set; }
        public DateTime                                 ExpirationDate                          { get; set; }
        public List<sbyte>?                             Opaque                                  { get; set; }
        public List<sbyte>?                             Hash                                    { get; set; }
        public string                                   OriginalApplicationVersion              { get; set; }
        public DateTime                                 ReceiptCreationDate                     { get; set; }
        public List<AppleInAppPurchaseReceipt>?         InAppPurchaseReceipts                   { get; set; }

        public static AppleReceipt? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AppleReceipt() { Pointer= p0 };

            value.BundleID                                  = GetString(new IntPtr(p + 0x010)); // 0x10 BundleID                    ( ModelPrimitiveType string string string String )
            value.AppVersion                                = GetString(new IntPtr(p + 0x018)); // 0x18 AppVersion                  ( ModelPrimitiveType string string string String )
            value.ExpirationDate                            = GetDateTime(new IntPtr(p + 0x020)); // 0x20 ExpirationDate              ( ModelPrimitiveType DateTime DateTime DateTime DateTime )
            value.Opaque                                    = GetSByteList(new IntPtr(p + 0x028)); // 0x28 Opaque                      ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.Hash                                      = GetSByteList(new IntPtr(p + 0x030)); // 0x30 Hash                        ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.OriginalApplicationVersion                = GetString(new IntPtr(p + 0x038)); // 0x38 OriginalApplicationVersion  ( ModelPrimitiveType string string string String )
            value.ReceiptCreationDate                       = GetDateTime(new IntPtr(p + 0x040)); // 0x40 ReceiptCreationDate         ( ModelPrimitiveType DateTime DateTime DateTime DateTime )
            value.InAppPurchaseReceipts                     = GetObjectList<AppleInAppPurchaseReceipt>(new IntPtr(p + 0x048), ReversePrism.DataModels.AppleInAppPurchaseReceipt.FromPointer); // 0x48 InAppPurchaseReceipts       ( ModelClassListType AppleInAppPurchaseReceipt[] AppleInAppPurchaseReceipt[] List<AppleInAppPurchaseReceipt> Pointer )

            return value;
        }
    }
}
