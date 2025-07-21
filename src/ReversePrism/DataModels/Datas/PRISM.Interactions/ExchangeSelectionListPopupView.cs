using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ItemPrefab                               ModelClassType GameObject GameObject GameObject Pointer
    // 028 ItemListContent                          ModelClassType Transform Transform Transform Pointer
    // 030 ExpireDateText                           ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 TicketIcon                               ModelClassType RewardItem RewardItem RewardItem Pointer
    // 040 TicketCountText                          ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 048 CautionText                              ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 050 onSelectItemSubject                      Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 058 onClose                                  Subject`1<bool> IL2CPP_TYPE_GENERICINST
    // 060 ViewModel                                ModelClassType ExchangeSelectionListPopupViewModel ExchangeSelectionListPopupViewModel ExchangeSelectionListPopupViewModel Pointer
    // 068 ItemViews                                ModelClassListType List`1<ExchangeSelectionItemView> List`1<ExchangeSelectionItemView> List<ExchangeSelectionItemView> Pointer
    // 070 Parent                                   ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class ExchangeSelectionListPopupView : DataModel
    {
        public GameObject?                              ItemPrefab                              { get; set; }
        public Transform?                               ItemListContent                         { get; set; }
        public UITextMeshProUGUI?                       ExpireDateText                          { get; set; }
        public RewardItem?                              TicketIcon                              { get; set; }
        public UITextMeshProUGUI?                       TicketCountText                         { get; set; }
        public UITextMeshProUGUI?                       CautionText                             { get; set; }
        public ExchangeSelectionListPopupViewModel?     ViewModel                               { get; set; }
        public List<ExchangeSelectionItemView>?         ItemViews                               { get; set; }
        public IPopupFrameView?                         Parent                                  { get; set; }

        public static ExchangeSelectionListPopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ExchangeSelectionListPopupView() { Pointer= p0 };

            value.ItemPrefab                                = GetObject<GameObject>(new IntPtr(p + 0x020), ReversePrism.DataModels.GameObject.FromPointer); // 0x20 ItemPrefab                  ( ModelClassType GameObject GameObject GameObject Pointer )
            value.ItemListContent                           = GetObject<Transform>(new IntPtr(p + 0x028), ReversePrism.DataModels.Transform.FromPointer); // 0x28 ItemListContent             ( ModelClassType Transform Transform Transform Pointer )
            value.ExpireDateText                            = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x30 ExpireDateText              ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TicketIcon                                = GetObject<RewardItem>(new IntPtr(p + 0x038), ReversePrism.DataModels.RewardItem.FromPointer); // 0x38 TicketIcon                  ( ModelClassType RewardItem RewardItem RewardItem Pointer )
            value.TicketCountText                           = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x040), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x40 TicketCountText             ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.CautionText                               = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x048), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x48 CautionText                 ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ViewModel                                 = GetObject<ExchangeSelectionListPopupViewModel>(new IntPtr(p + 0x060), ReversePrism.DataModels.ExchangeSelectionListPopupViewModel.FromPointer); // 0x60 ViewModel                   ( ModelClassType ExchangeSelectionListPopupViewModel ExchangeSelectionListPopupViewModel ExchangeSelectionListPopupViewModel Pointer )
            value.ItemViews                                 = GetObjectList<ExchangeSelectionItemView>(new IntPtr(p + 0x068), ReversePrism.DataModels.ExchangeSelectionItemView.FromPointer); // 0x68 ItemViews                   ( ModelClassListType List`1<ExchangeSelectionItemView> List`1<ExchangeSelectionItemView> List<ExchangeSelectionItemView> Pointer )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x070), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 0x70 Parent                      ( ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
