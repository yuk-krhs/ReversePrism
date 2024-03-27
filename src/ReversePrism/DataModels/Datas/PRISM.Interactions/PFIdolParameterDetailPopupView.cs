using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 CellBase                                 0001867052B0 ModelClassType PFIdolParameterDetailPopupViewCell PFIdolParameterDetailPopupViewCell PFIdolParameterDetailPopupViewCell Pointer
    // 028 onClosed                                 Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 030 Parent                                   0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    // 038 IpfIdolParameterDetailPopupViewImplementation 0001865CDF60 ModelClassType IPFIdolParameterDetailPopupView IPFIdolParameterDetailPopupView IPFIdolParameterDetailPopupView Pointer
    public partial class PFIdolParameterDetailPopupView
    {
        public PFIdolParameterDetailPopupViewCell?      CellBase                                { get; set; }
        public IPopupFrameView?                         Parent                                  { get; set; }
        public IPFIdolParameterDetailPopupView?         IpfIdolParameterDetailPopupViewImplementation { get; set; }

        public static PFIdolParameterDetailPopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PFIdolParameterDetailPopupView();

            value.CellBase                                  = GetObject<PFIdolParameterDetailPopupViewCell>(new IntPtr(p + 0x020), ReversePrism.DataModels.PFIdolParameterDetailPopupViewCell.FromPointer); // 0270DA3051D8 0x20 CellBase                    ( 0001867052B0 ModelClassType PFIdolParameterDetailPopupViewCell PFIdolParameterDetailPopupViewCell PFIdolParameterDetailPopupViewCell Pointer )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x030), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 0270DA305218 0x30 Parent                      ( 0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )
            value.IpfIdolParameterDetailPopupViewImplementation = GetObject<IPFIdolParameterDetailPopupView>(new IntPtr(p + 0x038), ReversePrism.DataModels.IPFIdolParameterDetailPopupView.FromPointer); // 0270DA305238 0x38 IpfIdolParameterDetailPopupViewImplementation ( 0001865CDF60 ModelClassType IPFIdolParameterDetailPopupView IPFIdolParameterDetailPopupView IPFIdolParameterDetailPopupView Pointer )

            return value;
        }
    }
}
