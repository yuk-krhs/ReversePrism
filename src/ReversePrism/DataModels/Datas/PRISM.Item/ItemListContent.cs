using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 AssetPath                                string IL2CPP_TYPE_STRING
    // 000 ExpireCautionDays                        int IL2CPP_TYPE_I4
    // 060 TabGroupView                             00018651D6E0 ModelClassType ViewItemTabGroupView ViewItemTabGroupView ViewItemTabGroupView Pointer
    // 068 ListView                                 00018651C7A0 ModelClassType ViewItemListView ViewItemListView ViewItemListView Pointer
    // 070 Model                                    00018651CF60 ModelClassType ViewItemModel ViewItemModel ViewItemModel Pointer
    public partial class ItemListContent : DataModel
    {
        public ViewItemTabGroupView?                    TabGroupView                            { get; set; }
        public ViewItemListView?                        ListView                                { get; set; }
        public ViewItemModel?                           Model                                   { get; set; }

        public static ItemListContent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ItemListContent() { Pointer= p0 };

            value.TabGroupView                              = GetObject<ViewItemTabGroupView>(new IntPtr(p + 0x060), ReversePrism.DataModels.ViewItemTabGroupView.FromPointer); // 02466534D590 0x60 TabGroupView                ( 00018651D6E0 ModelClassType ViewItemTabGroupView ViewItemTabGroupView ViewItemTabGroupView Pointer )
            value.ListView                                  = GetObject<ViewItemListView>(new IntPtr(p + 0x068), ReversePrism.DataModels.ViewItemListView.FromPointer); // 02466534D5B0 0x68 ListView                    ( 00018651C7A0 ModelClassType ViewItemListView ViewItemListView ViewItemListView Pointer )
            value.Model                                     = GetObject<ViewItemModel>(new IntPtr(p + 0x070), ReversePrism.DataModels.ViewItemModel.FromPointer); // 02466534D5D0 0x70 Model                       ( 00018651CF60 ModelClassType ViewItemModel ViewItemModel ViewItemModel Pointer )

            return value;
        }
    }
}
