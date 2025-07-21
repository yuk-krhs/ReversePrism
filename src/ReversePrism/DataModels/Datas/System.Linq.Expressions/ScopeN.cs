using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 Body                                     ModelClassListType IReadOnlyList`1<Expression> IReadOnlyList`1<Expression> List<Expression> Pointer
    public partial class ScopeN : DataModel
    {
        public List<Expression>?                        Body                                    { get; set; }

        public static ScopeN? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ScopeN() { Pointer= p0 };

            value.Body                                      = GetObjectList<Expression>(new IntPtr(p + 0x018), ReversePrism.DataModels.Expression.FromPointer); // 0x18 Body                        ( ModelClassListType IReadOnlyList`1<Expression> IReadOnlyList`1<Expression> List<Expression> Pointer )

            return value;
        }
    }
}
