using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 040 ItemIcon                                 ModelClassType RewardItemIcon RewardItemIcon RewardItemIcon Pointer
    // 048 NameText                                 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 050 LimitText                                ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 058 ButtonText                               ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 060 GotoButton                               ModelClassType UIButton UIButton UIButton Pointer
    // 068 IntervalDisposable                       ModelClassType IDisposable IDisposable IDisposable Pointer
    // 070 GotoButtonDisposable                     ModelClassType IDisposable IDisposable IDisposable Pointer
    // 078 onClick                                  Subject`1<HomeRemindItemListViewModel> IL2CPP_TYPE_GENERICINST
    public partial class HomeRemindItemListViewCell : DataModel
    {
        public RewardItemIcon?                          ItemIcon                                { get; set; }
        public UITextMeshProUGUI?                       NameText                                { get; set; }
        public UITextMeshProUGUI?                       LimitText                               { get; set; }
        public UITextMeshProUGUI?                       ButtonText                              { get; set; }
        public UIButton?                                GotoButton                              { get; set; }
        public IDisposable?                             IntervalDisposable                      { get; set; }
        public IDisposable?                             GotoButtonDisposable                    { get; set; }

        public static HomeRemindItemListViewCell? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new HomeRemindItemListViewCell() { Pointer= p0 };

            value.ItemIcon                                  = GetObject<RewardItemIcon>(new IntPtr(p + 0x040), ReversePrism.DataModels.RewardItemIcon.FromPointer); // 0x40 ItemIcon                    ( ModelClassType RewardItemIcon RewardItemIcon RewardItemIcon Pointer )
            value.NameText                                  = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x048), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x48 NameText                    ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.LimitText                                 = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x050), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x50 LimitText                   ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ButtonText                                = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x058), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x58 ButtonText                  ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.GotoButton                                = GetObject<UIButton>(new IntPtr(p + 0x060), ReversePrism.DataModels.UIButton.FromPointer); // 0x60 GotoButton                  ( ModelClassType UIButton UIButton UIButton Pointer )
            value.IntervalDisposable                        = GetObject<IDisposable>(new IntPtr(p + 0x068), ReversePrism.DataModels.IDisposable.FromPointer); // 0x68 IntervalDisposable          ( ModelClassType IDisposable IDisposable IDisposable Pointer )
            value.GotoButtonDisposable                      = GetObject<IDisposable>(new IntPtr(p + 0x070), ReversePrism.DataModels.IDisposable.FromPointer); // 0x70 GotoButtonDisposable        ( ModelClassType IDisposable IDisposable IDisposable Pointer )

            return value;
        }
    }
}
