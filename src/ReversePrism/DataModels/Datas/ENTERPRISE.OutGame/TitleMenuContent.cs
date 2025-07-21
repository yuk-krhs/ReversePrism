using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 060 AnnounceButton                           ModelClassType UIButton UIButton UIButton Pointer
    // 068 ContactButton                            ModelClassType UIButton UIButton UIButton Pointer
    // 070 ClearCacheButton                         ModelClassType UIButton UIButton UIButton Pointer
    // 078 DeleteAccountButton                      ModelClassType UIButton UIButton UIButton Pointer
    // 080 AccountTransferButton                    ModelClassType UIButton UIButton UIButton Pointer
    // 088 AnnounceText                             ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 090 ContactText                              ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 098 ClearCacheText                           ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 0A0 DeleteAccountText                        ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 0A8 AccountTransferText                      ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    public partial class TitleMenuContent : DataModel
    {
        public UIButton?                                AnnounceButton                          { get; set; }
        public UIButton?                                ContactButton                           { get; set; }
        public UIButton?                                ClearCacheButton                        { get; set; }
        public UIButton?                                DeleteAccountButton                     { get; set; }
        public UIButton?                                AccountTransferButton                   { get; set; }
        public UITextMeshProUGUI?                       AnnounceText                            { get; set; }
        public UITextMeshProUGUI?                       ContactText                             { get; set; }
        public UITextMeshProUGUI?                       ClearCacheText                          { get; set; }
        public UITextMeshProUGUI?                       DeleteAccountText                       { get; set; }
        public UITextMeshProUGUI?                       AccountTransferText                     { get; set; }

        public static TitleMenuContent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TitleMenuContent() { Pointer= p0 };

            value.AnnounceButton                            = GetObject<UIButton>(new IntPtr(p + 0x060), ReversePrism.DataModels.UIButton.FromPointer); // 0x60 AnnounceButton              ( ModelClassType UIButton UIButton UIButton Pointer )
            value.ContactButton                             = GetObject<UIButton>(new IntPtr(p + 0x068), ReversePrism.DataModels.UIButton.FromPointer); // 0x68 ContactButton               ( ModelClassType UIButton UIButton UIButton Pointer )
            value.ClearCacheButton                          = GetObject<UIButton>(new IntPtr(p + 0x070), ReversePrism.DataModels.UIButton.FromPointer); // 0x70 ClearCacheButton            ( ModelClassType UIButton UIButton UIButton Pointer )
            value.DeleteAccountButton                       = GetObject<UIButton>(new IntPtr(p + 0x078), ReversePrism.DataModels.UIButton.FromPointer); // 0x78 DeleteAccountButton         ( ModelClassType UIButton UIButton UIButton Pointer )
            value.AccountTransferButton                     = GetObject<UIButton>(new IntPtr(p + 0x080), ReversePrism.DataModels.UIButton.FromPointer); // 0x80 AccountTransferButton       ( ModelClassType UIButton UIButton UIButton Pointer )
            value.AnnounceText                              = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x088), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x88 AnnounceText                ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ContactText                               = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x090), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x90 ContactText                 ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ClearCacheText                            = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x098), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x98 ClearCacheText              ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.DeleteAccountText                         = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0xA0 DeleteAccountText           ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.AccountTransferText                       = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0xA8 AccountTransferText         ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )

            return value;
        }
    }
}
