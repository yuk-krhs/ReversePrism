using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 _definedParameters                       Dictionary`2<ParameterExpression, int> IL2CPP_TYPE_GENERICINST
    // 018 _hoistedParameters                       HashSet`1<ParameterExpression> IL2CPP_TYPE_GENERICINST
    public partial class QuoteVisitor : DataModel
    {

        public static QuoteVisitor? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new QuoteVisitor() { Pointer= p0 };


            return value;
        }
    }
}
