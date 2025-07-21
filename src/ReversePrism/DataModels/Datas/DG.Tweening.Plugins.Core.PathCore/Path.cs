using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _catmullRomDecoder                       CatmullRomDecoder IL2CPP_TYPE_CLASS
    // 008 _linearDecoder                           LinearDecoder IL2CPP_TYPE_CLASS
    // 010 CubicBezierDecoder                       ModelClassType CubicBezierDecoder CubicBezierDecoder CubicBezierDecoder Pointer
    // 010 WpLengths                                ModelPrimitiveListType float[] float[] List<float> Pointer
    // 018 Type                                     ModelEnumType PathType PathType PathType Int32
    // 01C SubdivisionsXSegment                     ModelPrimitiveType int int int Int32
    // 020 Subdivisions                             ModelPrimitiveType int int int Int32
    // 028 Wps                                      ModelEnumListType Vector3[] Vector3[] List<Vector3> Pointer
    // 030 ControlPoints                            ModelEnumListType ControlPoint[] ControlPoint[] List<ControlPoint> Pointer
    // 038 Length                                   ModelPrimitiveType float float float Single
    // 03C IsFinalized                              ModelPrimitiveType bool bool bool Bool
    // 040 TimesTable                               ModelPrimitiveListType float[] float[] List<float> Pointer
    // 048 LengthsTable                             ModelPrimitiveListType float[] float[] List<float> Pointer
    // 050 LinearWPIndex                            ModelPrimitiveType int int int Int32
    // 054 AddedExtraStartWp                        ModelPrimitiveType bool bool bool Bool
    // 055 AddedExtraEndWp                          ModelPrimitiveType bool bool bool Bool
    // 058 IncrementalClone                         ModelClassType Path Path Path Pointer
    // 060 IncrementalIndex                         ModelPrimitiveType int int int Int32
    // 068 Decoder                                  ModelClassType ABSPathDecoder ABSPathDecoder ABSPathDecoder Pointer
    // 070 Changed                                  ModelPrimitiveType bool bool bool Bool
    // 078 NonLinearDrawWps                         ModelEnumListType Vector3[] Vector3[] List<Vector3> Pointer
    // 080 TargetPosition                           ModelEnumType Vector3 Vector3 Vector3 Int32
    // 08C lookAtPosition                           Nullable`1<Vector3> IL2CPP_TYPE_GENERICINST
    // 09C GizmoColor                               ModelEnumType Color Color Color Int32
    public partial class Path : DataModel
    {
        public CubicBezierDecoder?                      CubicBezierDecoder                      { get; set; }
        public List<float>?                             WpLengths                               { get; set; }
        public PathType                                 Type                                    { get; set; }
        public int                                      SubdivisionsXSegment                    { get; set; }
        public int                                      Subdivisions                            { get; set; }
        public List<Vector3>?                           Wps                                     { get; set; }
        public List<ControlPoint>?                      ControlPoints                           { get; set; }
        public float                                    Length                                  { get; set; }
        public bool                                     IsFinalized                             { get; set; }
        public List<float>?                             TimesTable                              { get; set; }
        public List<float>?                             LengthsTable                            { get; set; }
        public int                                      LinearWPIndex                           { get; set; }
        public bool                                     AddedExtraStartWp                       { get; set; }
        public bool                                     AddedExtraEndWp                         { get; set; }
        public Path?                                    IncrementalClone                        { get; set; }
        public int                                      IncrementalIndex                        { get; set; }
        public ABSPathDecoder?                          Decoder                                 { get; set; }
        public bool                                     Changed                                 { get; set; }
        public List<Vector3>?                           NonLinearDrawWps                        { get; set; }
        public Vector3                                  TargetPosition                          { get; set; }
        public Color                                    GizmoColor                              { get; set; }

        public static Path? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Path() { Pointer= p0 };

            value.CubicBezierDecoder                        = GetObject<CubicBezierDecoder>(new IntPtr(p + 0x010), ReversePrism.DataModels.CubicBezierDecoder.FromPointer); // 0x10 CubicBezierDecoder          ( ModelClassType CubicBezierDecoder CubicBezierDecoder CubicBezierDecoder Pointer )
            value.WpLengths                                 = GetSingleList(new IntPtr(p + 0x010)); // 0x10 WpLengths                   ( ModelPrimitiveListType float[] float[] List<float> Pointer )
            value.Type                                      = (PathType)GetInt32(new IntPtr(p + 0x018)); // 0x18 Type                        ( ModelEnumType PathType PathType PathType Int32 )
            value.SubdivisionsXSegment                      = GetInt32(new IntPtr(p + 0x01C)); // 0x1C SubdivisionsXSegment        ( ModelPrimitiveType int int int Int32 )
            value.Subdivisions                              = GetInt32(new IntPtr(p + 0x020)); // 0x20 Subdivisions                ( ModelPrimitiveType int int int Int32 )
            value.Wps                                       = GetEnumList<Vector3>(new IntPtr(p + 0x028)); // 0x28 Wps                         ( ModelEnumListType Vector3[] Vector3[] List<Vector3> Pointer )
            value.ControlPoints                             = GetEnumList<ControlPoint>(new IntPtr(p + 0x030)); // 0x30 ControlPoints               ( ModelEnumListType ControlPoint[] ControlPoint[] List<ControlPoint> Pointer )
            value.Length                                    = GetSingle(new IntPtr(p + 0x038)); // 0x38 Length                      ( ModelPrimitiveType float float float Single )
            value.IsFinalized                               = GetBool(new IntPtr(p + 0x03C)); // 0x3C IsFinalized                 ( ModelPrimitiveType bool bool bool Bool )
            value.TimesTable                                = GetSingleList(new IntPtr(p + 0x040)); // 0x40 TimesTable                  ( ModelPrimitiveListType float[] float[] List<float> Pointer )
            value.LengthsTable                              = GetSingleList(new IntPtr(p + 0x048)); // 0x48 LengthsTable                ( ModelPrimitiveListType float[] float[] List<float> Pointer )
            value.LinearWPIndex                             = GetInt32(new IntPtr(p + 0x050)); // 0x50 LinearWPIndex               ( ModelPrimitiveType int int int Int32 )
            value.AddedExtraStartWp                         = GetBool(new IntPtr(p + 0x054)); // 0x54 AddedExtraStartWp           ( ModelPrimitiveType bool bool bool Bool )
            value.AddedExtraEndWp                           = GetBool(new IntPtr(p + 0x055)); // 0x55 AddedExtraEndWp             ( ModelPrimitiveType bool bool bool Bool )
            value.IncrementalClone                          = GetObject<Path>(new IntPtr(p + 0x058), ReversePrism.DataModels.Path.FromPointer); // 0x58 IncrementalClone            ( ModelClassType Path Path Path Pointer )
            value.IncrementalIndex                          = GetInt32(new IntPtr(p + 0x060)); // 0x60 IncrementalIndex            ( ModelPrimitiveType int int int Int32 )
            value.Decoder                                   = GetObject<ABSPathDecoder>(new IntPtr(p + 0x068), ReversePrism.DataModels.ABSPathDecoder.FromPointer); // 0x68 Decoder                     ( ModelClassType ABSPathDecoder ABSPathDecoder ABSPathDecoder Pointer )
            value.Changed                                   = GetBool(new IntPtr(p + 0x070)); // 0x70 Changed                     ( ModelPrimitiveType bool bool bool Bool )
            value.NonLinearDrawWps                          = GetEnumList<Vector3>(new IntPtr(p + 0x078)); // 0x78 NonLinearDrawWps            ( ModelEnumListType Vector3[] Vector3[] List<Vector3> Pointer )
            value.TargetPosition                            = (Vector3)GetInt32(new IntPtr(p + 0x080)); // 0x80 TargetPosition              ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.GizmoColor                                = (Color)GetInt32(new IntPtr(p + 0x09C)); // 0x9C GizmoColor                  ( ModelEnumType Color Color Color Int32 )

            return value;
        }
    }
}
