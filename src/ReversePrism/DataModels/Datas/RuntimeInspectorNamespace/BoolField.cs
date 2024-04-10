using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 080 ToggleBackground                         0001866CCDB0 ModelClassType Image Image Image Pointer
    // 088 Input                                    000186682710 ModelClassType Toggle Toggle Toggle Pointer
    public partial class BoolField : DataModel
    {
        public Image?                                   ToggleBackground                        { get; set; }
        public Toggle?                                  Input                                   { get; set; }

        public static BoolField? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BoolField() { Pointer= p0 };

            value.ToggleBackground                          = GetObject<Image>(new IntPtr(p + 0x080), ReversePrism.DataModels.Image.FromPointer); // 02466B236A78 0x80 ToggleBackground            ( 0001866CCDB0 ModelClassType Image Image Image Pointer )
            value.Input                                     = GetObject<Toggle>(new IntPtr(p + 0x088), ReversePrism.DataModels.Toggle.FromPointer); // 02466B236A98 0x88 Input                       ( 000186682710 ModelClassType Toggle Toggle Toggle Pointer )

            return value;
        }
    }
}
