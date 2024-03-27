using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<InheritanceSkillListReply> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 ProduceBaseInfoFieldNumber               int IL2CPP_TYPE_I4
    // 018 ProduceBaseInfo                          0001865332D0 ModelClassType ProduceBaseInfoStatus ProduceBaseInfoStatus ProduceBaseInfoStatus Pointer
    // 000 InheritanceSkillListFieldNumber          int IL2CPP_TYPE_I4
    // 008 _repeated_inheritanceSkillList_codec     FieldCodec`1<GettablePotentialSupportSkillStatus> IL2CPP_TYPE_GENERICINST
    // 020 InheritanceSkillList                     000185CDDA88 ModelClassListType RepeatedField`1<GettablePotentialSupportSkillStatus> RepeatedField`1<GettablePotentialSupportSkillStatus> List<GettablePotentialSupportSkillStatus> Pointer
    public partial class InheritanceSkillListReply
    {
        public ProduceBaseInfoStatus?                   ProduceBaseInfo                         { get; set; }
        public List<GettablePotentialSupportSkillStatus>? InheritanceSkillList                    { get; set; }

        public static InheritanceSkillListReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new InheritanceSkillListReply();

            value.ProduceBaseInfo                           = GetObject<ProduceBaseInfoStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.ProduceBaseInfoStatus.FromPointer); // 0270D258BFA0 0x18 ProduceBaseInfo             ( 0001865332D0 ModelClassType ProduceBaseInfoStatus ProduceBaseInfoStatus ProduceBaseInfoStatus Pointer )
            value.InheritanceSkillList                      = GetObjectList<GettablePotentialSupportSkillStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.GettablePotentialSupportSkillStatus.FromPointer); // 0270D258C000 0x20 InheritanceSkillList        ( 000185CDDA88 ModelClassListType RepeatedField`1<GettablePotentialSupportSkillStatus> RepeatedField`1<GettablePotentialSupportSkillStatus> List<GettablePotentialSupportSkillStatus> Pointer )

            return value;
        }
    }
}
