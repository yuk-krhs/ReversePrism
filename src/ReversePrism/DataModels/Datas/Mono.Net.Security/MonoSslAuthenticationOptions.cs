using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ServerCertSelectionDelegate              000186732740 ModelClassType ServerCertSelectionCallback ServerCertSelectionCallback ServerCertSelectionCallback Pointer
    public partial class MonoSslAuthenticationOptions : DataModel
    {
        public ServerCertSelectionCallback?             ServerCertSelectionDelegate             { get; set; }

        public static MonoSslAuthenticationOptions? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MonoSslAuthenticationOptions() { Pointer= p0 };

            value.ServerCertSelectionDelegate               = GetObject<ServerCertSelectionCallback>(new IntPtr(p + 0x010), ReversePrism.DataModels.ServerCertSelectionCallback.FromPointer); // 024667958EB0 0x10 ServerCertSelectionDelegate ( 000186732740 ModelClassType ServerCertSelectionCallback ServerCertSelectionCallback ServerCertSelectionCallback Pointer )

            return value;
        }
    }
}
