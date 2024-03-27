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
    public partial class MeshNR
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
            var value   = new MeshNR();

            value.Id                                        = GetInt32(new IntPtr(p + 0x010)); // 0270D4E52598 0x10 Id                          ( 0001865F4940 ModelPrimitiveType int int int Int32 )
            value.Cyasubs                                   = GetObjectList<GameObject>(new IntPtr(p + 0x018), ReversePrism.DataModels.GameObject.FromPointer); // 0270D4E525B8 0x18 Cyasubs                     ( 000185B81830 ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer )
            value.Filters                                   = GetObjectList<MeshFilter>(new IntPtr(p + 0x020), ReversePrism.DataModels.MeshFilter.FromPointer); // 0270D4E525D8 0x20 Filters                     ( 000185B93500 ModelClassListType MeshFilter[] MeshFilter[] List<MeshFilter> Pointer )
            value.CyabaseTra                                = GetObject<Transform>(new IntPtr(p + 0x028), ReversePrism.DataModels.Transform.FromPointer); // 0270D4E525F8 0x28 CyabaseTra                  ( 0001866AADB0 ModelClassType Transform Transform Transform Pointer )
            value.VertexCountC                              = GetInt32(new IntPtr(p + 0x030)); // 0270D4E52638 0x30 VertexCountC                ( 0001865F4940 ModelPrimitiveType int int int Int32 )
            value.VertexCountS                              = GetInt32(new IntPtr(p + 0x034)); // 0270D4E52658 0x34 VertexCountS                ( 0001865F4940 ModelPrimitiveType int int int Int32 )
            value.Meshes                                    = GetObjectList<Mesh>(new IntPtr(p + 0x038), ReversePrism.DataModels.Mesh.FromPointer); // 0270D4E52678 0x38 Meshes                      ( 000185B93300 ModelClassListType Mesh[] Mesh[] List<Mesh> Pointer )
            value.CurPtr                                    = GetInt32(new IntPtr(p + 0x040)); // 0270D4E52698 0x40 CurPtr                      ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Ready                                     = GetBool(new IntPtr(p + 0x044)); // 0270D4E526B8 0x44 Ready                       ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.HasNR                                     = GetBool(new IntPtr(p + 0x045)); // 0270D4E526D8 0x45 HasNR                       ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsReadable                                = GetBool(new IntPtr(p + 0x046)); // 0270D4E526F8 0x46 IsReadable                  ( 000186595960 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
