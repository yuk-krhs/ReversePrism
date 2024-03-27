using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum X509FindType
    {
        FindByThumbprint,
        FindBySubjectName,
        FindBySubjectDistinguishedName,
        FindByIssuerName,
        FindByIssuerDistinguishedName,
        FindBySerialNumber,
        FindByTimeValid,
        FindByTimeNotYetValid,
        FindByTimeExpired,
        FindByTemplateName,
        FindByApplicationPolicy,
        FindByCertificatePolicy,
        FindByExtension,
        FindByKeyUsage,
        FindBySubjectKeyIdentifier,
    }
}
