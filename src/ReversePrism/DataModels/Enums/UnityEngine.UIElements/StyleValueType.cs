using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum StyleValueType
    {
        Invalid,
        Keyword,
        Float,
        Dimension,
        Color,
        ResourcePath,
        AssetReference,
        Enum,
        Variable,
        String,
        Function,
        CommaSeparator,
        ScalableImage,
        MissingAssetReference,
    }
}
