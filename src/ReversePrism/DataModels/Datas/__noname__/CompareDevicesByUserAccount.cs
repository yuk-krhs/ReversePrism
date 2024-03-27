using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 PlatformUserAccountHandle                0001867071D0 ModelEnumType InputUserAccountHandle InputUserAccountHandle InputUserAccountHandle Int32
    public partial class CompareDevicesByUserAccount
    {
        public InputUserAccountHandle                   PlatformUserAccountHandle               { get; set; }

        public static CompareDevicesByUserAccount? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CompareDevicesByUserAccount();

            value.PlatformUserAccountHandle                 = (InputUserAccountHandle)GetInt32(new IntPtr(p + 0x010)); // 0270D7790160 0x10 PlatformUserAccountHandle   ( 0001867071D0 ModelEnumType InputUserAccountHandle InputUserAccountHandle InputUserAccountHandle Int32 )

            return value;
        }
    }
}
