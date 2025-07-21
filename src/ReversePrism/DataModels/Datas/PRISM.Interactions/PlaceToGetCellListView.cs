using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Scroller                                 ModelClassType EnhancedScroller EnhancedScroller EnhancedScroller Pointer
    // 028 PlaceToGetCellViewPrefab                 ModelClassType PlaceToGetCellView PlaceToGetCellView PlaceToGetCellView Pointer
    // 030 Context                                  ModelClassType PlaceToGetCellListContext PlaceToGetCellListContext PlaceToGetCellListContext Pointer
    // 038 VmList                                   ModelClassListType List`1<HowToGetItemsIconViewModel> List`1<HowToGetItemsIconViewModel> List<HowToGetItemsIconViewModel> Pointer
    // 040 <OnSelectPlace>k__BackingField           IObservable`1<ValueTuple`2<ButtonGoToType, string>> IL2CPP_TYPE_GENERICINST
    public partial class PlaceToGetCellListView : DataModel
    {
        public EnhancedScroller?                        Scroller                                { get; set; }
        public PlaceToGetCellView?                      PlaceToGetCellViewPrefab                { get; set; }
        public PlaceToGetCellListContext?               Context                                 { get; set; }
        public List<HowToGetItemsIconViewModel>?        VmList                                  { get; set; }

        public static PlaceToGetCellListView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PlaceToGetCellListView() { Pointer= p0 };

            value.Scroller                                  = GetObject<EnhancedScroller>(new IntPtr(p + 0x020), ReversePrism.DataModels.EnhancedScroller.FromPointer); // 0x20 Scroller                    ( ModelClassType EnhancedScroller EnhancedScroller EnhancedScroller Pointer )
            value.PlaceToGetCellViewPrefab                  = GetObject<PlaceToGetCellView>(new IntPtr(p + 0x028), ReversePrism.DataModels.PlaceToGetCellView.FromPointer); // 0x28 PlaceToGetCellViewPrefab    ( ModelClassType PlaceToGetCellView PlaceToGetCellView PlaceToGetCellView Pointer )
            value.Context                                   = GetObject<PlaceToGetCellListContext>(new IntPtr(p + 0x030), ReversePrism.DataModels.PlaceToGetCellListContext.FromPointer); // 0x30 Context                     ( ModelClassType PlaceToGetCellListContext PlaceToGetCellListContext PlaceToGetCellListContext Pointer )
            value.VmList                                    = GetObjectList<HowToGetItemsIconViewModel>(new IntPtr(p + 0x038), ReversePrism.DataModels.HowToGetItemsIconViewModel.FromPointer); // 0x38 VmList                      ( ModelClassListType List`1<HowToGetItemsIconViewModel> List`1<HowToGetItemsIconViewModel> List<HowToGetItemsIconViewModel> Pointer )

            return value;
        }
    }
}
