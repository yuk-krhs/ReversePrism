using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ExchangeItemView                         00018650BC70 ModelClassType ExchangeHistoryItemView ExchangeHistoryItemView ExchangeHistoryItemView Pointer
    // 028 ExchangeHistoryDetailItemContainerView   00018650B2B0 ModelClassType ExchangeHistoryDetailItemContainerView ExchangeHistoryDetailItemContainerView ExchangeHistoryDetailItemContainerView Pointer
    // 000 HistoryDetalTitleKey                     int IL2CPP_TYPE_I4
    // 030 onClick                                  Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 038 Parent                                   0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class ExchangeHistoryDetailPopupView
    {
        public ExchangeHistoryItemView?                 ExchangeItemView                        { get; set; }
        public ExchangeHistoryDetailItemContainerView?  ExchangeHistoryDetailItemContainerView  { get; set; }
        public IPopupFrameView?                         Parent                                  { get; set; }

        public static ExchangeHistoryDetailPopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ExchangeHistoryDetailPopupView();

            value.ExchangeItemView                          = GetObject<ExchangeHistoryItemView>(new IntPtr(p + 0x020), ReversePrism.DataModels.ExchangeHistoryItemView.FromPointer); // 0270DB8EB090 0x20 ExchangeItemView            ( 00018650BC70 ModelClassType ExchangeHistoryItemView ExchangeHistoryItemView ExchangeHistoryItemView Pointer )
            value.ExchangeHistoryDetailItemContainerView    = GetObject<ExchangeHistoryDetailItemContainerView>(new IntPtr(p + 0x028), ReversePrism.DataModels.ExchangeHistoryDetailItemContainerView.FromPointer); // 0270DB8EB0B0 0x28 ExchangeHistoryDetailItemContainerView ( 00018650B2B0 ModelClassType ExchangeHistoryDetailItemContainerView ExchangeHistoryDetailItemContainerView ExchangeHistoryDetailItemContainerView Pointer )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x038), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 0270DB8EB110 0x38 Parent                      ( 0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
