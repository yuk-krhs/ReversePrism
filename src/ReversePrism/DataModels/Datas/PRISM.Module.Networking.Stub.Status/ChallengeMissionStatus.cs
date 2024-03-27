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
    // 018 MstProduceIdolId                         0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 MstChallengeMissionIdFieldNumber         int IL2CPP_TYPE_I4
    // 020 MstChallengeMissionId                    000186671910 ModelPrimitiveType string string string String
    // 000 MstChallengeMissionTypeIdFieldNumber     int IL2CPP_TYPE_I4
    // 028 MstChallengeMissionTypeId                0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 GoalValueFieldNumber                     int IL2CPP_TYPE_I4
    // 02C GoalValue                                0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 BuildUpParameterFieldNumber              int IL2CPP_TYPE_I4
    // 030 BuildUpParameter                         00018650F800 ModelClassType BuildUpParameterValueStatus BuildUpParameterValueStatus BuildUpParameterValueStatus Pointer
    public partial class ChallengeMissionStatus
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
            var value   = new ChallengeMissionStatus();

            value.MstProduceIdolId                          = GetInt32(new IntPtr(p + 0x018)); // 0270D10B2D18 0x18 MstProduceIdolId            ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.MstChallengeMissionId                     = GetString(new IntPtr(p + 0x020)); // 0270D10B2D58 0x20 MstChallengeMissionId       ( 000186671910 ModelPrimitiveType string string string String )
            value.MstChallengeMissionTypeId                 = GetInt32(new IntPtr(p + 0x028)); // 0270D10B2D98 0x28 MstChallengeMissionTypeId   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.GoalValue                                 = GetInt32(new IntPtr(p + 0x02C)); // 0270D10B2DD8 0x2C GoalValue                   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.BuildUpParameter                          = GetObject<BuildUpParameterValueStatus>(new IntPtr(p + 0x030), ReversePrism.DataModels.BuildUpParameterValueStatus.FromPointer); // 0270D10B2E18 0x30 BuildUpParameter            ( 00018650F800 ModelClassType BuildUpParameterValueStatus BuildUpParameterValueStatus BuildUpParameterValueStatus Pointer )

            return value;
        }
    }
}
