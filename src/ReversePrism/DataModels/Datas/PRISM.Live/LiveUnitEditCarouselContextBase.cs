using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 030 MusicData                                000186664B50 ModelClassType MusicData MusicData MusicData Pointer
    // 038 <SetCarouselDraggable>k__BackingField    Action`1<bool> IL2CPP_TYPE_GENERICINST
    // 040 CameraModeSetting                        000186543310 ModelEnumType LiveCameraModeSetting LiveCameraModeSetting LiveCameraModeSetting Int32
    public partial class LiveUnitEditCarouselContextBase
    {
        public MusicData?                               MusicData                               { get; set; }
        public LiveCameraModeSetting                    CameraModeSetting                       { get; set; }

        public static LiveUnitEditCarouselContextBase? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveUnitEditCarouselContextBase();

            value.MusicData                                 = GetObject<MusicData>(new IntPtr(p + 0x030), ReversePrism.DataModels.MusicData.FromPointer); // 0270D5113538 0x30 MusicData                   ( 000186664B50 ModelClassType MusicData MusicData MusicData Pointer )
            value.CameraModeSetting                         = (LiveCameraModeSetting)GetInt32(new IntPtr(p + 0x040)); // 0270D5113578 0x40 CameraModeSetting           ( 000186543310 ModelEnumType LiveCameraModeSetting LiveCameraModeSetting LiveCameraModeSetting Int32 )

            return value;
        }
    }
}
