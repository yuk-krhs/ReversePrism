using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Image                                    0001866CCDB0 ModelClassType Image Image Image Pointer
    // 028 BlinkSeconds                             0001866656B0 ModelPrimitiveType float float float Single
    public partial class AutoMode : DataModel
    {
        public Image?                                   Image                                   { get; set; }
        public float                                    BlinkSeconds                            { get; set; }

        public static AutoMode? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AutoMode() { Pointer= p0 };

            value.Image                                     = GetObject<Image>(new IntPtr(p + 0x020), ReversePrism.DataModels.Image.FromPointer); // 02466509B3B8 0x20 Image                       ( 0001866CCDB0 ModelClassType Image Image Image Pointer )
            value.BlinkSeconds                              = GetSingle(new IntPtr(p + 0x028)); // 02466509B3D8 0x28 BlinkSeconds                ( 0001866656B0 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
