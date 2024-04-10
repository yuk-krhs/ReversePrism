using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 NodeType                                 00018652E0C0 ModelEnumType ExpressionType ExpressionType ExpressionType Int32
    // 018 Type                                     000186693960 ModelClassType Type Type Type Pointer
    public partial class ExtensionInfo : DataModel
    {
        public ExpressionType                           NodeType                                { get; set; }
        public Type?                                    Type                                    { get; set; }

        public static ExtensionInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ExtensionInfo() { Pointer= p0 };

            value.NodeType                                  = (ExpressionType)GetInt32(new IntPtr(p + 0x010)); // 024669F74920 0x10 NodeType                    ( 00018652E0C0 ModelEnumType ExpressionType ExpressionType ExpressionType Int32 )
            value.Type                                      = GetObject<Type>(new IntPtr(p + 0x018), ReversePrism.DataModels.Type.FromPointer); // 024669F74940 0x18 Type                        ( 000186693960 ModelClassType Type Type Type Pointer )

            return value;
        }
    }
}
