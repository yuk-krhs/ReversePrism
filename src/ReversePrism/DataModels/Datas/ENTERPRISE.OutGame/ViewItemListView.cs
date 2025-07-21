using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ScrollRectItem                           ModelClassType ScrollRect ScrollRect ScrollRect Pointer
    // 028 EmptyGameObject                          ModelClassType GameObject GameObject GameObject Pointer
    // 030 ContentListObj                           ModelClassType GameObject GameObject GameObject Pointer
    // 038 ItemIconPrefab                           ModelClassType ItemListIcon ItemListIcon ItemListIcon Pointer
    // 040 ItemListInfo                             ModelClassType ItemListInfo ItemListInfo ItemListInfo Pointer
    // 048 IconList                                 ModelClassListType List`1<ItemListIcon> List`1<ItemListIcon> List<ItemListIcon> Pointer
    // 050 ProductList                              ModelClassListType List`1<IHavingProductStatus> List`1<IHavingProductStatus> List<IHavingProductStatus> Pointer
    // 058 ShowProduct                              ModelClassType IHavingProductStatus IHavingProductStatus IHavingProductStatus Pointer
    // 060 itemConsumedSubject                      Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    public partial class ViewItemListView : DataModel
    {
        public ScrollRect?                              ScrollRectItem                          { get; set; }
        public GameObject?                              EmptyGameObject                         { get; set; }
        public GameObject?                              ContentListObj                          { get; set; }
        public ItemListIcon?                            ItemIconPrefab                          { get; set; }
        public ItemListInfo?                            ItemListInfo                            { get; set; }
        public List<ItemListIcon>?                      IconList                                { get; set; }
        public List<IHavingProductStatus>?              ProductList                             { get; set; }
        public IHavingProductStatus?                    ShowProduct                             { get; set; }

        public static ViewItemListView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ViewItemListView() { Pointer= p0 };

            value.ScrollRectItem                            = GetObject<ScrollRect>(new IntPtr(p + 0x020), ReversePrism.DataModels.ScrollRect.FromPointer); // 0x20 ScrollRectItem              ( ModelClassType ScrollRect ScrollRect ScrollRect Pointer )
            value.EmptyGameObject                           = GetObject<GameObject>(new IntPtr(p + 0x028), ReversePrism.DataModels.GameObject.FromPointer); // 0x28 EmptyGameObject             ( ModelClassType GameObject GameObject GameObject Pointer )
            value.ContentListObj                            = GetObject<GameObject>(new IntPtr(p + 0x030), ReversePrism.DataModels.GameObject.FromPointer); // 0x30 ContentListObj              ( ModelClassType GameObject GameObject GameObject Pointer )
            value.ItemIconPrefab                            = GetObject<ItemListIcon>(new IntPtr(p + 0x038), ReversePrism.DataModels.ItemListIcon.FromPointer); // 0x38 ItemIconPrefab              ( ModelClassType ItemListIcon ItemListIcon ItemListIcon Pointer )
            value.ItemListInfo                              = GetObject<ItemListInfo>(new IntPtr(p + 0x040), ReversePrism.DataModels.ItemListInfo.FromPointer); // 0x40 ItemListInfo                ( ModelClassType ItemListInfo ItemListInfo ItemListInfo Pointer )
            value.IconList                                  = GetObjectList<ItemListIcon>(new IntPtr(p + 0x048), ReversePrism.DataModels.ItemListIcon.FromPointer); // 0x48 IconList                    ( ModelClassListType List`1<ItemListIcon> List`1<ItemListIcon> List<ItemListIcon> Pointer )
            value.ProductList                               = GetObjectList<IHavingProductStatus>(new IntPtr(p + 0x050), ReversePrism.DataModels.IHavingProductStatus.FromPointer); // 0x50 ProductList                 ( ModelClassListType List`1<IHavingProductStatus> List`1<IHavingProductStatus> List<IHavingProductStatus> Pointer )
            value.ShowProduct                               = GetObject<IHavingProductStatus>(new IntPtr(p + 0x058), ReversePrism.DataModels.IHavingProductStatus.FromPointer); // 0x58 ShowProduct                 ( ModelClassType IHavingProductStatus IHavingProductStatus IHavingProductStatus Pointer )

            return value;
        }
    }
}
