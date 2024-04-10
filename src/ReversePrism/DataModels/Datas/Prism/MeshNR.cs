using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 id_counter                               int IL2CPP_TYPE_I4
    // 010 Id                                       0001865F4940 ModelPrimitiveType int int int Int32
    // 018 Cyasubs                                  000185B81830 ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer
    // 020 Filters                                  000185B93500 ModelClassListType MeshFilter[] MeshFilter[] List<MeshFilter> Pointer
    // 028 CyabaseTra                               0001866AADB0 ModelClassType Transform Transform Transform Pointer
    // 008 camTra                                   Transform IL2CPP_TYPE_CLASS
    // 030 VertexCountC                             0001865F4940 ModelPrimitiveType int int int Int32
    // 034 VertexCountS                             0001865F4940 ModelPrimitiveType int int int Int32
    // 038 Meshes                                   000185B93300 ModelClassListType Mesh[] Mesh[] List<Mesh> Pointer
    // 040 CurPtr                                   0001865F2AF0 ModelPrimitiveType int int int Int32
    // 044 Ready                                    000186594D10 ModelPrimitiveType bool bool bool Bool
    // 045 HasNR                                    000186594D10 ModelPrimitiveType bool bool bool Bool
    // 046 IsReadable                               000186595960 ModelPrimitiveType bool bool bool Bool
    public partial class MeshNR : DataModel
    {
        public int                                      Id                                      { get; set; }
        public List<GameObject>?                        Cyasubs                                 { get; set; }
        public List<MeshFilter>?                        Filters                                 { get; set; }
        public Transform?                               CyabaseTra                              { get; set; }
        public int                                      VertexCountC                            { get; set; }
        public int                                      VertexCountS                            { get; set; }
        public List<Mesh>?                              Meshes                                  { get; set; }
        public int                                      CurPtr                                  { get; set; }
        public bool                                     Ready                                   { get; set; }
        public bool                                     HasNR                                   { get; set; }
        public bool                                     IsReadable                              { get; set; }

        public static MeshNR? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MeshNR() { Pointer= p0 };

            value.Id                                        = GetInt32(new IntPtr(p + 0x010)); // 024664EC78A0 0x10 Id                          ( 0001865F4940 ModelPrimitiveType int int int Int32 )
            value.Cyasubs                                   = GetObjectList<GameObject>(new IntPtr(p + 0x018), ReversePrism.DataModels.GameObject.FromPointer); // 024664EC78C0 0x18 Cyasubs                     ( 000185B81830 ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer )
            value.Filters                                   = GetObjectList<MeshFilter>(new IntPtr(p + 0x020), ReversePrism.DataModels.MeshFilter.FromPointer); // 024664EC78E0 0x20 Filters                     ( 000185B93500 ModelClassListType MeshFilter[] MeshFilter[] List<MeshFilter> Pointer )
            value.CyabaseTra                                = GetObject<Transform>(new IntPtr(p + 0x028), ReversePrism.DataModels.Transform.FromPointer); // 024664EC7900 0x28 CyabaseTra                  ( 0001866AADB0 ModelClassType Transform Transform Transform Pointer )
            value.VertexCountC                              = GetInt32(new IntPtr(p + 0x030)); // 024664EC7940 0x30 VertexCountC                ( 0001865F4940 ModelPrimitiveType int int int Int32 )
            value.VertexCountS                              = GetInt32(new IntPtr(p + 0x034)); // 024664EC7960 0x34 VertexCountS                ( 0001865F4940 ModelPrimitiveType int int int Int32 )
            value.Meshes                                    = GetObjectList<Mesh>(new IntPtr(p + 0x038), ReversePrism.DataModels.Mesh.FromPointer); // 024664EC7980 0x38 Meshes                      ( 000185B93300 ModelClassListType Mesh[] Mesh[] List<Mesh> Pointer )
            value.CurPtr                                    = GetInt32(new IntPtr(p + 0x040)); // 024664EC79A0 0x40 CurPtr                      ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Ready                                     = GetBool(new IntPtr(p + 0x044)); // 024664EC79C0 0x44 Ready                       ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.HasNR                                     = GetBool(new IntPtr(p + 0x045)); // 024664EC79E0 0x45 HasNR                       ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsReadable                                = GetBool(new IntPtr(p + 0x046)); // 024664EC7A00 0x46 IsReadable                  ( 000186595960 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
