using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<ScheduleStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 ScheduleTypeFieldNumber                  int IL2CPP_TYPE_I4
    // 018 ScheduleType                             ModelEnumType ScheduleType ScheduleType ScheduleType Int32
    // 000 ScheduleStateFieldNumber                 int IL2CPP_TYPE_I4
    // 01C ScheduleState                            ModelEnumType ScheduleState ScheduleState ScheduleState Int32
    // 000 ScheduleDetailListFieldNumber            int IL2CPP_TYPE_I4
    // 008 _repeated_scheduleDetailList_codec       FieldCodec`1<ScheduleDetailStatus> IL2CPP_TYPE_GENERICINST
    // 020 ScheduleDetailList                       ModelClassListType RepeatedField`1<ScheduleDetailStatus> RepeatedField`1<ScheduleDetailStatus> List<ScheduleDetailStatus> Pointer
    // 000 ScheduleResultTypeFieldNumber            int IL2CPP_TYPE_I4
    // 028 ScheduleResultType                       ModelEnumType ScheduleResultType ScheduleResultType ScheduleResultType Int32
    // 000 IsSpecifiedByPassiveEffectFieldNumber    int IL2CPP_TYPE_I4
    // 02C IsSpecifiedByPassiveEffect               ModelPrimitiveType bool bool bool Bool
    public partial class ScheduleStatus : DataModel
    {
        public ScheduleType                             ScheduleType                            { get; set; }
        public ScheduleState                            ScheduleState                           { get; set; }
        public List<ScheduleDetailStatus>?              ScheduleDetailList                      { get; set; }
        public ScheduleResultType                       ScheduleResultType                      { get; set; }
        public bool                                     IsSpecifiedByPassiveEffect              { get; set; }

        public static ScheduleStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ScheduleStatus() { Pointer= p0 };

            value.ScheduleType                              = (ScheduleType)GetInt32(new IntPtr(p + 0x018)); // 0x18 ScheduleType                ( ModelEnumType ScheduleType ScheduleType ScheduleType Int32 )
            value.ScheduleState                             = (ScheduleState)GetInt32(new IntPtr(p + 0x01C)); // 0x1C ScheduleState               ( ModelEnumType ScheduleState ScheduleState ScheduleState Int32 )
            value.ScheduleDetailList                        = GetObjectList<ScheduleDetailStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.ScheduleDetailStatus.FromPointer); // 0x20 ScheduleDetailList          ( ModelClassListType RepeatedField`1<ScheduleDetailStatus> RepeatedField`1<ScheduleDetailStatus> List<ScheduleDetailStatus> Pointer )
            value.ScheduleResultType                        = (ScheduleResultType)GetInt32(new IntPtr(p + 0x028)); // 0x28 ScheduleResultType          ( ModelEnumType ScheduleResultType ScheduleResultType ScheduleResultType Int32 )
            value.IsSpecifiedByPassiveEffect                = GetBool(new IntPtr(p + 0x02C)); // 0x2C IsSpecifiedByPassiveEffect  ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
