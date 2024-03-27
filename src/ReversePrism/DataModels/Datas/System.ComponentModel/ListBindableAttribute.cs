using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 Yes                                      ListBindableAttribute IL2CPP_TYPE_CLASS
    // 008 No                                       ListBindableAttribute IL2CPP_TYPE_CLASS
    // 010 Default                                  000186535170 ModelClassType ListBindableAttribute ListBindableAttribute ListBindableAttribute Pointer
    // 010 IsDefault                                000186594D10 ModelPrimitiveType bool bool bool Bool
    // 011 ListBindable                             0001865965D0 ModelPrimitiveType bool bool bool Bool
    public partial class ListBindableAttribute
    {
        public ListBindableAttribute?                   Default                                 { get; set; }
        public bool                                     IsDefault                               { get; set; }
        public bool                                     ListBindable                            { get; set; }

        public static ListBindableAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ListBindableAttribute();

            value.Default                                   = GetObject<ListBindableAttribute>(new IntPtr(p + 0x010), ReversePrism.DataModels.ListBindableAttribute.FromPointer); // 0270D7B1F7A8 0x10 Default                     ( 000186535170 ModelClassType ListBindableAttribute ListBindableAttribute ListBindableAttribute Pointer )
            value.IsDefault                                 = GetBool(new IntPtr(p + 0x010)); // 0270D7B1F7C8 0x10 IsDefault                   ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.ListBindable                              = GetBool(new IntPtr(p + 0x011)); // 0270D7B1F7E8 0x11 ListBindable                ( 0001865965D0 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
