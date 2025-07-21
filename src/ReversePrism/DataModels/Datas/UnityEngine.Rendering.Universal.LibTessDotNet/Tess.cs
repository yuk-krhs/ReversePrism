using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Mesh                                     ModelClassType Mesh Mesh Mesh Pointer
    // 018 Normal                                   ModelEnumType Vec3 Vec3 Vec3 Int32
    // 024 SUnit                                    ModelEnumType Vec3 Vec3 Vec3 Int32
    // 030 TUnit                                    ModelEnumType Vec3 Vec3 Vec3 Int32
    // 03C BminX                                    ModelPrimitiveType float float float Single
    // 040 BminY                                    ModelPrimitiveType float float float Single
    // 044 BmaxX                                    ModelPrimitiveType float float float Single
    // 048 BmaxY                                    ModelPrimitiveType float float float Single
    // 04C WindingRule                              ModelEnumType WindingRule WindingRule WindingRule Int32
    // 050 _dict                                    Dict`1<ActiveRegion> IL2CPP_TYPE_GENERICINST
    // 058 _pq                                      PriorityQueue`1<Vertex> IL2CPP_TYPE_GENERICINST
    // 060 Event                                    ModelClassType Vertex Vertex Vertex Pointer
    // 068 CombineCallback                          ModelClassType CombineCallback CombineCallback CombineCallback Pointer
    // 070 Vertices                                 ModelEnumListType ContourVertex[] ContourVertex[] List<ContourVertex> Pointer
    // 078 VertexCount                              ModelPrimitiveType int int int Int32
    // 080 Elements                                 ModelPrimitiveListType int[] int[] List<int> Pointer
    // 088 ElementCount                             ModelPrimitiveType int int int Int32
    // 08C SUnitX                                   ModelPrimitiveType float float float Single
    // 090 SUnitY                                   ModelPrimitiveType float float float Single
    // 094 SentinelCoord                            ModelPrimitiveType float float float Single
    // 098 NoEmptyPolygons                          ModelPrimitiveType bool bool bool Bool
    // 099 UsePooling                               ModelPrimitiveType bool bool bool Bool
    public partial class Tess : DataModel
    {
        public Mesh?                                    Mesh                                    { get; set; }
        public Vec3                                     Normal                                  { get; set; }
        public Vec3                                     SUnit                                   { get; set; }
        public Vec3                                     TUnit                                   { get; set; }
        public float                                    BminX                                   { get; set; }
        public float                                    BminY                                   { get; set; }
        public float                                    BmaxX                                   { get; set; }
        public float                                    BmaxY                                   { get; set; }
        public WindingRule                              WindingRule                             { get; set; }
        public Vertex?                                  Event                                   { get; set; }
        public CombineCallback?                         CombineCallback                         { get; set; }
        public List<ContourVertex>?                     Vertices                                { get; set; }
        public int                                      VertexCount                             { get; set; }
        public List<int>?                               Elements                                { get; set; }
        public int                                      ElementCount                            { get; set; }
        public float                                    SUnitX                                  { get; set; }
        public float                                    SUnitY                                  { get; set; }
        public float                                    SentinelCoord                           { get; set; }
        public bool                                     NoEmptyPolygons                         { get; set; }
        public bool                                     UsePooling                              { get; set; }

        public static Tess? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Tess() { Pointer= p0 };

            value.Mesh                                      = GetObject<Mesh>(new IntPtr(p + 0x010), ReversePrism.DataModels.Mesh.FromPointer); // 0x10 Mesh                        ( ModelClassType Mesh Mesh Mesh Pointer )
            value.Normal                                    = (Vec3)GetInt32(new IntPtr(p + 0x018)); // 0x18 Normal                      ( ModelEnumType Vec3 Vec3 Vec3 Int32 )
            value.SUnit                                     = (Vec3)GetInt32(new IntPtr(p + 0x024)); // 0x24 SUnit                       ( ModelEnumType Vec3 Vec3 Vec3 Int32 )
            value.TUnit                                     = (Vec3)GetInt32(new IntPtr(p + 0x030)); // 0x30 TUnit                       ( ModelEnumType Vec3 Vec3 Vec3 Int32 )
            value.BminX                                     = GetSingle(new IntPtr(p + 0x03C)); // 0x3C BminX                       ( ModelPrimitiveType float float float Single )
            value.BminY                                     = GetSingle(new IntPtr(p + 0x040)); // 0x40 BminY                       ( ModelPrimitiveType float float float Single )
            value.BmaxX                                     = GetSingle(new IntPtr(p + 0x044)); // 0x44 BmaxX                       ( ModelPrimitiveType float float float Single )
            value.BmaxY                                     = GetSingle(new IntPtr(p + 0x048)); // 0x48 BmaxY                       ( ModelPrimitiveType float float float Single )
            value.WindingRule                               = (WindingRule)GetInt32(new IntPtr(p + 0x04C)); // 0x4C WindingRule                 ( ModelEnumType WindingRule WindingRule WindingRule Int32 )
            value.Event                                     = GetObject<Vertex>(new IntPtr(p + 0x060), ReversePrism.DataModels.Vertex.FromPointer); // 0x60 Event                       ( ModelClassType Vertex Vertex Vertex Pointer )
            value.CombineCallback                           = GetObject<CombineCallback>(new IntPtr(p + 0x068), ReversePrism.DataModels.CombineCallback.FromPointer); // 0x68 CombineCallback             ( ModelClassType CombineCallback CombineCallback CombineCallback Pointer )
            value.Vertices                                  = GetEnumList<ContourVertex>(new IntPtr(p + 0x070)); // 0x70 Vertices                    ( ModelEnumListType ContourVertex[] ContourVertex[] List<ContourVertex> Pointer )
            value.VertexCount                               = GetInt32(new IntPtr(p + 0x078)); // 0x78 VertexCount                 ( ModelPrimitiveType int int int Int32 )
            value.Elements                                  = GetInt32List(new IntPtr(p + 0x080)); // 0x80 Elements                    ( ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.ElementCount                              = GetInt32(new IntPtr(p + 0x088)); // 0x88 ElementCount                ( ModelPrimitiveType int int int Int32 )
            value.SUnitX                                    = GetSingle(new IntPtr(p + 0x08C)); // 0x8C SUnitX                      ( ModelPrimitiveType float float float Single )
            value.SUnitY                                    = GetSingle(new IntPtr(p + 0x090)); // 0x90 SUnitY                      ( ModelPrimitiveType float float float Single )
            value.SentinelCoord                             = GetSingle(new IntPtr(p + 0x094)); // 0x94 SentinelCoord               ( ModelPrimitiveType float float float Single )
            value.NoEmptyPolygons                           = GetBool(new IntPtr(p + 0x098)); // 0x98 NoEmptyPolygons             ( ModelPrimitiveType bool bool bool Bool )
            value.UsePooling                                = GetBool(new IntPtr(p + 0x099)); // 0x99 UsePooling                  ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
