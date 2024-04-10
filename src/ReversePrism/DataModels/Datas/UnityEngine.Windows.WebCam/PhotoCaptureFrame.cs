using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 m_NativePtr                              <int> IL2CPP_TYPE_I
    // 018 DataLength                               0001865F2AF0 ModelPrimitiveType int int int Int32
    // 01C HasLocationData                          000186594D10 ModelPrimitiveType bool bool bool Bool
    // 020 PixelFormat                              000186544350 ModelEnumType CapturePixelFormat CapturePixelFormat CapturePixelFormat Int32
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

            value.DataLength                                = GetInt32(new IntPtr(p + 0x018)); // 0245A4FAE6C8 0x18 DataLength                  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.HasLocationData                           = GetBool(new IntPtr(p + 0x01C)); // 0245A4FAE6E8 0x1C HasLocationData             ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.PixelFormat                               = (CapturePixelFormat)GetInt32(new IntPtr(p + 0x020)); // 0245A4FAE708 0x20 PixelFormat                 ( 000186544350 ModelEnumType CapturePixelFormat CapturePixelFormat CapturePixelFormat Int32 )

            return value;
        }
    }
}
