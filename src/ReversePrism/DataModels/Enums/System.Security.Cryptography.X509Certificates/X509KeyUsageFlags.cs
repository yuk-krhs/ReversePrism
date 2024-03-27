using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum X509KeyUsageFlags
    {
        None,
        EncipherOnly,
        CrlSign,
        KeyCertSign,
        KeyAgreement,
        DataEncipherment,
        KeyEncipherment,
        NonRepudiation,
        DigitalSignature,
        DecipherOnly,
    }
}
