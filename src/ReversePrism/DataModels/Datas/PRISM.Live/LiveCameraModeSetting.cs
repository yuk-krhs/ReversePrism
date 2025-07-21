using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 MusicId                                  ModelPrimitiveType int int int Int32
    // 014 CameraMode                               ModelEnumType LiveCameraMode LiveCameraMode LiveCameraMode Int32
    // 018 FocusPositionIndex                       ModelPrimitiveType int int int Int32
    public partial class LiveCameraModeSetting : DataModel
    {
        public int                                      MusicId                                 { get; set; }
        public LiveCameraMode                           CameraMode                              { get; set; }
        public int                                      FocusPositionIndex                      { get; set; }

        public static LiveCameraModeSetting? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveCameraModeSetting() { Pointer= p0 };

            value.MusicId                                   = GetInt32(new IntPtr(p + 0x010)); // 0x10 MusicId                     ( ModelPrimitiveType int int int Int32 )
            value.CameraMode                                = (LiveCameraMode)GetInt32(new IntPtr(p + 0x014)); // 0x14 CameraMode                  ( ModelEnumType LiveCameraMode LiveCameraMode LiveCameraMode Int32 )
            value.FocusPositionIndex                        = GetInt32(new IntPtr(p + 0x018)); // 0x18 FocusPositionIndex          ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
