using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 s_UseCompatibleTypeConverterBehavior     string IL2CPP_TYPE_STRING
    // 000 useCompatibleTypeConversion              bool IL2CPP_TYPE_BOOLEAN
    public partial class TypeConverter : DataModel
    {

        public static TypeConverter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TypeConverter() { Pointer= p0 };


            return value;
        }
    }
}
