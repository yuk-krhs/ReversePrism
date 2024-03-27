using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 030 InitialFrame                             0001865F2AF0 ModelPrimitiveType int int int Int32
    // 034 Elapsed                                  0001866656B0 ModelPrimitiveType float float float Single
    // 038 Interval                                 0001866656B0 ModelPrimitiveType float float float Single
    public partial class DeltaTimePlayerLoopTimer
    {
        public int                                      InitialFrame                            { get; set; }
        public float                                    Elapsed                                 { get; set; }
        public float                                    Interval                                { get; set; }

        public static DeltaTimePlayerLoopTimer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DeltaTimePlayerLoopTimer();

            value.InitialFrame                              = GetInt32(new IntPtr(p + 0x030)); // 027004E2D620 0x30 InitialFrame                ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Elapsed                                   = GetSingle(new IntPtr(p + 0x034)); // 027004E2D640 0x34 Elapsed                     ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.Interval                                  = GetSingle(new IntPtr(p + 0x038)); // 027004E2D660 0x38 Interval                    ( 0001866656B0 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
