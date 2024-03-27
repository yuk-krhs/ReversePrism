using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<LivePotentialLiveSkillStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 MstPotentialLiveSkillIdFieldNumber       int IL2CPP_TYPE_I4
    // 018 MstPotentialLiveSkillId                  0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 MstPotentialLiveSkillLevelIdFieldNumber  int IL2CPP_TYPE_I4
    // 01C MstPotentialLiveSkillLevelId             0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 LevelFieldNumber                         int IL2CPP_TYPE_I4
    // 020 Level                                    0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 SkillEffectListFieldNumber               int IL2CPP_TYPE_I4
    // 008 _repeated_skillEffectList_codec          FieldCodec`1<LiveSkillEffectStatus> IL2CPP_TYPE_GENERICINST
    // 028 SkillEffectList                          000185CE39A8 ModelClassListType RepeatedField`1<LiveSkillEffectStatus> RepeatedField`1<LiveSkillEffectStatus> List<LiveSkillEffectStatus> Pointer
    public partial class LivePotentialLiveSkillStatus
    {
        public int                                      MstPotentialLiveSkillId                 { get; set; }
        public int                                      MstPotentialLiveSkillLevelId            { get; set; }
        public int                                      Level                                   { get; set; }
        public List<LiveSkillEffectStatus>?             SkillEffectList                         { get; set; }

        public static LivePotentialLiveSkillStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LivePotentialLiveSkillStatus();

            value.MstPotentialLiveSkillId                   = GetInt32(new IntPtr(p + 0x018)); // 0270D1350910 0x18 MstPotentialLiveSkillId     ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.MstPotentialLiveSkillLevelId              = GetInt32(new IntPtr(p + 0x01C)); // 0270D1350950 0x1C MstPotentialLiveSkillLevelId ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Level                                     = GetInt32(new IntPtr(p + 0x020)); // 0270D1350990 0x20 Level                       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.SkillEffectList                           = GetObjectList<LiveSkillEffectStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.LiveSkillEffectStatus.FromPointer); // 0270D13509F0 0x28 SkillEffectList             ( 000185CE39A8 ModelClassListType RepeatedField`1<LiveSkillEffectStatus> RepeatedField`1<LiveSkillEffectStatus> List<LiveSkillEffectStatus> Pointer )

            return value;
        }
    }
}
