using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Matrix                                   ModelEnumType Matrix4x4 Matrix4x4 Matrix4x4 Int32
    // 050 Color                                    ModelEnumType Color Color Color Int32
    // 060 ContentColor                             ModelEnumType Color Color Color Int32
    // 070 BackgroundColor                          ModelEnumType Color Color Color Int32
    // 080 Enabled                                  ModelPrimitiveType bool bool bool Bool
    // 081 Changed                                  ModelPrimitiveType bool bool bool Bool
    // 084 DisplayIndex                             ModelPrimitiveType int int int Int32
    public partial class GUIGlobals : DataModel
    {
        public Matrix4x4                                Matrix                                  { get; set; }
        public Color                                    Color                                   { get; set; }
        public Color                                    ContentColor                            { get; set; }
        public Color                                    BackgroundColor                         { get; set; }
        public bool                                     Enabled                                 { get; set; }
        public bool                                     Changed                                 { get; set; }
        public int                                      DisplayIndex                            { get; set; }

        public static GUIGlobals? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GUIGlobals() { Pointer= p0 };

            value.Matrix                                    = (Matrix4x4)GetInt32(new IntPtr(p + 0x010)); // 0x10 Matrix                      ( ModelEnumType Matrix4x4 Matrix4x4 Matrix4x4 Int32 )
            value.Color                                     = (Color)GetInt32(new IntPtr(p + 0x050)); // 0x50 Color                       ( ModelEnumType Color Color Color Int32 )
            value.ContentColor                              = (Color)GetInt32(new IntPtr(p + 0x060)); // 0x60 ContentColor                ( ModelEnumType Color Color Color Int32 )
            value.BackgroundColor                           = (Color)GetInt32(new IntPtr(p + 0x070)); // 0x70 BackgroundColor             ( ModelEnumType Color Color Color Int32 )
            value.Enabled                                   = GetBool(new IntPtr(p + 0x080)); // 0x80 Enabled                     ( ModelPrimitiveType bool bool bool Bool )
            value.Changed                                   = GetBool(new IntPtr(p + 0x081)); // 0x81 Changed                     ( ModelPrimitiveType bool bool bool Bool )
            value.DisplayIndex                              = GetInt32(new IntPtr(p + 0x084)); // 0x84 DisplayIndex                ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
