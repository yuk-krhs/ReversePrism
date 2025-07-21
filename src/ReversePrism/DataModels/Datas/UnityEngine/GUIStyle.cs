using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 m_Ptr                                    <int> IL2CPP_TYPE_I
    // 018 M_Normal                                 ModelClassType GUIStyleState GUIStyleState GUIStyleState Pointer
    // 020 M_Hover                                  ModelClassType GUIStyleState GUIStyleState GUIStyleState Pointer
    // 028 M_Active                                 ModelClassType GUIStyleState GUIStyleState GUIStyleState Pointer
    // 030 M_Focused                                ModelClassType GUIStyleState GUIStyleState GUIStyleState Pointer
    // 038 M_OnNormal                               ModelClassType GUIStyleState GUIStyleState GUIStyleState Pointer
    // 040 M_OnHover                                ModelClassType GUIStyleState GUIStyleState GUIStyleState Pointer
    // 048 M_OnActive                               ModelClassType GUIStyleState GUIStyleState GUIStyleState Pointer
    // 050 M_OnFocused                              ModelClassType GUIStyleState GUIStyleState GUIStyleState Pointer
    // 058 M_Border                                 ModelClassType RectOffset RectOffset RectOffset Pointer
    // 060 M_Padding                                ModelClassType RectOffset RectOffset RectOffset Pointer
    // 068 M_Margin                                 ModelClassType RectOffset RectOffset RectOffset Pointer
    // 070 M_Overflow                               ModelClassType RectOffset RectOffset RectOffset Pointer
    // 078 M_Name                                   ModelPrimitiveType string string string String
    // 000 showKeyboardFocus                        bool IL2CPP_TYPE_BOOLEAN
    // 008 s_None                                   GUIStyle IL2CPP_TYPE_CLASS
    public partial class GUIStyle : DataModel
    {
        public GUIStyleState?                           M_Normal                                { get; set; }
        public GUIStyleState?                           M_Hover                                 { get; set; }
        public GUIStyleState?                           M_Active                                { get; set; }
        public GUIStyleState?                           M_Focused                               { get; set; }
        public GUIStyleState?                           M_OnNormal                              { get; set; }
        public GUIStyleState?                           M_OnHover                               { get; set; }
        public GUIStyleState?                           M_OnActive                              { get; set; }
        public GUIStyleState?                           M_OnFocused                             { get; set; }
        public RectOffset?                              M_Border                                { get; set; }
        public RectOffset?                              M_Padding                               { get; set; }
        public RectOffset?                              M_Margin                                { get; set; }
        public RectOffset?                              M_Overflow                              { get; set; }
        public string                                   M_Name                                  { get; set; }

        public static GUIStyle? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GUIStyle() { Pointer= p0 };

            value.M_Normal                                  = GetObject<GUIStyleState>(new IntPtr(p + 0x018), ReversePrism.DataModels.GUIStyleState.FromPointer); // 0x18 M_Normal                    ( ModelClassType GUIStyleState GUIStyleState GUIStyleState Pointer )
            value.M_Hover                                   = GetObject<GUIStyleState>(new IntPtr(p + 0x020), ReversePrism.DataModels.GUIStyleState.FromPointer); // 0x20 M_Hover                     ( ModelClassType GUIStyleState GUIStyleState GUIStyleState Pointer )
            value.M_Active                                  = GetObject<GUIStyleState>(new IntPtr(p + 0x028), ReversePrism.DataModels.GUIStyleState.FromPointer); // 0x28 M_Active                    ( ModelClassType GUIStyleState GUIStyleState GUIStyleState Pointer )
            value.M_Focused                                 = GetObject<GUIStyleState>(new IntPtr(p + 0x030), ReversePrism.DataModels.GUIStyleState.FromPointer); // 0x30 M_Focused                   ( ModelClassType GUIStyleState GUIStyleState GUIStyleState Pointer )
            value.M_OnNormal                                = GetObject<GUIStyleState>(new IntPtr(p + 0x038), ReversePrism.DataModels.GUIStyleState.FromPointer); // 0x38 M_OnNormal                  ( ModelClassType GUIStyleState GUIStyleState GUIStyleState Pointer )
            value.M_OnHover                                 = GetObject<GUIStyleState>(new IntPtr(p + 0x040), ReversePrism.DataModels.GUIStyleState.FromPointer); // 0x40 M_OnHover                   ( ModelClassType GUIStyleState GUIStyleState GUIStyleState Pointer )
            value.M_OnActive                                = GetObject<GUIStyleState>(new IntPtr(p + 0x048), ReversePrism.DataModels.GUIStyleState.FromPointer); // 0x48 M_OnActive                  ( ModelClassType GUIStyleState GUIStyleState GUIStyleState Pointer )
            value.M_OnFocused                               = GetObject<GUIStyleState>(new IntPtr(p + 0x050), ReversePrism.DataModels.GUIStyleState.FromPointer); // 0x50 M_OnFocused                 ( ModelClassType GUIStyleState GUIStyleState GUIStyleState Pointer )
            value.M_Border                                  = GetObject<RectOffset>(new IntPtr(p + 0x058), ReversePrism.DataModels.RectOffset.FromPointer); // 0x58 M_Border                    ( ModelClassType RectOffset RectOffset RectOffset Pointer )
            value.M_Padding                                 = GetObject<RectOffset>(new IntPtr(p + 0x060), ReversePrism.DataModels.RectOffset.FromPointer); // 0x60 M_Padding                   ( ModelClassType RectOffset RectOffset RectOffset Pointer )
            value.M_Margin                                  = GetObject<RectOffset>(new IntPtr(p + 0x068), ReversePrism.DataModels.RectOffset.FromPointer); // 0x68 M_Margin                    ( ModelClassType RectOffset RectOffset RectOffset Pointer )
            value.M_Overflow                                = GetObject<RectOffset>(new IntPtr(p + 0x070), ReversePrism.DataModels.RectOffset.FromPointer); // 0x70 M_Overflow                  ( ModelClassType RectOffset RectOffset RectOffset Pointer )
            value.M_Name                                    = GetString(new IntPtr(p + 0x078)); // 0x78 M_Name                      ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
