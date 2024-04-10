using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 TypeContractCacheLock                    <object> IL2CPP_TYPE_OBJECT
    // 008 NameTable                                DefaultJsonNameTable IL2CPP_TYPE_CLASS
    // 010 _contractCache                           Dictionary`2<StructMultiKey`2<Type, Type>, JsonContract> IL2CPP_TYPE_GENERICINST
    public partial class CamelCasePropertyNamesContractResolver : DataModel
    {

        public static CamelCasePropertyNamesContractResolver? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CamelCasePropertyNamesContractResolver() { Pointer= p0 };


            return value;
        }
    }
}
