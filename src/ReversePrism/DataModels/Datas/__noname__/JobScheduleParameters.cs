using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Dependency                               000186601120 ModelEnumType JobHandle JobHandle JobHandle Int32
    // 020 ScheduleMode                             0001865F36C0 ModelPrimitiveType int int int Int32
    // 028 ReflectionData                           <int> IL2CPP_TYPE_I
    // 030 JobDataPtr                               <int> IL2CPP_TYPE_I
    public partial class JobScheduleParameters
    {
        public JobHandle                                Dependency                              { get; set; }
        public int                                      ScheduleMode                            { get; set; }

        public static JobScheduleParameters? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new JobScheduleParameters();

            value.Dependency                                = (JobHandle)GetInt32(new IntPtr(p + 0x010)); // 0270068A32C8 0x10 Dependency                  ( 000186601120 ModelEnumType JobHandle JobHandle JobHandle Int32 )
            value.ScheduleMode                              = GetInt32(new IntPtr(p + 0x020)); // 0270068A32E8 0x20 ScheduleMode                ( 0001865F36C0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
