using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 MstSubSeasonId                           0001865F36C0 ModelPrimitiveType int int int Int32
    // 014 JoinState                                0001865A8F80 ModelEnumType JoinState JoinState JoinState Int32
    // 018 Season                                   0001865F36C0 ModelPrimitiveType int int int Int32
    // 020 EventTitle                               0001866722E0 ModelPrimitiveType string string string String
    // 028 ParamCondition                           0001865A9700 ModelClassType ParameterCondition ParameterCondition ParameterCondition Pointer
    // 030 DearnessConditionList                    000185D19928 ModelClassListType IReadOnlyList`1<DearnessCondition> IReadOnlyList`1<DearnessCondition> List<DearnessCondition> Pointer
    // 038 FanConditionList                         000185D19BA8 ModelClassListType IReadOnlyList`1<FanCondition> IReadOnlyList`1<FanCondition> List<FanCondition> Pointer
    public partial class ConditionDetail
    {
        public int                                      MstSubSeasonId                          { get; set; }
        public JoinState                                JoinState                               { get; set; }
        public int                                      Season                                  { get; set; }
        public string                                   EventTitle                              { get; set; }
        public ParameterCondition?                      ParamCondition                          { get; set; }
        public List<DearnessCondition>?                 DearnessConditionList                   { get; set; }
        public List<FanCondition>?                      FanConditionList                        { get; set; }

        public static ConditionDetail? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ConditionDetail();

            value.MstSubSeasonId                            = GetInt32(new IntPtr(p + 0x010)); // 0270D4D24150 0x10 MstSubSeasonId              ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.JoinState                                 = (JoinState)GetInt32(new IntPtr(p + 0x014)); // 0270D4D24170 0x14 JoinState                   ( 0001865A8F80 ModelEnumType JoinState JoinState JoinState Int32 )
            value.Season                                    = GetInt32(new IntPtr(p + 0x018)); // 0270D4D24190 0x18 Season                      ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.EventTitle                                = GetString(new IntPtr(p + 0x020)); // 0270D4D241B0 0x20 EventTitle                  ( 0001866722E0 ModelPrimitiveType string string string String )
            value.ParamCondition                            = GetObject<ParameterCondition>(new IntPtr(p + 0x028), ReversePrism.DataModels.ParameterCondition.FromPointer); // 0270D4D241D0 0x28 ParamCondition              ( 0001865A9700 ModelClassType ParameterCondition ParameterCondition ParameterCondition Pointer )
            value.DearnessConditionList                     = GetObjectList<DearnessCondition>(new IntPtr(p + 0x030), ReversePrism.DataModels.DearnessCondition.FromPointer); // 0270D4D241F0 0x30 DearnessConditionList       ( 000185D19928 ModelClassListType IReadOnlyList`1<DearnessCondition> IReadOnlyList`1<DearnessCondition> List<DearnessCondition> Pointer )
            value.FanConditionList                          = GetObjectList<FanCondition>(new IntPtr(p + 0x038), ReversePrism.DataModels.FanCondition.FromPointer); // 0270D4D24210 0x38 FanConditionList            ( 000185D19BA8 ModelClassListType IReadOnlyList`1<FanCondition> IReadOnlyList`1<FanCondition> List<FanCondition> Pointer )

            return value;
        }
    }
}
