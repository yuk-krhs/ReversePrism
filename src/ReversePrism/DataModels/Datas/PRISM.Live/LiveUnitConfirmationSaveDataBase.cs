using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 VocalSeparatedOnMusicIds                 000185B7D2C0 ModelPrimitiveListType int[] int[] List<int> Pointer
    // 028 CameraModeSettings                       000185B90580 ModelEnumListType LiveCameraModeSetting[] LiveCameraModeSetting[] List<LiveCameraModeSetting> Pointer
    // 030 SelectedUnitIndex                        0001865F2AF0 ModelPrimitiveType int int int Int32
    // 034 SpecialUnitCount                         0001865F2AF0 ModelPrimitiveType int int int Int32
    // 038 <VocalSeparatedOnMusicIds>k__BackingField HashSet`1<int> IL2CPP_TYPE_GENERICINST
    // 040 <CameraModeSettings>k__BackingField      Dictionary`2<int, LiveCameraModeSetting> IL2CPP_TYPE_GENERICINST
    public partial class LiveUnitConfirmationSaveDataBase
    {
        public List<int>?                               VocalSeparatedOnMusicIds                { get; set; }
        public List<LiveCameraModeSetting>?             CameraModeSettings                      { get; set; }
        public int                                      SelectedUnitIndex                       { get; set; }
        public int                                      SpecialUnitCount                        { get; set; }

        public static LiveUnitConfirmationSaveDataBase? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveUnitConfirmationSaveDataBase();

            value.VocalSeparatedOnMusicIds                  = GetInt32List(new IntPtr(p + 0x020)); // 027003A72160 0x20 VocalSeparatedOnMusicIds    ( 000185B7D2C0 ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.CameraModeSettings                        = GetEnumList<LiveCameraModeSetting>(new IntPtr(p + 0x028)); // 027003A72180 0x28 CameraModeSettings          ( 000185B90580 ModelEnumListType LiveCameraModeSetting[] LiveCameraModeSetting[] List<LiveCameraModeSetting> Pointer )
            value.SelectedUnitIndex                         = GetInt32(new IntPtr(p + 0x030)); // 027003A721A0 0x30 SelectedUnitIndex           ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.SpecialUnitCount                          = GetInt32(new IntPtr(p + 0x034)); // 027003A721C0 0x34 SpecialUnitCount            ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
