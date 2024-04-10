using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 s_Blit                                   Material IL2CPP_TYPE_CLASS
    // 008 s_BlitTexArray                           Material IL2CPP_TYPE_CLASS
    // 010 S_BlitTexArraySingleSlice                00018660C770 ModelClassType Material Material Material Pointer
    // 018 S_BlitColorAndDepth                      00018660C770 ModelClassType Material Material Material Pointer
    // 020 S_PropertyBlock                          0001865E1490 ModelClassType MaterialPropertyBlock MaterialPropertyBlock MaterialPropertyBlock Pointer
    // 028 S_TriangleMesh                           000186610B40 ModelClassType Mesh Mesh Mesh Pointer
    // 030 S_QuadMesh                               000186610B40 ModelClassType Mesh Mesh Mesh Pointer
    // 038 S_DecodeHdrKeyword                       000186608C70 ModelEnumType LocalKeyword LocalKeyword LocalKeyword Int32
    public partial class Blitter : DataModel
    {
        public Material?                                S_BlitTexArraySingleSlice               { get; set; }
        public Material?                                S_BlitColorAndDepth                     { get; set; }
        public MaterialPropertyBlock?                   S_PropertyBlock                         { get; set; }
        public Mesh?                                    S_TriangleMesh                          { get; set; }
        public Mesh?                                    S_QuadMesh                              { get; set; }
        public LocalKeyword                             S_DecodeHdrKeyword                      { get; set; }

        public static Blitter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Blitter() { Pointer= p0 };

            value.S_BlitTexArraySingleSlice                 = GetObject<Material>(new IntPtr(p + 0x010), ReversePrism.DataModels.Material.FromPointer); // 02466930B578 0x10 S_BlitTexArraySingleSlice   ( 00018660C770 ModelClassType Material Material Material Pointer )
            value.S_BlitColorAndDepth                       = GetObject<Material>(new IntPtr(p + 0x018), ReversePrism.DataModels.Material.FromPointer); // 02466930B598 0x18 S_BlitColorAndDepth         ( 00018660C770 ModelClassType Material Material Material Pointer )
            value.S_PropertyBlock                           = GetObject<MaterialPropertyBlock>(new IntPtr(p + 0x020), ReversePrism.DataModels.MaterialPropertyBlock.FromPointer); // 02466930B5B8 0x20 S_PropertyBlock             ( 0001865E1490 ModelClassType MaterialPropertyBlock MaterialPropertyBlock MaterialPropertyBlock Pointer )
            value.S_TriangleMesh                            = GetObject<Mesh>(new IntPtr(p + 0x028), ReversePrism.DataModels.Mesh.FromPointer); // 02466930B5D8 0x28 S_TriangleMesh              ( 000186610B40 ModelClassType Mesh Mesh Mesh Pointer )
            value.S_QuadMesh                                = GetObject<Mesh>(new IntPtr(p + 0x030), ReversePrism.DataModels.Mesh.FromPointer); // 02466930B5F8 0x30 S_QuadMesh                  ( 000186610B40 ModelClassType Mesh Mesh Mesh Pointer )
            value.S_DecodeHdrKeyword                        = (LocalKeyword)GetInt32(new IntPtr(p + 0x038)); // 02466930B618 0x38 S_DecodeHdrKeyword          ( 000186608C70 ModelEnumType LocalKeyword LocalKeyword LocalKeyword Int32 )

            return value;
        }
    }
}
