using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Position                                 ModelEnumType Rect Rect Rect Int32
    // 020 CurrentValue                             ModelPrimitiveType float float float Single
    // 024 Size                                     ModelPrimitiveType float float float Single
    // 028 Start                                    ModelPrimitiveType float float float Single
    // 02C End                                      ModelPrimitiveType float float float Single
    // 030 Slider                                   ModelClassType GUIStyle GUIStyle GUIStyle Pointer
    // 038 Thumb                                    ModelClassType GUIStyle GUIStyle GUIStyle Pointer
    // 040 ThumbExtent                              ModelClassType GUIStyle GUIStyle GUIStyle Pointer
    // 048 Horiz                                    ModelPrimitiveType bool bool bool Bool
    // 04C Id                                       ModelPrimitiveType int int int Int32
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

            value.Position                                  = (Rect)GetInt32(new IntPtr(p + 0x010)); // 0x10 Position                    ( ModelEnumType Rect Rect Rect Int32 )
            value.CurrentValue                              = GetSingle(new IntPtr(p + 0x020)); // 0x20 CurrentValue                ( ModelPrimitiveType float float float Single )
            value.Size                                      = GetSingle(new IntPtr(p + 0x024)); // 0x24 Size                        ( ModelPrimitiveType float float float Single )
            value.Start                                     = GetSingle(new IntPtr(p + 0x028)); // 0x28 Start                       ( ModelPrimitiveType float float float Single )
            value.End                                       = GetSingle(new IntPtr(p + 0x02C)); // 0x2C End                         ( ModelPrimitiveType float float float Single )
            value.Slider                                    = GetObject<GUIStyle>(new IntPtr(p + 0x030), ReversePrism.DataModels.GUIStyle.FromPointer); // 0x30 Slider                      ( ModelClassType GUIStyle GUIStyle GUIStyle Pointer )
            value.Thumb                                     = GetObject<GUIStyle>(new IntPtr(p + 0x038), ReversePrism.DataModels.GUIStyle.FromPointer); // 0x38 Thumb                       ( ModelClassType GUIStyle GUIStyle GUIStyle Pointer )
            value.ThumbExtent                               = GetObject<GUIStyle>(new IntPtr(p + 0x040), ReversePrism.DataModels.GUIStyle.FromPointer); // 0x40 ThumbExtent                 ( ModelClassType GUIStyle GUIStyle GUIStyle Pointer )
            value.Horiz                                     = GetBool(new IntPtr(p + 0x048)); // 0x48 Horiz                       ( ModelPrimitiveType bool bool bool Bool )
            value.Id                                        = GetInt32(new IntPtr(p + 0x04C)); // 0x4C Id                          ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
