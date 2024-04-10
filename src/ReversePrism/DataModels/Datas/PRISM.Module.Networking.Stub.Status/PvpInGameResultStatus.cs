using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<PvpInGameResultStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 IsWinFieldNumber                         int IL2CPP_TYPE_I4
    // 018 IsWin                                    000186594D10 ModelPrimitiveType bool bool bool Bool
    // 000 AppealPointFieldNumber                   int IL2CPP_TYPE_I4
    // 020 AppealPoint                              0001866D3050 ModelClassType InGameAppealPointStatus InGameAppealPointStatus InGameAppealPointStatus Pointer
    // 000 SecondFieldNumber                        int IL2CPP_TYPE_I4
    // 028 Second                                   0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 IdolSkillListFieldNumber                 int IL2CPP_TYPE_I4
    // 008 _repeated_idolSkillList_codec            FieldCodec`1<InGameIdolSkillStatus> IL2CPP_TYPE_GENERICINST
    // 030 IdolSkillList                            000185CE08C8 ModelClassListType RepeatedField`1<InGameIdolSkillStatus> RepeatedField`1<InGameIdolSkillStatus> List<InGameIdolSkillStatus> Pointer
    // 000 ProduceCardIdListFieldNumber             int IL2CPP_TYPE_I4
    // 010 _repeated_produceCardIdList_codec        FieldCodec`1<string> IL2CPP_TYPE_GENERICINST
    // 038 ProduceCardIdList                        000185CF3478 ModelPrimitiveListType RepeatedField`1<string> RepeatedField`1<string> List<string> Pointer
    public partial class PvpInGameResultStatus : DataModel
    {
        public bool                                     IsWin                                   { get; set; }
        public InGameAppealPointStatus?                 AppealPoint                             { get; set; }
        public int                                      Second                                  { get; set; }
        public List<InGameIdolSkillStatus>?             IdolSkillList                           { get; set; }
        public List<string>?                            ProduceCardIdList                       { get; set; }

        public static PvpInGameResultStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PvpInGameResultStatus() { Pointer= p0 };

            value.IsWin                                     = GetBool(new IntPtr(p + 0x018)); // 0246613945B8 0x18 IsWin                       ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.AppealPoint                               = GetObject<InGameAppealPointStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.InGameAppealPointStatus.FromPointer); // 0246613945F8 0x20 AppealPoint                 ( 0001866D3050 ModelClassType InGameAppealPointStatus InGameAppealPointStatus InGameAppealPointStatus Pointer )
            value.Second                                    = GetInt32(new IntPtr(p + 0x028)); // 024661394638 0x28 Second                      ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.IdolSkillList                             = GetObjectList<InGameIdolSkillStatus>(new IntPtr(p + 0x030), ReversePrism.DataModels.InGameIdolSkillStatus.FromPointer); // 024661394698 0x30 IdolSkillList               ( 000185CE08C8 ModelClassListType RepeatedField`1<InGameIdolSkillStatus> RepeatedField`1<InGameIdolSkillStatus> List<InGameIdolSkillStatus> Pointer )
            value.ProduceCardIdList                         = GetStringList(new IntPtr(p + 0x038)); // 0246613946F8 0x38 ProduceCardIdList           ( 000185CF3478 ModelPrimitiveListType RepeatedField`1<string> RepeatedField`1<string> List<string> Pointer )

            return value;
        }
    }
}
