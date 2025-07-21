using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 mUpdateStatus                            Dictionary`2<Transform, UpdateStatus> IL2CPP_TYPE_GENERICINST
    // 008 sToDelete                                List`1<Transform> IL2CPP_TYPE_GENERICINST
    // 010 MLastUpdateTime                          ModelPrimitiveType float float float Single
    public partial class UpdateTracker : DataModel
    {
        public float                                    MLastUpdateTime                         { get; set; }

        public static UpdateTracker? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UpdateTracker() { Pointer= p0 };

            value.MLastUpdateTime                           = GetSingle(new IntPtr(p + 0x010)); // 0x10 MLastUpdateTime             ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
