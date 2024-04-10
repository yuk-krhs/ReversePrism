using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 _unique                                  HashSet`1<BindingRestrictions> IL2CPP_TYPE_GENERICINST
    // 018 _tests                                   Stack`1<AndNode> IL2CPP_TYPE_GENERICINST
    public partial class TestBuilder : DataModel
    {

        public static TestBuilder? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TestBuilder() { Pointer= p0 };


            return value;
        }
    }
}
