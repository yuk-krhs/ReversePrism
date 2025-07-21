using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 090 CellPrefab                               ModelClassType ItemListOverlayContentListGridViewCell ItemListOverlayContentListGridViewCell ItemListOverlayContentListGridViewCell Pointer
    // 098 Scroller                                 ModelClassType Scroller Scroller Scroller Pointer
    // 0A0 EmptyView                                ModelClassType GameObject GameObject GameObject Pointer
    public partial class ItemListOverlayContentListGridView : DataModel
    {
        public ItemListOverlayContentListGridViewCell?  CellPrefab                              { get; set; }
        public Scroller?                                Scroller                                { get; set; }
        public GameObject?                              EmptyView                               { get; set; }

        public static ItemListOverlayContentListGridView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ItemListOverlayContentListGridView() { Pointer= p0 };

            value.CellPrefab                                = GetObject<ItemListOverlayContentListGridViewCell>(new IntPtr(p + 0x090), ReversePrism.DataModels.ItemListOverlayContentListGridViewCell.FromPointer); // 0x90 CellPrefab                  ( ModelClassType ItemListOverlayContentListGridViewCell ItemListOverlayContentListGridViewCell ItemListOverlayContentListGridViewCell Pointer )
            value.Scroller                                  = GetObject<Scroller>(new IntPtr(p + 0x098), ReversePrism.DataModels.Scroller.FromPointer); // 0x98 Scroller                    ( ModelClassType Scroller Scroller Scroller Pointer )
            value.EmptyView                                 = GetObject<GameObject>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.GameObject.FromPointer); // 0xA0 EmptyView                   ( ModelClassType GameObject GameObject GameObject Pointer )

            return value;
        }
    }
}
