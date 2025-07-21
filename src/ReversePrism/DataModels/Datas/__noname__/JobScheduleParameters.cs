using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Dependency                               ModelEnumType JobHandle JobHandle JobHandle Int32
    // 020 ScheduleMode                             ModelPrimitiveType int int int Int32
    // 028 ReflectionData                           <int> IL2CPP_TYPE_I
    // 030 JobDataPtr                               <int> IL2CPP_TYPE_I
    public partial class JobScheduleParameters : DataModel
    {
        public JobHandle                                Dependency                              { get; set; }
        public int                                      ScheduleMode                            { get; set; }

        public static JobScheduleParameters? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new JobScheduleParameters() { Pointer= p0 };

            value.Dependency                                = (JobHandle)GetInt32(new IntPtr(p + 0x010)); // 0x10 Dependency                  ( ModelEnumType JobHandle JobHandle JobHandle Int32 )
            value.ScheduleMode                              = GetInt32(new IntPtr(p + 0x020)); // 0x20 ScheduleMode                ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
