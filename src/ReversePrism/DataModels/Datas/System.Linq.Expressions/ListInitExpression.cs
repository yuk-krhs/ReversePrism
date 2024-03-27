using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 NewExpression                            00018669EE70 ModelClassType NewExpression NewExpression NewExpression Pointer
    // 018 <Initializers>k__BackingField            ReadOnlyCollection`1<ElementInit> IL2CPP_TYPE_GENERICINST
    public partial class ListInitExpression
    {
        public NewExpression?                           NewExpression                           { get; set; }

        public static ListInitExpression? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ListInitExpression();

            value.NewExpression                             = GetObject<NewExpression>(new IntPtr(p + 0x010), ReversePrism.DataModels.NewExpression.FromPointer); // 0270D9F643B8 0x10 NewExpression               ( 00018669EE70 ModelClassType NewExpression NewExpression NewExpression Pointer )

            return value;
        }
    }
}
