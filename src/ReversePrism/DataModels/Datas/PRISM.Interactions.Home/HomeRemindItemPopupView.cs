using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 RemindItemListView                       ModelClassType HomeRemindItemListView HomeRemindItemListView HomeRemindItemListView Pointer
    // 028 ReplaceMeshTexts                         ModelClassListType UITextMeshProUGUI[] UITextMeshProUGUI[] List<UITextMeshProUGUI> Pointer
    // 030 onClosed                                 Subject`1<HomeRemindItemListViewModel> IL2CPP_TYPE_GENERICINST
    // 038 Parent                                   ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class HomeRemindItemPopupView : DataModel
    {
        public HomeRemindItemListView?                  RemindItemListView                      { get; set; }
        public List<UITextMeshProUGUI>?                 ReplaceMeshTexts                        { get; set; }
        public IPopupFrameView?                         Parent                                  { get; set; }

        public static HomeRemindItemPopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new HomeRemindItemPopupView() { Pointer= p0 };

            value.RemindItemListView                        = GetObject<HomeRemindItemListView>(new IntPtr(p + 0x020), ReversePrism.DataModels.HomeRemindItemListView.FromPointer); // 0x20 RemindItemListView          ( ModelClassType HomeRemindItemListView HomeRemindItemListView HomeRemindItemListView Pointer )
            value.ReplaceMeshTexts                          = GetObjectList<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x28 ReplaceMeshTexts            ( ModelClassListType UITextMeshProUGUI[] UITextMeshProUGUI[] List<UITextMeshProUGUI> Pointer )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x038), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 0x38 Parent                      ( ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
