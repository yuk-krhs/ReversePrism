using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 SkipCopyAnnotations                      JsonCloneSettings IL2CPP_TYPE_CLASS
    // 010 CopyAnnotations                          ModelPrimitiveType bool bool bool Bool
    public partial class JsonCloneSettings : DataModel
    {
        public bool                                     CopyAnnotations                         { get; set; }

        public static JsonCloneSettings? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new JsonCloneSettings() { Pointer= p0 };

            value.CopyAnnotations                           = GetBool(new IntPtr(p + 0x010)); // 0x10 CopyAnnotations             ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
