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
    // 018 SlotAmount                               ModelPrimitiveType int int int Int32
    // 000 PotentialSupportSkillListFieldNumber     int IL2CPP_TYPE_I4
    // 008 _repeated_potentialSupportSkillList_codec FieldCodec`1<InProducePotentialSupportSkillStatus> IL2CPP_TYPE_GENERICINST
    // 020 PotentialSupportSkillList                ModelClassListType RepeatedField`1<InProducePotentialSupportSkillStatus> RepeatedField`1<InProducePotentialSupportSkillStatus> List<InProducePotentialSupportSkillStatus> Pointer
    public partial class SupportSkillStatus : DataModel
    {
        public int                                      SlotAmount                              { get; set; }
        public List<InProducePotentialSupportSkillStatus>? PotentialSupportSkillList               { get; set; }

        public static SupportSkillStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SupportSkillStatus() { Pointer= p0 };

            value.SlotAmount                                = GetInt32(new IntPtr(p + 0x018)); // 0x18 SlotAmount                  ( ModelPrimitiveType int int int Int32 )
            value.PotentialSupportSkillList                 = GetObjectList<InProducePotentialSupportSkillStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.InProducePotentialSupportSkillStatus.FromPointer); // 0x20 PotentialSupportSkillList   ( ModelClassListType RepeatedField`1<InProducePotentialSupportSkillStatus> RepeatedField`1<InProducePotentialSupportSkillStatus> List<InProducePotentialSupportSkillStatus> Pointer )

            return value;
        }
    }
}
