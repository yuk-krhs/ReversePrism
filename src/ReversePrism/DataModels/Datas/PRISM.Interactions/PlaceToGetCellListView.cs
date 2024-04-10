using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Scroller                                 000186735270 ModelClassType EnhancedScroller EnhancedScroller EnhancedScroller Pointer
    // 028 PlaceToGetCellViewPrefab                 0001867463F0 ModelClassType PlaceToGetCellView PlaceToGetCellView PlaceToGetCellView Pointer
    // 030 Context                                  000186745840 ModelClassType PlaceToGetCellListContext PlaceToGetCellListContext PlaceToGetCellListContext Pointer
    // 038 VmList                                   000185CE03A8 ModelClassListType List`1<HowToGetItemsPopupViewModel> List`1<HowToGetItemsPopupViewModel> List<HowToGetItemsPopupViewModel> Pointer
    // 040 <OnSelectPlace>k__BackingField           IObservable`1<ValueTuple`2<ButtonGoToType, string>> IL2CPP_TYPE_GENERICINST
    public partial class PlaceToGetCellListView : DataModel
    {
        public EnhancedScroller?                        Scroller                                { get; set; }
        public PlaceToGetCellView?                      PlaceToGetCellViewPrefab                { get; set; }
        public PlaceToGetCellListContext?               Context                                 { get; set; }
        public List<HowToGetItemsPopupViewModel>?       VmList                                  { get; set; }

        public static PlaceToGetCellListView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PlaceToGetCellListView() { Pointer= p0 };

            value.Scroller                                  = GetObject<EnhancedScroller>(new IntPtr(p + 0x020), ReversePrism.DataModels.EnhancedScroller.FromPointer); // 02466A340800 0x20 Scroller                    ( 000186735270 ModelClassType EnhancedScroller EnhancedScroller EnhancedScroller Pointer )
            value.PlaceToGetCellViewPrefab                  = GetObject<PlaceToGetCellView>(new IntPtr(p + 0x028), ReversePrism.DataModels.PlaceToGetCellView.FromPointer); // 02466A340820 0x28 PlaceToGetCellViewPrefab    ( 0001867463F0 ModelClassType PlaceToGetCellView PlaceToGetCellView PlaceToGetCellView Pointer )
            value.Context                                   = GetObject<PlaceToGetCellListContext>(new IntPtr(p + 0x030), ReversePrism.DataModels.PlaceToGetCellListContext.FromPointer); // 02466A340840 0x30 Context                     ( 000186745840 ModelClassType PlaceToGetCellListContext PlaceToGetCellListContext PlaceToGetCellListContext Pointer )
            value.VmList                                    = GetObjectList<HowToGetItemsPopupViewModel>(new IntPtr(p + 0x038), ReversePrism.DataModels.HowToGetItemsPopupViewModel.FromPointer); // 02466A340860 0x38 VmList                      ( 000185CE03A8 ModelClassListType List`1<HowToGetItemsPopupViewModel> List`1<HowToGetItemsPopupViewModel> List<HowToGetItemsPopupViewModel> Pointer )

            return value;
        }
    }
}
