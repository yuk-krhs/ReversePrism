using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Arguments                                000185CEF958 ModelClassListType IReadOnlyList`1<Expression> IReadOnlyList`1<Expression> List<Expression> Pointer
    // 018 Object                                   0001865CF210 ModelClassType Expression Expression Expression Pointer
    // 020 Indexer                                  0001865D48B0 ModelClassType PropertyInfo PropertyInfo PropertyInfo Pointer
    public partial class IndexExpression
    {
        public List<Expression>?                        Arguments                               { get; set; }
        public Expression?                              Object                                  { get; set; }
        public PropertyInfo?                            Indexer                                 { get; set; }

        public static IndexExpression? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IndexExpression();

            value.Arguments                                 = GetObjectList<Expression>(new IntPtr(p + 0x010), ReversePrism.DataModels.Expression.FromPointer); // 0270D9F31710 0x10 Arguments                   ( 000185CEF958 ModelClassListType IReadOnlyList`1<Expression> IReadOnlyList`1<Expression> List<Expression> Pointer )
            value.Object                                    = GetObject<Expression>(new IntPtr(p + 0x018), ReversePrism.DataModels.Expression.FromPointer); // 0270D9F31730 0x18 Object                      ( 0001865CF210 ModelClassType Expression Expression Expression Pointer )
            value.Indexer                                   = GetObject<PropertyInfo>(new IntPtr(p + 0x020), ReversePrism.DataModels.PropertyInfo.FromPointer); // 0270D9F31750 0x20 Indexer                     ( 0001865D48B0 ModelClassType PropertyInfo PropertyInfo PropertyInfo Pointer )

            return value;
        }
    }
}
