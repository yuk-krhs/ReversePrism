using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<StartScheduleAdviceReply> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 ProduceBaseInfoFieldNumber               int IL2CPP_TYPE_I4
    // 018 ProduceBaseInfo                          0001865332D0 ModelClassType ProduceBaseInfoStatus ProduceBaseInfoStatus ProduceBaseInfoStatus Pointer
    // 000 DisplayMstIdolIdFieldNumber              int IL2CPP_TYPE_I4
    // 020 DisplayMstIdolId                         0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 ScheduleDetailTypeFieldNumber            int IL2CPP_TYPE_I4
    // 024 ScheduleDetailType                       0001866D43F0 ModelEnumType ScheduleDetailType ScheduleDetailType ScheduleDetailType Int32
    // 000 DeletableProduceCardAmountFieldNumber    int IL2CPP_TYPE_I4
    // 028 DeletableProduceCardAmount               0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 UnitParameterVariationFieldNumber        int IL2CPP_TYPE_I4
    // 030 UnitParameterVariation                   00018671DE80 ModelClassType ParameterVariationStatus ParameterVariationStatus ParameterVariationStatus Pointer
    public partial class StartScheduleAdviceReply
    {
        public ProduceBaseInfoStatus?                   ProduceBaseInfo                         { get; set; }
        public int                                      DisplayMstIdolId                        { get; set; }
        public ScheduleDetailType                       ScheduleDetailType                      { get; set; }
        public int                                      DeletableProduceCardAmount              { get; set; }
        public ParameterVariationStatus?                UnitParameterVariation                  { get; set; }

        public static StartScheduleAdviceReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StartScheduleAdviceReply();

            value.ProduceBaseInfo                           = GetObject<ProduceBaseInfoStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.ProduceBaseInfoStatus.FromPointer); // 0270D25B6830 0x18 ProduceBaseInfo             ( 0001865332D0 ModelClassType ProduceBaseInfoStatus ProduceBaseInfoStatus ProduceBaseInfoStatus Pointer )
            value.DisplayMstIdolId                          = GetInt32(new IntPtr(p + 0x020)); // 0270D25B6870 0x20 DisplayMstIdolId            ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.ScheduleDetailType                        = (ScheduleDetailType)GetInt32(new IntPtr(p + 0x024)); // 0270D25B68B0 0x24 ScheduleDetailType          ( 0001866D43F0 ModelEnumType ScheduleDetailType ScheduleDetailType ScheduleDetailType Int32 )
            value.DeletableProduceCardAmount                = GetInt32(new IntPtr(p + 0x028)); // 0270D25B68F0 0x28 DeletableProduceCardAmount  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.UnitParameterVariation                    = GetObject<ParameterVariationStatus>(new IntPtr(p + 0x030), ReversePrism.DataModels.ParameterVariationStatus.FromPointer); // 0270D25B6930 0x30 UnitParameterVariation      ( 00018671DE80 ModelClassType ParameterVariationStatus ParameterVariationStatus ParameterVariationStatus Pointer )

            return value;
        }
    }
}
