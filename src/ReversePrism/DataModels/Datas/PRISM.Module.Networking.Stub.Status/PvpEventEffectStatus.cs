using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<PvpEventEffectStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 MstPvpEventEffectIdFieldNumber           int IL2CPP_TYPE_I4
    // 018 MstPvpEventEffectId                      0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 ValueListFieldNumber                     int IL2CPP_TYPE_I4
    // 008 _repeated_valueList_codec                FieldCodec`1<int> IL2CPP_TYPE_GENERICINST
    // 020 ValueList                                000185CE1CE8 ModelPrimitiveListType RepeatedField`1<int> RepeatedField`1<int> List<int> Pointer
    // 000 SkillBufferDisplayFieldNumber            int IL2CPP_TYPE_I4
    // 028 SkillBufferDisplay                       0001865119F0 ModelClassType SkillBufferDisplayStatus SkillBufferDisplayStatus SkillBufferDisplayStatus Pointer
    // 000 GrantSkillBufferDisplayFieldNumber       int IL2CPP_TYPE_I4
    // 030 GrantSkillBufferDisplay                  0001865119F0 ModelClassType SkillBufferDisplayStatus SkillBufferDisplayStatus SkillBufferDisplayStatus Pointer
    public partial class PvpEventEffectStatus
    {
        public int                                      MstPvpEventEffectId                     { get; set; }
        public List<int>?                               ValueList                               { get; set; }
        public SkillBufferDisplayStatus?                SkillBufferDisplay                      { get; set; }
        public SkillBufferDisplayStatus?                GrantSkillBufferDisplay                 { get; set; }

        public static PvpEventEffectStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PvpEventEffectStatus();

            value.MstPvpEventEffectId                       = GetInt32(new IntPtr(p + 0x018)); // 0270D141EAF8 0x18 MstPvpEventEffectId         ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.ValueList                                 = GetInt32List(new IntPtr(p + 0x020)); // 0270D141EB58 0x20 ValueList                   ( 000185CE1CE8 ModelPrimitiveListType RepeatedField`1<int> RepeatedField`1<int> List<int> Pointer )
            value.SkillBufferDisplay                        = GetObject<SkillBufferDisplayStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.SkillBufferDisplayStatus.FromPointer); // 0270D141EB98 0x28 SkillBufferDisplay          ( 0001865119F0 ModelClassType SkillBufferDisplayStatus SkillBufferDisplayStatus SkillBufferDisplayStatus Pointer )
            value.GrantSkillBufferDisplay                   = GetObject<SkillBufferDisplayStatus>(new IntPtr(p + 0x030), ReversePrism.DataModels.SkillBufferDisplayStatus.FromPointer); // 0270D141EBD8 0x30 GrantSkillBufferDisplay     ( 0001865119F0 ModelClassType SkillBufferDisplayStatus SkillBufferDisplayStatus SkillBufferDisplayStatus Pointer )

            return value;
        }
    }
}
