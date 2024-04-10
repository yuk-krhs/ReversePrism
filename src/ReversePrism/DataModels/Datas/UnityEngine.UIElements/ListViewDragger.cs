using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 030 M_LastDragPosition                       0001866FE150 ModelEnumType DragPosition DragPosition DragPosition Int32
    // 050 M_DragHoverBar                           0001866B2D70 ModelClassType VisualElement VisualElement VisualElement Pointer
    // 058 M_DragHoverItemMarker                    0001866B2D70 ModelClassType VisualElement VisualElement VisualElement Pointer
    // 060 M_DragHoverSiblingMarker                 0001866B2D70 ModelClassType VisualElement VisualElement VisualElement Pointer
    // 068 M_LeftIndentation                        0001866656B0 ModelPrimitiveType float float float Single
    // 06C M_SiblingBottom                          0001866656B0 ModelPrimitiveType float float float Single
    // 070 DragAndDropController                    000186732630 ModelClassType ICollectionDragAndDropController ICollectionDragAndDropController ICollectionDragAndDropController Pointer
    public partial class ListViewDragger : DataModel
    {
        public DragPosition                             M_LastDragPosition                      { get; set; }
        public VisualElement?                           M_DragHoverBar                          { get; set; }
        public VisualElement?                           M_DragHoverItemMarker                   { get; set; }
        public VisualElement?                           M_DragHoverSiblingMarker                { get; set; }
        public float                                    M_LeftIndentation                       { get; set; }
        public float                                    M_SiblingBottom                         { get; set; }
        public ICollectionDragAndDropController?        DragAndDropController                   { get; set; }

        public static ListViewDragger? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ListViewDragger() { Pointer= p0 };

            value.M_LastDragPosition                        = (DragPosition)GetInt32(new IntPtr(p + 0x030)); // 0245A6718BA0 0x30 M_LastDragPosition          ( 0001866FE150 ModelEnumType DragPosition DragPosition DragPosition Int32 )
            value.M_DragHoverBar                            = GetObject<VisualElement>(new IntPtr(p + 0x050), ReversePrism.DataModels.VisualElement.FromPointer); // 0245A6718BC0 0x50 M_DragHoverBar              ( 0001866B2D70 ModelClassType VisualElement VisualElement VisualElement Pointer )
            value.M_DragHoverItemMarker                     = GetObject<VisualElement>(new IntPtr(p + 0x058), ReversePrism.DataModels.VisualElement.FromPointer); // 0245A6718BE0 0x58 M_DragHoverItemMarker       ( 0001866B2D70 ModelClassType VisualElement VisualElement VisualElement Pointer )
            value.M_DragHoverSiblingMarker                  = GetObject<VisualElement>(new IntPtr(p + 0x060), ReversePrism.DataModels.VisualElement.FromPointer); // 0245A6718C00 0x60 M_DragHoverSiblingMarker    ( 0001866B2D70 ModelClassType VisualElement VisualElement VisualElement Pointer )
            value.M_LeftIndentation                         = GetSingle(new IntPtr(p + 0x068)); // 0245A6718C20 0x68 M_LeftIndentation           ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.M_SiblingBottom                           = GetSingle(new IntPtr(p + 0x06C)); // 0245A6718C40 0x6C M_SiblingBottom             ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.DragAndDropController                     = GetObject<ICollectionDragAndDropController>(new IntPtr(p + 0x070), ReversePrism.DataModels.ICollectionDragAndDropController.FromPointer); // 0245A6718C60 0x70 DragAndDropController       ( 000186732630 ModelClassType ICollectionDragAndDropController ICollectionDragAndDropController ICollectionDragAndDropController Pointer )

            return value;
        }
    }
}
