using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 MstCharacterInfoId                       ModelPrimitiveType int int int Int32
    // 014 MstProduceIdolId                         ModelPrimitiveType int int int Int32
    // 018 UnitIdol                                 ModelClassType UnitIdol UnitIdol UnitIdol Pointer
    // 020 Color                                    ModelPrimitiveType string string string String
    // 028 BeforeLv                                 ModelPrimitiveType int int int Int32
    // 02C AfterLv                                  ModelPrimitiveType int int int Int32
    // 030 IsMaxLv                                  ModelPrimitiveType bool bool bool Bool
    // 038 IdolBaseReward                           ModelClassType IIdolBaseRewardStatus IIdolBaseRewardStatus IIdolBaseRewardStatus Pointer
    public partial class AwakeningPerformanceViewModel : DataModel
    {
        public int                                      MstCharacterInfoId                      { get; set; }
        public int                                      MstProduceIdolId                        { get; set; }
        public UnitIdol?                                UnitIdol                                { get; set; }
        public string                                   Color                                   { get; set; }
        public int                                      BeforeLv                                { get; set; }
        public int                                      AfterLv                                 { get; set; }
        public bool                                     IsMaxLv                                 { get; set; }
        public IIdolBaseRewardStatus?                   IdolBaseReward                          { get; set; }

        public static AwakeningPerformanceViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AwakeningPerformanceViewModel() { Pointer= p0 };

            value.MstCharacterInfoId                        = GetInt32(new IntPtr(p + 0x010)); // 0x10 MstCharacterInfoId          ( ModelPrimitiveType int int int Int32 )
            value.MstProduceIdolId                          = GetInt32(new IntPtr(p + 0x014)); // 0x14 MstProduceIdolId            ( ModelPrimitiveType int int int Int32 )
            value.UnitIdol                                  = GetObject<UnitIdol>(new IntPtr(p + 0x018), ReversePrism.DataModels.UnitIdol.FromPointer); // 0x18 UnitIdol                    ( ModelClassType UnitIdol UnitIdol UnitIdol Pointer )
            value.Color                                     = GetString(new IntPtr(p + 0x020)); // 0x20 Color                       ( ModelPrimitiveType string string string String )
            value.BeforeLv                                  = GetInt32(new IntPtr(p + 0x028)); // 0x28 BeforeLv                    ( ModelPrimitiveType int int int Int32 )
            value.AfterLv                                   = GetInt32(new IntPtr(p + 0x02C)); // 0x2C AfterLv                     ( ModelPrimitiveType int int int Int32 )
            value.IsMaxLv                                   = GetBool(new IntPtr(p + 0x030)); // 0x30 IsMaxLv                     ( ModelPrimitiveType bool bool bool Bool )
            value.IdolBaseReward                            = GetObject<IIdolBaseRewardStatus>(new IntPtr(p + 0x038), ReversePrism.DataModels.IIdolBaseRewardStatus.FromPointer); // 0x38 IdolBaseReward              ( ModelClassType IIdolBaseRewardStatus IIdolBaseRewardStatus IIdolBaseRewardStatus Pointer )

            return value;
        }
    }
}
