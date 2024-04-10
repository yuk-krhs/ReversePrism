using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_View                                   000186745380 ModelClassType BaseVerticalCollectionView BaseVerticalCollectionView BaseVerticalCollectionView Pointer
    // 018 M_ItemsSource                            000186591B20 ModelClassType IList IList IList Pointer
    // 020 ItemsSourceChanged                       0001866792B0 ModelClassType Action Action Action Pointer
    // 028 itemIndexChanged                         Action`2<int, int> IL2CPP_TYPE_GENERICINST
    public partial class CollectionViewController : DataModel
    {
        public BaseVerticalCollectionView?              M_View                                  { get; set; }
        public IList?                                   M_ItemsSource                           { get; set; }
        public Action?                                  ItemsSourceChanged                      { get; set; }

        public static CollectionViewController? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CollectionViewController() { Pointer= p0 };

            value.M_View                                    = GetObject<BaseVerticalCollectionView>(new IntPtr(p + 0x010), ReversePrism.DataModels.BaseVerticalCollectionView.FromPointer); // 0245A66A7F38 0x10 M_View                      ( 000186745380 ModelClassType BaseVerticalCollectionView BaseVerticalCollectionView BaseVerticalCollectionView Pointer )
            value.M_ItemsSource                             = GetObject<IList>(new IntPtr(p + 0x018), ReversePrism.DataModels.IList.FromPointer); // 0245A66A7F58 0x18 M_ItemsSource               ( 000186591B20 ModelClassType IList IList IList Pointer )
            value.ItemsSourceChanged                        = GetObject<Action>(new IntPtr(p + 0x020), ReversePrism.DataModels.Action.FromPointer); // 0245A66A7F78 0x20 ItemsSourceChanged          ( 0001866792B0 ModelClassType Action Action Action Pointer )

            return value;
        }
    }
}
