using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Id                                       0001865F4260 ModelPrimitiveType int int int Int32
    // 014 LiveSkillType                            0001865F4260 ModelPrimitiveType int int int Int32
    // 018 EffectValue                              0001865F4260 ModelPrimitiveType int int int Int32
    // 01C EffectValue2                             0001865F4260 ModelPrimitiveType int int int Int32
    // 020 EffectValue3                             0001865F4260 ModelPrimitiveType int int int Int32
    // 024 EffectValue4                             0001865F4260 ModelPrimitiveType int int int Int32
    // 028 EffectTime                               0001865F4260 ModelPrimitiveType int int int Int32
    public partial class MstLiveSkillEffect
    {
        public int                                      Id                                      { get; set; }
        public int                                      LiveSkillType                           { get; set; }
        public int                                      EffectValue                             { get; set; }
        public int                                      EffectValue2                            { get; set; }
        public int                                      EffectValue3                            { get; set; }
        public int                                      EffectValue4                            { get; set; }
        public int                                      EffectTime                              { get; set; }

        public static MstLiveSkillEffect? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MstLiveSkillEffect();

            value.Id                                        = GetInt32(new IntPtr(p + 0x010)); // 027004679B28 0x10 Id                          ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.LiveSkillType                             = GetInt32(new IntPtr(p + 0x014)); // 027004679B48 0x14 LiveSkillType               ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.EffectValue                               = GetInt32(new IntPtr(p + 0x018)); // 027004679B68 0x18 EffectValue                 ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.EffectValue2                              = GetInt32(new IntPtr(p + 0x01C)); // 027004679B88 0x1C EffectValue2                ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.EffectValue3                              = GetInt32(new IntPtr(p + 0x020)); // 027004679BA8 0x20 EffectValue3                ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.EffectValue4                              = GetInt32(new IntPtr(p + 0x024)); // 027004679BC8 0x24 EffectValue4                ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.EffectTime                                = GetInt32(new IntPtr(p + 0x028)); // 027004679BE8 0x28 EffectTime                  ( 0001865F4260 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
