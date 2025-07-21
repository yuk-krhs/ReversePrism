using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<SubSeasonCharacterConditionStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 IsConditionFieldNumber                   int IL2CPP_TYPE_I4
    // 018 IsCondition                              ModelPrimitiveType bool bool bool Bool
    // 000 RequiredCharacterNumFieldNumber          int IL2CPP_TYPE_I4
    // 01C RequiredCharacterNum                     ModelPrimitiveType int int int Int32
    // 000 RequiredMstCharacterInfoIdListFieldNumber int IL2CPP_TYPE_I4
    // 008 _repeated_requiredMstCharacterInfoIdList_codec FieldCodec`1<int> IL2CPP_TYPE_GENERICINST
    // 020 RequiredMstCharacterInfoIdList           ModelPrimitiveListType RepeatedField`1<int> RepeatedField`1<int> List<int> Pointer
    // 000 MstCharacterInfoIdListFieldNumber        int IL2CPP_TYPE_I4
    // 010 _repeated_mstCharacterInfoIdList_codec   FieldCodec`1<int> IL2CPP_TYPE_GENERICINST
    // 028 MstCharacterInfoIdList                   ModelPrimitiveListType RepeatedField`1<int> RepeatedField`1<int> List<int> Pointer
    // 000 MeetConditionFieldNumber                 int IL2CPP_TYPE_I4
    // 030 MeetCondition                            ModelPrimitiveType bool bool bool Bool
    public partial class SubSeasonCharacterConditionStatus : DataModel
    {
        public bool                                     IsCondition                             { get; set; }
        public int                                      RequiredCharacterNum                    { get; set; }
        public List<int>?                               RequiredMstCharacterInfoIdList          { get; set; }
        public List<int>?                               MstCharacterInfoIdList                  { get; set; }
        public bool                                     MeetCondition                           { get; set; }

        public static SubSeasonCharacterConditionStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SubSeasonCharacterConditionStatus() { Pointer= p0 };

            value.IsCondition                               = GetBool(new IntPtr(p + 0x018)); // 0x18 IsCondition                 ( ModelPrimitiveType bool bool bool Bool )
            value.RequiredCharacterNum                      = GetInt32(new IntPtr(p + 0x01C)); // 0x1C RequiredCharacterNum        ( ModelPrimitiveType int int int Int32 )
            value.RequiredMstCharacterInfoIdList            = GetInt32List(new IntPtr(p + 0x020)); // 0x20 RequiredMstCharacterInfoIdList ( ModelPrimitiveListType RepeatedField`1<int> RepeatedField`1<int> List<int> Pointer )
            value.MstCharacterInfoIdList                    = GetInt32List(new IntPtr(p + 0x028)); // 0x28 MstCharacterInfoIdList      ( ModelPrimitiveListType RepeatedField`1<int> RepeatedField`1<int> List<int> Pointer )
            value.MeetCondition                             = GetBool(new IntPtr(p + 0x030)); // 0x30 MeetCondition               ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
