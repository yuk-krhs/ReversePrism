using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 NodeType                                 ModelEnumType ExpressionType ExpressionType ExpressionType Int32
    public partial class LogicalBinaryExpression : DataModel
    {
        public ExpressionType                           NodeType                                { get; set; }

        public static LogicalBinaryExpression? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LogicalBinaryExpression() { Pointer= p0 };

            value.NodeType                                  = (ExpressionType)GetInt32(new IntPtr(p + 0x020)); // 0x20 NodeType                    ( ModelEnumType ExpressionType ExpressionType ExpressionType Int32 )

            return value;
        }
    }
}
