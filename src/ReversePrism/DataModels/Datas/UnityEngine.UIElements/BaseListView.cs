using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 k_SizeFieldLabel                         string IL2CPP_TYPE_STRING
    // 4B0 M_ShowBoundCollectionSize                ModelPrimitiveType bool bool bool Bool
    // 4B1 M_ShowFoldoutHeader                      ModelPrimitiveType bool bool bool Bool
    // 4B8 M_HeaderTitle                            ModelPrimitiveType string string string String
    // 4C0 itemsAdded                               Action`1<IEnumerable`1<int>> IL2CPP_TYPE_GENERICINST
    // 4C8 itemsRemoved                             Action`1<IEnumerable`1<int>> IL2CPP_TYPE_GENERICINST
    // 4D0 ItemsSourceSizeChanged                   ModelClassType Action Action Action Pointer
    // 4D8 M_ListViewLabel                          ModelClassType Label Label Label Pointer
    // 4E0 M_Foldout                                ModelClassType Foldout Foldout Foldout Pointer
    // 4E8 M_ArraySizeField                         ModelClassType TextField TextField TextField Pointer
    // 4F0 M_IsOverMultiEditLimit                   ModelPrimitiveType bool bool bool Bool
    // 4F8 M_Footer                                 ModelClassType VisualElement VisualElement VisualElement Pointer
    // 500 M_AddButton                              ModelClassType Button Button Button Pointer
    // 508 M_RemoveButton                           ModelClassType Button Button Button Pointer
    // 510 m_ItemAddedCallback                      Action`1<IEnumerable`1<int>> IL2CPP_TYPE_GENERICINST
    // 518 m_ItemRemovedCallback                    Action`1<IEnumerable`1<int>> IL2CPP_TYPE_GENERICINST
    // 520 M_ItemsSourceSizeChangedCallback         ModelClassType Action Action Action Pointer
    // 528 M_ReorderMode                            ModelEnumType ListViewReorderMode ListViewReorderMode ListViewReorderMode Int32
    // 530 ReorderModeChanged                       ModelClassType Action Action Action Pointer
    // 008 ussClassName                             string IL2CPP_TYPE_STRING
    // 010 ItemUssClassName                         ModelPrimitiveType string string string String
    // 018 EmptyLabelUssClassName                   ModelPrimitiveType string string string String
    // 020 OverMaxMultiEditLimitClassName           ModelPrimitiveType string string string String
    // 028 ReorderableUssClassName                  ModelPrimitiveType string string string String
    // 030 ReorderableItemUssClassName              ModelPrimitiveType string string string String
    // 038 ReorderableItemContainerUssClassName     ModelPrimitiveType string string string String
    // 040 ReorderableItemHandleUssClassName        ModelPrimitiveType string string string String
    // 048 ReorderableItemHandleBarUssClassName     ModelPrimitiveType string string string String
    // 050 FooterUssClassName                       ModelPrimitiveType string string string String
    // 058 FoldoutHeaderUssClassName                ModelPrimitiveType string string string String
    // 060 ArraySizeFieldUssClassName               ModelPrimitiveType string string string String
    // 068 ArraySizeFieldWithHeaderUssClassName     ModelPrimitiveType string string string String
    // 070 ArraySizeFieldWithFooterUssClassName     ModelPrimitiveType string string string String
    // 078 ListViewWithHeaderUssClassName           ModelPrimitiveType string string string String
    // 080 ListViewWithFooterUssClassName           ModelPrimitiveType string string string String
    // 088 ScrollViewWithFooterUssClassName         ModelPrimitiveType string string string String
    // 090 FooterAddButtonName                      ModelPrimitiveType string string string String
    // 098 FooterRemoveButtonName                   ModelPrimitiveType string string string String
    // 538 M_MaxMultiEditStr                        ModelPrimitiveType string string string String
    // 0A0 K_EmptyListStr                           ModelPrimitiveType string string string String
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
        public string                                   ItemUssClassName                        { get; set; }
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
        public string                                   ArraySizeFieldWithHeaderUssClassName    { get; set; }
        public string                                   ArraySizeFieldWithFooterUssClassName    { get; set; }
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

            value.M_ShowBoundCollectionSize                 = GetBool(new IntPtr(p + 0x4B0)); // 0x4B0 M_ShowBoundCollectionSize   ( ModelPrimitiveType bool bool bool Bool )
            value.M_ShowFoldoutHeader                       = GetBool(new IntPtr(p + 0x4B1)); // 0x4B1 M_ShowFoldoutHeader         ( ModelPrimitiveType bool bool bool Bool )
            value.M_HeaderTitle                             = GetString(new IntPtr(p + 0x4B8)); // 0x4B8 M_HeaderTitle               ( ModelPrimitiveType string string string String )
            value.ItemsSourceSizeChanged                    = GetObject<Action>(new IntPtr(p + 0x4D0), ReversePrism.DataModels.Action.FromPointer); // 0x4D0 ItemsSourceSizeChanged      ( ModelClassType Action Action Action Pointer )
            value.M_ListViewLabel                           = GetObject<Label>(new IntPtr(p + 0x4D8), ReversePrism.DataModels.Label.FromPointer); // 0x4D8 M_ListViewLabel             ( ModelClassType Label Label Label Pointer )
            value.M_Foldout                                 = GetObject<Foldout>(new IntPtr(p + 0x4E0), ReversePrism.DataModels.Foldout.FromPointer); // 0x4E0 M_Foldout                   ( ModelClassType Foldout Foldout Foldout Pointer )
            value.M_ArraySizeField                          = GetObject<TextField>(new IntPtr(p + 0x4E8), ReversePrism.DataModels.TextField.FromPointer); // 0x4E8 M_ArraySizeField            ( ModelClassType TextField TextField TextField Pointer )
            value.M_IsOverMultiEditLimit                    = GetBool(new IntPtr(p + 0x4F0)); // 0x4F0 M_IsOverMultiEditLimit      ( ModelPrimitiveType bool bool bool Bool )
            value.M_Footer                                  = GetObject<VisualElement>(new IntPtr(p + 0x4F8), ReversePrism.DataModels.VisualElement.FromPointer); // 0x4F8 M_Footer                    ( ModelClassType VisualElement VisualElement VisualElement Pointer )
            value.M_AddButton                               = GetObject<Button>(new IntPtr(p + 0x500), ReversePrism.DataModels.Button.FromPointer); // 0x500 M_AddButton                 ( ModelClassType Button Button Button Pointer )
            value.M_RemoveButton                            = GetObject<Button>(new IntPtr(p + 0x508), ReversePrism.DataModels.Button.FromPointer); // 0x508 M_RemoveButton              ( ModelClassType Button Button Button Pointer )
            value.M_ItemsSourceSizeChangedCallback          = GetObject<Action>(new IntPtr(p + 0x520), ReversePrism.DataModels.Action.FromPointer); // 0x520 M_ItemsSourceSizeChangedCallback ( ModelClassType Action Action Action Pointer )
            value.M_ReorderMode                             = (ListViewReorderMode)GetInt32(new IntPtr(p + 0x528)); // 0x528 M_ReorderMode               ( ModelEnumType ListViewReorderMode ListViewReorderMode ListViewReorderMode Int32 )
            value.ReorderModeChanged                        = GetObject<Action>(new IntPtr(p + 0x530), ReversePrism.DataModels.Action.FromPointer); // 0x530 ReorderModeChanged          ( ModelClassType Action Action Action Pointer )
            value.ItemUssClassName                          = GetString(new IntPtr(p + 0x010)); // 0x10 ItemUssClassName            ( ModelPrimitiveType string string string String )
            value.EmptyLabelUssClassName                    = GetString(new IntPtr(p + 0x018)); // 0x18 EmptyLabelUssClassName      ( ModelPrimitiveType string string string String )
            value.OverMaxMultiEditLimitClassName            = GetString(new IntPtr(p + 0x020)); // 0x20 OverMaxMultiEditLimitClassName ( ModelPrimitiveType string string string String )
            value.ReorderableUssClassName                   = GetString(new IntPtr(p + 0x028)); // 0x28 ReorderableUssClassName     ( ModelPrimitiveType string string string String )
            value.ReorderableItemUssClassName               = GetString(new IntPtr(p + 0x030)); // 0x30 ReorderableItemUssClassName ( ModelPrimitiveType string string string String )
            value.ReorderableItemContainerUssClassName      = GetString(new IntPtr(p + 0x038)); // 0x38 ReorderableItemContainerUssClassName ( ModelPrimitiveType string string string String )
            value.ReorderableItemHandleUssClassName         = GetString(new IntPtr(p + 0x040)); // 0x40 ReorderableItemHandleUssClassName ( ModelPrimitiveType string string string String )
            value.ReorderableItemHandleBarUssClassName      = GetString(new IntPtr(p + 0x048)); // 0x48 ReorderableItemHandleBarUssClassName ( ModelPrimitiveType string string string String )
            value.FooterUssClassName                        = GetString(new IntPtr(p + 0x050)); // 0x50 FooterUssClassName          ( ModelPrimitiveType string string string String )
            value.FoldoutHeaderUssClassName                 = GetString(new IntPtr(p + 0x058)); // 0x58 FoldoutHeaderUssClassName   ( ModelPrimitiveType string string string String )
            value.ArraySizeFieldUssClassName                = GetString(new IntPtr(p + 0x060)); // 0x60 ArraySizeFieldUssClassName  ( ModelPrimitiveType string string string String )
            value.ArraySizeFieldWithHeaderUssClassName      = GetString(new IntPtr(p + 0x068)); // 0x68 ArraySizeFieldWithHeaderUssClassName ( ModelPrimitiveType string string string String )
            value.ArraySizeFieldWithFooterUssClassName      = GetString(new IntPtr(p + 0x070)); // 0x70 ArraySizeFieldWithFooterUssClassName ( ModelPrimitiveType string string string String )
            value.ListViewWithHeaderUssClassName            = GetString(new IntPtr(p + 0x078)); // 0x78 ListViewWithHeaderUssClassName ( ModelPrimitiveType string string string String )
            value.ListViewWithFooterUssClassName            = GetString(new IntPtr(p + 0x080)); // 0x80 ListViewWithFooterUssClassName ( ModelPrimitiveType string string string String )
            value.ScrollViewWithFooterUssClassName          = GetString(new IntPtr(p + 0x088)); // 0x88 ScrollViewWithFooterUssClassName ( ModelPrimitiveType string string string String )
            value.FooterAddButtonName                       = GetString(new IntPtr(p + 0x090)); // 0x90 FooterAddButtonName         ( ModelPrimitiveType string string string String )
            value.FooterRemoveButtonName                    = GetString(new IntPtr(p + 0x098)); // 0x98 FooterRemoveButtonName      ( ModelPrimitiveType string string string String )
            value.M_MaxMultiEditStr                         = GetString(new IntPtr(p + 0x538)); // 0x538 M_MaxMultiEditStr           ( ModelPrimitiveType string string string String )
            value.K_EmptyListStr                            = GetString(new IntPtr(p + 0x0A0)); // 0xA0 K_EmptyListStr              ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
