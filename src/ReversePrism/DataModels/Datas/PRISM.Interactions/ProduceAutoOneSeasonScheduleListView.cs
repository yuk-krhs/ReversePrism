using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 068 JumpTime                                 0001866656B0 ModelPrimitiveType float float float Single
    public partial class ProduceAutoOneSeasonScheduleListView
    {
        public float                                    JumpTime                                { get; set; }

        public static ProduceAutoOneSeasonScheduleListView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceAutoOneSeasonScheduleListView();

            value.JumpTime                                  = GetSingle(new IntPtr(p + 0x068)); // 0270DA0CE798 0x68 JumpTime                    ( 0001866656B0 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
