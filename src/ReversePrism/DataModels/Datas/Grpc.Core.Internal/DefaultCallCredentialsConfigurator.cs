using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 NativeCredentials                        ModelClassType CallCredentialsSafeHandle CallCredentialsSafeHandle CallCredentialsSafeHandle Pointer
    public partial class DefaultCallCredentialsConfigurator : DataModel
    {
        public CallCredentialsSafeHandle?               NativeCredentials                       { get; set; }

        public static DefaultCallCredentialsConfigurator? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DefaultCallCredentialsConfigurator() { Pointer= p0 };

            value.NativeCredentials                         = GetObject<CallCredentialsSafeHandle>(new IntPtr(p + 0x010), ReversePrism.DataModels.CallCredentialsSafeHandle.FromPointer); // 0x10 NativeCredentials           ( ModelClassType CallCredentialsSafeHandle CallCredentialsSafeHandle CallCredentialsSafeHandle Pointer )

            return value;
        }
    }
}
