using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<ScheduleVariationStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 ScheduleDetailTypeFieldNumber            int IL2CPP_TYPE_I4
    // 018 ScheduleDetailType                       0001866D43F0 ModelEnumType ScheduleDetailType ScheduleDetailType ScheduleDetailType Int32
    // 000 BeforeScheduleLevelFieldNumber           int IL2CPP_TYPE_I4
    // 01C BeforeScheduleLevel                      0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 AfterScheduleLevelFieldNumber            int IL2CPP_TYPE_I4
    // 020 AfterScheduleLevel                       0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class ScheduleVariationStatus
    {
        public ScheduleDetailType                       ScheduleDetailType                      { get; set; }
        public int                                      BeforeScheduleLevel                     { get; set; }
        public int                                      AfterScheduleLevel                      { get; set; }

        public static ScheduleVariationStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ScheduleVariationStatus();

            value.ScheduleDetailType                        = (ScheduleDetailType)GetInt32(new IntPtr(p + 0x018)); // 0270041D18D0 0x18 ScheduleDetailType          ( 0001866D43F0 ModelEnumType ScheduleDetailType ScheduleDetailType ScheduleDetailType Int32 )
            value.BeforeScheduleLevel                       = GetInt32(new IntPtr(p + 0x01C)); // 0270041D1910 0x1C BeforeScheduleLevel         ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.AfterScheduleLevel                        = GetInt32(new IntPtr(p + 0x020)); // 0270041D1950 0x20 AfterScheduleLevel          ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
