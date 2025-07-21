using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 PlaceToGetCellListView                   ModelClassType PlaceToGetCellListView PlaceToGetCellListView PlaceToGetCellListView Pointer
    // 028 onClick                                  Subject`1<ValueTuple`2<ButtonGoToType, string>> IL2CPP_TYPE_GENERICINST
    // 030 Parent                                   ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class HowToGetItemsPopupView : DataModel
    {
        public PlaceToGetCellListView?                  PlaceToGetCellListView                  { get; set; }
        public IPopupFrameView?                         Parent                                  { get; set; }

        public static HowToGetItemsPopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new HowToGetItemsPopupView() { Pointer= p0 };

            value.PlaceToGetCellListView                    = GetObject<PlaceToGetCellListView>(new IntPtr(p + 0x020), ReversePrism.DataModels.PlaceToGetCellListView.FromPointer); // 0x20 PlaceToGetCellListView      ( ModelClassType PlaceToGetCellListView PlaceToGetCellListView PlaceToGetCellListView Pointer )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x030), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 0x30 Parent                      ( ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
