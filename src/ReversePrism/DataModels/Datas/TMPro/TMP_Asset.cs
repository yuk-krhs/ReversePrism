using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 M_InstanceID                             0001865F2AF0 ModelPrimitiveType int int int Int32
    // 01C HashCode                                 0001865F36C0 ModelPrimitiveType int int int Int32
    // 020 Material                                 00018660C4B0 ModelClassType Material Material Material Pointer
    // 028 MaterialHashCode                         0001865F36C0 ModelPrimitiveType int int int Int32
    public partial class TMP_Asset
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
            var value   = new TMP_Asset();

            value.M_InstanceID                              = GetInt32(new IntPtr(p + 0x018)); // 0270D098E530 0x18 M_InstanceID                ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.HashCode                                  = GetInt32(new IntPtr(p + 0x01C)); // 0270D098E550 0x1C HashCode                    ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.Material                                  = GetObject<Material>(new IntPtr(p + 0x020), ReversePrism.DataModels.Material.FromPointer); // 0270D098E570 0x20 Material                    ( 00018660C4B0 ModelClassType Material Material Material Pointer )
            value.MaterialHashCode                          = GetInt32(new IntPtr(p + 0x028)); // 0270D098E590 0x28 MaterialHashCode            ( 0001865F36C0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
