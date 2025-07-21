using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 VocalSeparatedOnMusicIds                 ModelPrimitiveListType int[] int[] List<int> Pointer
    // 028 CameraModeSettings                       ModelEnumListType LiveCameraModeSetting[] LiveCameraModeSetting[] List<LiveCameraModeSetting> Pointer
    // 030 SelectedUnitIndex                        ModelPrimitiveType int int int Int32
    // 034 SpecialUnitCount                         ModelPrimitiveType int int int Int32
    // 038 SelectedSummerUnitIndex                  ModelPrimitiveType int int int Int32
    // 03C SpecialSummerUnitCount                   ModelPrimitiveType int int int Int32
    // 040 <VocalSeparatedOnMusicIds>k__BackingField HashSet`1<int> IL2CPP_TYPE_GENERICINST
    // 048 <CameraModeSettings>k__BackingField      Dictionary`2<int, LiveCameraModeSetting> IL2CPP_TYPE_GENERICINST
    public partial class LiveUnitConfirmationSaveDataBase : DataModel
    {
        public List<int>?                               VocalSeparatedOnMusicIds                { get; set; }
        public List<LiveCameraModeSetting>?             CameraModeSettings                      { get; set; }
        public int                                      SelectedUnitIndex                       { get; set; }
        public int                                      SpecialUnitCount                        { get; set; }
        public int                                      SelectedSummerUnitIndex                 { get; set; }
        public int                                      SpecialSummerUnitCount                  { get; set; }

        public static LiveUnitConfirmationSaveDataBase? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveUnitConfirmationSaveDataBase() { Pointer= p0 };

            value.VocalSeparatedOnMusicIds                  = GetInt32List(new IntPtr(p + 0x020)); // 0x20 VocalSeparatedOnMusicIds    ( ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.CameraModeSettings                        = GetEnumList<LiveCameraModeSetting>(new IntPtr(p + 0x028)); // 0x28 CameraModeSettings          ( ModelEnumListType LiveCameraModeSetting[] LiveCameraModeSetting[] List<LiveCameraModeSetting> Pointer )
            value.SelectedUnitIndex                         = GetInt32(new IntPtr(p + 0x030)); // 0x30 SelectedUnitIndex           ( ModelPrimitiveType int int int Int32 )
            value.SpecialUnitCount                          = GetInt32(new IntPtr(p + 0x034)); // 0x34 SpecialUnitCount            ( ModelPrimitiveType int int int Int32 )
            value.SelectedSummerUnitIndex                   = GetInt32(new IntPtr(p + 0x038)); // 0x38 SelectedSummerUnitIndex     ( ModelPrimitiveType int int int Int32 )
            value.SpecialSummerUnitCount                    = GetInt32(new IntPtr(p + 0x03C)); // 0x3C SpecialSummerUnitCount      ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
