using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 ioReverseSolution                        int IL2CPP_TYPE_I4
    // 000 ioStrictlySimple                         int IL2CPP_TYPE_I4
    // 000 ioPreserveCollinear                      int IL2CPP_TYPE_I4
    // 048 M_ClipType                               ModelEnumType ClipType ClipType ClipType Int32
    // 050 M_Maxima                                 ModelClassType Maxima Maxima Maxima Pointer
    // 058 M_SortedEdges                            ModelClassType TEdge TEdge TEdge Pointer
    // 060 M_IntersectList                          ModelClassListType List`1<IntersectNode> List`1<IntersectNode> List<IntersectNode> Pointer
    // 068 m_IntersectNodeComparer                  IComparer`1<IntersectNode> IL2CPP_TYPE_GENERICINST
    // 070 M_ExecuteLocked                          ModelPrimitiveType bool bool bool Bool
    // 074 M_ClipFillType                           ModelEnumType PolyFillType PolyFillType PolyFillType Int32
    // 078 M_SubjFillType                           ModelEnumType PolyFillType PolyFillType PolyFillType Int32
    // 080 M_Joins                                  ModelClassListType List`1<Join> List`1<Join> List<Join> Pointer
    // 088 M_GhostJoins                             ModelClassListType List`1<Join> List`1<Join> List<Join> Pointer
    // 090 M_UsingPolyTree                          ModelPrimitiveType bool bool bool Bool
    // 094 LastIndex                                ModelPrimitiveType int int int Int32
    // 098 ReverseSolution                          ModelPrimitiveType bool bool bool Bool
    // 099 StrictlySimple                           ModelPrimitiveType bool bool bool Bool
    public partial class Clipper : DataModel
    {
        public ClipType                                 M_ClipType                              { get; set; }
        public Maxima?                                  M_Maxima                                { get; set; }
        public TEdge?                                   M_SortedEdges                           { get; set; }
        public List<IntersectNode>?                     M_IntersectList                         { get; set; }
        public bool                                     M_ExecuteLocked                         { get; set; }
        public PolyFillType                             M_ClipFillType                          { get; set; }
        public PolyFillType                             M_SubjFillType                          { get; set; }
        public List<Join>?                              M_Joins                                 { get; set; }
        public List<Join>?                              M_GhostJoins                            { get; set; }
        public bool                                     M_UsingPolyTree                         { get; set; }
        public int                                      LastIndex                               { get; set; }
        public bool                                     ReverseSolution                         { get; set; }
        public bool                                     StrictlySimple                          { get; set; }

        public static Clipper? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Clipper() { Pointer= p0 };

            value.M_ClipType                                = (ClipType)GetInt32(new IntPtr(p + 0x048)); // 0x48 M_ClipType                  ( ModelEnumType ClipType ClipType ClipType Int32 )
            value.M_Maxima                                  = GetObject<Maxima>(new IntPtr(p + 0x050), ReversePrism.DataModels.Maxima.FromPointer); // 0x50 M_Maxima                    ( ModelClassType Maxima Maxima Maxima Pointer )
            value.M_SortedEdges                             = GetObject<TEdge>(new IntPtr(p + 0x058), ReversePrism.DataModels.TEdge.FromPointer); // 0x58 M_SortedEdges               ( ModelClassType TEdge TEdge TEdge Pointer )
            value.M_IntersectList                           = GetObjectList<IntersectNode>(new IntPtr(p + 0x060), ReversePrism.DataModels.IntersectNode.FromPointer); // 0x60 M_IntersectList             ( ModelClassListType List`1<IntersectNode> List`1<IntersectNode> List<IntersectNode> Pointer )
            value.M_ExecuteLocked                           = GetBool(new IntPtr(p + 0x070)); // 0x70 M_ExecuteLocked             ( ModelPrimitiveType bool bool bool Bool )
            value.M_ClipFillType                            = (PolyFillType)GetInt32(new IntPtr(p + 0x074)); // 0x74 M_ClipFillType              ( ModelEnumType PolyFillType PolyFillType PolyFillType Int32 )
            value.M_SubjFillType                            = (PolyFillType)GetInt32(new IntPtr(p + 0x078)); // 0x78 M_SubjFillType              ( ModelEnumType PolyFillType PolyFillType PolyFillType Int32 )
            value.M_Joins                                   = GetObjectList<Join>(new IntPtr(p + 0x080), ReversePrism.DataModels.Join.FromPointer); // 0x80 M_Joins                     ( ModelClassListType List`1<Join> List`1<Join> List<Join> Pointer )
            value.M_GhostJoins                              = GetObjectList<Join>(new IntPtr(p + 0x088), ReversePrism.DataModels.Join.FromPointer); // 0x88 M_GhostJoins                ( ModelClassListType List`1<Join> List`1<Join> List<Join> Pointer )
            value.M_UsingPolyTree                           = GetBool(new IntPtr(p + 0x090)); // 0x90 M_UsingPolyTree             ( ModelPrimitiveType bool bool bool Bool )
            value.LastIndex                                 = GetInt32(new IntPtr(p + 0x094)); // 0x94 LastIndex                   ( ModelPrimitiveType int int int Int32 )
            value.ReverseSolution                           = GetBool(new IntPtr(p + 0x098)); // 0x98 ReverseSolution             ( ModelPrimitiveType bool bool bool Bool )
            value.StrictlySimple                            = GetBool(new IntPtr(p + 0x099)); // 0x99 StrictlySimple              ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
