using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 MstSubSeasonId                           ModelPrimitiveType int int int Int32
    // 014 JoinState                                ModelEnumType JoinState JoinState JoinState Int32
    // 018 Season                                   ModelPrimitiveType int int int Int32
    // 020 EventTitle                               ModelPrimitiveType string string string String
    // 028 ParamCondition                           ModelClassType ParameterCondition ParameterCondition ParameterCondition Pointer
    // 030 DearnessConditionList                    ModelClassListType IReadOnlyList`1<DearnessCondition> IReadOnlyList`1<DearnessCondition> List<DearnessCondition> Pointer
    // 038 FanConditionList                         ModelClassListType IReadOnlyList`1<FanCondition> IReadOnlyList`1<FanCondition> List<FanCondition> Pointer
    public partial class ConditionDetail : DataModel
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
            var value   = new ConditionDetail() { Pointer= p0 };

            value.MstSubSeasonId                            = GetInt32(new IntPtr(p + 0x010)); // 0x10 MstSubSeasonId              ( ModelPrimitiveType int int int Int32 )
            value.JoinState                                 = (JoinState)GetInt32(new IntPtr(p + 0x014)); // 0x14 JoinState                   ( ModelEnumType JoinState JoinState JoinState Int32 )
            value.Season                                    = GetInt32(new IntPtr(p + 0x018)); // 0x18 Season                      ( ModelPrimitiveType int int int Int32 )
            value.EventTitle                                = GetString(new IntPtr(p + 0x020)); // 0x20 EventTitle                  ( ModelPrimitiveType string string string String )
            value.ParamCondition                            = GetObject<ParameterCondition>(new IntPtr(p + 0x028), ReversePrism.DataModels.ParameterCondition.FromPointer); // 0x28 ParamCondition              ( ModelClassType ParameterCondition ParameterCondition ParameterCondition Pointer )
            value.DearnessConditionList                     = GetObjectList<DearnessCondition>(new IntPtr(p + 0x030), ReversePrism.DataModels.DearnessCondition.FromPointer); // 0x30 DearnessConditionList       ( ModelClassListType IReadOnlyList`1<DearnessCondition> IReadOnlyList`1<DearnessCondition> List<DearnessCondition> Pointer )
            value.FanConditionList                          = GetObjectList<FanCondition>(new IntPtr(p + 0x038), ReversePrism.DataModels.FanCondition.FromPointer); // 0x38 FanConditionList            ( ModelClassListType IReadOnlyList`1<FanCondition> IReadOnlyList`1<FanCondition> List<FanCondition> Pointer )

            return value;
        }
    }
}
