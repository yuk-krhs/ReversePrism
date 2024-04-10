using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 PopupHeaderText                          0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 028 ItemCellPrefab                           0001865B1BE0 ModelClassType StoryUnlockPopupItemCell StoryUnlockPopupItemCell StoryUnlockPopupItemCell Pointer
    // 030 ItemCellPos                              0001866AA150 ModelClassType Transform Transform Transform Pointer
    // 038 onCloseRequested                         Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 040 Parent                                   0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class StoryUnlockPopupView : DataModel
    {
        public UITextMeshProUGUI?                       PopupHeaderText                         { get; set; }
        public StoryUnlockPopupItemCell?                ItemCellPrefab                          { get; set; }
        public Transform?                               ItemCellPos                             { get; set; }
        public IPopupFrameView?                         Parent                                  { get; set; }

        public static StoryUnlockPopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StoryUnlockPopupView() { Pointer= p0 };

            value.PopupHeaderText                           = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x020), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466B625468 0x20 PopupHeaderText             ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ItemCellPrefab                            = GetObject<StoryUnlockPopupItemCell>(new IntPtr(p + 0x028), ReversePrism.DataModels.StoryUnlockPopupItemCell.FromPointer); // 02466B625488 0x28 ItemCellPrefab              ( 0001865B1BE0 ModelClassType StoryUnlockPopupItemCell StoryUnlockPopupItemCell StoryUnlockPopupItemCell Pointer )
            value.ItemCellPos                               = GetObject<Transform>(new IntPtr(p + 0x030), ReversePrism.DataModels.Transform.FromPointer); // 02466B6254A8 0x30 ItemCellPos                 ( 0001866AA150 ModelClassType Transform Transform Transform Pointer )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x040), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 02466B6254E8 0x40 Parent                      ( 0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
