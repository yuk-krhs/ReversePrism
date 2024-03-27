using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Table                                    0001865B7E00 ModelClassType DataTable DataTable DataTable Pointer
    public partial class ExpressionNode
    {
        public DataTable?                               Table                                   { get; set; }

        public static ExpressionNode? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ExpressionNode();

            value.Table                                     = GetObject<DataTable>(new IntPtr(p + 0x010), ReversePrism.DataModels.DataTable.FromPointer); // 0270D8926C80 0x10 Table                       ( 0001865B7E00 ModelClassType DataTable DataTable DataTable Pointer )

            return value;
        }
    }
}
