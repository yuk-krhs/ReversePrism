using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 AllocVerts                               ModelEnumType Alloc Alloc Alloc Int32
    // 030 AllocIndices                             ModelEnumType Alloc Alloc Alloc Int32
    // 048 TriangleCount                            ModelPrimitiveType uint uint uint UInt32
    // 050 AllocPage                                ModelClassType Page Page Page Pointer
    // 058 AllocTime                                ModelPrimitiveType uint uint uint UInt32
    // 05C UpdateAllocID                            ModelPrimitiveType uint uint uint UInt32
    public partial class MeshHandle : DataModel
    {
        public Alloc                                    AllocVerts                              { get; set; }
        public Alloc                                    AllocIndices                            { get; set; }
        public uint                                     TriangleCount                           { get; set; }
        public Page?                                    AllocPage                               { get; set; }
        public uint                                     AllocTime                               { get; set; }
        public uint                                     UpdateAllocID                           { get; set; }

        public static MeshHandle? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MeshHandle() { Pointer= p0 };

            value.AllocVerts                                = (Alloc)GetInt32(new IntPtr(p + 0x018)); // 0x18 AllocVerts                  ( ModelEnumType Alloc Alloc Alloc Int32 )
            value.AllocIndices                              = (Alloc)GetInt32(new IntPtr(p + 0x030)); // 0x30 AllocIndices                ( ModelEnumType Alloc Alloc Alloc Int32 )
            value.TriangleCount                             = GetUInt32(new IntPtr(p + 0x048)); // 0x48 TriangleCount               ( ModelPrimitiveType uint uint uint UInt32 )
            value.AllocPage                                 = GetObject<Page>(new IntPtr(p + 0x050), ReversePrism.DataModels.Page.FromPointer); // 0x50 AllocPage                   ( ModelClassType Page Page Page Pointer )
            value.AllocTime                                 = GetUInt32(new IntPtr(p + 0x058)); // 0x58 AllocTime                   ( ModelPrimitiveType uint uint uint UInt32 )
            value.UpdateAllocID                             = GetUInt32(new IntPtr(p + 0x05C)); // 0x5C UpdateAllocID               ( ModelPrimitiveType uint uint uint UInt32 )

            return value;
        }
    }
}
