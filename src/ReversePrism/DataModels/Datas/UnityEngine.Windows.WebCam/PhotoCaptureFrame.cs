using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 m_NativePtr                              <int> IL2CPP_TYPE_I
    // 018 DataLength                               ModelPrimitiveType int int int Int32
    // 01C HasLocationData                          ModelPrimitiveType bool bool bool Bool
    // 020 PixelFormat                              ModelEnumType CapturePixelFormat CapturePixelFormat CapturePixelFormat Int32
    public partial class PhotoCaptureFrame : DataModel
    {
        public int                                      DataLength                              { get; set; }
        public bool                                     HasLocationData                         { get; set; }
        public CapturePixelFormat                       PixelFormat                             { get; set; }

        public static PhotoCaptureFrame? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PhotoCaptureFrame() { Pointer= p0 };

            value.DataLength                                = GetInt32(new IntPtr(p + 0x018)); // 0x18 DataLength                  ( ModelPrimitiveType int int int Int32 )
            value.HasLocationData                           = GetBool(new IntPtr(p + 0x01C)); // 0x1C HasLocationData             ( ModelPrimitiveType bool bool bool Bool )
            value.PixelFormat                               = (CapturePixelFormat)GetInt32(new IntPtr(p + 0x020)); // 0x20 PixelFormat                 ( ModelEnumType CapturePixelFormat CapturePixelFormat CapturePixelFormat Int32 )

            return value;
        }
    }
}
