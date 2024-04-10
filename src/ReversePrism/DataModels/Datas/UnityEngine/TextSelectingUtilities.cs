using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 DblClickSnap                             0001865F7570 ModelEnumType DblClickSnapping DblClickSnapping DblClickSnapping Int32
    // 014 IAltCursorPos                            0001865F36C0 ModelPrimitiveType int int int Int32
    // 018 HasHorizontalCursorPos                   000186595960 ModelPrimitiveType bool bool bool Bool
    // 019 M_bJustSelected                          000186594D10 ModelPrimitiveType bool bool bool Bool
    // 01A M_MouseDragSelectsWholeWords             000186594D10 ModelPrimitiveType bool bool bool Bool
    // 01C M_DblClickInitPos                        0001865F2AF0 ModelPrimitiveType int int int Int32
    // 020 M_TextHandle                             00018663D5B0 ModelClassType TextHandle TextHandle TextHandle Pointer
    // 000 kMoveDownHeight                          int IL2CPP_TYPE_I4
    // 000 kNewLineChar                             char IL2CPP_TYPE_CHAR
    // 028 M_RevealCursor                           000186594D10 ModelPrimitiveType bool bool bool Bool
    // 02C M_CursorIndex                            0001865F2AF0 ModelPrimitiveType int int int Int32
    // 030 M_SelectIndex                            0001865F2F90 ModelPrimitiveType int int int Int32
    // 000 s_KeySelectOps                           Dictionary`2<Event, TextSelectOp> IL2CPP_TYPE_GENERICINST
    // 038 OnCursorIndexChange                      0001866794E0 ModelClassType Action Action Action Pointer
    // 040 OnSelectIndexChange                      0001866794E0 ModelClassType Action Action Action Pointer
    // 048 OnRevealCursorChange                     0001866794E0 ModelClassType Action Action Action Pointer
    public partial class TextSelectingUtilities : DataModel
    {
        public DblClickSnapping                         DblClickSnap                            { get; set; }
        public int                                      IAltCursorPos                           { get; set; }
        public bool                                     HasHorizontalCursorPos                  { get; set; }
        public bool                                     M_bJustSelected                         { get; set; }
        public bool                                     M_MouseDragSelectsWholeWords            { get; set; }
        public int                                      M_DblClickInitPos                       { get; set; }
        public TextHandle?                              M_TextHandle                            { get; set; }
        public bool                                     M_RevealCursor                          { get; set; }
        public int                                      M_CursorIndex                           { get; set; }
        public int                                      M_SelectIndex                           { get; set; }
        public Action?                                  OnCursorIndexChange                     { get; set; }
        public Action?                                  OnSelectIndexChange                     { get; set; }
        public Action?                                  OnRevealCursorChange                    { get; set; }

        public static TextSelectingUtilities? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TextSelectingUtilities() { Pointer= p0 };

            value.DblClickSnap                              = (DblClickSnapping)GetInt32(new IntPtr(p + 0x010)); // 0245A68EFAA8 0x10 DblClickSnap                ( 0001865F7570 ModelEnumType DblClickSnapping DblClickSnapping DblClickSnapping Int32 )
            value.IAltCursorPos                             = GetInt32(new IntPtr(p + 0x014)); // 0245A68EFAC8 0x14 IAltCursorPos               ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.HasHorizontalCursorPos                    = GetBool(new IntPtr(p + 0x018)); // 0245A68EFAE8 0x18 HasHorizontalCursorPos      ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.M_bJustSelected                           = GetBool(new IntPtr(p + 0x019)); // 0245A68EFB08 0x19 M_bJustSelected             ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_MouseDragSelectsWholeWords              = GetBool(new IntPtr(p + 0x01A)); // 0245A68EFB28 0x1A M_MouseDragSelectsWholeWords ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_DblClickInitPos                         = GetInt32(new IntPtr(p + 0x01C)); // 0245A68EFB48 0x1C M_DblClickInitPos           ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_TextHandle                              = GetObject<TextHandle>(new IntPtr(p + 0x020), ReversePrism.DataModels.TextHandle.FromPointer); // 0245A68EFB68 0x20 M_TextHandle                ( 00018663D5B0 ModelClassType TextHandle TextHandle TextHandle Pointer )
            value.M_RevealCursor                            = GetBool(new IntPtr(p + 0x028)); // 0245A68EFBC8 0x28 M_RevealCursor              ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_CursorIndex                             = GetInt32(new IntPtr(p + 0x02C)); // 0245A68EFBE8 0x2C M_CursorIndex               ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_SelectIndex                             = GetInt32(new IntPtr(p + 0x030)); // 0245A68EFC08 0x30 M_SelectIndex               ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.OnCursorIndexChange                       = GetObject<Action>(new IntPtr(p + 0x038), ReversePrism.DataModels.Action.FromPointer); // 0245A68EFC48 0x38 OnCursorIndexChange         ( 0001866794E0 ModelClassType Action Action Action Pointer )
            value.OnSelectIndexChange                       = GetObject<Action>(new IntPtr(p + 0x040), ReversePrism.DataModels.Action.FromPointer); // 0245A68EFC68 0x40 OnSelectIndexChange         ( 0001866794E0 ModelClassType Action Action Action Pointer )
            value.OnRevealCursorChange                      = GetObject<Action>(new IntPtr(p + 0x048), ReversePrism.DataModels.Action.FromPointer); // 0245A68EFC88 0x48 OnRevealCursorChange        ( 0001866794E0 ModelClassType Action Action Action Pointer )

            return value;
        }
    }
}
