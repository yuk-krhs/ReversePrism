using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 M_Version                                ModelPrimitiveType string string string String
    // 020 M_InstanceID                             ModelPrimitiveType int int int Int32
    // 024 M_HashCode                               ModelPrimitiveType int int int Int32
    // 028 M_Material                               ModelClassType Material Material Material Pointer
    // 030 M_MaterialHashCode                       ModelPrimitiveType int int int Int32
    public partial class TextAsset : DataModel
    {
        public string                                   M_Version                               { get; set; }
        public int                                      M_InstanceID                            { get; set; }
        public int                                      M_HashCode                              { get; set; }
        public Material?                                M_Material                              { get; set; }
        public int                                      M_MaterialHashCode                      { get; set; }

        public static TextAsset? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TextAsset() { Pointer= p0 };

            value.M_Version                                 = GetString(new IntPtr(p + 0x018)); // 0x18 M_Version                   ( ModelPrimitiveType string string string String )
            value.M_InstanceID                              = GetInt32(new IntPtr(p + 0x020)); // 0x20 M_InstanceID                ( ModelPrimitiveType int int int Int32 )
            value.M_HashCode                                = GetInt32(new IntPtr(p + 0x024)); // 0x24 M_HashCode                  ( ModelPrimitiveType int int int Int32 )
            value.M_Material                                = GetObject<Material>(new IntPtr(p + 0x028), ReversePrism.DataModels.Material.FromPointer); // 0x28 M_Material                  ( ModelClassType Material Material Material Pointer )
            value.M_MaterialHashCode                        = GetInt32(new IntPtr(p + 0x030)); // 0x30 M_MaterialHashCode          ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
