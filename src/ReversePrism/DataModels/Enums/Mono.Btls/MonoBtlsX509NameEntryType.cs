using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum MonoBtlsX509NameEntryType
    {
        Unknown,
        CountryName,
        OrganizationName,
        OrganizationalUnitName,
        CommonName,
        LocalityName,
        StateOrProvinceName,
        StreetAddress,
        SerialNumber,
        DomainComponent,
        UserId,
        Email,
        DnQualifier,
        Title,
        Surname,
        GivenName,
        Initial,
    }
}
