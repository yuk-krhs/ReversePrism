using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 EnumSeparatorChar                        char IL2CPP_TYPE_CHAR
    // 000 EnumSeparatorString                      string IL2CPP_TYPE_STRING
    // 000 ValuesAndNamesPerEnum                    ThreadSafeStore`2<StructMultiKey`2<Type, NamingStrategy>, EnumInfo> IL2CPP_TYPE_GENERICINST
    // 008 _camelCaseNamingStrategy                 CamelCaseNamingStrategy IL2CPP_TYPE_CLASS
    public partial class EnumUtils : DataModel
    {

        public static EnumUtils? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EnumUtils() { Pointer= p0 };


            return value;
        }
    }
}
