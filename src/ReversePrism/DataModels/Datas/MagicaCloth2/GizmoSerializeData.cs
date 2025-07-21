using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Always                                   ModelPrimitiveType bool bool bool Bool
    // 018 ClothDebugSettings                       ModelClassType ClothDebugSettings ClothDebugSettings ClothDebugSettings Pointer
    public partial class GizmoSerializeData : DataModel
    {
        public bool                                     Always                                  { get; set; }
        public ClothDebugSettings?                      ClothDebugSettings                      { get; set; }

        public static GizmoSerializeData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GizmoSerializeData() { Pointer= p0 };

            value.Always                                    = GetBool(new IntPtr(p + 0x010)); // 0x10 Always                      ( ModelPrimitiveType bool bool bool Bool )
            value.ClothDebugSettings                        = GetObject<ClothDebugSettings>(new IntPtr(p + 0x018), ReversePrism.DataModels.ClothDebugSettings.FromPointer); // 0x18 ClothDebugSettings          ( ModelClassType ClothDebugSettings ClothDebugSettings ClothDebugSettings Pointer )

            return value;
        }
    }
}
