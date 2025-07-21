using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 s_UssClassName                           string IL2CPP_TYPE_STRING
    // 008 s_ContentContainerClassName              string IL2CPP_TYPE_STRING
    // 010 S_HandleDragLineClassName                ModelPrimitiveType string string string String
    // 018 S_HandleDragLineVerticalClassName        ModelPrimitiveType string string string String
    // 020 S_HandleDragLineHorizontalClassName      ModelPrimitiveType string string string String
    // 028 S_HandleDragLineAnchorClassName          ModelPrimitiveType string string string String
    // 030 S_HandleDragLineAnchorVerticalClassName  ModelPrimitiveType string string string String
    // 038 S_HandleDragLineAnchorHorizontalClassName ModelPrimitiveType string string string String
    // 040 S_VerticalClassName                      ModelPrimitiveType string string string String
    // 048 S_HorizontalClassName                    ModelPrimitiveType string string string String
    // 3C8 M_LeftPane                               ModelClassType VisualElement VisualElement VisualElement Pointer
    // 3D0 M_RightPane                              ModelClassType VisualElement VisualElement VisualElement Pointer
    // 3D8 M_FixedPane                              ModelClassType VisualElement VisualElement VisualElement Pointer
    // 3E0 M_FlexedPane                             ModelClassType VisualElement VisualElement VisualElement Pointer
    // 3E8 M_FixedPaneDimension                     ModelPrimitiveType float float float Single
    // 3F0 M_DragLine                               ModelClassType VisualElement VisualElement VisualElement Pointer
    // 3F8 M_DragLineAnchor                         ModelClassType VisualElement VisualElement VisualElement Pointer
    // 400 M_CollapseMode                           ModelPrimitiveType bool bool bool Bool
    // 408 M_Content                                ModelClassType VisualElement VisualElement VisualElement Pointer
    // 410 M_Orientation                            ModelEnumType TwoPaneSplitViewOrientation TwoPaneSplitViewOrientation TwoPaneSplitViewOrientation Int32
    // 414 M_FixedPaneIndex                         ModelPrimitiveType int int int Int32
    // 418 M_FixedPaneInitialDimension              ModelPrimitiveType float float float Single
    // 420 M_Resizer                                ModelClassType TwoPaneSplitViewResizer TwoPaneSplitViewResizer TwoPaneSplitViewResizer Pointer
    public partial class TwoPaneSplitView : DataModel
    {
        public string                                   S_HandleDragLineClassName               { get; set; }
        public string                                   S_HandleDragLineVerticalClassName       { get; set; }
        public string                                   S_HandleDragLineHorizontalClassName     { get; set; }
        public string                                   S_HandleDragLineAnchorClassName         { get; set; }
        public string                                   S_HandleDragLineAnchorVerticalClassName { get; set; }
        public string                                   S_HandleDragLineAnchorHorizontalClassName { get; set; }
        public string                                   S_VerticalClassName                     { get; set; }
        public string                                   S_HorizontalClassName                   { get; set; }
        public VisualElement?                           M_LeftPane                              { get; set; }
        public VisualElement?                           M_RightPane                             { get; set; }
        public VisualElement?                           M_FixedPane                             { get; set; }
        public VisualElement?                           M_FlexedPane                            { get; set; }
        public float                                    M_FixedPaneDimension                    { get; set; }
        public VisualElement?                           M_DragLine                              { get; set; }
        public VisualElement?                           M_DragLineAnchor                        { get; set; }
        public bool                                     M_CollapseMode                          { get; set; }
        public VisualElement?                           M_Content                               { get; set; }
        public TwoPaneSplitViewOrientation              M_Orientation                           { get; set; }
        public int                                      M_FixedPaneIndex                        { get; set; }
        public float                                    M_FixedPaneInitialDimension             { get; set; }
        public TwoPaneSplitViewResizer?                 M_Resizer                               { get; set; }

        public static TwoPaneSplitView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TwoPaneSplitView() { Pointer= p0 };

            value.S_HandleDragLineClassName                 = GetString(new IntPtr(p + 0x010)); // 0x10 S_HandleDragLineClassName   ( ModelPrimitiveType string string string String )
            value.S_HandleDragLineVerticalClassName         = GetString(new IntPtr(p + 0x018)); // 0x18 S_HandleDragLineVerticalClassName ( ModelPrimitiveType string string string String )
            value.S_HandleDragLineHorizontalClassName       = GetString(new IntPtr(p + 0x020)); // 0x20 S_HandleDragLineHorizontalClassName ( ModelPrimitiveType string string string String )
            value.S_HandleDragLineAnchorClassName           = GetString(new IntPtr(p + 0x028)); // 0x28 S_HandleDragLineAnchorClassName ( ModelPrimitiveType string string string String )
            value.S_HandleDragLineAnchorVerticalClassName   = GetString(new IntPtr(p + 0x030)); // 0x30 S_HandleDragLineAnchorVerticalClassName ( ModelPrimitiveType string string string String )
            value.S_HandleDragLineAnchorHorizontalClassName = GetString(new IntPtr(p + 0x038)); // 0x38 S_HandleDragLineAnchorHorizontalClassName ( ModelPrimitiveType string string string String )
            value.S_VerticalClassName                       = GetString(new IntPtr(p + 0x040)); // 0x40 S_VerticalClassName         ( ModelPrimitiveType string string string String )
            value.S_HorizontalClassName                     = GetString(new IntPtr(p + 0x048)); // 0x48 S_HorizontalClassName       ( ModelPrimitiveType string string string String )
            value.M_LeftPane                                = GetObject<VisualElement>(new IntPtr(p + 0x3C8), ReversePrism.DataModels.VisualElement.FromPointer); // 0x3C8 M_LeftPane                  ( ModelClassType VisualElement VisualElement VisualElement Pointer )
            value.M_RightPane                               = GetObject<VisualElement>(new IntPtr(p + 0x3D0), ReversePrism.DataModels.VisualElement.FromPointer); // 0x3D0 M_RightPane                 ( ModelClassType VisualElement VisualElement VisualElement Pointer )
            value.M_FixedPane                               = GetObject<VisualElement>(new IntPtr(p + 0x3D8), ReversePrism.DataModels.VisualElement.FromPointer); // 0x3D8 M_FixedPane                 ( ModelClassType VisualElement VisualElement VisualElement Pointer )
            value.M_FlexedPane                              = GetObject<VisualElement>(new IntPtr(p + 0x3E0), ReversePrism.DataModels.VisualElement.FromPointer); // 0x3E0 M_FlexedPane                ( ModelClassType VisualElement VisualElement VisualElement Pointer )
            value.M_FixedPaneDimension                      = GetSingle(new IntPtr(p + 0x3E8)); // 0x3E8 M_FixedPaneDimension        ( ModelPrimitiveType float float float Single )
            value.M_DragLine                                = GetObject<VisualElement>(new IntPtr(p + 0x3F0), ReversePrism.DataModels.VisualElement.FromPointer); // 0x3F0 M_DragLine                  ( ModelClassType VisualElement VisualElement VisualElement Pointer )
            value.M_DragLineAnchor                          = GetObject<VisualElement>(new IntPtr(p + 0x3F8), ReversePrism.DataModels.VisualElement.FromPointer); // 0x3F8 M_DragLineAnchor            ( ModelClassType VisualElement VisualElement VisualElement Pointer )
            value.M_CollapseMode                            = GetBool(new IntPtr(p + 0x400)); // 0x400 M_CollapseMode              ( ModelPrimitiveType bool bool bool Bool )
            value.M_Content                                 = GetObject<VisualElement>(new IntPtr(p + 0x408), ReversePrism.DataModels.VisualElement.FromPointer); // 0x408 M_Content                   ( ModelClassType VisualElement VisualElement VisualElement Pointer )
            value.M_Orientation                             = (TwoPaneSplitViewOrientation)GetInt32(new IntPtr(p + 0x410)); // 0x410 M_Orientation               ( ModelEnumType TwoPaneSplitViewOrientation TwoPaneSplitViewOrientation TwoPaneSplitViewOrientation Int32 )
            value.M_FixedPaneIndex                          = GetInt32(new IntPtr(p + 0x414)); // 0x414 M_FixedPaneIndex            ( ModelPrimitiveType int int int Int32 )
            value.M_FixedPaneInitialDimension               = GetSingle(new IntPtr(p + 0x418)); // 0x418 M_FixedPaneInitialDimension ( ModelPrimitiveType float float float Single )
            value.M_Resizer                                 = GetObject<TwoPaneSplitViewResizer>(new IntPtr(p + 0x420), ReversePrism.DataModels.TwoPaneSplitViewResizer.FromPointer); // 0x420 M_Resizer                   ( ModelClassType TwoPaneSplitViewResizer TwoPaneSplitViewResizer TwoPaneSplitViewResizer Pointer )

            return value;
        }
    }
}
