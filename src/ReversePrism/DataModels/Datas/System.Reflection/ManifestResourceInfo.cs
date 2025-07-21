using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ReferencedAssembly                       ModelClassType Assembly Assembly Assembly Pointer
    // 018 FileName                                 ModelPrimitiveType string string string String
    // 020 ResourceLocation                         ModelEnumType ResourceLocation ResourceLocation ResourceLocation Int32
    public partial class ManifestResourceInfo : DataModel
    {
        public Assembly?                                ReferencedAssembly                      { get; set; }
        public string                                   FileName                                { get; set; }
        public ResourceLocation                         ResourceLocation                        { get; set; }

        public static ManifestResourceInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ManifestResourceInfo() { Pointer= p0 };

            value.ReferencedAssembly                        = GetObject<Assembly>(new IntPtr(p + 0x010), ReversePrism.DataModels.Assembly.FromPointer); // 0x10 ReferencedAssembly          ( ModelClassType Assembly Assembly Assembly Pointer )
            value.FileName                                  = GetString(new IntPtr(p + 0x018)); // 0x18 FileName                    ( ModelPrimitiveType string string string String )
            value.ResourceLocation                          = (ResourceLocation)GetInt32(new IntPtr(p + 0x020)); // 0x20 ResourceLocation            ( ModelEnumType ResourceLocation ResourceLocation ResourceLocation Int32 )

            return value;
        }
    }
}
