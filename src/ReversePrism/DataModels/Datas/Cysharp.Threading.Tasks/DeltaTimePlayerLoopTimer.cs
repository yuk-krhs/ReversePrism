using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 030 InitialFrame                             ModelPrimitiveType int int int Int32
    // 034 Elapsed                                  ModelPrimitiveType float float float Single
    // 038 Interval                                 ModelPrimitiveType float float float Single
    public partial class DeltaTimePlayerLoopTimer : DataModel
    {
        public int                                      InitialFrame                            { get; set; }
        public float                                    Elapsed                                 { get; set; }
        public float                                    Interval                                { get; set; }

        public static DeltaTimePlayerLoopTimer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DeltaTimePlayerLoopTimer() { Pointer= p0 };

            value.InitialFrame                              = GetInt32(new IntPtr(p + 0x030)); // 0x30 InitialFrame                ( ModelPrimitiveType int int int Int32 )
            value.Elapsed                                   = GetSingle(new IntPtr(p + 0x034)); // 0x34 Elapsed                     ( ModelPrimitiveType float float float Single )
            value.Interval                                  = GetSingle(new IntPtr(p + 0x038)); // 0x38 Interval                    ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
