using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 CSharpAssemblyName                       string IL2CPP_TYPE_STRING
    // 000 BinderTypeName                           string IL2CPP_TYPE_STRING
    // 000 CSharpArgumentInfoTypeName               string IL2CPP_TYPE_STRING
    // 000 CSharpArgumentInfoFlagsTypeName          string IL2CPP_TYPE_STRING
    // 000 CSharpBinderFlagsTypeName                string IL2CPP_TYPE_STRING
    // 000 _getCSharpArgumentInfoArray              <object> IL2CPP_TYPE_OBJECT
    // 008 _setCSharpArgumentInfoArray              <object> IL2CPP_TYPE_OBJECT
    // 010 _getMemberCall                           MethodCall`2<<object>, <object>> IL2CPP_TYPE_GENERICINST
    // 018 _setMemberCall                           MethodCall`2<<object>, <object>> IL2CPP_TYPE_GENERICINST
    // 020 Init                                     000186595C30 ModelPrimitiveType bool bool bool Bool
    public partial class BinderWrapper : DataModel
    {
        public bool                                     Init                                    { get; set; }

        public static BinderWrapper? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BinderWrapper() { Pointer= p0 };

            value.Init                                      = GetBool(new IntPtr(p + 0x020)); // 02466879F240 0x20 Init                        ( 000186595C30 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
