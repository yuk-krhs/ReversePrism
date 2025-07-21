using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 s_linkedTokenCancelDelegate              Action`1<<object>> IL2CPP_TYPE_GENERICINST
    // 040 LinkingRegistrations                     ModelEnumListType CancellationTokenRegistration[] CancellationTokenRegistration[] List<CancellationTokenRegistration> Pointer
    public partial class LinkedNCancellationTokenSource : DataModel
    {
        public List<CancellationTokenRegistration>?     LinkingRegistrations                    { get; set; }

        public static LinkedNCancellationTokenSource? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LinkedNCancellationTokenSource() { Pointer= p0 };

            value.LinkingRegistrations                      = GetEnumList<CancellationTokenRegistration>(new IntPtr(p + 0x040)); // 0x40 LinkingRegistrations        ( ModelEnumListType CancellationTokenRegistration[] CancellationTokenRegistration[] List<CancellationTokenRegistration> Pointer )

            return value;
        }
    }
}
