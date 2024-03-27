using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<ProduceActionEffectStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 MstProduceActionEffectIdFieldNumber      int IL2CPP_TYPE_I4
    // 018 MstProduceActionEffectId                 0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 MstProduceActionEffectTypeIdFieldNumber  int IL2CPP_TYPE_I4
    // 01C MstProduceActionEffectTypeId             0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 ValueListFieldNumber                     int IL2CPP_TYPE_I4
    // 008 _repeated_valueList_codec                FieldCodec`1<int> IL2CPP_TYPE_GENERICINST
    // 020 ValueList                                000185CE1CE8 ModelPrimitiveListType RepeatedField`1<int> RepeatedField`1<int> List<int> Pointer
    // 000 MstProduceActionEffectConditionTypeIdFieldNumber int IL2CPP_TYPE_I4
    // 028 MstProduceActionEffectConditionTypeId    0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 ConditionValueFieldNumber                int IL2CPP_TYPE_I4
    // 02C ConditionValue                           0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 MstProduceActionEffectActivationTimingTypeIdFieldNumber int IL2CPP_TYPE_I4
    // 030 MstProduceActionEffectActivationTimingTypeId 0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 MstProduceActionEffectDisplayIdListFieldNumber int IL2CPP_TYPE_I4
    // 010 _repeated_mstProduceActionEffectDisplayIdList_codec FieldCodec`1<int> IL2CPP_TYPE_GENERICINST
    // 038 MstProduceActionEffectDisplayIdList      000185CE1CE8 ModelPrimitiveListType RepeatedField`1<int> RepeatedField`1<int> List<int> Pointer
    // 000 IconIdFieldNumber                        int IL2CPP_TYPE_I4
    // 040 IconId                                   0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 SkillBufferDisplayFieldNumber            int IL2CPP_TYPE_I4
    // 048 SkillBufferDisplay                       0001865119F0 ModelClassType SkillBufferDisplayStatus SkillBufferDisplayStatus SkillBufferDisplayStatus Pointer
    // 000 GrantSkillBufferDisplayFieldNumber       int IL2CPP_TYPE_I4
    // 050 GrantSkillBufferDisplay                  0001865119F0 ModelClassType SkillBufferDisplayStatus SkillBufferDisplayStatus SkillBufferDisplayStatus Pointer
    // 000 IsHideConditionEffectFieldNumber         int IL2CPP_TYPE_I4
    // 058 IsHideConditionEffect                    000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class ProduceActionEffectStatus
    {
        public int                                      MstProduceActionEffectId                { get; set; }
        public int                                      MstProduceActionEffectTypeId            { get; set; }
        public List<int>?                               ValueList                               { get; set; }
        public int                                      MstProduceActionEffectConditionTypeId   { get; set; }
        public int                                      ConditionValue                          { get; set; }
        public int                                      MstProduceActionEffectActivationTimingTypeId { get; set; }
        public List<int>?                               MstProduceActionEffectDisplayIdList     { get; set; }
        public int                                      IconId                                  { get; set; }
        public SkillBufferDisplayStatus?                SkillBufferDisplay                      { get; set; }
        public SkillBufferDisplayStatus?                GrantSkillBufferDisplay                 { get; set; }
        public bool                                     IsHideConditionEffect                   { get; set; }

        public static ProduceActionEffectStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceActionEffectStatus();

            value.MstProduceActionEffectId                  = GetInt32(new IntPtr(p + 0x018)); // 0270D10FD0E8 0x18 MstProduceActionEffectId    ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.MstProduceActionEffectTypeId              = GetInt32(new IntPtr(p + 0x01C)); // 0270D10FD128 0x1C MstProduceActionEffectTypeId ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.ValueList                                 = GetInt32List(new IntPtr(p + 0x020)); // 0270D10FD188 0x20 ValueList                   ( 000185CE1CE8 ModelPrimitiveListType RepeatedField`1<int> RepeatedField`1<int> List<int> Pointer )
            value.MstProduceActionEffectConditionTypeId     = GetInt32(new IntPtr(p + 0x028)); // 0270D10FD1C8 0x28 MstProduceActionEffectConditionTypeId ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.ConditionValue                            = GetInt32(new IntPtr(p + 0x02C)); // 0270D10FD208 0x2C ConditionValue              ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.MstProduceActionEffectActivationTimingTypeId = GetInt32(new IntPtr(p + 0x030)); // 0270D10FD248 0x30 MstProduceActionEffectActivationTimingTypeId ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.MstProduceActionEffectDisplayIdList       = GetInt32List(new IntPtr(p + 0x038)); // 0270D10FD2A8 0x38 MstProduceActionEffectDisplayIdList ( 000185CE1CE8 ModelPrimitiveListType RepeatedField`1<int> RepeatedField`1<int> List<int> Pointer )
            value.IconId                                    = GetInt32(new IntPtr(p + 0x040)); // 0270D10FD2E8 0x40 IconId                      ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.SkillBufferDisplay                        = GetObject<SkillBufferDisplayStatus>(new IntPtr(p + 0x048), ReversePrism.DataModels.SkillBufferDisplayStatus.FromPointer); // 0270D10FD328 0x48 SkillBufferDisplay          ( 0001865119F0 ModelClassType SkillBufferDisplayStatus SkillBufferDisplayStatus SkillBufferDisplayStatus Pointer )
            value.GrantSkillBufferDisplay                   = GetObject<SkillBufferDisplayStatus>(new IntPtr(p + 0x050), ReversePrism.DataModels.SkillBufferDisplayStatus.FromPointer); // 0270D10FD368 0x50 GrantSkillBufferDisplay     ( 0001865119F0 ModelClassType SkillBufferDisplayStatus SkillBufferDisplayStatus SkillBufferDisplayStatus Pointer )
            value.IsHideConditionEffect                     = GetBool(new IntPtr(p + 0x058)); // 0270D10FD3A8 0x58 IsHideConditionEffect       ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
