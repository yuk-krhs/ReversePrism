using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ModeSelector                             ModelClassType ToggleButtonGroup ToggleButtonGroup ToggleButtonGroup Pointer
    // 028 CharacterIcons                           ModelClassListType LiveCameraModeSettingCharacterIcon[] LiveCameraModeSettingCharacterIcon[] List<LiveCameraModeSettingCharacterIcon> Pointer
    // 030 SummerIconGameObject                     ModelClassType GameObject GameObject GameObject Pointer
    // 038 onSelect                                 Subject`1<ValueTuple`3<bool, LiveCameraMode, int>> IL2CPP_TYPE_GENERICINST
    // 040 SelectedFocusPositionIndex               ModelPrimitiveType int int int Int32
    // 048 Parent                                   ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class LiveCameraModeSettingPopupView : DataModel
    {
        public ToggleButtonGroup?                       ModeSelector                            { get; set; }
        public List<LiveCameraModeSettingCharacterIcon>? CharacterIcons                          { get; set; }
        public GameObject?                              SummerIconGameObject                    { get; set; }
        public int                                      SelectedFocusPositionIndex              { get; set; }
        public IPopupFrameView?                         Parent                                  { get; set; }

        public static LiveCameraModeSettingPopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveCameraModeSettingPopupView() { Pointer= p0 };

            value.ModeSelector                              = GetObject<ToggleButtonGroup>(new IntPtr(p + 0x020), ReversePrism.DataModels.ToggleButtonGroup.FromPointer); // 0x20 ModeSelector                ( ModelClassType ToggleButtonGroup ToggleButtonGroup ToggleButtonGroup Pointer )
            value.CharacterIcons                            = GetObjectList<LiveCameraModeSettingCharacterIcon>(new IntPtr(p + 0x028), ReversePrism.DataModels.LiveCameraModeSettingCharacterIcon.FromPointer); // 0x28 CharacterIcons              ( ModelClassListType LiveCameraModeSettingCharacterIcon[] LiveCameraModeSettingCharacterIcon[] List<LiveCameraModeSettingCharacterIcon> Pointer )
            value.SummerIconGameObject                      = GetObject<GameObject>(new IntPtr(p + 0x030), ReversePrism.DataModels.GameObject.FromPointer); // 0x30 SummerIconGameObject        ( ModelClassType GameObject GameObject GameObject Pointer )
            value.SelectedFocusPositionIndex                = GetInt32(new IntPtr(p + 0x040)); // 0x40 SelectedFocusPositionIndex  ( ModelPrimitiveType int int int Int32 )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x048), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 0x48 Parent                      ( ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
