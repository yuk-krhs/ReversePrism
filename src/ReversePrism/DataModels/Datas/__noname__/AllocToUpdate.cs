using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Id                                       0001866992B0 ModelPrimitiveType uint uint uint UInt32
    // 014 AllocTime                                0001866992B0 ModelPrimitiveType uint uint uint UInt32
    // 018 MeshHandle                               000186611EA0 ModelClassType MeshHandle MeshHandle MeshHandle Pointer
    // 020 PermAllocVerts                           0001865866A0 ModelEnumType Alloc Alloc Alloc Int32
    // 038 PermAllocIndices                         0001865866A0 ModelEnumType Alloc Alloc Alloc Int32
    // 050 PermPage                                 0001867144C0 ModelClassType Page Page Page Pointer
    // 058 CopyBackIndices                          000186595960 ModelPrimitiveType bool bool bool Bool
    public partial class AllocToUpdate
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
            var value   = new AllocToUpdate();

            value.Id                                        = GetUInt32(new IntPtr(p + 0x010)); // 0270068603E0 0x10 Id                          ( 0001866992B0 ModelPrimitiveType uint uint uint UInt32 )
            value.AllocTime                                 = GetUInt32(new IntPtr(p + 0x014)); // 027006860400 0x14 AllocTime                   ( 0001866992B0 ModelPrimitiveType uint uint uint UInt32 )
            value.MeshHandle                                = GetObject<MeshHandle>(new IntPtr(p + 0x018), ReversePrism.DataModels.MeshHandle.FromPointer); // 027006860420 0x18 MeshHandle                  ( 000186611EA0 ModelClassType MeshHandle MeshHandle MeshHandle Pointer )
            value.PermAllocVerts                            = (Alloc)GetInt32(new IntPtr(p + 0x020)); // 027006860440 0x20 PermAllocVerts              ( 0001865866A0 ModelEnumType Alloc Alloc Alloc Int32 )
            value.PermAllocIndices                          = (Alloc)GetInt32(new IntPtr(p + 0x038)); // 027006860460 0x38 PermAllocIndices            ( 0001865866A0 ModelEnumType Alloc Alloc Alloc Int32 )
            value.PermPage                                  = GetObject<Page>(new IntPtr(p + 0x050), ReversePrism.DataModels.Page.FromPointer); // 027006860480 0x50 PermPage                    ( 0001867144C0 ModelClassType Page Page Page Pointer )
            value.CopyBackIndices                           = GetBool(new IntPtr(p + 0x058)); // 0270068604A0 0x58 CopyBackIndices             ( 000186595960 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
