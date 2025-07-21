using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 038 MusicData                                ModelClassType MusicData MusicData MusicData Pointer
    // 040 <SetCarouselDraggable>k__BackingField    Action`1<bool> IL2CPP_TYPE_GENERICINST
    // 048 CameraModeSetting                        ModelEnumType LiveCameraModeSetting LiveCameraModeSetting LiveCameraModeSetting Int32
    // 054 IsActiveVocalSeparate                    ModelPrimitiveType bool bool bool Bool
    public partial class LiveUnitEditCarouselContextBase : DataModel
    {
        public MusicData?                               MusicData                               { get; set; }
        public LiveCameraModeSetting                    CameraModeSetting                       { get; set; }
        public bool                                     IsActiveVocalSeparate                   { get; set; }

        public static LiveUnitEditCarouselContextBase? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveUnitEditCarouselContextBase() { Pointer= p0 };

            value.MusicData                                 = GetObject<MusicData>(new IntPtr(p + 0x038), ReversePrism.DataModels.MusicData.FromPointer); // 0x38 MusicData                   ( ModelClassType MusicData MusicData MusicData Pointer )
            value.CameraModeSetting                         = (LiveCameraModeSetting)GetInt32(new IntPtr(p + 0x048)); // 0x48 CameraModeSetting           ( ModelEnumType LiveCameraModeSetting LiveCameraModeSetting LiveCameraModeSetting Int32 )
            value.IsActiveVocalSeparate                     = GetBool(new IntPtr(p + 0x054)); // 0x54 IsActiveVocalSeparate       ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
