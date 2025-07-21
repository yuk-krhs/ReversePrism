using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Material                                 ModelClassType Material Material Material Pointer
    // 018 Texture                                  ModelEnumType TextureId TextureId TextureId Int32
    // 01C StencilRef                               ModelPrimitiveType int int int Int32
    // 020 SdfScale                                 ModelPrimitiveType float float float Single
    public partial class State : DataModel
    {
        public Material?                                Material                                { get; set; }
        public TextureId                                Texture                                 { get; set; }
        public int                                      StencilRef                              { get; set; }
        public float                                    SdfScale                                { get; set; }

        public static State? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new State() { Pointer= p0 };

            value.Material                                  = GetObject<Material>(new IntPtr(p + 0x010), ReversePrism.DataModels.Material.FromPointer); // 0x10 Material                    ( ModelClassType Material Material Material Pointer )
            value.Texture                                   = (TextureId)GetInt32(new IntPtr(p + 0x018)); // 0x18 Texture                     ( ModelEnumType TextureId TextureId TextureId Int32 )
            value.StencilRef                                = GetInt32(new IntPtr(p + 0x01C)); // 0x1C StencilRef                  ( ModelPrimitiveType int int int Int32 )
            value.SdfScale                                  = GetSingle(new IntPtr(p + 0x020)); // 0x20 SdfScale                    ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
