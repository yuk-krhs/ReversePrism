using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 CategoryListView                         ModelClassType ItemListOverlayTabListView ItemListOverlayTabListView ItemListOverlayTabListView Pointer
    // 028 ContentListView                          ModelClassType ItemListOverlayContentListGridView ItemListOverlayContentListGridView ItemListOverlayContentListGridView Pointer
    // 030 ContentPanelView                         ModelClassType ItemListOverlayContentPanelView ItemListOverlayContentPanelView ItemListOverlayContentPanelView Pointer
    // 038 CloseButton                              ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 040 ViewModel                                ModelClassType ItemListOverlayViewModel ItemListOverlayViewModel ItemListOverlayViewModel Pointer
    // 048 ResourceLoader                           ModelClassType IResourceLoader IResourceLoader IResourceLoader Pointer
    // 050 BackKeyDisposable                        ModelClassType IDisposable IDisposable IDisposable Pointer
    // 058 StartScrollbarValue                      ModelPrimitiveType float float float Single
    public partial class ItemListOverlayView : DataModel
    {
        public ItemListOverlayTabListView?              CategoryListView                        { get; set; }
        public ItemListOverlayContentListGridView?      ContentListView                         { get; set; }
        public ItemListOverlayContentPanelView?         ContentPanelView                        { get; set; }
        public ButtonBase?                              CloseButton                             { get; set; }
        public ItemListOverlayViewModel?                ViewModel                               { get; set; }
        public IResourceLoader?                         ResourceLoader                          { get; set; }
        public IDisposable?                             BackKeyDisposable                       { get; set; }
        public float                                    StartScrollbarValue                     { get; set; }

        public static ItemListOverlayView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ItemListOverlayView() { Pointer= p0 };

            value.CategoryListView                          = GetObject<ItemListOverlayTabListView>(new IntPtr(p + 0x020), ReversePrism.DataModels.ItemListOverlayTabListView.FromPointer); // 0x20 CategoryListView            ( ModelClassType ItemListOverlayTabListView ItemListOverlayTabListView ItemListOverlayTabListView Pointer )
            value.ContentListView                           = GetObject<ItemListOverlayContentListGridView>(new IntPtr(p + 0x028), ReversePrism.DataModels.ItemListOverlayContentListGridView.FromPointer); // 0x28 ContentListView             ( ModelClassType ItemListOverlayContentListGridView ItemListOverlayContentListGridView ItemListOverlayContentListGridView Pointer )
            value.ContentPanelView                          = GetObject<ItemListOverlayContentPanelView>(new IntPtr(p + 0x030), ReversePrism.DataModels.ItemListOverlayContentPanelView.FromPointer); // 0x30 ContentPanelView            ( ModelClassType ItemListOverlayContentPanelView ItemListOverlayContentPanelView ItemListOverlayContentPanelView Pointer )
            value.CloseButton                               = GetObject<ButtonBase>(new IntPtr(p + 0x038), ReversePrism.DataModels.ButtonBase.FromPointer); // 0x38 CloseButton                 ( ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.ViewModel                                 = GetObject<ItemListOverlayViewModel>(new IntPtr(p + 0x040), ReversePrism.DataModels.ItemListOverlayViewModel.FromPointer); // 0x40 ViewModel                   ( ModelClassType ItemListOverlayViewModel ItemListOverlayViewModel ItemListOverlayViewModel Pointer )
            value.ResourceLoader                            = GetObject<IResourceLoader>(new IntPtr(p + 0x048), ReversePrism.DataModels.IResourceLoader.FromPointer); // 0x48 ResourceLoader              ( ModelClassType IResourceLoader IResourceLoader IResourceLoader Pointer )
            value.BackKeyDisposable                         = GetObject<IDisposable>(new IntPtr(p + 0x050), ReversePrism.DataModels.IDisposable.FromPointer); // 0x50 BackKeyDisposable           ( ModelClassType IDisposable IDisposable IDisposable Pointer )
            value.StartScrollbarValue                       = GetSingle(new IntPtr(p + 0x058)); // 0x58 StartScrollbarValue         ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
