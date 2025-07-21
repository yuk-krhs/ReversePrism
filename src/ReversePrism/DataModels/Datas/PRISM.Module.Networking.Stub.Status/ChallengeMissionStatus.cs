using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<ChallengeMissionStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 MstProduceIdolIdFieldNumber              int IL2CPP_TYPE_I4
    // 018 MstProduceIdolId                         ModelPrimitiveType int int int Int32
    // 000 MstChallengeMissionIdFieldNumber         int IL2CPP_TYPE_I4
    // 020 MstChallengeMissionId                    ModelPrimitiveType string string string String
    // 000 MstChallengeMissionTypeIdFieldNumber     int IL2CPP_TYPE_I4
    // 028 MstChallengeMissionTypeId                ModelPrimitiveType int int int Int32
    // 000 GoalValueFieldNumber                     int IL2CPP_TYPE_I4
    // 02C GoalValue                                ModelPrimitiveType int int int Int32
    // 000 BuildUpParameterFieldNumber              int IL2CPP_TYPE_I4
    // 030 BuildUpParameter                         ModelClassType BuildUpParameterValueStatus BuildUpParameterValueStatus BuildUpParameterValueStatus Pointer
    public partial class ChallengeMissionStatus : DataModel
    {
        public int                                      MstProduceIdolId                        { get; set; }
        public string                                   MstChallengeMissionId                   { get; set; }
        public int                                      MstChallengeMissionTypeId               { get; set; }
        public int                                      GoalValue                               { get; set; }
        public BuildUpParameterValueStatus?             BuildUpParameter                        { get; set; }

        public static ChallengeMissionStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ChallengeMissionStatus() { Pointer= p0 };

            value.MstProduceIdolId                          = GetInt32(new IntPtr(p + 0x018)); // 0x18 MstProduceIdolId            ( ModelPrimitiveType int int int Int32 )
            value.MstChallengeMissionId                     = GetString(new IntPtr(p + 0x020)); // 0x20 MstChallengeMissionId       ( ModelPrimitiveType string string string String )
            value.MstChallengeMissionTypeId                 = GetInt32(new IntPtr(p + 0x028)); // 0x28 MstChallengeMissionTypeId   ( ModelPrimitiveType int int int Int32 )
            value.GoalValue                                 = GetInt32(new IntPtr(p + 0x02C)); // 0x2C GoalValue                   ( ModelPrimitiveType int int int Int32 )
            value.BuildUpParameter                          = GetObject<BuildUpParameterValueStatus>(new IntPtr(p + 0x030), ReversePrism.DataModels.BuildUpParameterValueStatus.FromPointer); // 0x30 BuildUpParameter            ( ModelClassType BuildUpParameterValueStatus BuildUpParameterValueStatus BuildUpParameterValueStatus Pointer )

            return value;
        }
    }
}
