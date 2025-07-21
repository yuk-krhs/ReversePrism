using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Menu                                     ModelPrimitiveType string string string String
    public partial class VolumeComponentMenu : DataModel
    {
        public string                                   Menu                                    { get; set; }

        public static VolumeComponentMenu? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new VolumeComponentMenu() { Pointer= p0 };

            value.Menu                                      = GetString(new IntPtr(p + 0x010)); // 0x10 Menu                        ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
