using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 M_AsyncWorkQueue                         ModelEnumListType List`1<WorkRequest> List`1<WorkRequest> List<WorkRequest> Pointer
    // 020 M_CurrentFrameWork                       ModelEnumListType List`1<WorkRequest> List`1<WorkRequest> List<WorkRequest> Pointer
    // 028 M_MainThreadID                           ModelPrimitiveType int int int Int32
    // 02C M_TrackedCount                           ModelPrimitiveType int int int Int32
    public partial class UnitySynchronizationContext : DataModel
    {
        public List<WorkRequest>?                       M_AsyncWorkQueue                        { get; set; }
        public List<WorkRequest>?                       M_CurrentFrameWork                      { get; set; }
        public int                                      M_MainThreadID                          { get; set; }
        public int                                      M_TrackedCount                          { get; set; }

        public static UnitySynchronizationContext? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UnitySynchronizationContext() { Pointer= p0 };

            value.M_AsyncWorkQueue                          = GetEnumList<WorkRequest>(new IntPtr(p + 0x018)); // 0x18 M_AsyncWorkQueue            ( ModelEnumListType List`1<WorkRequest> List`1<WorkRequest> List<WorkRequest> Pointer )
            value.M_CurrentFrameWork                        = GetEnumList<WorkRequest>(new IntPtr(p + 0x020)); // 0x20 M_CurrentFrameWork          ( ModelEnumListType List`1<WorkRequest> List`1<WorkRequest> List<WorkRequest> Pointer )
            value.M_MainThreadID                            = GetInt32(new IntPtr(p + 0x028)); // 0x28 M_MainThreadID              ( ModelPrimitiveType int int int Int32 )
            value.M_TrackedCount                            = GetInt32(new IntPtr(p + 0x02C)); // 0x2C M_TrackedCount              ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
