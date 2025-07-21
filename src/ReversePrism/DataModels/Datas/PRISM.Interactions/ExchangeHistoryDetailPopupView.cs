using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ExchangeItemView                         ModelClassType ExchangeHistoryItemView ExchangeHistoryItemView ExchangeHistoryItemView Pointer
    // 028 ExchangeHistoryDetailItemContainerView   ModelClassType ExchangeHistoryDetailItemContainerView ExchangeHistoryDetailItemContainerView ExchangeHistoryDetailItemContainerView Pointer
    // 000 HistoryDetalTitleKey                     int IL2CPP_TYPE_I4
    // 030 onClick                                  Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 038 Parent                                   ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class ExchangeHistoryDetailPopupView : DataModel
    {
        public ExchangeHistoryItemView?                 ExchangeItemView                        { get; set; }
        public ExchangeHistoryDetailItemContainerView?  ExchangeHistoryDetailItemContainerView  { get; set; }
        public IPopupFrameView?                         Parent                                  { get; set; }

        public static ExchangeHistoryDetailPopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ExchangeHistoryDetailPopupView() { Pointer= p0 };

            value.ExchangeItemView                          = GetObject<ExchangeHistoryItemView>(new IntPtr(p + 0x020), ReversePrism.DataModels.ExchangeHistoryItemView.FromPointer); // 0x20 ExchangeItemView            ( ModelClassType ExchangeHistoryItemView ExchangeHistoryItemView ExchangeHistoryItemView Pointer )
            value.ExchangeHistoryDetailItemContainerView    = GetObject<ExchangeHistoryDetailItemContainerView>(new IntPtr(p + 0x028), ReversePrism.DataModels.ExchangeHistoryDetailItemContainerView.FromPointer); // 0x28 ExchangeHistoryDetailItemContainerView ( ModelClassType ExchangeHistoryDetailItemContainerView ExchangeHistoryDetailItemContainerView ExchangeHistoryDetailItemContainerView Pointer )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x038), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 0x38 Parent                      ( ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
