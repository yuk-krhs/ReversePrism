using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<GraphQLOperationOption> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 OperationTypeFieldNumber                 int IL2CPP_TYPE_I4
    // 018 OperationType                            00018651B120 ModelEnumType GraphQLOperationType GraphQLOperationType GraphQLOperationType Int32
    public partial class GraphQLOperationOption : DataModel
    {
        public GraphQLOperationType                     OperationType                           { get; set; }

        public static GraphQLOperationOption? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GraphQLOperationOption() { Pointer= p0 };

            value.OperationType                             = (GraphQLOperationType)GetInt32(new IntPtr(p + 0x018)); // 024660B5F8F8 0x18 OperationType               ( 00018651B120 ModelEnumType GraphQLOperationType GraphQLOperationType GraphQLOperationType Int32 )

            return value;
        }
    }
}
