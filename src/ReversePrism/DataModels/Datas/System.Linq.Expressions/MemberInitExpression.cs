using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 NewExpression                            ModelClassType NewExpression NewExpression NewExpression Pointer
    // 018 <Bindings>k__BackingField                ReadOnlyCollection`1<MemberBinding> IL2CPP_TYPE_GENERICINST
    public partial class MemberInitExpression : DataModel
    {
        public NewExpression?                           NewExpression                           { get; set; }

        public static MemberInitExpression? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MemberInitExpression() { Pointer= p0 };

            value.NewExpression                             = GetObject<NewExpression>(new IntPtr(p + 0x010), ReversePrism.DataModels.NewExpression.FromPointer); // 0x10 NewExpression               ( ModelClassType NewExpression NewExpression NewExpression Pointer )

            return value;
        }
    }
}
