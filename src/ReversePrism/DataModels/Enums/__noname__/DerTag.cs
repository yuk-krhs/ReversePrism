using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum DerTag
    {
        Boolean,
        Integer,
        BitString,
        OctetString,
        Null,
        ObjectIdentifier,
        UTF8String,
        Sequence,
        Set,
        PrintableString,
        T61String,
        IA5String,
        UTCTime,
        GeneralizedTime,
        BMPString,
    }
}
