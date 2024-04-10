using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Bindings                                 000185D259A8 ModelEnumListType List`1<BindingOverrideJson> List`1<BindingOverrideJson> List<BindingOverrideJson> Pointer
    public partial class BindingOverrideListJson : DataModel
    {
        public List<BindingOverrideJson>?               Bindings                                { get; set; }

        public static BindingOverrideListJson? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BindingOverrideListJson() { Pointer= p0 };

            value.Bindings                                  = GetEnumList<BindingOverrideJson>(new IntPtr(p + 0x010)); // 0246676BAB18 0x10 Bindings                    ( 000185D259A8 ModelEnumListType List`1<BindingOverrideJson> List`1<BindingOverrideJson> List<BindingOverrideJson> Pointer )

            return value;
        }
    }
}
