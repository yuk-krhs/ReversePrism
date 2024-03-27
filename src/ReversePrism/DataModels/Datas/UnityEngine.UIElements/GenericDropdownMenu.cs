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
    // 010 LabelUssClassName                        000186674040 ModelPrimitiveType string string string String
    // 018 ContainerInnerUssClassName               000186674040 ModelPrimitiveType string string string String
    // 020 ContainerOuterUssClassName               000186674040 ModelPrimitiveType string string string String
    // 028 CheckmarkUssClassName                    000186674040 ModelPrimitiveType string string string String
    // 030 SeparatorUssClassName                    000186674040 ModelPrimitiveType string string string String
    // 010 M_Items                                  000185D247C8 ModelClassListType List`1<MenuItem> List`1<MenuItem> List<MenuItem> Pointer
    // 018 M_MenuContainer                          0001866B2D70 ModelClassType VisualElement VisualElement VisualElement Pointer
    // 020 M_OuterContainer                         0001866B2D70 ModelClassType VisualElement VisualElement VisualElement Pointer
    // 028 M_ScrollView                             0001866F8E70 ModelClassType ScrollView ScrollView ScrollView Pointer
    // 030 M_PanelRootVisualContainer               0001866B2D70 ModelClassType VisualElement VisualElement VisualElement Pointer
    // 038 M_TargetElement                          0001866B2D70 ModelClassType VisualElement VisualElement VisualElement Pointer
    // 040 M_DesiredRect                            00018664F620 ModelEnumType Rect Rect Rect Int32
    // 050 M_NavigationManipulator                  000186772620 ModelClassType KeyboardNavigationManipulator KeyboardNavigationManipulator KeyboardNavigationManipulator Pointer
    // 058 IsSingleSelectionDropdown                000186594D10 ModelPrimitiveType bool bool bool Bool
    // 059 CloseOnParentResize                      000186594D10 ModelPrimitiveType bool bool bool Bool
    // 05C M_MousePosition                          0001866A7FB0 ModelEnumType Vector2 Vector2 Vector2 Int32
    public partial class GenericDropdownMenu
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
            var value   = new GenericDropdownMenu();

            value.LabelUssClassName                         = GetString(new IntPtr(p + 0x010)); // 0270067117F8 0x10 LabelUssClassName           ( 000186674040 ModelPrimitiveType string string string String )
            value.ContainerInnerUssClassName                = GetString(new IntPtr(p + 0x018)); // 027006711818 0x18 ContainerInnerUssClassName  ( 000186674040 ModelPrimitiveType string string string String )
            value.ContainerOuterUssClassName                = GetString(new IntPtr(p + 0x020)); // 027006711838 0x20 ContainerOuterUssClassName  ( 000186674040 ModelPrimitiveType string string string String )
            value.CheckmarkUssClassName                     = GetString(new IntPtr(p + 0x028)); // 027006711858 0x28 CheckmarkUssClassName       ( 000186674040 ModelPrimitiveType string string string String )
            value.SeparatorUssClassName                     = GetString(new IntPtr(p + 0x030)); // 027006711878 0x30 SeparatorUssClassName       ( 000186674040 ModelPrimitiveType string string string String )
            value.M_Items                                   = GetObjectList<MenuItem>(new IntPtr(p + 0x010), ReversePrism.DataModels.MenuItem.FromPointer); // 027006711898 0x10 M_Items                     ( 000185D247C8 ModelClassListType List`1<MenuItem> List`1<MenuItem> List<MenuItem> Pointer )
            value.M_MenuContainer                           = GetObject<VisualElement>(new IntPtr(p + 0x018), ReversePrism.DataModels.VisualElement.FromPointer); // 0270067118B8 0x18 M_MenuContainer             ( 0001866B2D70 ModelClassType VisualElement VisualElement VisualElement Pointer )
            value.M_OuterContainer                          = GetObject<VisualElement>(new IntPtr(p + 0x020), ReversePrism.DataModels.VisualElement.FromPointer); // 0270067118D8 0x20 M_OuterContainer            ( 0001866B2D70 ModelClassType VisualElement VisualElement VisualElement Pointer )
            value.M_ScrollView                              = GetObject<ScrollView>(new IntPtr(p + 0x028), ReversePrism.DataModels.ScrollView.FromPointer); // 0270067118F8 0x28 M_ScrollView                ( 0001866F8E70 ModelClassType ScrollView ScrollView ScrollView Pointer )
            value.M_PanelRootVisualContainer                = GetObject<VisualElement>(new IntPtr(p + 0x030), ReversePrism.DataModels.VisualElement.FromPointer); // 027006711918 0x30 M_PanelRootVisualContainer  ( 0001866B2D70 ModelClassType VisualElement VisualElement VisualElement Pointer )
            value.M_TargetElement                           = GetObject<VisualElement>(new IntPtr(p + 0x038), ReversePrism.DataModels.VisualElement.FromPointer); // 027006711938 0x38 M_TargetElement             ( 0001866B2D70 ModelClassType VisualElement VisualElement VisualElement Pointer )
            value.M_DesiredRect                             = (Rect)GetInt32(new IntPtr(p + 0x040)); // 027006711958 0x40 M_DesiredRect               ( 00018664F620 ModelEnumType Rect Rect Rect Int32 )
            value.M_NavigationManipulator                   = GetObject<KeyboardNavigationManipulator>(new IntPtr(p + 0x050), ReversePrism.DataModels.KeyboardNavigationManipulator.FromPointer); // 027006711978 0x50 M_NavigationManipulator     ( 000186772620 ModelClassType KeyboardNavigationManipulator KeyboardNavigationManipulator KeyboardNavigationManipulator Pointer )
            value.IsSingleSelectionDropdown                 = GetBool(new IntPtr(p + 0x058)); // 027006711998 0x58 IsSingleSelectionDropdown   ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.CloseOnParentResize                       = GetBool(new IntPtr(p + 0x059)); // 0270067119B8 0x59 CloseOnParentResize         ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_MousePosition                           = (Vector2)GetInt32(new IntPtr(p + 0x05C)); // 0270067119D8 0x5C M_MousePosition             ( 0001866A7FB0 ModelEnumType Vector2 Vector2 Vector2 Int32 )

            return value;
        }
    }
}
