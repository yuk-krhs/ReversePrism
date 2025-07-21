using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 058 JumpTime                                 ModelPrimitiveType float float float Single
    public partial class ProduceAutoOneSeasonScheduleListView : DataModel
    {
        public float                                    JumpTime                                { get; set; }

        public static ProduceAutoOneSeasonScheduleListView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceAutoOneSeasonScheduleListView() { Pointer= p0 };

            value.JumpTime                                  = GetSingle(new IntPtr(p + 0x058)); // 0x58 JumpTime                    ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
