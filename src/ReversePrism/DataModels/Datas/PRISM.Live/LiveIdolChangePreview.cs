using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 BeforeEmpty                              0001867037B0 ModelClassType PFIdolIconRectEmptyView PFIdolIconRectEmptyView PFIdolIconRectEmptyView Pointer
    // 028 BeforeIcon                               000186703B70 ModelClassType PFIdolIconRectView PFIdolIconRectView PFIdolIconRectView Pointer
    // 030 AfterEmpty                               0001867037B0 ModelClassType PFIdolIconRectEmptyView PFIdolIconRectEmptyView PFIdolIconRectEmptyView Pointer
    // 038 AfterIcon                                000186703B70 ModelClassType PFIdolIconRectView PFIdolIconRectView PFIdolIconRectView Pointer
    // 040 PIdolDetailPopupCaller                   000186709050 ModelClassType PIdolDetailPopupCaller PIdolDetailPopupCaller PIdolDetailPopupCaller Pointer
    // 048 FIdolDetailPopupCaller                   000186541E70 ModelClassType FIdolDetailPopupCaller FIdolDetailPopupCaller FIdolDetailPopupCaller Pointer
    // 050 AfterIconCanceller                       000186724470 ModelEnumType AutoCancellationTokenSource AutoCancellationTokenSource AutoCancellationTokenSource Int32
    public partial class LiveIdolChangePreview
    {
        public PFIdolIconRectEmptyView?                 BeforeEmpty                             { get; set; }
        public PFIdolIconRectView?                      BeforeIcon                              { get; set; }
        public PFIdolIconRectEmptyView?                 AfterEmpty                              { get; set; }
        public PFIdolIconRectView?                      AfterIcon                               { get; set; }
        public PIdolDetailPopupCaller?                  PIdolDetailPopupCaller                  { get; set; }
        public FIdolDetailPopupCaller?                  FIdolDetailPopupCaller                  { get; set; }
        public AutoCancellationTokenSource              AfterIconCanceller                      { get; set; }

        public static LiveIdolChangePreview? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveIdolChangePreview();

            value.BeforeEmpty                               = GetObject<PFIdolIconRectEmptyView>(new IntPtr(p + 0x020), ReversePrism.DataModels.PFIdolIconRectEmptyView.FromPointer); // 0270D51D8C00 0x20 BeforeEmpty                 ( 0001867037B0 ModelClassType PFIdolIconRectEmptyView PFIdolIconRectEmptyView PFIdolIconRectEmptyView Pointer )
            value.BeforeIcon                                = GetObject<PFIdolIconRectView>(new IntPtr(p + 0x028), ReversePrism.DataModels.PFIdolIconRectView.FromPointer); // 0270D51D8C20 0x28 BeforeIcon                  ( 000186703B70 ModelClassType PFIdolIconRectView PFIdolIconRectView PFIdolIconRectView Pointer )
            value.AfterEmpty                                = GetObject<PFIdolIconRectEmptyView>(new IntPtr(p + 0x030), ReversePrism.DataModels.PFIdolIconRectEmptyView.FromPointer); // 0270D51D8C40 0x30 AfterEmpty                  ( 0001867037B0 ModelClassType PFIdolIconRectEmptyView PFIdolIconRectEmptyView PFIdolIconRectEmptyView Pointer )
            value.AfterIcon                                 = GetObject<PFIdolIconRectView>(new IntPtr(p + 0x038), ReversePrism.DataModels.PFIdolIconRectView.FromPointer); // 0270D51D8C60 0x38 AfterIcon                   ( 000186703B70 ModelClassType PFIdolIconRectView PFIdolIconRectView PFIdolIconRectView Pointer )
            value.PIdolDetailPopupCaller                    = GetObject<PIdolDetailPopupCaller>(new IntPtr(p + 0x040), ReversePrism.DataModels.PIdolDetailPopupCaller.FromPointer); // 0270D51D8C80 0x40 PIdolDetailPopupCaller      ( 000186709050 ModelClassType PIdolDetailPopupCaller PIdolDetailPopupCaller PIdolDetailPopupCaller Pointer )
            value.FIdolDetailPopupCaller                    = GetObject<FIdolDetailPopupCaller>(new IntPtr(p + 0x048), ReversePrism.DataModels.FIdolDetailPopupCaller.FromPointer); // 0270D51D8CA0 0x48 FIdolDetailPopupCaller      ( 000186541E70 ModelClassType FIdolDetailPopupCaller FIdolDetailPopupCaller FIdolDetailPopupCaller Pointer )
            value.AfterIconCanceller                        = (AutoCancellationTokenSource)GetInt32(new IntPtr(p + 0x050)); // 0270D51D8CC0 0x50 AfterIconCanceller          ( 000186724470 ModelEnumType AutoCancellationTokenSource AutoCancellationTokenSource AutoCancellationTokenSource Int32 )

            return value;
        }
    }
}
