using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 MeshFilter                               ModelClassType MeshFilter MeshFilter MeshFilter Pointer
    // 028 Mesh                                     ModelClassType Mesh Mesh Mesh Pointer
    public partial class NoteLine : DataModel
    {
        public MeshFilter?                              MeshFilter                              { get; set; }
        public Mesh?                                    Mesh                                    { get; set; }

        public static NoteLine? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new NoteLine() { Pointer= p0 };

            value.MeshFilter                                = GetObject<MeshFilter>(new IntPtr(p + 0x020), ReversePrism.DataModels.MeshFilter.FromPointer); // 0x20 MeshFilter                  ( ModelClassType MeshFilter MeshFilter MeshFilter Pointer )
            value.Mesh                                      = GetObject<Mesh>(new IntPtr(p + 0x028), ReversePrism.DataModels.Mesh.FromPointer); // 0x28 Mesh                        ( ModelClassType Mesh Mesh Mesh Pointer )

            return value;
        }
    }
}
