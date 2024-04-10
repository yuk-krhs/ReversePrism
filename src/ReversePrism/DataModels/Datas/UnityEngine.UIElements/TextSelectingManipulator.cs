using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_SelectingUtilities                     0001866474B0 ModelClassType TextSelectingUtilities TextSelectingUtilities TextSelectingUtilities Pointer
    // 018 SelectAllOnMouseUp                       000186594D10 ModelPrimitiveType bool bool bool Bool
    // 020 M_TextElement                            000186638B30 ModelClassType TextElement TextElement TextElement Pointer
    // 028 M_ClickStartPosition                     0001866A7FB0 ModelEnumType Vector2 Vector2 Vector2 Int32
    // 030 M_Dragged                                000186594D10 ModelPrimitiveType bool bool bool Bool
    // 031 M_IsClicking                             000186594D10 ModelPrimitiveType bool bool bool Bool
    // 000 k_DragThresholdSqr                       int IL2CPP_TYPE_I4
    // 034 M_ConsecutiveMouseDownCount              0001865F2AF0 ModelPrimitiveType int int int Int32
    // 038 M_LastMouseDownTimeStamp                 0001865F7700 ModelPrimitiveType long long long Int64
    // 040 M_ImguiEvent                             00018674D0D0 ModelClassType Event Event Event Pointer
    public partial class TextSelectingManipulator : DataModel
    {
        public TextSelectingUtilities?                  M_SelectingUtilities                    { get; set; }
        public bool                                     SelectAllOnMouseUp                      { get; set; }
        public TextElement?                             M_TextElement                           { get; set; }
        public Vector2                                  M_ClickStartPosition                    { get; set; }
        public bool                                     M_Dragged                               { get; set; }
        public bool                                     M_IsClicking                            { get; set; }
        public int                                      M_ConsecutiveMouseDownCount             { get; set; }
        public long                                     M_LastMouseDownTimeStamp                { get; set; }
        public Event?                                   M_ImguiEvent                            { get; set; }

        public static TextSelectingManipulator? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TextSelectingManipulator() { Pointer= p0 };

            value.M_SelectingUtilities                      = GetObject<TextSelectingUtilities>(new IntPtr(p + 0x010), ReversePrism.DataModels.TextSelectingUtilities.FromPointer); // 0245A6807E00 0x10 M_SelectingUtilities        ( 0001866474B0 ModelClassType TextSelectingUtilities TextSelectingUtilities TextSelectingUtilities Pointer )
            value.SelectAllOnMouseUp                        = GetBool(new IntPtr(p + 0x018)); // 0245A6807E20 0x18 SelectAllOnMouseUp          ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_TextElement                             = GetObject<TextElement>(new IntPtr(p + 0x020), ReversePrism.DataModels.TextElement.FromPointer); // 0245A6807E40 0x20 M_TextElement               ( 000186638B30 ModelClassType TextElement TextElement TextElement Pointer )
            value.M_ClickStartPosition                      = (Vector2)GetInt32(new IntPtr(p + 0x028)); // 0245A6807E60 0x28 M_ClickStartPosition        ( 0001866A7FB0 ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.M_Dragged                                 = GetBool(new IntPtr(p + 0x030)); // 0245A6807E80 0x30 M_Dragged                   ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_IsClicking                              = GetBool(new IntPtr(p + 0x031)); // 0245A6807EA0 0x31 M_IsClicking                ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_ConsecutiveMouseDownCount               = GetInt32(new IntPtr(p + 0x034)); // 0245A6807EE0 0x34 M_ConsecutiveMouseDownCount ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_LastMouseDownTimeStamp                  = GetInt64(new IntPtr(p + 0x038)); // 0245A6807F00 0x38 M_LastMouseDownTimeStamp    ( 0001865F7700 ModelPrimitiveType long long long Int64 )
            value.M_ImguiEvent                              = GetObject<Event>(new IntPtr(p + 0x040), ReversePrism.DataModels.Event.FromPointer); // 0245A6807F20 0x40 M_ImguiEvent                ( 00018674D0D0 ModelClassType Event Event Event Pointer )

            return value;
        }
    }
}
