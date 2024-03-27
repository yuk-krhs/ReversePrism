using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 MusicId                                  0001865F36C0 ModelPrimitiveType int int int Int32
    // 014 CameraMode                               000186542C90 ModelEnumType LiveCameraMode LiveCameraMode LiveCameraMode Int32
    // 018 FocusPositionIndex                       0001865F36C0 ModelPrimitiveType int int int Int32
    public partial class LiveCameraModeSetting
    {
        public int                                      MusicId                                 { get; set; }
        public LiveCameraMode                           CameraMode                              { get; set; }
        public int                                      FocusPositionIndex                      { get; set; }

        public static LiveCameraModeSetting? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveCameraModeSetting();

            value.MusicId                                   = GetInt32(new IntPtr(p + 0x010)); // 027003A848D0 0x10 MusicId                     ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.CameraMode                                = (LiveCameraMode)GetInt32(new IntPtr(p + 0x014)); // 027003A848F0 0x14 CameraMode                  ( 000186542C90 ModelEnumType LiveCameraMode LiveCameraMode LiveCameraMode Int32 )
            value.FocusPositionIndex                        = GetInt32(new IntPtr(p + 0x018)); // 027003A84910 0x18 FocusPositionIndex          ( 0001865F36C0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
