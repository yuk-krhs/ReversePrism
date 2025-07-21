using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 FieldName                                ModelPrimitiveType string string string String
    // 018 NotifyPropertyChanged                    ModelPrimitiveType bool bool bool Bool
    public partial class InspectorDisplayAttribute : DataModel
    {
        public string                                   FieldName                               { get; set; }
        public bool                                     NotifyPropertyChanged                   { get; set; }

        public static InspectorDisplayAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new InspectorDisplayAttribute() { Pointer= p0 };

            value.FieldName                                 = GetString(new IntPtr(p + 0x010)); // 0x10 FieldName                   ( ModelPrimitiveType string string string String )
            value.NotifyPropertyChanged                     = GetBool(new IntPtr(p + 0x018)); // 0x18 NotifyPropertyChanged       ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
