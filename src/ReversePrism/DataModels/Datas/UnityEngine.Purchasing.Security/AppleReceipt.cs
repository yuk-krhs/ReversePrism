using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 BundleID                                 000186671910 ModelPrimitiveType string string string String
    // 018 AppVersion                               000186671910 ModelPrimitiveType string string string String
    // 020 ExpirationDate                           0001865B9010 ModelPrimitiveType DateTime DateTime DateTime DateTime
    // 028 Opaque                                   000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 030 Hash                                     000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 038 OriginalApplicationVersion               000186671910 ModelPrimitiveType string string string String
    // 040 ReceiptCreationDate                      0001865B9010 ModelPrimitiveType DateTime DateTime DateTime DateTime
    // 048 InAppPurchaseReceipts                    000185B706F0 ModelClassListType AppleInAppPurchaseReceipt[] AppleInAppPurchaseReceipt[] List<AppleInAppPurchaseReceipt> Pointer
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

            value.BundleID                                  = GetString(new IntPtr(p + 0x010)); // 0245A692F318 0x10 BundleID                    ( 000186671910 ModelPrimitiveType string string string String )
            value.AppVersion                                = GetString(new IntPtr(p + 0x018)); // 0245A692F338 0x18 AppVersion                  ( 000186671910 ModelPrimitiveType string string string String )
            value.ExpirationDate                            = GetDateTime(new IntPtr(p + 0x020)); // 0245A692F358 0x20 ExpirationDate              ( 0001865B9010 ModelPrimitiveType DateTime DateTime DateTime DateTime )
            value.Opaque                                    = GetSByteList(new IntPtr(p + 0x028)); // 0245A692F378 0x28 Opaque                      ( 000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.Hash                                      = GetSByteList(new IntPtr(p + 0x030)); // 0245A692F398 0x30 Hash                        ( 000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.OriginalApplicationVersion                = GetString(new IntPtr(p + 0x038)); // 0245A692F3B8 0x38 OriginalApplicationVersion  ( 000186671910 ModelPrimitiveType string string string String )
            value.ReceiptCreationDate                       = GetDateTime(new IntPtr(p + 0x040)); // 0245A692F3D8 0x40 ReceiptCreationDate         ( 0001865B9010 ModelPrimitiveType DateTime DateTime DateTime DateTime )
            value.InAppPurchaseReceipts                     = GetObjectList<AppleInAppPurchaseReceipt>(new IntPtr(p + 0x048), ReversePrism.DataModels.AppleInAppPurchaseReceipt.FromPointer); // 0245A692F3F8 0x48 InAppPurchaseReceipts       ( 000185B706F0 ModelClassListType AppleInAppPurchaseReceipt[] AppleInAppPurchaseReceipt[] List<AppleInAppPurchaseReceipt> Pointer )

            return value;
        }
    }
}
