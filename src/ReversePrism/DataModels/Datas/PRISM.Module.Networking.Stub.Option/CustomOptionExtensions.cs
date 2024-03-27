using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 PrismOption                              Extension`2<ServiceOptions, PrismOptions> IL2CPP_TYPE_GENERICINST
    // 008 GoType                                   Extension`2<FieldOptions, string> IL2CPP_TYPE_GENERICINST
    // 010 GqlOperationOption                       Extension`2<MethodOptions, GraphQLOperationOption> IL2CPP_TYPE_GENERICINST
    public partial class CustomOptionExtensions
    {

        public static CustomOptionExtensions? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CustomOptionExtensions();


            return value;
        }
    }
}
