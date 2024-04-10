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
    public partial class MstLiveSkillEffect : DataModel
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
            var value   = new MstLiveSkillEffect() { Pointer= p0 };

            value.Id                                        = GetInt32(new IntPtr(p + 0x010)); // 0245A4706628 0x10 Id                          ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.LiveSkillType                             = GetInt32(new IntPtr(p + 0x014)); // 0245A4706648 0x14 LiveSkillType               ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.EffectValue                               = GetInt32(new IntPtr(p + 0x018)); // 0245A4706668 0x18 EffectValue                 ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.EffectValue2                              = GetInt32(new IntPtr(p + 0x01C)); // 0245A4706688 0x1C EffectValue2                ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.EffectValue3                              = GetInt32(new IntPtr(p + 0x020)); // 0245A47066A8 0x20 EffectValue3                ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.EffectValue4                              = GetInt32(new IntPtr(p + 0x024)); // 0245A47066C8 0x24 EffectValue4                ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.EffectTime                                = GetInt32(new IntPtr(p + 0x028)); // 0245A47066E8 0x28 EffectTime                  ( 0001865F4260 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
