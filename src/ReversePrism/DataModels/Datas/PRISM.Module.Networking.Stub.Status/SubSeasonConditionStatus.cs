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
    // 018 MstSubSeasonId                           0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 SeasonFieldNumber                        int IL2CPP_TYPE_I4
    // 01C Season                                   0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 ParameterConditionFieldNumber            int IL2CPP_TYPE_I4
    // 020 ParameterCondition                       0001865D7410 ModelClassType SubSeasonParameterConditionStatus SubSeasonParameterConditionStatus SubSeasonParameterConditionStatus Pointer
    // 000 MeetConditionFieldNumber                 int IL2CPP_TYPE_I4
    // 028 MeetCondition                            000186594D10 ModelPrimitiveType bool bool bool Bool
    // 000 DearnessConditionFieldNumber             int IL2CPP_TYPE_I4
    // 030 DearnessCondition                        0001865D3BE0 ModelClassType SubSeasonDearnessConditionStatus SubSeasonDearnessConditionStatus SubSeasonDearnessConditionStatus Pointer
    // 000 FanConditionFieldNumber                  int IL2CPP_TYPE_I4
    // 038 FanCondition                             0001865D57B0 ModelClassType SubSeasonFanConditionStatus SubSeasonFanConditionStatus SubSeasonFanConditionStatus Pointer
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

            value.MstSubSeasonId                            = GetInt32(new IntPtr(p + 0x018)); // 0246610B7380 0x18 MstSubSeasonId              ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Season                                    = GetInt32(new IntPtr(p + 0x01C)); // 0246610B73C0 0x1C Season                      ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.ParameterCondition                        = GetObject<SubSeasonParameterConditionStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.SubSeasonParameterConditionStatus.FromPointer); // 0246610B7400 0x20 ParameterCondition          ( 0001865D7410 ModelClassType SubSeasonParameterConditionStatus SubSeasonParameterConditionStatus SubSeasonParameterConditionStatus Pointer )
            value.MeetCondition                             = GetBool(new IntPtr(p + 0x028)); // 0246610B7440 0x28 MeetCondition               ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.DearnessCondition                         = GetObject<SubSeasonDearnessConditionStatus>(new IntPtr(p + 0x030), ReversePrism.DataModels.SubSeasonDearnessConditionStatus.FromPointer); // 0246610B7480 0x30 DearnessCondition           ( 0001865D3BE0 ModelClassType SubSeasonDearnessConditionStatus SubSeasonDearnessConditionStatus SubSeasonDearnessConditionStatus Pointer )
            value.FanCondition                              = GetObject<SubSeasonFanConditionStatus>(new IntPtr(p + 0x038), ReversePrism.DataModels.SubSeasonFanConditionStatus.FromPointer); // 0246610B74C0 0x38 FanCondition                ( 0001865D57B0 ModelClassType SubSeasonFanConditionStatus SubSeasonFanConditionStatus SubSeasonFanConditionStatus Pointer )

            return value;
        }
    }
}
