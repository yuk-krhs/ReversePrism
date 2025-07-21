using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<SubSeasonConditionStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 MstSubSeasonIdFieldNumber                int IL2CPP_TYPE_I4
    // 018 MstSubSeasonId                           ModelPrimitiveType int int int Int32
    // 000 SeasonFieldNumber                        int IL2CPP_TYPE_I4
    // 01C Season                                   ModelPrimitiveType int int int Int32
    // 000 ParameterConditionFieldNumber            int IL2CPP_TYPE_I4
    // 020 ParameterCondition                       ModelClassType SubSeasonParameterConditionStatus SubSeasonParameterConditionStatus SubSeasonParameterConditionStatus Pointer
    // 000 MeetConditionFieldNumber                 int IL2CPP_TYPE_I4
    // 028 MeetCondition                            ModelPrimitiveType bool bool bool Bool
    // 000 DearnessConditionFieldNumber             int IL2CPP_TYPE_I4
    // 030 DearnessCondition                        ModelClassType SubSeasonDearnessConditionStatus SubSeasonDearnessConditionStatus SubSeasonDearnessConditionStatus Pointer
    // 000 FanConditionFieldNumber                  int IL2CPP_TYPE_I4
    // 038 FanCondition                             ModelClassType SubSeasonFanConditionStatus SubSeasonFanConditionStatus SubSeasonFanConditionStatus Pointer
    public partial class SubSeasonConditionStatus : DataModel
    {
        public int                                      MstSubSeasonId                          { get; set; }
        public int                                      Season                                  { get; set; }
        public SubSeasonParameterConditionStatus?       ParameterCondition                      { get; set; }
        public bool                                     MeetCondition                           { get; set; }
        public SubSeasonDearnessConditionStatus?        DearnessCondition                       { get; set; }
        public SubSeasonFanConditionStatus?             FanCondition                            { get; set; }

        public static SubSeasonConditionStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SubSeasonConditionStatus() { Pointer= p0 };

            value.MstSubSeasonId                            = GetInt32(new IntPtr(p + 0x018)); // 0x18 MstSubSeasonId              ( ModelPrimitiveType int int int Int32 )
            value.Season                                    = GetInt32(new IntPtr(p + 0x01C)); // 0x1C Season                      ( ModelPrimitiveType int int int Int32 )
            value.ParameterCondition                        = GetObject<SubSeasonParameterConditionStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.SubSeasonParameterConditionStatus.FromPointer); // 0x20 ParameterCondition          ( ModelClassType SubSeasonParameterConditionStatus SubSeasonParameterConditionStatus SubSeasonParameterConditionStatus Pointer )
            value.MeetCondition                             = GetBool(new IntPtr(p + 0x028)); // 0x28 MeetCondition               ( ModelPrimitiveType bool bool bool Bool )
            value.DearnessCondition                         = GetObject<SubSeasonDearnessConditionStatus>(new IntPtr(p + 0x030), ReversePrism.DataModels.SubSeasonDearnessConditionStatus.FromPointer); // 0x30 DearnessCondition           ( ModelClassType SubSeasonDearnessConditionStatus SubSeasonDearnessConditionStatus SubSeasonDearnessConditionStatus Pointer )
            value.FanCondition                              = GetObject<SubSeasonFanConditionStatus>(new IntPtr(p + 0x038), ReversePrism.DataModels.SubSeasonFanConditionStatus.FromPointer); // 0x38 FanCondition                ( ModelClassType SubSeasonFanConditionStatus SubSeasonFanConditionStatus SubSeasonFanConditionStatus Pointer )

            return value;
        }
    }
}
