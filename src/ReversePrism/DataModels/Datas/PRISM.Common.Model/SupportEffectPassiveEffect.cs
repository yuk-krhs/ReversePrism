using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 AcquiredSkill                            0001865965D0 ModelPrimitiveType bool bool bool Bool
    // 014 MstProducePassiveEffectTypeId            0001865F4260 ModelPrimitiveType int int int Int32
    // 018 ScheduleType                             0001865F4260 ModelPrimitiveType int int int Int32
    // 01C ScheduleDetailType                       0001865F4260 ModelPrimitiveType int int int Int32
    public partial class SupportEffectPassiveEffect
    {
        public bool                                     AcquiredSkill                           { get; set; }
        public int                                      MstProducePassiveEffectTypeId           { get; set; }
        public int                                      ScheduleType                            { get; set; }
        public int                                      ScheduleDetailType                      { get; set; }

        public static SupportEffectPassiveEffect? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SupportEffectPassiveEffect();

            value.AcquiredSkill                             = GetBool(new IntPtr(p + 0x010)); // 0270D59A5CA0 0x10 AcquiredSkill               ( 0001865965D0 ModelPrimitiveType bool bool bool Bool )
            value.MstProducePassiveEffectTypeId             = GetInt32(new IntPtr(p + 0x014)); // 0270D59A5CC0 0x14 MstProducePassiveEffectTypeId ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.ScheduleType                              = GetInt32(new IntPtr(p + 0x018)); // 0270D59A5CE0 0x18 ScheduleType                ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.ScheduleDetailType                        = GetInt32(new IntPtr(p + 0x01C)); // 0270D59A5D00 0x1C ScheduleDetailType          ( 0001865F4260 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
