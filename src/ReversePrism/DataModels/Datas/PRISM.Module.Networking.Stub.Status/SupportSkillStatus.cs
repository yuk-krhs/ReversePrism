using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<SupportSkillStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 SlotAmountFieldNumber                    int IL2CPP_TYPE_I4
    // 018 SlotAmount                               0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 PotentialSupportSkillListFieldNumber     int IL2CPP_TYPE_I4
    // 008 _repeated_potentialSupportSkillList_codec FieldCodec`1<InProducePotentialSupportSkillStatus> IL2CPP_TYPE_GENERICINST
    // 020 PotentialSupportSkillList                000185CE0D58 ModelClassListType RepeatedField`1<InProducePotentialSupportSkillStatus> RepeatedField`1<InProducePotentialSupportSkillStatus> List<InProducePotentialSupportSkillStatus> Pointer
    public partial class SupportSkillStatus
    {
        public int                                      SlotAmount                              { get; set; }
        public List<InProducePotentialSupportSkillStatus>? PotentialSupportSkillList               { get; set; }

        public static SupportSkillStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SupportSkillStatus();

            value.SlotAmount                                = GetInt32(new IntPtr(p + 0x018)); // 0270D115F1B8 0x18 SlotAmount                  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.PotentialSupportSkillList                 = GetObjectList<InProducePotentialSupportSkillStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.InProducePotentialSupportSkillStatus.FromPointer); // 0270D115F218 0x20 PotentialSupportSkillList   ( 000185CE0D58 ModelClassListType RepeatedField`1<InProducePotentialSupportSkillStatus> RepeatedField`1<InProducePotentialSupportSkillStatus> List<InProducePotentialSupportSkillStatus> Pointer )

            return value;
        }
    }
}
