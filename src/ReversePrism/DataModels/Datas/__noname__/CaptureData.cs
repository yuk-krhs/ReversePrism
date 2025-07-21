using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Uid                                      ModelPrimitiveType int int int Int32
    // 018 TargetCamera                             ModelClassType Camera Camera Camera Pointer
    // 020 IsSetCaptureRange                        ModelPrimitiveType bool bool bool Bool
    // 024 CaptureRange                             ModelEnumType Rect Rect Rect Int32
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

            value.Uid                                       = GetInt32(new IntPtr(p + 0x010)); // 0x10 Uid                         ( ModelPrimitiveType int int int Int32 )
            value.TargetCamera                              = GetObject<Camera>(new IntPtr(p + 0x018), ReversePrism.DataModels.Camera.FromPointer); // 0x18 TargetCamera                ( ModelClassType Camera Camera Camera Pointer )
            value.IsSetCaptureRange                         = GetBool(new IntPtr(p + 0x020)); // 0x20 IsSetCaptureRange           ( ModelPrimitiveType bool bool bool Bool )
            value.CaptureRange                              = (Rect)GetInt32(new IntPtr(p + 0x024)); // 0x24 CaptureRange                ( ModelEnumType Rect Rect Rect Int32 )

            return value;
        }
    }
}
