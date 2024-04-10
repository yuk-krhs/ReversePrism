using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 AllocVerts                               0001865863D0 ModelEnumType Alloc Alloc Alloc Int32
    // 030 AllocIndices                             0001865863D0 ModelEnumType Alloc Alloc Alloc Int32
    // 048 TriangleCount                            000186698DF0 ModelPrimitiveType uint uint uint UInt32
    // 050 AllocPage                                000186714250 ModelClassType Page Page Page Pointer
    // 058 AllocTime                                000186698DF0 ModelPrimitiveType uint uint uint UInt32
    // 05C UpdateAllocID                            000186698DF0 ModelPrimitiveType uint uint uint UInt32
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

            value.AllocVerts                                = (Alloc)GetInt32(new IntPtr(p + 0x018)); // 0245A68221B0 0x18 AllocVerts                  ( 0001865863D0 ModelEnumType Alloc Alloc Alloc Int32 )
            value.AllocIndices                              = (Alloc)GetInt32(new IntPtr(p + 0x030)); // 0245A68221D0 0x30 AllocIndices                ( 0001865863D0 ModelEnumType Alloc Alloc Alloc Int32 )
            value.TriangleCount                             = GetUInt32(new IntPtr(p + 0x048)); // 0245A68221F0 0x48 TriangleCount               ( 000186698DF0 ModelPrimitiveType uint uint uint UInt32 )
            value.AllocPage                                 = GetObject<Page>(new IntPtr(p + 0x050), ReversePrism.DataModels.Page.FromPointer); // 0245A6822210 0x50 AllocPage                   ( 000186714250 ModelClassType Page Page Page Pointer )
            value.AllocTime                                 = GetUInt32(new IntPtr(p + 0x058)); // 0245A6822230 0x58 AllocTime                   ( 000186698DF0 ModelPrimitiveType uint uint uint UInt32 )
            value.UpdateAllocID                             = GetUInt32(new IntPtr(p + 0x05C)); // 0245A6822250 0x5C UpdateAllocID               ( 000186698DF0 ModelPrimitiveType uint uint uint UInt32 )

            return value;
        }
    }
}
