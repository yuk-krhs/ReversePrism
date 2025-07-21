using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 s_Instance                               DebugShapes IL2CPP_TYPE_CLASS
    // 010 M_sphereMesh                             ModelClassType Mesh Mesh Mesh Pointer
    // 018 M_boxMesh                                ModelClassType Mesh Mesh Mesh Pointer
    // 020 M_coneMesh                               ModelClassType Mesh Mesh Mesh Pointer
    // 028 M_pyramidMesh                            ModelClassType Mesh Mesh Mesh Pointer
    public partial class DebugShapes : DataModel
    {
        public Mesh?                                    M_sphereMesh                            { get; set; }
        public Mesh?                                    M_boxMesh                               { get; set; }
        public Mesh?                                    M_coneMesh                              { get; set; }
        public Mesh?                                    M_pyramidMesh                           { get; set; }

        public static DebugShapes? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DebugShapes() { Pointer= p0 };

            value.M_sphereMesh                              = GetObject<Mesh>(new IntPtr(p + 0x010), ReversePrism.DataModels.Mesh.FromPointer); // 0x10 M_sphereMesh                ( ModelClassType Mesh Mesh Mesh Pointer )
            value.M_boxMesh                                 = GetObject<Mesh>(new IntPtr(p + 0x018), ReversePrism.DataModels.Mesh.FromPointer); // 0x18 M_boxMesh                   ( ModelClassType Mesh Mesh Mesh Pointer )
            value.M_coneMesh                                = GetObject<Mesh>(new IntPtr(p + 0x020), ReversePrism.DataModels.Mesh.FromPointer); // 0x20 M_coneMesh                  ( ModelClassType Mesh Mesh Mesh Pointer )
            value.M_pyramidMesh                             = GetObject<Mesh>(new IntPtr(p + 0x028), ReversePrism.DataModels.Mesh.FromPointer); // 0x28 M_pyramidMesh               ( ModelClassType Mesh Mesh Mesh Pointer )

            return value;
        }
    }
}
