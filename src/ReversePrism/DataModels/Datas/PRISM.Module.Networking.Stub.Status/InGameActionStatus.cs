using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<InGameActionStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 VocalAppealPointFieldNumber              int IL2CPP_TYPE_I4
    // 018 VocalAppealPoint                         0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 DanceAppealPointFieldNumber              int IL2CPP_TYPE_I4
    // 01C DanceAppealPoint                         0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 VisualAppealPointFieldNumber             int IL2CPP_TYPE_I4
    // 020 VisualAppealPoint                        0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 ClearSecondFieldNumber                   int IL2CPP_TYPE_I4
    // 024 ClearSecond                              0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 IdolSkillCountFieldNumber                int IL2CPP_TYPE_I4
    // 028 IdolSkillCount                           0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 ProduceCardCountFieldNumber              int IL2CPP_TYPE_I4
    // 02C ProduceCardCount                         0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 MstIdolSkillIdListFieldNumber            int IL2CPP_TYPE_I4
    // 008 _repeated_mstIdolSkillIdList_codec       FieldCodec`1<int> IL2CPP_TYPE_GENERICINST
    // 030 MstIdolSkillIdList                       000185CE1CE8 ModelPrimitiveListType RepeatedField`1<int> RepeatedField`1<int> List<int> Pointer
    // 000 ProduceCardIdListFieldNumber             int IL2CPP_TYPE_I4
    // 010 _repeated_produceCardIdList_codec        FieldCodec`1<string> IL2CPP_TYPE_GENERICINST
    // 038 ProduceCardIdList                        000185CF3478 ModelPrimitiveListType RepeatedField`1<string> RepeatedField`1<string> List<string> Pointer
    public partial class InGameActionStatus : DataModel
    {
        public int                                      VocalAppealPoint                        { get; set; }
        public int                                      DanceAppealPoint                        { get; set; }
        public int                                      VisualAppealPoint                       { get; set; }
        public int                                      ClearSecond                             { get; set; }
        public int                                      IdolSkillCount                          { get; set; }
        public int                                      ProduceCardCount                        { get; set; }
        public List<int>?                               MstIdolSkillIdList                      { get; set; }
        public List<string>?                            ProduceCardIdList                       { get; set; }

        public static InGameActionStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new InGameActionStatus() { Pointer= p0 };

            value.VocalAppealPoint                          = GetInt32(new IntPtr(p + 0x018)); // 024661058828 0x18 VocalAppealPoint            ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.DanceAppealPoint                          = GetInt32(new IntPtr(p + 0x01C)); // 024661058868 0x1C DanceAppealPoint            ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.VisualAppealPoint                         = GetInt32(new IntPtr(p + 0x020)); // 0246610588A8 0x20 VisualAppealPoint           ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.ClearSecond                               = GetInt32(new IntPtr(p + 0x024)); // 0246610588E8 0x24 ClearSecond                 ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.IdolSkillCount                            = GetInt32(new IntPtr(p + 0x028)); // 024661058928 0x28 IdolSkillCount              ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.ProduceCardCount                          = GetInt32(new IntPtr(p + 0x02C)); // 024661058968 0x2C ProduceCardCount            ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.MstIdolSkillIdList                        = GetInt32List(new IntPtr(p + 0x030)); // 0246610589C8 0x30 MstIdolSkillIdList          ( 000185CE1CE8 ModelPrimitiveListType RepeatedField`1<int> RepeatedField`1<int> List<int> Pointer )
            value.ProduceCardIdList                         = GetStringList(new IntPtr(p + 0x038)); // 024661058A28 0x38 ProduceCardIdList           ( 000185CF3478 ModelPrimitiveListType RepeatedField`1<string> RepeatedField`1<string> List<string> Pointer )

            return value;
        }
    }
}
