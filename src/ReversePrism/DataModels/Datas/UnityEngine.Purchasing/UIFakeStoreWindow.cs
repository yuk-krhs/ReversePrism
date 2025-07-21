using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 M_QueryText                              ModelPrimitiveType string string string String
    // 028 M_OkText                                 ModelPrimitiveType string string string String
    // 030 M_CancelText                             ModelPrimitiveType string string string String
    // 038 M_LastSelectedOptionText                 ModelPrimitiveType string string string String
    // 040 M_OnOk                                   ModelClassType Action Action Action Pointer
    // 048 M_OnCancel                               ModelClassType Action Action Action Pointer
    // 050 m_OnDropdown                             Action`1<int> IL2CPP_TYPE_GENERICINST
    // 058 M_CancelEnabled                          ModelPrimitiveType bool bool bool Bool
    // 059 M_DropdownEnabled                        ModelPrimitiveType bool bool bool Bool
    // 05A M_DoDropdown                             ModelPrimitiveType bool bool bool Bool
    // 060 M_Dropdown                               ModelClassType UIFakeStoreDropdown UIFakeStoreDropdown UIFakeStoreDropdown Pointer
    // 068 ScrollPosition                           ModelEnumType Vector2 Vector2 Vector2 Int32
    // 000 k_MenuScreenRatio                        float IL2CPP_TYPE_R4
    public partial class UIFakeStoreWindow : DataModel
    {
        public string                                   M_QueryText                             { get; set; }
        public string                                   M_OkText                                { get; set; }
        public string                                   M_CancelText                            { get; set; }
        public string                                   M_LastSelectedOptionText                { get; set; }
        public Action?                                  M_OnOk                                  { get; set; }
        public Action?                                  M_OnCancel                              { get; set; }
        public bool                                     M_CancelEnabled                         { get; set; }
        public bool                                     M_DropdownEnabled                       { get; set; }
        public bool                                     M_DoDropdown                            { get; set; }
        public UIFakeStoreDropdown?                     M_Dropdown                              { get; set; }
        public Vector2                                  ScrollPosition                          { get; set; }

        public static UIFakeStoreWindow? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UIFakeStoreWindow() { Pointer= p0 };

            value.M_QueryText                               = GetString(new IntPtr(p + 0x020)); // 0x20 M_QueryText                 ( ModelPrimitiveType string string string String )
            value.M_OkText                                  = GetString(new IntPtr(p + 0x028)); // 0x28 M_OkText                    ( ModelPrimitiveType string string string String )
            value.M_CancelText                              = GetString(new IntPtr(p + 0x030)); // 0x30 M_CancelText                ( ModelPrimitiveType string string string String )
            value.M_LastSelectedOptionText                  = GetString(new IntPtr(p + 0x038)); // 0x38 M_LastSelectedOptionText    ( ModelPrimitiveType string string string String )
            value.M_OnOk                                    = GetObject<Action>(new IntPtr(p + 0x040), ReversePrism.DataModels.Action.FromPointer); // 0x40 M_OnOk                      ( ModelClassType Action Action Action Pointer )
            value.M_OnCancel                                = GetObject<Action>(new IntPtr(p + 0x048), ReversePrism.DataModels.Action.FromPointer); // 0x48 M_OnCancel                  ( ModelClassType Action Action Action Pointer )
            value.M_CancelEnabled                           = GetBool(new IntPtr(p + 0x058)); // 0x58 M_CancelEnabled             ( ModelPrimitiveType bool bool bool Bool )
            value.M_DropdownEnabled                         = GetBool(new IntPtr(p + 0x059)); // 0x59 M_DropdownEnabled           ( ModelPrimitiveType bool bool bool Bool )
            value.M_DoDropdown                              = GetBool(new IntPtr(p + 0x05A)); // 0x5A M_DoDropdown                ( ModelPrimitiveType bool bool bool Bool )
            value.M_Dropdown                                = GetObject<UIFakeStoreDropdown>(new IntPtr(p + 0x060), ReversePrism.DataModels.UIFakeStoreDropdown.FromPointer); // 0x60 M_Dropdown                  ( ModelClassType UIFakeStoreDropdown UIFakeStoreDropdown UIFakeStoreDropdown Pointer )
            value.ScrollPosition                            = (Vector2)GetInt32(new IntPtr(p + 0x068)); // 0x68 ScrollPosition              ( ModelEnumType Vector2 Vector2 Vector2 Int32 )

            return value;
        }
    }
}
