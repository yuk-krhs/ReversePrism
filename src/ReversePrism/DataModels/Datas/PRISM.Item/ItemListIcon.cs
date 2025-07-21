using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ItemIcon                                 ModelClassType RewardItem RewardItem RewardItem Pointer
    // 028 ExpireLabel                              ModelClassType ItemExpireLabel ItemExpireLabel ItemExpireLabel Pointer
    // 030 SelectedCursor                           ModelClassType GameObject GameObject GameObject Pointer
    // 038 selectSubject                            Subject`1<IHavingProductStatus> IL2CPP_TYPE_GENERICINST
    public partial class ItemListIcon : DataModel
    {
        public RewardItem?                              ItemIcon                                { get; set; }
        public ItemExpireLabel?                         ExpireLabel                             { get; set; }
        public GameObject?                              SelectedCursor                          { get; set; }

        public static ItemListIcon? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ItemListIcon() { Pointer= p0 };

            value.ItemIcon                                  = GetObject<RewardItem>(new IntPtr(p + 0x020), ReversePrism.DataModels.RewardItem.FromPointer); // 0x20 ItemIcon                    ( ModelClassType RewardItem RewardItem RewardItem Pointer )
            value.ExpireLabel                               = GetObject<ItemExpireLabel>(new IntPtr(p + 0x028), ReversePrism.DataModels.ItemExpireLabel.FromPointer); // 0x28 ExpireLabel                 ( ModelClassType ItemExpireLabel ItemExpireLabel ItemExpireLabel Pointer )
            value.SelectedCursor                            = GetObject<GameObject>(new IntPtr(p + 0x030), ReversePrism.DataModels.GameObject.FromPointer); // 0x30 SelectedCursor              ( ModelClassType GameObject GameObject GameObject Pointer )

            return value;
        }
    }
}
