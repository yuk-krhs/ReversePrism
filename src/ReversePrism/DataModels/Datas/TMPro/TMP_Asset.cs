using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 M_InstanceID                             ModelPrimitiveType int int int Int32
    // 01C HashCode                                 ModelPrimitiveType int int int Int32
    // 020 Material                                 ModelClassType Material Material Material Pointer
    // 028 MaterialHashCode                         ModelPrimitiveType int int int Int32
    public partial class TMP_Asset : DataModel
    {
        public int                                      M_InstanceID                            { get; set; }
        public int                                      HashCode                                { get; set; }
        public Material?                                Material                                { get; set; }
        public int                                      MaterialHashCode                        { get; set; }

        public static TMP_Asset? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TMP_Asset() { Pointer= p0 };

            value.M_InstanceID                              = GetInt32(new IntPtr(p + 0x018)); // 0x18 M_InstanceID                ( ModelPrimitiveType int int int Int32 )
            value.HashCode                                  = GetInt32(new IntPtr(p + 0x01C)); // 0x1C HashCode                    ( ModelPrimitiveType int int int Int32 )
            value.Material                                  = GetObject<Material>(new IntPtr(p + 0x020), ReversePrism.DataModels.Material.FromPointer); // 0x20 Material                    ( ModelClassType Material Material Material Pointer )
            value.MaterialHashCode                          = GetInt32(new IntPtr(p + 0x028)); // 0x28 MaterialHashCode            ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
