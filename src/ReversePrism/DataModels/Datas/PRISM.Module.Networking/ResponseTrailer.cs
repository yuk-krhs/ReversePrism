using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 MissionCompleted                         ModelClassType INotifyMissionCompletedStatus INotifyMissionCompletedStatus INotifyMissionCompletedStatus Pointer
    public partial class ResponseTrailer : DataModel
    {
        public INotifyMissionCompletedStatus?           MissionCompleted                        { get; set; }

        public static ResponseTrailer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ResponseTrailer() { Pointer= p0 };

            value.MissionCompleted                          = GetObject<INotifyMissionCompletedStatus>(new IntPtr(p + 0x010), ReversePrism.DataModels.INotifyMissionCompletedStatus.FromPointer); // 0x10 MissionCompleted            ( ModelClassType INotifyMissionCompletedStatus INotifyMissionCompletedStatus INotifyMissionCompletedStatus Pointer )

            return value;
        }
    }
}
