using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 id_counter                               int IL2CPP_TYPE_I4
    // 010 Id                                       ModelPrimitiveType int int int Int32
    // 018 Cyasubs                                  ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer
    // 020 Filters                                  ModelClassListType MeshFilter[] MeshFilter[] List<MeshFilter> Pointer
    // 028 CyabaseTra                               ModelClassType Transform Transform Transform Pointer
    // 008 camTra                                   Transform IL2CPP_TYPE_CLASS
    // 030 VertexCountC                             ModelPrimitiveType int int int Int32
    // 034 VertexCountS                             ModelPrimitiveType int int int Int32
    // 038 Meshes                                   ModelClassListType Mesh[] Mesh[] List<Mesh> Pointer
    // 040 CurPtr                                   ModelPrimitiveType int int int Int32
    // 044 Ready                                    ModelPrimitiveType bool bool bool Bool
    // 045 HasNR                                    ModelPrimitiveType bool bool bool Bool
    // 046 IsReadable                               ModelPrimitiveType bool bool bool Bool
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

            value.Id                                        = GetInt32(new IntPtr(p + 0x010)); // 0x10 Id                          ( ModelPrimitiveType int int int Int32 )
            value.Cyasubs                                   = GetObjectList<GameObject>(new IntPtr(p + 0x018), ReversePrism.DataModels.GameObject.FromPointer); // 0x18 Cyasubs                     ( ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer )
            value.Filters                                   = GetObjectList<MeshFilter>(new IntPtr(p + 0x020), ReversePrism.DataModels.MeshFilter.FromPointer); // 0x20 Filters                     ( ModelClassListType MeshFilter[] MeshFilter[] List<MeshFilter> Pointer )
            value.CyabaseTra                                = GetObject<Transform>(new IntPtr(p + 0x028), ReversePrism.DataModels.Transform.FromPointer); // 0x28 CyabaseTra                  ( ModelClassType Transform Transform Transform Pointer )
            value.VertexCountC                              = GetInt32(new IntPtr(p + 0x030)); // 0x30 VertexCountC                ( ModelPrimitiveType int int int Int32 )
            value.VertexCountS                              = GetInt32(new IntPtr(p + 0x034)); // 0x34 VertexCountS                ( ModelPrimitiveType int int int Int32 )
            value.Meshes                                    = GetObjectList<Mesh>(new IntPtr(p + 0x038), ReversePrism.DataModels.Mesh.FromPointer); // 0x38 Meshes                      ( ModelClassListType Mesh[] Mesh[] List<Mesh> Pointer )
            value.CurPtr                                    = GetInt32(new IntPtr(p + 0x040)); // 0x40 CurPtr                      ( ModelPrimitiveType int int int Int32 )
            value.Ready                                     = GetBool(new IntPtr(p + 0x044)); // 0x44 Ready                       ( ModelPrimitiveType bool bool bool Bool )
            value.HasNR                                     = GetBool(new IntPtr(p + 0x045)); // 0x45 HasNR                       ( ModelPrimitiveType bool bool bool Bool )
            value.IsReadable                                = GetBool(new IntPtr(p + 0x046)); // 0x46 IsReadable                  ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
