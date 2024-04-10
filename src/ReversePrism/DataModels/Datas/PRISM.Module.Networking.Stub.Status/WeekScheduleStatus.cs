using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<WeekScheduleStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 SeasonFieldNumber                        int IL2CPP_TYPE_I4
    // 018 Season                                   0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 WeekFieldNumber                          int IL2CPP_TYPE_I4
    // 01C Week                                     0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 IsDoneFieldNumber                        int IL2CPP_TYPE_I4
    // 020 IsDone                                   000186594D10 ModelPrimitiveType bool bool bool Bool
    // 000 ScheduleListFieldNumber                  int IL2CPP_TYPE_I4
    // 008 _repeated_scheduleList_codec             FieldCodec`1<ScheduleStatus> IL2CPP_TYPE_GENERICINST
    // 028 ScheduleList                             000185CEF808 ModelClassListType RepeatedField`1<ScheduleStatus> RepeatedField`1<ScheduleStatus> List<ScheduleStatus> Pointer
    public partial class WeekScheduleStatus : DataModel
    {
        public int                                      Season                                  { get; set; }
        public int                                      Week                                    { get; set; }
        public bool                                     IsDone                                  { get; set; }
        public List<ScheduleStatus>?                    ScheduleList                            { get; set; }

        public static WeekScheduleStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new WeekScheduleStatus() { Pointer= p0 };

            value.Season                                    = GetInt32(new IntPtr(p + 0x018)); // 0246610D2C70 0x18 Season                      ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Week                                      = GetInt32(new IntPtr(p + 0x01C)); // 0246610D2CB0 0x1C Week                        ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.IsDone                                    = GetBool(new IntPtr(p + 0x020)); // 0246610D2CF0 0x20 IsDone                      ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.ScheduleList                              = GetObjectList<ScheduleStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.ScheduleStatus.FromPointer); // 0246610D2D50 0x28 ScheduleList                ( 000185CEF808 ModelClassListType RepeatedField`1<ScheduleStatus> RepeatedField`1<ScheduleStatus> List<ScheduleStatus> Pointer )

            return value;
        }
    }
}
