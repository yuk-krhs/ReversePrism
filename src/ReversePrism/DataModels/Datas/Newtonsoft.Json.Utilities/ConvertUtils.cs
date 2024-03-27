using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 TypeCodeMap                              Dictionary`2<Type, PrimitiveTypeCode> IL2CPP_TYPE_GENERICINST
    // 008 PrimitiveTypeCodes                       TypeInformation[] IL2CPP_TYPE_SZARRAY
    // 010 CastConverters                           ThreadSafeStore`2<StructMultiKey`2<Type, Type>, Func`2<<object>, <object>>> IL2CPP_TYPE_GENERICINST
    public partial class ConvertUtils
    {

        public static ConvertUtils? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ConvertUtils();


            return value;
        }
    }
}
