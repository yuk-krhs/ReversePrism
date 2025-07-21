using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ShareVirtualMesh                         ModelClassType VirtualMesh VirtualMesh VirtualMesh Pointer
    // 018 UniqueData                               ModelClassType UniqueSerializationData UniqueSerializationData UniqueSerializationData Pointer
    public partial class VirtualMeshContainer : DataModel
    {
        public VirtualMesh?                             ShareVirtualMesh                        { get; set; }
        public UniqueSerializationData?                 UniqueData                              { get; set; }

        public static VirtualMeshContainer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new VirtualMeshContainer() { Pointer= p0 };

            value.ShareVirtualMesh                          = GetObject<VirtualMesh>(new IntPtr(p + 0x010), ReversePrism.DataModels.VirtualMesh.FromPointer); // 0x10 ShareVirtualMesh            ( ModelClassType VirtualMesh VirtualMesh VirtualMesh Pointer )
            value.UniqueData                                = GetObject<UniqueSerializationData>(new IntPtr(p + 0x018), ReversePrism.DataModels.UniqueSerializationData.FromPointer); // 0x18 UniqueData                  ( ModelClassType UniqueSerializationData UniqueSerializationData UniqueSerializationData Pointer )

            return value;
        }
    }
}
