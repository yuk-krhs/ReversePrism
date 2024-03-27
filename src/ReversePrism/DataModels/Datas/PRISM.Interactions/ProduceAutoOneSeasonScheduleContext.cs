using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 038 OnPostExecScheduleAsync                  Func`4<ProduceAutoOneSeasonViewModel, int, CancellationToken, UniTask> IL2CPP_TYPE_GENERICINST
    // 040 AssetTag                                 0001866722E0 ModelPrimitiveType string string string String
    public partial class ProduceAutoOneSeasonScheduleContext
    {
        public string                                   AssetTag                                { get; set; }

        public static ProduceAutoOneSeasonScheduleContext? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceAutoOneSeasonScheduleContext();

            value.AssetTag                                  = GetString(new IntPtr(p + 0x040)); // 0270DA0CDE20 0x40 AssetTag                    ( 0001866722E0 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
