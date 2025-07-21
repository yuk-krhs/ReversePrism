using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Button                                   ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 028 Labels                                   ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer
    // 030 LiveCameraModeSettingPopupCaller         ModelClassType LiveCameraModeSettingPopupCaller LiveCameraModeSettingPopupCaller LiveCameraModeSettingPopupCaller Pointer
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

            value.Button                                    = GetObject<ButtonBase>(new IntPtr(p + 0x020), ReversePrism.DataModels.ButtonBase.FromPointer); // 0x20 Button                      ( ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.Labels                                    = GetObjectList<GameObject>(new IntPtr(p + 0x028), ReversePrism.DataModels.GameObject.FromPointer); // 0x28 Labels                      ( ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer )
            value.LiveCameraModeSettingPopupCaller          = GetObject<LiveCameraModeSettingPopupCaller>(new IntPtr(p + 0x030), ReversePrism.DataModels.LiveCameraModeSettingPopupCaller.FromPointer); // 0x30 LiveCameraModeSettingPopupCaller ( ModelClassType LiveCameraModeSettingPopupCaller LiveCameraModeSettingPopupCaller LiveCameraModeSettingPopupCaller Pointer )

            return value;
        }
    }
}
