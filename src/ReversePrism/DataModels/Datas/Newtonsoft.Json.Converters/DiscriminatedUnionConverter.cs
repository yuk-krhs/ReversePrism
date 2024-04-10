using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 CasePropertyName                         string IL2CPP_TYPE_STRING
    // 000 FieldsPropertyName                       string IL2CPP_TYPE_STRING
    // 000 UnionCache                               ThreadSafeStore`2<Type, Union> IL2CPP_TYPE_GENERICINST
    // 008 UnionTypeLookupCache                     ThreadSafeStore`2<Type, Type> IL2CPP_TYPE_GENERICINST
    public partial class DiscriminatedUnionConverter : DataModel
    {

        public static DiscriminatedUnionConverter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DiscriminatedUnionConverter() { Pointer= p0 };


            return value;
        }
    }
}
