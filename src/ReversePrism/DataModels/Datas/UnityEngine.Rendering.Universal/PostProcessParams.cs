using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 BlitMaterial                             ModelClassType Material Material Material Pointer
    // 018 RequestHDRFormat                         ModelEnumType GraphicsFormat GraphicsFormat GraphicsFormat Int32
    public partial class PostProcessParams : DataModel
    {
        public Material?                                BlitMaterial                            { get; set; }
        public GraphicsFormat                           RequestHDRFormat                        { get; set; }

        public static PostProcessParams? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PostProcessParams() { Pointer= p0 };

            value.BlitMaterial                              = GetObject<Material>(new IntPtr(p + 0x010), ReversePrism.DataModels.Material.FromPointer); // 0x10 BlitMaterial                ( ModelClassType Material Material Material Pointer )
            value.RequestHDRFormat                          = (GraphicsFormat)GetInt32(new IntPtr(p + 0x018)); // 0x18 RequestHDRFormat            ( ModelEnumType GraphicsFormat GraphicsFormat GraphicsFormat Int32 )

            return value;
        }
    }
}
