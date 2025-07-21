using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 040 ItemIcon                                 ModelClassType RewardItemIcon RewardItemIcon RewardItemIcon Pointer
    // 048 Label                                    ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 050 Discription                              ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    public partial class ItemListExpireDetailListViewCell : DataModel
    {
        public RewardItemIcon?                          ItemIcon                                { get; set; }
        public UITextMeshProUGUI?                       Label                                   { get; set; }
        public UITextMeshProUGUI?                       Discription                             { get; set; }

        public static ItemListExpireDetailListViewCell? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ItemListExpireDetailListViewCell() { Pointer= p0 };

            value.ItemIcon                                  = GetObject<RewardItemIcon>(new IntPtr(p + 0x040), ReversePrism.DataModels.RewardItemIcon.FromPointer); // 0x40 ItemIcon                    ( ModelClassType RewardItemIcon RewardItemIcon RewardItemIcon Pointer )
            value.Label                                     = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x048), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x48 Label                       ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.Discription                               = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x050), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x50 Discription                 ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )

            return value;
        }
    }
}
