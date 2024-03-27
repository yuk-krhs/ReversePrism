using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 vertexCountPerCube                       int IL2CPP_TYPE_I4
    // 010 Mesh                                     0001866109A0 ModelClassType Mesh Mesh Mesh Pointer
    // 018 Vertices                                 000185D1AE38 ModelEnumListType List`1<Vector3> List`1<Vector3> List<Vector3> Pointer
    // 020 Indices                                  000185CECF28 ModelPrimitiveListType List`1<int> List`1<int> List<int> Pointer
    // 028 Colors                                   000185CD3358 ModelEnumListType List`1<Color> List`1<Color> List<Color> Pointer
    // 030 WireMaterial                             00018660BDD0 ModelClassType Material Material Material Pointer
    // 038 DottedWireMaterial                       00018660BDD0 ModelClassType Material Material Material Pointer
    // 040 SolidMaterial                            00018660BDD0 ModelClassType Material Material Material Pointer
    public partial class MeshGizmo
    {
        public Mesh?                                    Mesh                                    { get; set; }
        public List<Vector3>?                           Vertices                                { get; set; }
        public List<int>?                               Indices                                 { get; set; }
        public List<Color>?                             Colors                                  { get; set; }
        public Material?                                WireMaterial                            { get; set; }
        public Material?                                DottedWireMaterial                      { get; set; }
        public Material?                                SolidMaterial                           { get; set; }

        public static MeshGizmo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MeshGizmo();

            value.Mesh                                      = GetObject<Mesh>(new IntPtr(p + 0x010), ReversePrism.DataModels.Mesh.FromPointer); // 0270D92B7E18 0x10 Mesh                        ( 0001866109A0 ModelClassType Mesh Mesh Mesh Pointer )
            value.Vertices                                  = GetEnumList<Vector3>(new IntPtr(p + 0x018)); // 0270D92B7E38 0x18 Vertices                    ( 000185D1AE38 ModelEnumListType List`1<Vector3> List`1<Vector3> List<Vector3> Pointer )
            value.Indices                                   = GetInt32List(new IntPtr(p + 0x020)); // 0270D92B7E58 0x20 Indices                     ( 000185CECF28 ModelPrimitiveListType List`1<int> List`1<int> List<int> Pointer )
            value.Colors                                    = GetEnumList<Color>(new IntPtr(p + 0x028)); // 0270D92B7E78 0x28 Colors                      ( 000185CD3358 ModelEnumListType List`1<Color> List`1<Color> List<Color> Pointer )
            value.WireMaterial                              = GetObject<Material>(new IntPtr(p + 0x030), ReversePrism.DataModels.Material.FromPointer); // 0270D92B7E98 0x30 WireMaterial                ( 00018660BDD0 ModelClassType Material Material Material Pointer )
            value.DottedWireMaterial                        = GetObject<Material>(new IntPtr(p + 0x038), ReversePrism.DataModels.Material.FromPointer); // 0270D92B7EB8 0x38 DottedWireMaterial          ( 00018660BDD0 ModelClassType Material Material Material Pointer )
            value.SolidMaterial                             = GetObject<Material>(new IntPtr(p + 0x040), ReversePrism.DataModels.Material.FromPointer); // 0270D92B7ED8 0x40 SolidMaterial               ( 00018660BDD0 ModelClassType Material Material Material Pointer )

            return value;
        }
    }
}
