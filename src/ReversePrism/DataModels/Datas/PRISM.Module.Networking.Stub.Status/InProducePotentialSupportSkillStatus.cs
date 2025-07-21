using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<InProducePotentialSupportSkillStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 MstPotentialSkillIdFieldNumber           int IL2CPP_TYPE_I4
    // 018 MstPotentialSkillId                      ModelPrimitiveType int int int Int32
    // 000 ValueListFieldNumber                     int IL2CPP_TYPE_I4
    // 008 _repeated_valueList_codec                FieldCodec`1<int> IL2CPP_TYPE_GENERICINST
    // 020 ValueList                                ModelPrimitiveListType RepeatedField`1<int> RepeatedField`1<int> List<int> Pointer
    // 000 MstSupportSkillTypeIdFieldNumber         int IL2CPP_TYPE_I4
    // 028 MstSupportSkillTypeId                    ModelPrimitiveType int int int Int32
    // 000 SkillBufferDisplayFieldNumber            int IL2CPP_TYPE_I4
    // 030 SkillBufferDisplay                       ModelClassType SkillBufferDisplayStatus SkillBufferDisplayStatus SkillBufferDisplayStatus Pointer
    // 000 IsInheritanceFieldNumber                 int IL2CPP_TYPE_I4
    // 038 IsInheritance                            ModelPrimitiveType bool bool bool Bool
    // 000 AutoSelectionScoreFieldNumber            int IL2CPP_TYPE_I4
    // 03C AutoSelectionScore                       ModelPrimitiveType int int int Int32
    // 000 GrantSkillBufferDisplayFieldNumber       int IL2CPP_TYPE_I4
    // 040 GrantSkillBufferDisplay                  ModelClassType SkillBufferDisplayStatus SkillBufferDisplayStatus SkillBufferDisplayStatus Pointer
    public partial class InProducePotentialSupportSkillStatus : DataModel
    {
        public int                                      MstPotentialSkillId                     { get; set; }
        public List<int>?                               ValueList                               { get; set; }
        public int                                      MstSupportSkillTypeId                   { get; set; }
        public SkillBufferDisplayStatus?                SkillBufferDisplay                      { get; set; }
        public bool                                     IsInheritance                           { get; set; }
        public int                                      AutoSelectionScore                      { get; set; }
        public SkillBufferDisplayStatus?                GrantSkillBufferDisplay                 { get; set; }

        public static InProducePotentialSupportSkillStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new InProducePotentialSupportSkillStatus() { Pointer= p0 };

            value.MstPotentialSkillId                       = GetInt32(new IntPtr(p + 0x018)); // 0x18 MstPotentialSkillId         ( ModelPrimitiveType int int int Int32 )
            value.ValueList                                 = GetInt32List(new IntPtr(p + 0x020)); // 0x20 ValueList                   ( ModelPrimitiveListType RepeatedField`1<int> RepeatedField`1<int> List<int> Pointer )
            value.MstSupportSkillTypeId                     = GetInt32(new IntPtr(p + 0x028)); // 0x28 MstSupportSkillTypeId       ( ModelPrimitiveType int int int Int32 )
            value.SkillBufferDisplay                        = GetObject<SkillBufferDisplayStatus>(new IntPtr(p + 0x030), ReversePrism.DataModels.SkillBufferDisplayStatus.FromPointer); // 0x30 SkillBufferDisplay          ( ModelClassType SkillBufferDisplayStatus SkillBufferDisplayStatus SkillBufferDisplayStatus Pointer )
            value.IsInheritance                             = GetBool(new IntPtr(p + 0x038)); // 0x38 IsInheritance               ( ModelPrimitiveType bool bool bool Bool )
            value.AutoSelectionScore                        = GetInt32(new IntPtr(p + 0x03C)); // 0x3C AutoSelectionScore          ( ModelPrimitiveType int int int Int32 )
            value.GrantSkillBufferDisplay                   = GetObject<SkillBufferDisplayStatus>(new IntPtr(p + 0x040), ReversePrism.DataModels.SkillBufferDisplayStatus.FromPointer); // 0x40 GrantSkillBufferDisplay     ( ModelClassType SkillBufferDisplayStatus SkillBufferDisplayStatus SkillBufferDisplayStatus Pointer )

            return value;
        }
    }
}
