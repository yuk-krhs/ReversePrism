using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ScheduleModel                            0001866D5EA0 ModelClassType ScheduleModel ScheduleModel ScheduleModel Pointer
    public partial class ScheduleConnection
    {
        public ScheduleModel?                           ScheduleModel                           { get; set; }

        public static ScheduleConnection? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ScheduleConnection();

            value.ScheduleModel                             = GetObject<ScheduleModel>(new IntPtr(p + 0x010), ReversePrism.DataModels.ScheduleModel.FromPointer); // 0270D5A29938 0x10 ScheduleModel               ( 0001866D5EA0 ModelClassType ScheduleModel ScheduleModel ScheduleModel Pointer )

            return value;
        }
    }
}
