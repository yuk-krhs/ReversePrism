using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ModeSelector                             000186684350 ModelClassType ToggleButtonGroup ToggleButtonGroup ToggleButtonGroup Pointer
    // 028 CharacterIcons                           000185B90670 ModelClassListType LiveCameraModeSettingCharacterIcon[] LiveCameraModeSettingCharacterIcon[] List<LiveCameraModeSettingCharacterIcon> Pointer
    // 030 onSelect                                 Subject`1<ValueTuple`3<bool, LiveCameraMode, int>> IL2CPP_TYPE_GENERICINST
    // 038 SelectedFocusPositionIndex               0001865F2AF0 ModelPrimitiveType int int int Int32
    // 040 Parent                                   0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class LiveCameraModeSettingPopupView : DataModel
    {
        public ToggleButtonGroup?                       ModeSelector                            { get; set; }
        public List<LiveCameraModeSettingCharacterIcon>? CharacterIcons                          { get; set; }
        public int                                      SelectedFocusPositionIndex              { get; set; }
        public IPopupFrameView?                         Parent                                  { get; set; }

        public static LiveCameraModeSettingPopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveCameraModeSettingPopupView() { Pointer= p0 };

            value.ModeSelector                              = GetObject<ToggleButtonGroup>(new IntPtr(p + 0x020), ReversePrism.DataModels.ToggleButtonGroup.FromPointer); // 02466B4838E8 0x20 ModeSelector                ( 000186684350 ModelClassType ToggleButtonGroup ToggleButtonGroup ToggleButtonGroup Pointer )
            value.CharacterIcons                            = GetObjectList<LiveCameraModeSettingCharacterIcon>(new IntPtr(p + 0x028), ReversePrism.DataModels.LiveCameraModeSettingCharacterIcon.FromPointer); // 02466B483908 0x28 CharacterIcons              ( 000185B90670 ModelClassListType LiveCameraModeSettingCharacterIcon[] LiveCameraModeSettingCharacterIcon[] List<LiveCameraModeSettingCharacterIcon> Pointer )
            value.SelectedFocusPositionIndex                = GetInt32(new IntPtr(p + 0x038)); // 02466B483948 0x38 SelectedFocusPositionIndex  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x040), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 02466B483968 0x40 Parent                      ( 0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
