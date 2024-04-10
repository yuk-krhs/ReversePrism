using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 4B0 M_ShowBoundCollectionSize                000186594D10 ModelPrimitiveType bool bool bool Bool
    // 4B1 M_ShowFoldoutHeader                      000186594D10 ModelPrimitiveType bool bool bool Bool
    // 4B8 M_HeaderTitle                            000186671910 ModelPrimitiveType string string string String
    // 4C0 itemsAdded                               Action`1<IEnumerable`1<int>> IL2CPP_TYPE_GENERICINST
    // 4C8 itemsRemoved                             Action`1<IEnumerable`1<int>> IL2CPP_TYPE_GENERICINST
    // 4D0 ItemsSourceSizeChanged                   0001866792B0 ModelClassType Action Action Action Pointer
    // 4D8 M_ListViewLabel                          000186774D80 ModelClassType Label Label Label Pointer
    // 4E0 M_Foldout                                0001865AC1D0 ModelClassType Foldout Foldout Foldout Pointer
    // 4E8 M_ArraySizeField                         00018663ACC0 ModelClassType TextField TextField TextField Pointer
    // 4F0 M_IsOverMultiEditLimit                   000186594D10 ModelPrimitiveType bool bool bool Bool
    // 4F8 M_Footer                                 0001866B2D70 ModelClassType VisualElement VisualElement VisualElement Pointer
    // 500 M_AddButton                              000186514B20 ModelClassType Button Button Button Pointer
    // 508 M_RemoveButton                           000186514B20 ModelClassType Button Button Button Pointer
    // 510 m_ItemAddedCallback                      Action`1<IEnumerable`1<int>> IL2CPP_TYPE_GENERICINST
    // 518 m_ItemRemovedCallback                    Action`1<IEnumerable`1<int>> IL2CPP_TYPE_GENERICINST
    // 520 M_ItemsSourceSizeChangedCallback         0001866792B0 ModelClassType Action Action Action Pointer
    // 528 M_ReorderMode                            00018653C9B0 ModelEnumType ListViewReorderMode ListViewReorderMode ListViewReorderMode Int32
    // 530 ReorderModeChanged                       0001866792B0 ModelClassType Action Action Action Pointer
    // 000 ussClassName                             string IL2CPP_TYPE_STRING
    // 008 itemUssClassName                         string IL2CPP_TYPE_STRING
    // 010 EmptyLabelUssClassName                   000186674040 ModelPrimitiveType string string string String
    // 018 OverMaxMultiEditLimitClassName           000186674040 ModelPrimitiveType string string string String
    // 020 ReorderableUssClassName                  000186674040 ModelPrimitiveType string string string String
    // 028 ReorderableItemUssClassName              000186674040 ModelPrimitiveType string string string String
    // 030 ReorderableItemContainerUssClassName     000186674040 ModelPrimitiveType string string string String
    // 038 ReorderableItemHandleUssClassName        000186674040 ModelPrimitiveType string string string String
    // 040 ReorderableItemHandleBarUssClassName     000186674040 ModelPrimitiveType string string string String
    // 048 FooterUssClassName                       000186674040 ModelPrimitiveType string string string String
    // 050 FoldoutHeaderUssClassName                000186674040 ModelPrimitiveType string string string String
    // 058 ArraySizeFieldUssClassName               000186674040 ModelPrimitiveType string string string String
    // 060 ListViewWithHeaderUssClassName           000186674040 ModelPrimitiveType string string string String
    // 068 ListViewWithFooterUssClassName           000186674040 ModelPrimitiveType string string string String
    // 070 ScrollViewWithFooterUssClassName         000186674040 ModelPrimitiveType string string string String
    // 078 FooterAddButtonName                      000186674040 ModelPrimitiveType string string string String
    // 080 FooterRemoveButtonName                   000186674040 ModelPrimitiveType string string string String
    // 538 M_MaxMultiEditStr                        000186671910 ModelPrimitiveType string string string String
    // 088 K_EmptyListStr                           0001866738F0 ModelPrimitiveType string string string String
    public partial class BaseListView : DataModel
    {
        public bool                                     M_ShowBoundCollectionSize               { get; set; }
        public bool                                     M_ShowFoldoutHeader                     { get; set; }
        public string                                   M_HeaderTitle                           { get; set; }
        public Action?                                  ItemsSourceSizeChanged                  { get; set; }
        public Label?                                   M_ListViewLabel                         { get; set; }
        public Foldout?                                 M_Foldout                               { get; set; }
        public TextField?                               M_ArraySizeField                        { get; set; }
        public bool                                     M_IsOverMultiEditLimit                  { get; set; }
        public VisualElement?                           M_Footer                                { get; set; }
        public Button?                                  M_AddButton                             { get; set; }
        public Button?                                  M_RemoveButton                          { get; set; }
        public Action?                                  M_ItemsSourceSizeChangedCallback        { get; set; }
        public ListViewReorderMode                      M_ReorderMode                           { get; set; }
        public Action?                                  ReorderModeChanged                      { get; set; }
        public string                                   EmptyLabelUssClassName                  { get; set; }
        public string                                   OverMaxMultiEditLimitClassName          { get; set; }
        public string                                   ReorderableUssClassName                 { get; set; }
        public string                                   ReorderableItemUssClassName             { get; set; }
        public string                                   ReorderableItemContainerUssClassName    { get; set; }
        public string                                   ReorderableItemHandleUssClassName       { get; set; }
        public string                                   ReorderableItemHandleBarUssClassName    { get; set; }
        public string                                   FooterUssClassName                      { get; set; }
        public string                                   FoldoutHeaderUssClassName               { get; set; }
        public string                                   ArraySizeFieldUssClassName              { get; set; }
        public string                                   ListViewWithHeaderUssClassName          { get; set; }
        public string                                   ListViewWithFooterUssClassName          { get; set; }
        public string                                   ScrollViewWithFooterUssClassName        { get; set; }
        public string                                   FooterAddButtonName                     { get; set; }
        public string                                   FooterRemoveButtonName                  { get; set; }
        public string                                   M_MaxMultiEditStr                       { get; set; }
        public string                                   K_EmptyListStr                          { get; set; }

        public static BaseListView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BaseListView() { Pointer= p0 };

            value.M_ShowBoundCollectionSize                 = GetBool(new IntPtr(p + 0x4B0)); // 0245A66B5DA8 0x4B0 M_ShowBoundCollectionSize   ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_ShowFoldoutHeader                       = GetBool(new IntPtr(p + 0x4B1)); // 0245A66B5DC8 0x4B1 M_ShowFoldoutHeader         ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_HeaderTitle                             = GetString(new IntPtr(p + 0x4B8)); // 0245A66B5DE8 0x4B8 M_HeaderTitle               ( 000186671910 ModelPrimitiveType string string string String )
            value.ItemsSourceSizeChanged                    = GetObject<Action>(new IntPtr(p + 0x4D0), ReversePrism.DataModels.Action.FromPointer); // 0245A66B5E48 0x4D0 ItemsSourceSizeChanged      ( 0001866792B0 ModelClassType Action Action Action Pointer )
            value.M_ListViewLabel                           = GetObject<Label>(new IntPtr(p + 0x4D8), ReversePrism.DataModels.Label.FromPointer); // 0245A66B5E68 0x4D8 M_ListViewLabel             ( 000186774D80 ModelClassType Label Label Label Pointer )
            value.M_Foldout                                 = GetObject<Foldout>(new IntPtr(p + 0x4E0), ReversePrism.DataModels.Foldout.FromPointer); // 0245A66B5E88 0x4E0 M_Foldout                   ( 0001865AC1D0 ModelClassType Foldout Foldout Foldout Pointer )
            value.M_ArraySizeField                          = GetObject<TextField>(new IntPtr(p + 0x4E8), ReversePrism.DataModels.TextField.FromPointer); // 0245A66B5EA8 0x4E8 M_ArraySizeField            ( 00018663ACC0 ModelClassType TextField TextField TextField Pointer )
            value.M_IsOverMultiEditLimit                    = GetBool(new IntPtr(p + 0x4F0)); // 0245A66B5EC8 0x4F0 M_IsOverMultiEditLimit      ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_Footer                                  = GetObject<VisualElement>(new IntPtr(p + 0x4F8), ReversePrism.DataModels.VisualElement.FromPointer); // 0245A66B5EE8 0x4F8 M_Footer                    ( 0001866B2D70 ModelClassType VisualElement VisualElement VisualElement Pointer )
            value.M_AddButton                               = GetObject<Button>(new IntPtr(p + 0x500), ReversePrism.DataModels.Button.FromPointer); // 0245A66B5F08 0x500 M_AddButton                 ( 000186514B20 ModelClassType Button Button Button Pointer )
            value.M_RemoveButton                            = GetObject<Button>(new IntPtr(p + 0x508), ReversePrism.DataModels.Button.FromPointer); // 0245A66B5F28 0x508 M_RemoveButton              ( 000186514B20 ModelClassType Button Button Button Pointer )
            value.M_ItemsSourceSizeChangedCallback          = GetObject<Action>(new IntPtr(p + 0x520), ReversePrism.DataModels.Action.FromPointer); // 0245A66B5F88 0x520 M_ItemsSourceSizeChangedCallback ( 0001866792B0 ModelClassType Action Action Action Pointer )
            value.M_ReorderMode                             = (ListViewReorderMode)GetInt32(new IntPtr(p + 0x528)); // 0245A66B5FA8 0x528 M_ReorderMode               ( 00018653C9B0 ModelEnumType ListViewReorderMode ListViewReorderMode ListViewReorderMode Int32 )
            value.ReorderModeChanged                        = GetObject<Action>(new IntPtr(p + 0x530), ReversePrism.DataModels.Action.FromPointer); // 0245A66B5FC8 0x530 ReorderModeChanged          ( 0001866792B0 ModelClassType Action Action Action Pointer )
            value.EmptyLabelUssClassName                    = GetString(new IntPtr(p + 0x010)); // 0245A66B6028 0x10 EmptyLabelUssClassName      ( 000186674040 ModelPrimitiveType string string string String )
            value.OverMaxMultiEditLimitClassName            = GetString(new IntPtr(p + 0x018)); // 0245A66B6048 0x18 OverMaxMultiEditLimitClassName ( 000186674040 ModelPrimitiveType string string string String )
            value.ReorderableUssClassName                   = GetString(new IntPtr(p + 0x020)); // 0245A66B6068 0x20 ReorderableUssClassName     ( 000186674040 ModelPrimitiveType string string string String )
            value.ReorderableItemUssClassName               = GetString(new IntPtr(p + 0x028)); // 0245A66B6088 0x28 ReorderableItemUssClassName ( 000186674040 ModelPrimitiveType string string string String )
            value.ReorderableItemContainerUssClassName      = GetString(new IntPtr(p + 0x030)); // 0245A66B60A8 0x30 ReorderableItemContainerUssClassName ( 000186674040 ModelPrimitiveType string string string String )
            value.ReorderableItemHandleUssClassName         = GetString(new IntPtr(p + 0x038)); // 0245A66B60C8 0x38 ReorderableItemHandleUssClassName ( 000186674040 ModelPrimitiveType string string string String )
            value.ReorderableItemHandleBarUssClassName      = GetString(new IntPtr(p + 0x040)); // 0245A66B60E8 0x40 ReorderableItemHandleBarUssClassName ( 000186674040 ModelPrimitiveType string string string String )
            value.FooterUssClassName                        = GetString(new IntPtr(p + 0x048)); // 0245A66B6108 0x48 FooterUssClassName          ( 000186674040 ModelPrimitiveType string string string String )
            value.FoldoutHeaderUssClassName                 = GetString(new IntPtr(p + 0x050)); // 0245A66B6128 0x50 FoldoutHeaderUssClassName   ( 000186674040 ModelPrimitiveType string string string String )
            value.ArraySizeFieldUssClassName                = GetString(new IntPtr(p + 0x058)); // 0245A66B6148 0x58 ArraySizeFieldUssClassName  ( 000186674040 ModelPrimitiveType string string string String )
            value.ListViewWithHeaderUssClassName            = GetString(new IntPtr(p + 0x060)); // 0245A66B6168 0x60 ListViewWithHeaderUssClassName ( 000186674040 ModelPrimitiveType string string string String )
            value.ListViewWithFooterUssClassName            = GetString(new IntPtr(p + 0x068)); // 0245A66B6188 0x68 ListViewWithFooterUssClassName ( 000186674040 ModelPrimitiveType string string string String )
            value.ScrollViewWithFooterUssClassName          = GetString(new IntPtr(p + 0x070)); // 0245A66B61A8 0x70 ScrollViewWithFooterUssClassName ( 000186674040 ModelPrimitiveType string string string String )
            value.FooterAddButtonName                       = GetString(new IntPtr(p + 0x078)); // 0245A66B61C8 0x78 FooterAddButtonName         ( 000186674040 ModelPrimitiveType string string string String )
            value.FooterRemoveButtonName                    = GetString(new IntPtr(p + 0x080)); // 0245A66B61E8 0x80 FooterRemoveButtonName      ( 000186674040 ModelPrimitiveType string string string String )
            value.M_MaxMultiEditStr                         = GetString(new IntPtr(p + 0x538)); // 0245A66B6208 0x538 M_MaxMultiEditStr           ( 000186671910 ModelPrimitiveType string string string String )
            value.K_EmptyListStr                            = GetString(new IntPtr(p + 0x088)); // 0245A66B6228 0x88 K_EmptyListStr              ( 0001866738F0 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
