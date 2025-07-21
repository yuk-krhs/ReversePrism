using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 s_ScrollControlId                        int IL2CPP_TYPE_I4
    // 004 s_HotTextField                           int IL2CPP_TYPE_I4
    // 008 s_BoxHash                                int IL2CPP_TYPE_I4
    // 00C s_ButonHash                              int IL2CPP_TYPE_I4
    // 010 S_RepeatButtonHash                       ModelPrimitiveType int int int Int32
    // 014 S_ToggleHash                             ModelPrimitiveType int int int Int32
    // 018 S_ButtonGridHash                         ModelPrimitiveType int int int Int32
    // 01C S_SliderHash                             ModelPrimitiveType int int int Int32
    // 020 S_BeginGroupHash                         ModelPrimitiveType int int int Int32
    // 024 S_ScrollviewHash                         ModelPrimitiveType int int int Int32
    // 028 ScrollTroughSide                         ModelPrimitiveType int int int Int32
    // 030 NextScrollStepTime                       ModelPrimitiveType DateTime DateTime DateTime DateTime
    // 038 S_Skin                                   ModelClassType GUISkin GUISkin GUISkin Pointer
    // 040 S_ToolTipRect                            ModelEnumType Rect Rect Rect Int32
    // 050 ScrollViewStates                         ModelClassType GenericStack GenericStack GenericStack Pointer
    public partial class GUI : DataModel
    {
        public int                                      S_RepeatButtonHash                      { get; set; }
        public int                                      S_ToggleHash                            { get; set; }
        public int                                      S_ButtonGridHash                        { get; set; }
        public int                                      S_SliderHash                            { get; set; }
        public int                                      S_BeginGroupHash                        { get; set; }
        public int                                      S_ScrollviewHash                        { get; set; }
        public int                                      ScrollTroughSide                        { get; set; }
        public DateTime                                 NextScrollStepTime                      { get; set; }
        public GUISkin?                                 S_Skin                                  { get; set; }
        public Rect                                     S_ToolTipRect                           { get; set; }
        public GenericStack?                            ScrollViewStates                        { get; set; }

        public static GUI? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GUI() { Pointer= p0 };

            value.S_RepeatButtonHash                        = GetInt32(new IntPtr(p + 0x010)); // 0x10 S_RepeatButtonHash          ( ModelPrimitiveType int int int Int32 )
            value.S_ToggleHash                              = GetInt32(new IntPtr(p + 0x014)); // 0x14 S_ToggleHash                ( ModelPrimitiveType int int int Int32 )
            value.S_ButtonGridHash                          = GetInt32(new IntPtr(p + 0x018)); // 0x18 S_ButtonGridHash            ( ModelPrimitiveType int int int Int32 )
            value.S_SliderHash                              = GetInt32(new IntPtr(p + 0x01C)); // 0x1C S_SliderHash                ( ModelPrimitiveType int int int Int32 )
            value.S_BeginGroupHash                          = GetInt32(new IntPtr(p + 0x020)); // 0x20 S_BeginGroupHash            ( ModelPrimitiveType int int int Int32 )
            value.S_ScrollviewHash                          = GetInt32(new IntPtr(p + 0x024)); // 0x24 S_ScrollviewHash            ( ModelPrimitiveType int int int Int32 )
            value.ScrollTroughSide                          = GetInt32(new IntPtr(p + 0x028)); // 0x28 ScrollTroughSide            ( ModelPrimitiveType int int int Int32 )
            value.NextScrollStepTime                        = GetDateTime(new IntPtr(p + 0x030)); // 0x30 NextScrollStepTime          ( ModelPrimitiveType DateTime DateTime DateTime DateTime )
            value.S_Skin                                    = GetObject<GUISkin>(new IntPtr(p + 0x038), ReversePrism.DataModels.GUISkin.FromPointer); // 0x38 S_Skin                      ( ModelClassType GUISkin GUISkin GUISkin Pointer )
            value.S_ToolTipRect                             = (Rect)GetInt32(new IntPtr(p + 0x040)); // 0x40 S_ToolTipRect               ( ModelEnumType Rect Rect Rect Int32 )
            value.ScrollViewStates                          = GetObject<GenericStack>(new IntPtr(p + 0x050), ReversePrism.DataModels.GenericStack.FromPointer); // 0x50 ScrollViewStates            ( ModelClassType GenericStack GenericStack GenericStack Pointer )

            return value;
        }
    }
}
