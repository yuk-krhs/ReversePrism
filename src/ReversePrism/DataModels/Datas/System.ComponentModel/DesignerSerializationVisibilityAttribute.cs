using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 Content                                  DesignerSerializationVisibilityAttribute IL2CPP_TYPE_CLASS
    // 008 Hidden                                   DesignerSerializationVisibilityAttribute IL2CPP_TYPE_CLASS
    // 010 Visible                                  ModelClassType DesignerSerializationVisibilityAttribute DesignerSerializationVisibilityAttribute DesignerSerializationVisibilityAttribute Pointer
    // 018 Default                                  ModelClassType DesignerSerializationVisibilityAttribute DesignerSerializationVisibilityAttribute DesignerSerializationVisibilityAttribute Pointer
    // 010 Visibility                               ModelEnumType DesignerSerializationVisibility DesignerSerializationVisibility DesignerSerializationVisibility Int32
    public partial class DesignerSerializationVisibilityAttribute : DataModel
    {
        public DesignerSerializationVisibilityAttribute? Visible                                 { get; set; }
        public DesignerSerializationVisibilityAttribute? Default                                 { get; set; }
        public DesignerSerializationVisibility          Visibility                              { get; set; }

        public static DesignerSerializationVisibilityAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DesignerSerializationVisibilityAttribute() { Pointer= p0 };

            value.Visible                                   = GetObject<DesignerSerializationVisibilityAttribute>(new IntPtr(p + 0x010), ReversePrism.DataModels.DesignerSerializationVisibilityAttribute.FromPointer); // 0x10 Visible                     ( ModelClassType DesignerSerializationVisibilityAttribute DesignerSerializationVisibilityAttribute DesignerSerializationVisibilityAttribute Pointer )
            value.Default                                   = GetObject<DesignerSerializationVisibilityAttribute>(new IntPtr(p + 0x018), ReversePrism.DataModels.DesignerSerializationVisibilityAttribute.FromPointer); // 0x18 Default                     ( ModelClassType DesignerSerializationVisibilityAttribute DesignerSerializationVisibilityAttribute DesignerSerializationVisibilityAttribute Pointer )
            value.Visibility                                = (DesignerSerializationVisibility)GetInt32(new IntPtr(p + 0x010)); // 0x10 Visibility                  ( ModelEnumType DesignerSerializationVisibility DesignerSerializationVisibility DesignerSerializationVisibility Int32 )

            return value;
        }
    }
}
