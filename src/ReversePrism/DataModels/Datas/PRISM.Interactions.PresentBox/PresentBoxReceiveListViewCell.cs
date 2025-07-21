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
    public partial class PresentBoxReceiveListViewCell : DataModel
    {
        public RewardItemIcon?                          ItemIcon                                { get; set; }
        public UITextMeshProUGUI?                       NameText                                { get; set; }

        public static PresentBoxReceiveListViewCell? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PresentBoxReceiveListViewCell() { Pointer= p0 };

            value.ItemIcon                                  = GetObject<RewardItemIcon>(new IntPtr(p + 0x040), ReversePrism.DataModels.RewardItemIcon.FromPointer); // 0x40 ItemIcon                    ( ModelClassType RewardItemIcon RewardItemIcon RewardItemIcon Pointer )
            value.NameText                                  = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x048), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x48 NameText                    ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )

            return value;
        }
    }
}
