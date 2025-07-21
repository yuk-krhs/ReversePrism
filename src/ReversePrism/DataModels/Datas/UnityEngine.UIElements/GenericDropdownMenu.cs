using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 ussClassName                             string IL2CPP_TYPE_STRING
    // 008 itemUssClassName                         string IL2CPP_TYPE_STRING
    // 010 LabelUssClassName                        ModelPrimitiveType string string string String
    // 018 ContainerInnerUssClassName               ModelPrimitiveType string string string String
    // 020 ContainerOuterUssClassName               ModelPrimitiveType string string string String
    // 028 CheckmarkUssClassName                    ModelPrimitiveType string string string String
    // 030 SeparatorUssClassName                    ModelPrimitiveType string string string String
    // 010 M_Items                                  ModelClassListType List`1<MenuItem> List`1<MenuItem> List<MenuItem> Pointer
    // 018 M_MenuContainer                          ModelClassType VisualElement VisualElement VisualElement Pointer
    // 020 M_OuterContainer                         ModelClassType VisualElement VisualElement VisualElement Pointer
    // 028 M_ScrollView                             ModelClassType ScrollView ScrollView ScrollView Pointer
    // 030 M_PanelRootVisualContainer               ModelClassType VisualElement VisualElement VisualElement Pointer
    // 038 M_TargetElement                          ModelClassType VisualElement VisualElement VisualElement Pointer
    // 040 M_DesiredRect                            ModelEnumType Rect Rect Rect Int32
    // 050 M_NavigationManipulator                  ModelClassType KeyboardNavigationManipulator KeyboardNavigationManipulator KeyboardNavigationManipulator Pointer
    // 058 IsSingleSelectionDropdown                ModelPrimitiveType bool bool bool Bool
    // 059 CloseOnParentResize                      ModelPrimitiveType bool bool bool Bool
    // 05C M_MousePosition                          ModelEnumType Vector2 Vector2 Vector2 Int32
    public partial class GenericDropdownMenu : DataModel
    {
        public string                                   LabelUssClassName                       { get; set; }
        public string                                   ContainerInnerUssClassName              { get; set; }
        public string                                   ContainerOuterUssClassName              { get; set; }
        public string                                   CheckmarkUssClassName                   { get; set; }
        public string                                   SeparatorUssClassName                   { get; set; }
        public List<MenuItem>?                          M_Items                                 { get; set; }
        public VisualElement?                           M_MenuContainer                         { get; set; }
        public VisualElement?                           M_OuterContainer                        { get; set; }
        public ScrollView?                              M_ScrollView                            { get; set; }
        public VisualElement?                           M_PanelRootVisualContainer              { get; set; }
        public VisualElement?                           M_TargetElement                         { get; set; }
        public Rect                                     M_DesiredRect                           { get; set; }
        public KeyboardNavigationManipulator?           M_NavigationManipulator                 { get; set; }
        public bool                                     IsSingleSelectionDropdown               { get; set; }
        public bool                                     CloseOnParentResize                     { get; set; }
        public Vector2                                  M_MousePosition                         { get; set; }

        public static GenericDropdownMenu? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GenericDropdownMenu() { Pointer= p0 };

            value.LabelUssClassName                         = GetString(new IntPtr(p + 0x010)); // 0x10 LabelUssClassName           ( ModelPrimitiveType string string string String )
            value.ContainerInnerUssClassName                = GetString(new IntPtr(p + 0x018)); // 0x18 ContainerInnerUssClassName  ( ModelPrimitiveType string string string String )
            value.ContainerOuterUssClassName                = GetString(new IntPtr(p + 0x020)); // 0x20 ContainerOuterUssClassName  ( ModelPrimitiveType string string string String )
            value.CheckmarkUssClassName                     = GetString(new IntPtr(p + 0x028)); // 0x28 CheckmarkUssClassName       ( ModelPrimitiveType string string string String )
            value.SeparatorUssClassName                     = GetString(new IntPtr(p + 0x030)); // 0x30 SeparatorUssClassName       ( ModelPrimitiveType string string string String )
            value.M_Items                                   = GetObjectList<MenuItem>(new IntPtr(p + 0x010), ReversePrism.DataModels.MenuItem.FromPointer); // 0x10 M_Items                     ( ModelClassListType List`1<MenuItem> List`1<MenuItem> List<MenuItem> Pointer )
            value.M_MenuContainer                           = GetObject<VisualElement>(new IntPtr(p + 0x018), ReversePrism.DataModels.VisualElement.FromPointer); // 0x18 M_MenuContainer             ( ModelClassType VisualElement VisualElement VisualElement Pointer )
            value.M_OuterContainer                          = GetObject<VisualElement>(new IntPtr(p + 0x020), ReversePrism.DataModels.VisualElement.FromPointer); // 0x20 M_OuterContainer            ( ModelClassType VisualElement VisualElement VisualElement Pointer )
            value.M_ScrollView                              = GetObject<ScrollView>(new IntPtr(p + 0x028), ReversePrism.DataModels.ScrollView.FromPointer); // 0x28 M_ScrollView                ( ModelClassType ScrollView ScrollView ScrollView Pointer )
            value.M_PanelRootVisualContainer                = GetObject<VisualElement>(new IntPtr(p + 0x030), ReversePrism.DataModels.VisualElement.FromPointer); // 0x30 M_PanelRootVisualContainer  ( ModelClassType VisualElement VisualElement VisualElement Pointer )
            value.M_TargetElement                           = GetObject<VisualElement>(new IntPtr(p + 0x038), ReversePrism.DataModels.VisualElement.FromPointer); // 0x38 M_TargetElement             ( ModelClassType VisualElement VisualElement VisualElement Pointer )
            value.M_DesiredRect                             = (Rect)GetInt32(new IntPtr(p + 0x040)); // 0x40 M_DesiredRect               ( ModelEnumType Rect Rect Rect Int32 )
            value.M_NavigationManipulator                   = GetObject<KeyboardNavigationManipulator>(new IntPtr(p + 0x050), ReversePrism.DataModels.KeyboardNavigationManipulator.FromPointer); // 0x50 M_NavigationManipulator     ( ModelClassType KeyboardNavigationManipulator KeyboardNavigationManipulator KeyboardNavigationManipulator Pointer )
            value.IsSingleSelectionDropdown                 = GetBool(new IntPtr(p + 0x058)); // 0x58 IsSingleSelectionDropdown   ( ModelPrimitiveType bool bool bool Bool )
            value.CloseOnParentResize                       = GetBool(new IntPtr(p + 0x059)); // 0x59 CloseOnParentResize         ( ModelPrimitiveType bool bool bool Bool )
            value.M_MousePosition                           = (Vector2)GetInt32(new IntPtr(p + 0x05C)); // 0x5C M_MousePosition             ( ModelEnumType Vector2 Vector2 Vector2 Int32 )

            return value;
        }
    }
}
