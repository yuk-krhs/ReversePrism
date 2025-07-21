using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 120 HasManuallySetStartValue                 ModelPrimitiveType bool bool bool Bool
    // 121 IsFromAllowed                            ModelPrimitiveType bool bool bool Bool
    public partial class Tweener : DataModel
    {
        public bool                                     HasManuallySetStartValue                { get; set; }
        public bool                                     IsFromAllowed                           { get; set; }

        public static Tweener? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Tweener() { Pointer= p0 };

            value.HasManuallySetStartValue                  = GetBool(new IntPtr(p + 0x120)); // 0x120 HasManuallySetStartValue    ( ModelPrimitiveType bool bool bool Bool )
            value.IsFromAllowed                             = GetBool(new IntPtr(p + 0x121)); // 0x121 IsFromAllowed               ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
