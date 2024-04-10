using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 NodeType                                 00018652DE40 ModelEnumType ExpressionType ExpressionType ExpressionType Int32
    // 028 Type                                     0001866936B0 ModelClassType Type Type Type Pointer
    public partial class SimpleBinaryExpression : DataModel
    {
        public ExpressionType                           NodeType                                { get; set; }
        public Type?                                    Type                                    { get; set; }

        public static SimpleBinaryExpression? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SimpleBinaryExpression() { Pointer= p0 };

            value.NodeType                                  = (ExpressionType)GetInt32(new IntPtr(p + 0x020)); // 024669F74538 0x20 NodeType                    ( 00018652DE40 ModelEnumType ExpressionType ExpressionType ExpressionType Int32 )
            value.Type                                      = GetObject<Type>(new IntPtr(p + 0x028), ReversePrism.DataModels.Type.FromPointer); // 024669F74558 0x28 Type                        ( 0001866936B0 ModelClassType Type Type Type Pointer )

            return value;
        }
    }
}
