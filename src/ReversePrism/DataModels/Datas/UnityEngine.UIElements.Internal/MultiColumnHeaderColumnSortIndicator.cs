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
    // 010 IndexLabelUssClassName                   000186674040 ModelPrimitiveType string string string String
    // 3C8 M_IndexLabel                             000186774D80 ModelClassType Label Label Label Pointer
    public partial class MultiColumnHeaderColumnSortIndicator
    {
        public string                                   IndexLabelUssClassName                  { get; set; }
        public Label?                                   M_IndexLabel                            { get; set; }

        public static MultiColumnHeaderColumnSortIndicator? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MultiColumnHeaderColumnSortIndicator();

            value.IndexLabelUssClassName                    = GetString(new IntPtr(p + 0x010)); // 0270068A0F28 0x10 IndexLabelUssClassName      ( 000186674040 ModelPrimitiveType string string string String )
            value.M_IndexLabel                              = GetObject<Label>(new IntPtr(p + 0x3C8), ReversePrism.DataModels.Label.FromPointer); // 0270068A0F48 0x3C8 M_IndexLabel                ( 000186774D80 ModelClassType Label Label Label Pointer )

            return value;
        }
    }
}
