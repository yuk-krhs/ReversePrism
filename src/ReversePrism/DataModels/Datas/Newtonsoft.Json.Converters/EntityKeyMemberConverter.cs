using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 EntityKeyMemberFullTypeName              string IL2CPP_TYPE_STRING
    // 000 KeyPropertyName                          string IL2CPP_TYPE_STRING
    // 000 TypePropertyName                         string IL2CPP_TYPE_STRING
    // 000 ValuePropertyName                        string IL2CPP_TYPE_STRING
    // 000 _reflectionObject                        ReflectionObject IL2CPP_TYPE_CLASS
    public partial class EntityKeyMemberConverter : DataModel
    {

        public static EntityKeyMemberConverter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EntityKeyMemberConverter() { Pointer= p0 };


            return value;
        }
    }
}
