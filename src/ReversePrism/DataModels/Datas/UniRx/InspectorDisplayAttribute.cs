using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 FieldName                                000186671910 ModelPrimitiveType string string string String
    // 018 NotifyPropertyChanged                    000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class InspectorDisplayAttribute
    {
        public string                                   FieldName                               { get; set; }
        public bool                                     NotifyPropertyChanged                   { get; set; }

        public static InspectorDisplayAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new InspectorDisplayAttribute();

            value.FieldName                                 = GetString(new IntPtr(p + 0x010)); // 0270D95A4BB8 0x10 FieldName                   ( 000186671910 ModelPrimitiveType string string string String )
            value.NotifyPropertyChanged                     = GetBool(new IntPtr(p + 0x018)); // 0270D95A4BD8 0x18 NotifyPropertyChanged       ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
