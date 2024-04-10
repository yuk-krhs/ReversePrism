using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Button                                   000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 028 Labels                                   000185B81520 ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer
    // 030 LiveCameraModeSettingPopupCaller         000186543E50 ModelClassType LiveCameraModeSettingPopupCaller LiveCameraModeSettingPopupCaller LiveCameraModeSettingPopupCaller Pointer
    public partial class CameraSettingButton : DataModel
    {
        public ButtonBase?                              Button                                  { get; set; }
        public List<GameObject>?                        Labels                                  { get; set; }
        public LiveCameraModeSettingPopupCaller?        LiveCameraModeSettingPopupCaller        { get; set; }

        public static CameraSettingButton? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CameraSettingButton() { Pointer= p0 };

            value.Button                                    = GetObject<ButtonBase>(new IntPtr(p + 0x020), ReversePrism.DataModels.ButtonBase.FromPointer); // 02466517E8D0 0x20 Button                      ( 000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.Labels                                    = GetObjectList<GameObject>(new IntPtr(p + 0x028), ReversePrism.DataModels.GameObject.FromPointer); // 02466517E8F0 0x28 Labels                      ( 000185B81520 ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer )
            value.LiveCameraModeSettingPopupCaller          = GetObject<LiveCameraModeSettingPopupCaller>(new IntPtr(p + 0x030), ReversePrism.DataModels.LiveCameraModeSettingPopupCaller.FromPointer); // 02466517E910 0x30 LiveCameraModeSettingPopupCaller ( 000186543E50 ModelClassType LiveCameraModeSettingPopupCaller LiveCameraModeSettingPopupCaller LiveCameraModeSettingPopupCaller Pointer )

            return value;
        }
    }
}
