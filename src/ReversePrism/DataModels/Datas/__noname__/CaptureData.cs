using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Uid                                      0001865F36C0 ModelPrimitiveType int int int Int32
    // 018 TargetCamera                             0001865A2380 ModelClassType Camera Camera Camera Pointer
    // 020 IsSetCaptureRange                        000186595960 ModelPrimitiveType bool bool bool Bool
    // 024 CaptureRange                             00018664FAF0 ModelEnumType Rect Rect Rect Int32
    public partial class CaptureData : DataModel
    {
        public int                                      Uid                                     { get; set; }
        public Camera?                                  TargetCamera                            { get; set; }
        public bool                                     IsSetCaptureRange                       { get; set; }
        public Rect                                     CaptureRange                            { get; set; }

        public static CaptureData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CaptureData() { Pointer= p0 };

            value.Uid                                       = GetInt32(new IntPtr(p + 0x010)); // 024660DF7B88 0x10 Uid                         ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.TargetCamera                              = GetObject<Camera>(new IntPtr(p + 0x018), ReversePrism.DataModels.Camera.FromPointer); // 024660DF7BA8 0x18 TargetCamera                ( 0001865A2380 ModelClassType Camera Camera Camera Pointer )
            value.IsSetCaptureRange                         = GetBool(new IntPtr(p + 0x020)); // 024660DF7BC8 0x20 IsSetCaptureRange           ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.CaptureRange                              = (Rect)GetInt32(new IntPtr(p + 0x024)); // 024660DF7BE8 0x24 CaptureRange                ( 00018664FAF0 ModelEnumType Rect Rect Rect Int32 )

            return value;
        }
    }
}
