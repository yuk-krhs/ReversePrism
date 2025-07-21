using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Arguments                                ModelClassListType IReadOnlyList`1<Expression> IReadOnlyList`1<Expression> List<Expression> Pointer
    // 018 Object                                   ModelClassType Expression Expression Expression Pointer
    // 020 Indexer                                  ModelClassType PropertyInfo PropertyInfo PropertyInfo Pointer
    public partial class IndexExpression : DataModel
    {
        public List<Expression>?                        Arguments                               { get; set; }
        public Expression?                              Object                                  { get; set; }
        public PropertyInfo?                            Indexer                                 { get; set; }

        public static IndexExpression? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IndexExpression() { Pointer= p0 };

            value.Arguments                                 = GetObjectList<Expression>(new IntPtr(p + 0x010), ReversePrism.DataModels.Expression.FromPointer); // 0x10 Arguments                   ( ModelClassListType IReadOnlyList`1<Expression> IReadOnlyList`1<Expression> List<Expression> Pointer )
            value.Object                                    = GetObject<Expression>(new IntPtr(p + 0x018), ReversePrism.DataModels.Expression.FromPointer); // 0x18 Object                      ( ModelClassType Expression Expression Expression Pointer )
            value.Indexer                                   = GetObject<PropertyInfo>(new IntPtr(p + 0x020), ReversePrism.DataModels.PropertyInfo.FromPointer); // 0x20 Indexer                     ( ModelClassType PropertyInfo PropertyInfo PropertyInfo Pointer )

            return value;
        }
    }
}
