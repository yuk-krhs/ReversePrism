using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 AttributeTarget                          ModelEnumType AttributeTargets AttributeTargets AttributeTargets Int32
    // 014 AllowMultiple                            ModelPrimitiveType bool bool bool Bool
    // 015 Inherited                                ModelPrimitiveType bool bool bool Bool
    // 000 Default                                  AttributeUsageAttribute IL2CPP_TYPE_CLASS
    public partial class AttributeUsageAttribute : DataModel
    {
        public AttributeTargets                         AttributeTarget                         { get; set; }
        public bool                                     AllowMultiple                           { get; set; }
        public bool                                     Inherited                               { get; set; }

        public static AttributeUsageAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AttributeUsageAttribute() { Pointer= p0 };

            value.AttributeTarget                           = (AttributeTargets)GetInt32(new IntPtr(p + 0x010)); // 0x10 AttributeTarget             ( ModelEnumType AttributeTargets AttributeTargets AttributeTargets Int32 )
            value.AllowMultiple                             = GetBool(new IntPtr(p + 0x014)); // 0x14 AllowMultiple               ( ModelPrimitiveType bool bool bool Bool )
            value.Inherited                                 = GetBool(new IntPtr(p + 0x015)); // 0x15 Inherited                   ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
