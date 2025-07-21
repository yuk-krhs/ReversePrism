using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 ussClassName                             string IL2CPP_TYPE_STRING
    // 008 arrowUssClassName                        string IL2CPP_TYPE_STRING
    // 010 IndexLabelUssClassName                   ModelPrimitiveType string string string String
    // 3C8 M_IndexLabel                             ModelClassType Label Label Label Pointer
    public partial class MultiColumnHeaderColumnSortIndicator : DataModel
    {
        public string                                   IndexLabelUssClassName                  { get; set; }
        public Label?                                   M_IndexLabel                            { get; set; }

        public static MultiColumnHeaderColumnSortIndicator? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MultiColumnHeaderColumnSortIndicator() { Pointer= p0 };

            value.IndexLabelUssClassName                    = GetString(new IntPtr(p + 0x010)); // 0x10 IndexLabelUssClassName      ( ModelPrimitiveType string string string String )
            value.M_IndexLabel                              = GetObject<Label>(new IntPtr(p + 0x3C8), ReversePrism.DataModels.Label.FromPointer); // 0x3C8 M_IndexLabel                ( ModelClassType Label Label Label Pointer )

            return value;
        }
    }
}
