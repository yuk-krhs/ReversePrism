using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 Operation                                00018652DE40 ModelEnumType ExpressionType ExpressionType ExpressionType Int32
    public partial class BinaryOperationBinder : DataModel
    {
        public ExpressionType                           Operation                               { get; set; }

        public static BinaryOperationBinder? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BinaryOperationBinder() { Pointer= p0 };

            value.Operation                                 = (ExpressionType)GetInt32(new IntPtr(p + 0x018)); // 02466877EBB0 0x18 Operation                   ( 00018652DE40 ModelEnumType ExpressionType ExpressionType ExpressionType Int32 )

            return value;
        }
    }
}
