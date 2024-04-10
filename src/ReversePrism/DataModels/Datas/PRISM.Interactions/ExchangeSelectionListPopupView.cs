using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ItemPrefab                               0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 028 ItemListContent                          0001866AA150 ModelClassType Transform Transform Transform Pointer
    // 030 ExpireDateText                           0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 TicketIcon                               00018667EAE0 ModelClassType RewardItem RewardItem RewardItem Pointer
    // 040 TicketCountText                          0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 048 CautionText                              0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 050 onSelectItemSubject                      Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 058 onClose                                  Subject`1<bool> IL2CPP_TYPE_GENERICINST
    // 060 ViewModel                                00018651A2F0 ModelClassType ExchangeSelectionListPopupViewModel ExchangeSelectionListPopupViewModel ExchangeSelectionListPopupViewModel Pointer
    // 068 ItemViews                                000185CDB268 ModelClassListType List`1<ExchangeSelectionItemView> List`1<ExchangeSelectionItemView> List<ExchangeSelectionItemView> Pointer
    // 070 Parent                                   0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
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

            value.ItemPrefab                                = GetObject<GameObject>(new IntPtr(p + 0x020), ReversePrism.DataModels.GameObject.FromPointer); // 02466B975068 0x20 ItemPrefab                  ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.ItemListContent                           = GetObject<Transform>(new IntPtr(p + 0x028), ReversePrism.DataModels.Transform.FromPointer); // 02466B975088 0x28 ItemListContent             ( 0001866AA150 ModelClassType Transform Transform Transform Pointer )
            value.ExpireDateText                            = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466B9750A8 0x30 ExpireDateText              ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TicketIcon                                = GetObject<RewardItem>(new IntPtr(p + 0x038), ReversePrism.DataModels.RewardItem.FromPointer); // 02466B9750C8 0x38 TicketIcon                  ( 00018667EAE0 ModelClassType RewardItem RewardItem RewardItem Pointer )
            value.TicketCountText                           = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x040), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466B9750E8 0x40 TicketCountText             ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.CautionText                               = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x048), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466B975108 0x48 CautionText                 ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ViewModel                                 = GetObject<ExchangeSelectionListPopupViewModel>(new IntPtr(p + 0x060), ReversePrism.DataModels.ExchangeSelectionListPopupViewModel.FromPointer); // 02466B975168 0x60 ViewModel                   ( 00018651A2F0 ModelClassType ExchangeSelectionListPopupViewModel ExchangeSelectionListPopupViewModel ExchangeSelectionListPopupViewModel Pointer )
            value.ItemViews                                 = GetObjectList<ExchangeSelectionItemView>(new IntPtr(p + 0x068), ReversePrism.DataModels.ExchangeSelectionItemView.FromPointer); // 02466B975188 0x68 ItemViews                   ( 000185CDB268 ModelClassListType List`1<ExchangeSelectionItemView> List`1<ExchangeSelectionItemView> List<ExchangeSelectionItemView> Pointer )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x070), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 02466B9751A8 0x70 Parent                      ( 0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
