using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 License                                  ModelClassType TitleLicensePopupView TitleLicensePopupView TitleLicensePopupView Pointer
    // 028 Transfer                                 ModelClassType TitleTransferPopupView TitleTransferPopupView TitleTransferPopupView Pointer
    // 030 NameInput                                ModelClassType TitleNameInputPopupView TitleNameInputPopupView TitleNameInputPopupView Pointer
    // 038 Att                                      ModelClassType TitleATTPopupView TitleATTPopupView TitleATTPopupView Pointer
    // 040 Menu                                     ModelClassType TitleMenuPopupView TitleMenuPopupView TitleMenuPopupView Pointer
    // 048 TransferContact                          ModelClassType TransferContactPopupView TransferContactPopupView TransferContactPopupView Pointer
    public partial class TitlePopupReference : DataModel
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
            var value   = new TitlePopupReference() { Pointer= p0 };

            value.License                                   = GetObject<TitleLicensePopupView>(new IntPtr(p + 0x020), ReversePrism.DataModels.TitleLicensePopupView.FromPointer); // 0x20 License                     ( ModelClassType TitleLicensePopupView TitleLicensePopupView TitleLicensePopupView Pointer )
            value.Transfer                                  = GetObject<TitleTransferPopupView>(new IntPtr(p + 0x028), ReversePrism.DataModels.TitleTransferPopupView.FromPointer); // 0x28 Transfer                    ( ModelClassType TitleTransferPopupView TitleTransferPopupView TitleTransferPopupView Pointer )
            value.NameInput                                 = GetObject<TitleNameInputPopupView>(new IntPtr(p + 0x030), ReversePrism.DataModels.TitleNameInputPopupView.FromPointer); // 0x30 NameInput                   ( ModelClassType TitleNameInputPopupView TitleNameInputPopupView TitleNameInputPopupView Pointer )
            value.Att                                       = GetObject<TitleATTPopupView>(new IntPtr(p + 0x038), ReversePrism.DataModels.TitleATTPopupView.FromPointer); // 0x38 Att                         ( ModelClassType TitleATTPopupView TitleATTPopupView TitleATTPopupView Pointer )
            value.Menu                                      = GetObject<TitleMenuPopupView>(new IntPtr(p + 0x040), ReversePrism.DataModels.TitleMenuPopupView.FromPointer); // 0x40 Menu                        ( ModelClassType TitleMenuPopupView TitleMenuPopupView TitleMenuPopupView Pointer )
            value.TransferContact                           = GetObject<TransferContactPopupView>(new IntPtr(p + 0x048), ReversePrism.DataModels.TransferContactPopupView.FromPointer); // 0x48 TransferContact             ( ModelClassType TransferContactPopupView TransferContactPopupView TransferContactPopupView Pointer )

            return value;
        }
    }
}
