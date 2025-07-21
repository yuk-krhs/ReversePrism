using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 RenderHandle                             ModelPrimitiveType int int int Int32
    // 018 RenderMeshContainer                      ModelClassType VirtualMeshContainer VirtualMeshContainer VirtualMeshContainer Pointer
    // 020 MappingChunk                             ModelEnumType DataChunk DataChunk DataChunk Int32
    public partial class RenderMeshInfo : DataModel
    {
        public int                                      RenderHandle                            { get; set; }
        public VirtualMeshContainer?                    RenderMeshContainer                     { get; set; }
        public DataChunk                                MappingChunk                            { get; set; }

        public static RenderMeshInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RenderMeshInfo() { Pointer= p0 };

            value.RenderHandle                              = GetInt32(new IntPtr(p + 0x010)); // 0x10 RenderHandle                ( ModelPrimitiveType int int int Int32 )
            value.RenderMeshContainer                       = GetObject<VirtualMeshContainer>(new IntPtr(p + 0x018), ReversePrism.DataModels.VirtualMeshContainer.FromPointer); // 0x18 RenderMeshContainer         ( ModelClassType VirtualMeshContainer VirtualMeshContainer VirtualMeshContainer Pointer )
            value.MappingChunk                              = (DataChunk)GetInt32(new IntPtr(p + 0x020)); // 0x20 MappingChunk                ( ModelEnumType DataChunk DataChunk DataChunk Int32 )

            return value;
        }
    }
}
