using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Id                                       ModelPrimitiveType uint uint uint UInt32
    // 014 AllocTime                                ModelPrimitiveType uint uint uint UInt32
    // 018 MeshHandle                               ModelClassType MeshHandle MeshHandle MeshHandle Pointer
    // 020 PermAllocVerts                           ModelEnumType Alloc Alloc Alloc Int32
    // 038 PermAllocIndices                         ModelEnumType Alloc Alloc Alloc Int32
    // 050 PermPage                                 ModelClassType Page Page Page Pointer
    // 058 CopyBackIndices                          ModelPrimitiveType bool bool bool Bool
    public partial class AllocToUpdate : DataModel
    {
        public uint                                     Id                                      { get; set; }
        public uint                                     AllocTime                               { get; set; }
        public MeshHandle?                              MeshHandle                              { get; set; }
        public Alloc                                    PermAllocVerts                          { get; set; }
        public Alloc                                    PermAllocIndices                        { get; set; }
        public Page?                                    PermPage                                { get; set; }
        public bool                                     CopyBackIndices                         { get; set; }

        public static AllocToUpdate? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AllocToUpdate() { Pointer= p0 };

            value.Id                                        = GetUInt32(new IntPtr(p + 0x010)); // 0x10 Id                          ( ModelPrimitiveType uint uint uint UInt32 )
            value.AllocTime                                 = GetUInt32(new IntPtr(p + 0x014)); // 0x14 AllocTime                   ( ModelPrimitiveType uint uint uint UInt32 )
            value.MeshHandle                                = GetObject<MeshHandle>(new IntPtr(p + 0x018), ReversePrism.DataModels.MeshHandle.FromPointer); // 0x18 MeshHandle                  ( ModelClassType MeshHandle MeshHandle MeshHandle Pointer )
            value.PermAllocVerts                            = (Alloc)GetInt32(new IntPtr(p + 0x020)); // 0x20 PermAllocVerts              ( ModelEnumType Alloc Alloc Alloc Int32 )
            value.PermAllocIndices                          = (Alloc)GetInt32(new IntPtr(p + 0x038)); // 0x38 PermAllocIndices            ( ModelEnumType Alloc Alloc Alloc Int32 )
            value.PermPage                                  = GetObject<Page>(new IntPtr(p + 0x050), ReversePrism.DataModels.Page.FromPointer); // 0x50 PermPage                    ( ModelClassType Page Page Page Pointer )
            value.CopyBackIndices                           = GetBool(new IntPtr(p + 0x058)); // 0x58 CopyBackIndices             ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
