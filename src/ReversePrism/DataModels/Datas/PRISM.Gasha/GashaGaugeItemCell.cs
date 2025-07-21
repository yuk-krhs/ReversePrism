using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ItemIcon                                 ModelClassType RewardItem RewardItem RewardItem Pointer
    // 028 TxtPrismPoint                            ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 030 TxtItemName                              ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 GoDone                                   ModelClassType GameObject GameObject GameObject Pointer
    public partial class GashaGaugeItemCell : DataModel
    {
        public RewardItem?                              ItemIcon                                { get; set; }
        public UITextMeshProUGUI?                       TxtPrismPoint                           { get; set; }
        public UITextMeshProUGUI?                       TxtItemName                             { get; set; }
        public GameObject?                              GoDone                                  { get; set; }

        public static GashaGaugeItemCell? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GashaGaugeItemCell() { Pointer= p0 };

            value.ItemIcon                                  = GetObject<RewardItem>(new IntPtr(p + 0x020), ReversePrism.DataModels.RewardItem.FromPointer); // 0x20 ItemIcon                    ( ModelClassType RewardItem RewardItem RewardItem Pointer )
            value.TxtPrismPoint                             = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x28 TxtPrismPoint               ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtItemName                               = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x30 TxtItemName                 ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.GoDone                                    = GetObject<GameObject>(new IntPtr(p + 0x038), ReversePrism.DataModels.GameObject.FromPointer); // 0x38 GoDone                      ( ModelClassType GameObject GameObject GameObject Pointer )

            return value;
        }
    }
}
