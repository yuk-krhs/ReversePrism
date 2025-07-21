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
    // 010 Default                                  ModelClassType ListBindableAttribute ListBindableAttribute ListBindableAttribute Pointer
    // 010 IsDefault                                ModelPrimitiveType bool bool bool Bool
    // 011 ListBindable                             ModelPrimitiveType bool bool bool Bool
    public partial class ListBindableAttribute : DataModel
    {
        public ListBindableAttribute?                   Default                                 { get; set; }
        public bool                                     IsDefault                               { get; set; }
        public bool                                     ListBindable                            { get; set; }

        public static ListBindableAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ListBindableAttribute() { Pointer= p0 };

            value.Default                                   = GetObject<ListBindableAttribute>(new IntPtr(p + 0x010), ReversePrism.DataModels.ListBindableAttribute.FromPointer); // 0x10 Default                     ( ModelClassType ListBindableAttribute ListBindableAttribute ListBindableAttribute Pointer )
            value.IsDefault                                 = GetBool(new IntPtr(p + 0x010)); // 0x10 IsDefault                   ( ModelPrimitiveType bool bool bool Bool )
            value.ListBindable                              = GetBool(new IntPtr(p + 0x011)); // 0x11 ListBindable                ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
