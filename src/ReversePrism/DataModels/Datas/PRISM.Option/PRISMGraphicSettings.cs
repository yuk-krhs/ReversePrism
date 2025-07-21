using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 OptionLocalSave                          ModelClassType OptionLocalSave OptionLocalSave OptionLocalSave Pointer
    public partial class PRISMGraphicSettings : DataModel
    {
        public OptionLocalSave?                         OptionLocalSave                         { get; set; }

        public static PRISMGraphicSettings? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PRISMGraphicSettings() { Pointer= p0 };

            value.OptionLocalSave                           = GetObject<OptionLocalSave>(new IntPtr(p + 0x010), ReversePrism.DataModels.OptionLocalSave.FromPointer); // 0x10 OptionLocalSave             ( ModelClassType OptionLocalSave OptionLocalSave OptionLocalSave Pointer )

            return value;
        }
    }
}
