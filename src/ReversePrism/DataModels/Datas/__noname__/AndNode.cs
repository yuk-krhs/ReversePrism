using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Depth                                    0001865F2F90 ModelPrimitiveType int int int Int32
    // 018 Node                                     0001865CEFD0 ModelClassType Expression Expression Expression Pointer
    public partial class AndNode
    {
        public int                                      Depth                                   { get; set; }
        public Expression?                              Node                                    { get; set; }

        public static AndNode? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AndNode();

            value.Depth                                     = GetInt32(new IntPtr(p + 0x010)); // 0270DA05F028 0x10 Depth                       ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.Node                                      = GetObject<Expression>(new IntPtr(p + 0x018), ReversePrism.DataModels.Expression.FromPointer); // 0270DA05F048 0x18 Node                        ( 0001865CEFD0 ModelClassType Expression Expression Expression Pointer )

            return value;
        }
    }
}
