using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 MstCharacterInfoId                       0001865F4260 ModelPrimitiveType int int int Int32
    // 014 MstProduceIdolId                         0001865F4260 ModelPrimitiveType int int int Int32
    // 018 UnitIdol                                 00018670CE40 ModelClassType UnitIdol UnitIdol UnitIdol Pointer
    // 020 Color                                    000186672F10 ModelPrimitiveType string string string String
    // 028 BeforeLv                                 0001865F4260 ModelPrimitiveType int int int Int32
    // 02C AfterLv                                  0001865F4260 ModelPrimitiveType int int int Int32
    // 030 IsMaxLv                                  0001865965D0 ModelPrimitiveType bool bool bool Bool
    // 038 IdolBaseReward                           000186571DC0 ModelClassType IIdolBaseRewardStatus IIdolBaseRewardStatus IIdolBaseRewardStatus Pointer
    // 040 OtherSceneLoaderAddressables             000185D05E08 ModelClassListType List`1<SceneLoaderAddressable> List`1<SceneLoaderAddressable> List<SceneLoaderAddressable> Pointer
    public partial class AwakeningPerformanceViewModel
    {
        public int                                      MstCharacterInfoId                      { get; set; }
        public int                                      MstProduceIdolId                        { get; set; }
        public UnitIdol?                                UnitIdol                                { get; set; }
        public string                                   Color                                   { get; set; }
        public int                                      BeforeLv                                { get; set; }
        public int                                      AfterLv                                 { get; set; }
        public bool                                     IsMaxLv                                 { get; set; }
        public IIdolBaseRewardStatus?                   IdolBaseReward                          { get; set; }
        public List<SceneLoaderAddressable>?            OtherSceneLoaderAddressables            { get; set; }

        public static AwakeningPerformanceViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AwakeningPerformanceViewModel();

            value.MstCharacterInfoId                        = GetInt32(new IntPtr(p + 0x010)); // 0270D5FB3E70 0x10 MstCharacterInfoId          ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.MstProduceIdolId                          = GetInt32(new IntPtr(p + 0x014)); // 0270D5FB3E90 0x14 MstProduceIdolId            ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.UnitIdol                                  = GetObject<UnitIdol>(new IntPtr(p + 0x018), ReversePrism.DataModels.UnitIdol.FromPointer); // 0270D5FB3EB0 0x18 UnitIdol                    ( 00018670CE40 ModelClassType UnitIdol UnitIdol UnitIdol Pointer )
            value.Color                                     = GetString(new IntPtr(p + 0x020)); // 0270D5FB3ED0 0x20 Color                       ( 000186672F10 ModelPrimitiveType string string string String )
            value.BeforeLv                                  = GetInt32(new IntPtr(p + 0x028)); // 0270D5FB3EF0 0x28 BeforeLv                    ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.AfterLv                                   = GetInt32(new IntPtr(p + 0x02C)); // 0270D5FB3F10 0x2C AfterLv                     ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.IsMaxLv                                   = GetBool(new IntPtr(p + 0x030)); // 0270D5FB3F30 0x30 IsMaxLv                     ( 0001865965D0 ModelPrimitiveType bool bool bool Bool )
            value.IdolBaseReward                            = GetObject<IIdolBaseRewardStatus>(new IntPtr(p + 0x038), ReversePrism.DataModels.IIdolBaseRewardStatus.FromPointer); // 0270D5FB3F50 0x38 IdolBaseReward              ( 000186571DC0 ModelClassType IIdolBaseRewardStatus IIdolBaseRewardStatus IIdolBaseRewardStatus Pointer )
            value.OtherSceneLoaderAddressables              = GetObjectList<SceneLoaderAddressable>(new IntPtr(p + 0x040), ReversePrism.DataModels.SceneLoaderAddressable.FromPointer); // 0270D5FB3F70 0x40 OtherSceneLoaderAddressables ( 000185D05E08 ModelClassListType List`1<SceneLoaderAddressable> List`1<SceneLoaderAddressable> List<SceneLoaderAddressable> Pointer )

            return value;
        }
    }
}
