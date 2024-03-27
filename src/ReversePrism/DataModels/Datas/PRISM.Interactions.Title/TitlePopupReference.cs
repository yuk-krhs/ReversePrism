using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 License                                  0001866785C0 ModelClassType TitleLicensePopupView TitleLicensePopupView TitleLicensePopupView Pointer
    // 028 Transfer                                 00018667BE20 ModelClassType TitleTransferPopupView TitleTransferPopupView TitleTransferPopupView Pointer
    // 030 NameInput                                00018667A5A0 ModelClassType TitleNameInputPopupView TitleNameInputPopupView TitleNameInputPopupView Pointer
    // 038 privacyOptionPopupFactory                PopupViewFactory`1<IPrivacyOptionPopupView> IL2CPP_TYPE_GENERICINST
    // 040 Att                                      0001866766A0 ModelClassType TitleATTPopupView TitleATTPopupView TitleATTPopupView Pointer
    // 048 Menu                                     000186679920 ModelClassType TitleMenuPopupView TitleMenuPopupView TitleMenuPopupView Pointer
    // 050 TransferContact                          0001866A3D90 ModelClassType TransferContactPopupView TransferContactPopupView TransferContactPopupView Pointer
    public partial class TitlePopupReference
    {
        public TitleLicensePopupView?                   License                                 { get; set; }
        public TitleTransferPopupView?                  Transfer                                { get; set; }
        public TitleNameInputPopupView?                 NameInput                               { get; set; }
        public TitleATTPopupView?                       Att                                     { get; set; }
        public TitleMenuPopupView?                      Menu                                    { get; set; }
        public TransferContactPopupView?                TransferContact                         { get; set; }

        public static TitlePopupReference? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TitlePopupReference();

            value.License                                   = GetObject<TitleLicensePopupView>(new IntPtr(p + 0x020), ReversePrism.DataModels.TitleLicensePopupView.FromPointer); // 027004371078 0x20 License                     ( 0001866785C0 ModelClassType TitleLicensePopupView TitleLicensePopupView TitleLicensePopupView Pointer )
            value.Transfer                                  = GetObject<TitleTransferPopupView>(new IntPtr(p + 0x028), ReversePrism.DataModels.TitleTransferPopupView.FromPointer); // 027004371098 0x28 Transfer                    ( 00018667BE20 ModelClassType TitleTransferPopupView TitleTransferPopupView TitleTransferPopupView Pointer )
            value.NameInput                                 = GetObject<TitleNameInputPopupView>(new IntPtr(p + 0x030), ReversePrism.DataModels.TitleNameInputPopupView.FromPointer); // 0270043710B8 0x30 NameInput                   ( 00018667A5A0 ModelClassType TitleNameInputPopupView TitleNameInputPopupView TitleNameInputPopupView Pointer )
            value.Att                                       = GetObject<TitleATTPopupView>(new IntPtr(p + 0x040), ReversePrism.DataModels.TitleATTPopupView.FromPointer); // 0270043710F8 0x40 Att                         ( 0001866766A0 ModelClassType TitleATTPopupView TitleATTPopupView TitleATTPopupView Pointer )
            value.Menu                                      = GetObject<TitleMenuPopupView>(new IntPtr(p + 0x048), ReversePrism.DataModels.TitleMenuPopupView.FromPointer); // 027004371118 0x48 Menu                        ( 000186679920 ModelClassType TitleMenuPopupView TitleMenuPopupView TitleMenuPopupView Pointer )
            value.TransferContact                           = GetObject<TransferContactPopupView>(new IntPtr(p + 0x050), ReversePrism.DataModels.TransferContactPopupView.FromPointer); // 027004371138 0x50 TransferContact             ( 0001866A3D90 ModelClassType TransferContactPopupView TransferContactPopupView TransferContactPopupView Pointer )

            return value;
        }
    }
}
