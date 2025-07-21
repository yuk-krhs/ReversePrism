using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<LiveSkillEffectStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 MstLiveSkillEffectIdFieldNumber          int IL2CPP_TYPE_I4
    // 018 MstLiveSkillEffectId                     ModelPrimitiveType int int int Int32
    // 000 SkillTypeFieldNumber                     int IL2CPP_TYPE_I4
    // 01C SkillType                                ModelEnumType LiveSkillEffectType LiveSkillEffectType LiveSkillEffectType Int32
    // 000 EffectValueFieldNumber                   int IL2CPP_TYPE_I4
    // 020 EffectValue                              ModelPrimitiveType int int int Int32
    // 000 EffectTimeFieldNumber                    int IL2CPP_TYPE_I4
    // 024 EffectTime                               ModelPrimitiveType int int int Int32
    // 000 EffectValue2FieldNumber                  int IL2CPP_TYPE_I4
    // 028 EffectValue2                             ModelPrimitiveType int int int Int32
    // 000 EffectValue3FieldNumber                  int IL2CPP_TYPE_I4
    // 02C EffectValue3                             ModelPrimitiveType int int int Int32
    // 000 EffectValue4FieldNumber                  int IL2CPP_TYPE_I4
    // 030 EffectValue4                             ModelPrimitiveType int int int Int32
    public partial class LiveSkillEffectStatus : DataModel
    {
        public int                                      MstLiveSkillEffectId                    { get; set; }
        public LiveSkillEffectType                      SkillType                               { get; set; }
        public int                                      EffectValue                             { get; set; }
        public int                                      EffectTime                              { get; set; }
        public int                                      EffectValue2                            { get; set; }
        public int                                      EffectValue3                            { get; set; }
        public int                                      EffectValue4                            { get; set; }

        public static LiveSkillEffectStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveSkillEffectStatus() { Pointer= p0 };

            value.MstLiveSkillEffectId                      = GetInt32(new IntPtr(p + 0x018)); // 0x18 MstLiveSkillEffectId        ( ModelPrimitiveType int int int Int32 )
            value.SkillType                                 = (LiveSkillEffectType)GetInt32(new IntPtr(p + 0x01C)); // 0x1C SkillType                   ( ModelEnumType LiveSkillEffectType LiveSkillEffectType LiveSkillEffectType Int32 )
            value.EffectValue                               = GetInt32(new IntPtr(p + 0x020)); // 0x20 EffectValue                 ( ModelPrimitiveType int int int Int32 )
            value.EffectTime                                = GetInt32(new IntPtr(p + 0x024)); // 0x24 EffectTime                  ( ModelPrimitiveType int int int Int32 )
            value.EffectValue2                              = GetInt32(new IntPtr(p + 0x028)); // 0x28 EffectValue2                ( ModelPrimitiveType int int int Int32 )
            value.EffectValue3                              = GetInt32(new IntPtr(p + 0x02C)); // 0x2C EffectValue3                ( ModelPrimitiveType int int int Int32 )
            value.EffectValue4                              = GetInt32(new IntPtr(p + 0x030)); // 0x30 EffectValue4                ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
