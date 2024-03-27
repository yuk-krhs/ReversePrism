using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ItemIcon                                 00018667EAE0 ModelClassType RewardItem RewardItem RewardItem Pointer
    // 028 ExpireLabel                              00018673DEF0 ModelClassType ItemExpireLabel ItemExpireLabel ItemExpireLabel Pointer
    // 030 SelectedCursor                           0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 038 selectSubject                            Subject`1<IHavingProductStatus> IL2CPP_TYPE_GENERICINST
    public partial class ItemListIcon
    {
        public RewardItem?                              ItemIcon                                { get; set; }
        public ItemExpireLabel?                         ExpireLabel                             { get; set; }
        public GameObject?                              SelectedCursor                          { get; set; }

        public static ItemListIcon? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ItemListIcon();

            value.ItemIcon                                  = GetObject<RewardItem>(new IntPtr(p + 0x020), ReversePrism.DataModels.RewardItem.FromPointer); // 0270D4BC1190 0x20 ItemIcon                    ( 00018667EAE0 ModelClassType RewardItem RewardItem RewardItem Pointer )
            value.ExpireLabel                               = GetObject<ItemExpireLabel>(new IntPtr(p + 0x028), ReversePrism.DataModels.ItemExpireLabel.FromPointer); // 0270D4BC11B0 0x28 ExpireLabel                 ( 00018673DEF0 ModelClassType ItemExpireLabel ItemExpireLabel ItemExpireLabel Pointer )
            value.SelectedCursor                            = GetObject<GameObject>(new IntPtr(p + 0x030), ReversePrism.DataModels.GameObject.FromPointer); // 0270D4BC11D0 0x30 SelectedCursor              ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )

            return value;
        }
    }
}
