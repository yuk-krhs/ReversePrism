using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<PotentialLiveSkillParameterStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 LiveSkillTypeFieldNumber                 int IL2CPP_TYPE_I4
    // 018 LiveSkillType                            00018657D180 ModelEnumType LiveSkillEffectType LiveSkillEffectType LiveSkillEffectType Int32
    // 000 ValueFieldNumber                         int IL2CPP_TYPE_I4
    // 01C Value                                    0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 MillisecondFieldNumber                   int IL2CPP_TYPE_I4
    // 020 Millisecond                              0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class PotentialLiveSkillParameterStatus
    {
        public LiveSkillEffectType                      LiveSkillType                           { get; set; }
        public int                                      Value                                   { get; set; }
        public int                                      Millisecond                             { get; set; }

        public static PotentialLiveSkillParameterStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PotentialLiveSkillParameterStatus();

            value.LiveSkillType                             = (LiveSkillEffectType)GetInt32(new IntPtr(p + 0x018)); // 0270D103F898 0x18 LiveSkillType               ( 00018657D180 ModelEnumType LiveSkillEffectType LiveSkillEffectType LiveSkillEffectType Int32 )
            value.Value                                     = GetInt32(new IntPtr(p + 0x01C)); // 0270D103F8D8 0x1C Value                       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Millisecond                               = GetInt32(new IntPtr(p + 0x020)); // 0270D103F918 0x20 Millisecond                 ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
