using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Position                                 00018664FFE0 ModelEnumType Rect Rect Rect Int32
    // 020 CurrentValue                             000186666CB0 ModelPrimitiveType float float float Single
    // 024 Size                                     000186666CB0 ModelPrimitiveType float float float Single
    // 028 Start                                    000186666CB0 ModelPrimitiveType float float float Single
    // 02C End                                      000186666CB0 ModelPrimitiveType float float float Single
    // 030 Slider                                   0001865DF720 ModelClassType GUIStyle GUIStyle GUIStyle Pointer
    // 038 Thumb                                    0001865DF720 ModelClassType GUIStyle GUIStyle GUIStyle Pointer
    // 040 ThumbExtent                              0001865DF720 ModelClassType GUIStyle GUIStyle GUIStyle Pointer
    // 048 Horiz                                    0001865965D0 ModelPrimitiveType bool bool bool Bool
    // 04C Id                                       0001865F4260 ModelPrimitiveType int int int Int32
    public partial class SliderHandler : DataModel
    {
        public Rect                                     Position                                { get; set; }
        public float                                    CurrentValue                            { get; set; }
        public float                                    Size                                    { get; set; }
        public float                                    Start                                   { get; set; }
        public float                                    End                                     { get; set; }
        public GUIStyle?                                Slider                                  { get; set; }
        public GUIStyle?                                Thumb                                   { get; set; }
        public GUIStyle?                                ThumbExtent                             { get; set; }
        public bool                                     Horiz                                   { get; set; }
        public int                                      Id                                      { get; set; }

        public static SliderHandler? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SliderHandler() { Pointer= p0 };

            value.Position                                  = (Rect)GetInt32(new IntPtr(p + 0x010)); // 0245A68EC618 0x10 Position                    ( 00018664FFE0 ModelEnumType Rect Rect Rect Int32 )
            value.CurrentValue                              = GetSingle(new IntPtr(p + 0x020)); // 0245A68EC638 0x20 CurrentValue                ( 000186666CB0 ModelPrimitiveType float float float Single )
            value.Size                                      = GetSingle(new IntPtr(p + 0x024)); // 0245A68EC658 0x24 Size                        ( 000186666CB0 ModelPrimitiveType float float float Single )
            value.Start                                     = GetSingle(new IntPtr(p + 0x028)); // 0245A68EC678 0x28 Start                       ( 000186666CB0 ModelPrimitiveType float float float Single )
            value.End                                       = GetSingle(new IntPtr(p + 0x02C)); // 0245A68EC698 0x2C End                         ( 000186666CB0 ModelPrimitiveType float float float Single )
            value.Slider                                    = GetObject<GUIStyle>(new IntPtr(p + 0x030), ReversePrism.DataModels.GUIStyle.FromPointer); // 0245A68EC6B8 0x30 Slider                      ( 0001865DF720 ModelClassType GUIStyle GUIStyle GUIStyle Pointer )
            value.Thumb                                     = GetObject<GUIStyle>(new IntPtr(p + 0x038), ReversePrism.DataModels.GUIStyle.FromPointer); // 0245A68EC6D8 0x38 Thumb                       ( 0001865DF720 ModelClassType GUIStyle GUIStyle GUIStyle Pointer )
            value.ThumbExtent                               = GetObject<GUIStyle>(new IntPtr(p + 0x040), ReversePrism.DataModels.GUIStyle.FromPointer); // 0245A68EC6F8 0x40 ThumbExtent                 ( 0001865DF720 ModelClassType GUIStyle GUIStyle GUIStyle Pointer )
            value.Horiz                                     = GetBool(new IntPtr(p + 0x048)); // 0245A68EC718 0x48 Horiz                       ( 0001865965D0 ModelPrimitiveType bool bool bool Bool )
            value.Id                                        = GetInt32(new IntPtr(p + 0x04C)); // 0245A68EC738 0x4C Id                          ( 0001865F4260 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
