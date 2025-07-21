using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 lockObject                               <object> IL2CPP_TYPE_OBJECT
    // 018 statusChanged                            Subject`1<CountChangedStatus> IL2CPP_TYPE_GENERICINST
    // 020 Max                                      ModelPrimitiveType int int int Int32
    // 024 Count                                    ModelPrimitiveType int int int Int32
    public partial class CountNotifier : DataModel
    {
        public int                                      Max                                     { get; set; }
        public int                                      Count                                   { get; set; }

        public static CountNotifier? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CountNotifier() { Pointer= p0 };

            value.Max                                       = GetInt32(new IntPtr(p + 0x020)); // 0x20 Max                         ( ModelPrimitiveType int int int Int32 )
            value.Count                                     = GetInt32(new IntPtr(p + 0x024)); // 0x24 Count                       ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
