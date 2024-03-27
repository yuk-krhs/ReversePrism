using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ScrollRectItem                           0001866F7FA0 ModelClassType ScrollRect ScrollRect ScrollRect Pointer
    // 028 EmptyGameObject                          0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 030 ContentListObj                           0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 038 ItemIconPrefab                           00018673F460 ModelClassType ItemListIcon ItemListIcon ItemListIcon Pointer
    // 040 ItemListInfo                             00018673FB50 ModelClassType ItemListInfo ItemListInfo ItemListInfo Pointer
    // 048 IconList                                 000185CEE368 ModelClassListType List`1<ItemListIcon> List`1<ItemListIcon> List<ItemListIcon> Pointer
    // 050 ProductList                              000185CE4BF8 ModelClassListType List`1<IHavingProductStatus> List`1<IHavingProductStatus> List<IHavingProductStatus> Pointer
    // 058 ShowProduct                              000186565CA0 ModelClassType IHavingProductStatus IHavingProductStatus IHavingProductStatus Pointer
    // 060 itemConsumedSubject                      Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    public partial class ViewItemListView
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
            var value   = new ViewItemListView();

            value.ScrollRectItem                            = GetObject<ScrollRect>(new IntPtr(p + 0x020), ReversePrism.DataModels.ScrollRect.FromPointer); // 0270D4BC0F98 0x20 ScrollRectItem              ( 0001866F7FA0 ModelClassType ScrollRect ScrollRect ScrollRect Pointer )
            value.EmptyGameObject                           = GetObject<GameObject>(new IntPtr(p + 0x028), ReversePrism.DataModels.GameObject.FromPointer); // 0270D4BC0FB8 0x28 EmptyGameObject             ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.ContentListObj                            = GetObject<GameObject>(new IntPtr(p + 0x030), ReversePrism.DataModels.GameObject.FromPointer); // 0270D4BC0FD8 0x30 ContentListObj              ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.ItemIconPrefab                            = GetObject<ItemListIcon>(new IntPtr(p + 0x038), ReversePrism.DataModels.ItemListIcon.FromPointer); // 0270D4BC0FF8 0x38 ItemIconPrefab              ( 00018673F460 ModelClassType ItemListIcon ItemListIcon ItemListIcon Pointer )
            value.ItemListInfo                              = GetObject<ItemListInfo>(new IntPtr(p + 0x040), ReversePrism.DataModels.ItemListInfo.FromPointer); // 0270D4BC1018 0x40 ItemListInfo                ( 00018673FB50 ModelClassType ItemListInfo ItemListInfo ItemListInfo Pointer )
            value.IconList                                  = GetObjectList<ItemListIcon>(new IntPtr(p + 0x048), ReversePrism.DataModels.ItemListIcon.FromPointer); // 0270D4BC1038 0x48 IconList                    ( 000185CEE368 ModelClassListType List`1<ItemListIcon> List`1<ItemListIcon> List<ItemListIcon> Pointer )
            value.ProductList                               = GetObjectList<IHavingProductStatus>(new IntPtr(p + 0x050), ReversePrism.DataModels.IHavingProductStatus.FromPointer); // 0270D4BC1058 0x50 ProductList                 ( 000185CE4BF8 ModelClassListType List`1<IHavingProductStatus> List`1<IHavingProductStatus> List<IHavingProductStatus> Pointer )
            value.ShowProduct                               = GetObject<IHavingProductStatus>(new IntPtr(p + 0x058), ReversePrism.DataModels.IHavingProductStatus.FromPointer); // 0270D4BC1078 0x58 ShowProduct                 ( 000186565CA0 ModelClassType IHavingProductStatus IHavingProductStatus IHavingProductStatus Pointer )

            return value;
        }
    }
}
