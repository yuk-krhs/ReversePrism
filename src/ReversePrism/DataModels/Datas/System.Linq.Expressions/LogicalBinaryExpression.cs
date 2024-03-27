using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 NodeType                                 00018652DE40 ModelEnumType ExpressionType ExpressionType ExpressionType Int32
    public partial class LogicalBinaryExpression
    {
        public ExpressionType                           NodeType                                { get; set; }

        public static LogicalBinaryExpression? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LogicalBinaryExpression();

            value.NodeType                                  = (ExpressionType)GetInt32(new IntPtr(p + 0x020)); // 0270D9F16ED8 0x20 NodeType                    ( 00018652DE40 ModelEnumType ExpressionType ExpressionType ExpressionType Int32 )

            return value;
        }
    }
}
