using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum AxisType
    {
        Ancestor,
        AncestorOrSelf,
        Attribute,
        Child,
        Descendant,
        DescendantOrSelf,
        Following,
        FollowingSibling,
        Namespace,
        Parent,
        Preceding,
        PrecedingSibling,
        Self,
        None,
    }
}
