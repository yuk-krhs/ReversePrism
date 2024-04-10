using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<FinishAuditionReply> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 ProduceBaseInfoFieldNumber               int IL2CPP_TYPE_I4
    // 018 ProduceBaseInfo                          0001865332D0 ModelClassType ProduceBaseInfoStatus ProduceBaseInfoStatus ProduceBaseInfoStatus Pointer
    // 000 UnitParameterVariationFieldNumber        int IL2CPP_TYPE_I4
    // 020 UnitParameterVariation                   00018671DE80 ModelClassType ParameterVariationStatus ParameterVariationStatus ParameterVariationStatus Pointer
    // 000 FanVariationFieldNumber                  int IL2CPP_TYPE_I4
    // 028 FanVariation                             000186553750 ModelClassType FanVariationStatus FanVariationStatus FanVariationStatus Pointer
    // 000 ScheduleDetailTypeFieldNumber            int IL2CPP_TYPE_I4
    // 030 ScheduleDetailType                       0001866D43F0 ModelEnumType ScheduleDetailType ScheduleDetailType ScheduleDetailType Int32
    // 000 ClearSecondFieldNumber                   int IL2CPP_TYPE_I4
    // 034 ClearSecond                              0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 ClearRankFieldNumber                     int IL2CPP_TYPE_I4
    // 038 ClearRank                                000186538BD0 ModelEnumType ProduceClearRank ProduceClearRank ProduceClearRank Int32
    public partial class FinishAuditionReply : DataModel
    {
        public ProduceBaseInfoStatus?                   ProduceBaseInfo                         { get; set; }
        public ParameterVariationStatus?                UnitParameterVariation                  { get; set; }
        public FanVariationStatus?                      FanVariation                            { get; set; }
        public ScheduleDetailType                       ScheduleDetailType                      { get; set; }
        public int                                      ClearSecond                             { get; set; }
        public ProduceClearRank                         ClearRank                               { get; set; }

        public static FinishAuditionReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FinishAuditionReply() { Pointer= p0 };

            value.ProduceBaseInfo                           = GetObject<ProduceBaseInfoStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.ProduceBaseInfoStatus.FromPointer); // 02466250F7F8 0x18 ProduceBaseInfo             ( 0001865332D0 ModelClassType ProduceBaseInfoStatus ProduceBaseInfoStatus ProduceBaseInfoStatus Pointer )
            value.UnitParameterVariation                    = GetObject<ParameterVariationStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.ParameterVariationStatus.FromPointer); // 02466250F838 0x20 UnitParameterVariation      ( 00018671DE80 ModelClassType ParameterVariationStatus ParameterVariationStatus ParameterVariationStatus Pointer )
            value.FanVariation                              = GetObject<FanVariationStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.FanVariationStatus.FromPointer); // 02466250F878 0x28 FanVariation                ( 000186553750 ModelClassType FanVariationStatus FanVariationStatus FanVariationStatus Pointer )
            value.ScheduleDetailType                        = (ScheduleDetailType)GetInt32(new IntPtr(p + 0x030)); // 02466250F8B8 0x30 ScheduleDetailType          ( 0001866D43F0 ModelEnumType ScheduleDetailType ScheduleDetailType ScheduleDetailType Int32 )
            value.ClearSecond                               = GetInt32(new IntPtr(p + 0x034)); // 02466250F8F8 0x34 ClearSecond                 ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.ClearRank                                 = (ProduceClearRank)GetInt32(new IntPtr(p + 0x038)); // 02466250F938 0x38 ClearRank                   ( 000186538BD0 ModelEnumType ProduceClearRank ProduceClearRank ProduceClearRank Int32 )

            return value;
        }
    }
}
