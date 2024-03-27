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
    public partial class AppleReceipt
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
            var value   = new AppleReceipt();

            value.BundleID                                  = GetString(new IntPtr(p + 0x010)); // 02700697CB80 0x10 BundleID                    ( 000186671910 ModelPrimitiveType string string string String )
            value.AppVersion                                = GetString(new IntPtr(p + 0x018)); // 02700697CBA0 0x18 AppVersion                  ( 000186671910 ModelPrimitiveType string string string String )
            value.ExpirationDate                            = GetDateTime(new IntPtr(p + 0x020)); // 02700697CBC0 0x20 ExpirationDate              ( 0001865B9010 ModelPrimitiveType DateTime DateTime DateTime DateTime )
            value.Opaque                                    = GetSByteList(new IntPtr(p + 0x028)); // 02700697CBE0 0x28 Opaque                      ( 000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.Hash                                      = GetSByteList(new IntPtr(p + 0x030)); // 02700697CC00 0x30 Hash                        ( 000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.OriginalApplicationVersion                = GetString(new IntPtr(p + 0x038)); // 02700697CC20 0x38 OriginalApplicationVersion  ( 000186671910 ModelPrimitiveType string string string String )
            value.ReceiptCreationDate                       = GetDateTime(new IntPtr(p + 0x040)); // 02700697CC40 0x40 ReceiptCreationDate         ( 0001865B9010 ModelPrimitiveType DateTime DateTime DateTime DateTime )
            value.InAppPurchaseReceipts                     = GetObjectList<AppleInAppPurchaseReceipt>(new IntPtr(p + 0x048), ReversePrism.DataModels.AppleInAppPurchaseReceipt.FromPointer); // 02700697CC60 0x48 InAppPurchaseReceipts       ( 000185B706F0 ModelClassListType AppleInAppPurchaseReceipt[] AppleInAppPurchaseReceipt[] List<AppleInAppPurchaseReceipt> Pointer )

            return value;
        }
    }
}
