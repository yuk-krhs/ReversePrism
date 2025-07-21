using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_ValidationCallback                     ModelClassType RemoteCertificateValidationCallback RemoteCertificateValidationCallback RemoteCertificateValidationCallback Pointer
    // 018 M_Context                                ModelClassType ExecutionContext ExecutionContext ExecutionContext Pointer
    public partial class ServerCertValidationCallback : DataModel
    {
        public RemoteCertificateValidationCallback?     M_ValidationCallback                    { get; set; }
        public ExecutionContext?                        M_Context                               { get; set; }

        public static ServerCertValidationCallback? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ServerCertValidationCallback() { Pointer= p0 };

            value.M_ValidationCallback                      = GetObject<RemoteCertificateValidationCallback>(new IntPtr(p + 0x010), ReversePrism.DataModels.RemoteCertificateValidationCallback.FromPointer); // 0x10 M_ValidationCallback        ( ModelClassType RemoteCertificateValidationCallback RemoteCertificateValidationCallback RemoteCertificateValidationCallback Pointer )
            value.M_Context                                 = GetObject<ExecutionContext>(new IntPtr(p + 0x018), ReversePrism.DataModels.ExecutionContext.FromPointer); // 0x18 M_Context                   ( ModelClassType ExecutionContext ExecutionContext ExecutionContext Pointer )

            return value;
        }
    }
}
