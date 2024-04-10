using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CtorInfo                                 00018660F790 ModelClassType ConstructorInfo ConstructorInfo ConstructorInfo Pointer
    // 018 ctorArgs                                 IList`1<CustomAttributeTypedArgument> IL2CPP_TYPE_GENERICINST
    // 020 namedArgs                                IList`1<CustomAttributeNamedArgument> IL2CPP_TYPE_GENERICINST
    // 028 LazyData                                 000186568530 ModelClassType LazyCAttrData LazyCAttrData LazyCAttrData Pointer
    public partial class CustomAttributeData : DataModel
    {
        public ConstructorInfo?                         CtorInfo                                { get; set; }
        public LazyCAttrData?                           LazyData                                { get; set; }

        public static CustomAttributeData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CustomAttributeData() { Pointer= p0 };

            value.CtorInfo                                  = GetObject<ConstructorInfo>(new IntPtr(p + 0x010), ReversePrism.DataModels.ConstructorInfo.FromPointer); // 0245A3D9BEC0 0x10 CtorInfo                    ( 00018660F790 ModelClassType ConstructorInfo ConstructorInfo ConstructorInfo Pointer )
            value.LazyData                                  = GetObject<LazyCAttrData>(new IntPtr(p + 0x028), ReversePrism.DataModels.LazyCAttrData.FromPointer); // 0245A3D9BF20 0x28 LazyData                    ( 000186568530 ModelClassType LazyCAttrData LazyCAttrData LazyCAttrData Pointer )

            return value;
        }
    }
}
