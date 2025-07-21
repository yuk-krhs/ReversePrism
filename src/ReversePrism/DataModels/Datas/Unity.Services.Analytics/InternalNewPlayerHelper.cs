using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 InstallId                                ModelClassType IInstallationId IInstallationId IInstallationId Pointer
    // 000 k_UnityAnalyticsInstallationIdKey        string IL2CPP_TYPE_STRING
    public partial class InternalNewPlayerHelper : DataModel
    {
        public IInstallationId?                         InstallId                               { get; set; }

        public static InternalNewPlayerHelper? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new InternalNewPlayerHelper() { Pointer= p0 };

            value.InstallId                                 = GetObject<IInstallationId>(new IntPtr(p + 0x010), ReversePrism.DataModels.IInstallationId.FromPointer); // 0x10 InstallId                   ( ModelClassType IInstallationId IInstallationId IInstallationId Pointer )

            return value;
        }
    }
}
