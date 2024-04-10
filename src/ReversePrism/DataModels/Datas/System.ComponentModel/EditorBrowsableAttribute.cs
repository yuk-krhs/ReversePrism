using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 BrowsableState                           00018671EEA0 ModelEnumType EditorBrowsableState EditorBrowsableState EditorBrowsableState Int32
    public partial class EditorBrowsableAttribute : DataModel
    {
        public EditorBrowsableState                     BrowsableState                          { get; set; }

        public static EditorBrowsableAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EditorBrowsableAttribute() { Pointer= p0 };

            value.BrowsableState                            = (EditorBrowsableState)GetInt32(new IntPtr(p + 0x010)); // 024667B7B068 0x10 BrowsableState              ( 00018671EEA0 ModelEnumType EditorBrowsableState EditorBrowsableState EditorBrowsableState Int32 )

            return value;
        }
    }
}
