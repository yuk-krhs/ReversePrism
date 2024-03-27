using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<SubSeasonStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 IsSubSeasonFieldNumber                   int IL2CPP_TYPE_I4
    // 018 IsSubSeason                              000186594D10 ModelPrimitiveType bool bool bool Bool
    // 000 SubSeasonTermFieldNumber                 int IL2CPP_TYPE_I4
    // 020 SubSeasonTerm                            0001865D86A0 ModelClassType SubSeasonTermStatus SubSeasonTermStatus SubSeasonTermStatus Pointer
    // 000 SubSeasonConditionListFieldNumber        int IL2CPP_TYPE_I4
    // 008 _repeated_subSeasonConditionList_codec   FieldCodec`1<SubSeasonConditionStatus> IL2CPP_TYPE_GENERICINST
    // 028 SubSeasonConditionList                   000185CF3938 ModelClassListType RepeatedField`1<SubSeasonConditionStatus> RepeatedField`1<SubSeasonConditionStatus> List<SubSeasonConditionStatus> Pointer
    // 000 SelectedMstSubSeasonIdListFieldNumber    int IL2CPP_TYPE_I4
    // 010 _repeated_selectedMstSubSeasonIdList_codec FieldCodec`1<int> IL2CPP_TYPE_GENERICINST
    // 030 SelectedMstSubSeasonIdList               000185CE1CE8 ModelPrimitiveListType RepeatedField`1<int> RepeatedField`1<int> List<int> Pointer
    // 000 AdditionalInfoListFieldNumber            int IL2CPP_TYPE_I4
    // 018 _repeated_additionalInfoList_codec       FieldCodec`1<SubSeasonAdditionalInfoStatus> IL2CPP_TYPE_GENERICINST
    // 038 AdditionalInfoList                       000185CF36E8 ModelClassListType RepeatedField`1<SubSeasonAdditionalInfoStatus> RepeatedField`1<SubSeasonAdditionalInfoStatus> List<SubSeasonAdditionalInfoStatus> Pointer
    public partial class SubSeasonStatus
    {
        public bool                                     IsSubSeason                             { get; set; }
        public SubSeasonTermStatus?                     SubSeasonTerm                           { get; set; }
        public List<SubSeasonConditionStatus>?          SubSeasonConditionList                  { get; set; }
        public List<int>?                               SelectedMstSubSeasonIdList              { get; set; }
        public List<SubSeasonAdditionalInfoStatus>?     AdditionalInfoList                      { get; set; }

        public static SubSeasonStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SubSeasonStatus();

            value.IsSubSeason                               = GetBool(new IntPtr(p + 0x018)); // 0270D1156C38 0x18 IsSubSeason                 ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.SubSeasonTerm                             = GetObject<SubSeasonTermStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.SubSeasonTermStatus.FromPointer); // 0270D1156C78 0x20 SubSeasonTerm               ( 0001865D86A0 ModelClassType SubSeasonTermStatus SubSeasonTermStatus SubSeasonTermStatus Pointer )
            value.SubSeasonConditionList                    = GetObjectList<SubSeasonConditionStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.SubSeasonConditionStatus.FromPointer); // 0270D1156CD8 0x28 SubSeasonConditionList      ( 000185CF3938 ModelClassListType RepeatedField`1<SubSeasonConditionStatus> RepeatedField`1<SubSeasonConditionStatus> List<SubSeasonConditionStatus> Pointer )
            value.SelectedMstSubSeasonIdList                = GetInt32List(new IntPtr(p + 0x030)); // 0270D1156D38 0x30 SelectedMstSubSeasonIdList  ( 000185CE1CE8 ModelPrimitiveListType RepeatedField`1<int> RepeatedField`1<int> List<int> Pointer )
            value.AdditionalInfoList                        = GetObjectList<SubSeasonAdditionalInfoStatus>(new IntPtr(p + 0x038), ReversePrism.DataModels.SubSeasonAdditionalInfoStatus.FromPointer); // 0270D1156D98 0x38 AdditionalInfoList          ( 000185CF36E8 ModelClassListType RepeatedField`1<SubSeasonAdditionalInfoStatus> RepeatedField`1<SubSeasonAdditionalInfoStatus> List<SubSeasonAdditionalInfoStatus> Pointer )

            return value;
        }
    }
}
