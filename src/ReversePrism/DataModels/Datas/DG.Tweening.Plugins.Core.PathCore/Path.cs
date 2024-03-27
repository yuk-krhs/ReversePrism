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
    // 010 CubicBezierDecoder                       0001866632E0 ModelClassType CubicBezierDecoder CubicBezierDecoder CubicBezierDecoder Pointer
    // 010 WpLengths                                000185B80920 ModelPrimitiveListType float[] float[] List<float> Pointer
    // 018 Type                                     00018672A430 ModelEnumType PathType PathType PathType Int32
    // 01C SubdivisionsXSegment                     0001865F2F90 ModelPrimitiveType int int int Int32
    // 020 Subdivisions                             0001865F2F90 ModelPrimitiveType int int int Int32
    // 028 Wps                                      000185CB0CD8 ModelEnumListType Vector3[] Vector3[] List<Vector3> Pointer
    // 030 ControlPoints                            000185B77500 ModelEnumListType ControlPoint[] ControlPoint[] List<ControlPoint> Pointer
    // 038 Length                                   000186665900 ModelPrimitiveType float float float Single
    // 03C IsFinalized                              000186595210 ModelPrimitiveType bool bool bool Bool
    // 040 TimesTable                               000185B80710 ModelPrimitiveListType float[] float[] List<float> Pointer
    // 048 LengthsTable                             000185B80710 ModelPrimitiveListType float[] float[] List<float> Pointer
    // 050 LinearWPIndex                            0001865F2F90 ModelPrimitiveType int int int Int32
    // 054 AddedExtraStartWp                        000186595210 ModelPrimitiveType bool bool bool Bool
    // 055 AddedExtraEndWp                          000186595210 ModelPrimitiveType bool bool bool Bool
    // 058 IncrementalClone                         000186728530 ModelClassType Path Path Path Pointer
    // 060 IncrementalIndex                         0001865F2AF0 ModelPrimitiveType int int int Int32
    // 068 Decoder                                  0001866615D0 ModelClassType ABSPathDecoder ABSPathDecoder ABSPathDecoder Pointer
    // 070 Changed                                  000186594D10 ModelPrimitiveType bool bool bool Bool
    // 078 NonLinearDrawWps                         000185CB0CD8 ModelEnumListType Vector3[] Vector3[] List<Vector3> Pointer
    // 080 TargetPosition                           0001866ABA80 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 08C lookAtPosition                           Nullable`1<Vector3> IL2CPP_TYPE_GENERICINST
    // 09C GizmoColor                               0001865AABD0 ModelEnumType Color Color Color Int32
    public partial class Path
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
            var value   = new Path();

            value.CubicBezierDecoder                        = GetObject<CubicBezierDecoder>(new IntPtr(p + 0x010), ReversePrism.DataModels.CubicBezierDecoder.FromPointer); // 0270DB09CB88 0x10 CubicBezierDecoder          ( 0001866632E0 ModelClassType CubicBezierDecoder CubicBezierDecoder CubicBezierDecoder Pointer )
            value.WpLengths                                 = GetSingleList(new IntPtr(p + 0x010)); // 0270DB09CBA8 0x10 WpLengths                   ( 000185B80920 ModelPrimitiveListType float[] float[] List<float> Pointer )
            value.Type                                      = (PathType)GetInt32(new IntPtr(p + 0x018)); // 0270DB09CBC8 0x18 Type                        ( 00018672A430 ModelEnumType PathType PathType PathType Int32 )
            value.SubdivisionsXSegment                      = GetInt32(new IntPtr(p + 0x01C)); // 0270DB09CBE8 0x1C SubdivisionsXSegment        ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.Subdivisions                              = GetInt32(new IntPtr(p + 0x020)); // 0270DB09CC08 0x20 Subdivisions                ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.Wps                                       = GetEnumList<Vector3>(new IntPtr(p + 0x028)); // 0270DB09CC28 0x28 Wps                         ( 000185CB0CD8 ModelEnumListType Vector3[] Vector3[] List<Vector3> Pointer )
            value.ControlPoints                             = GetEnumList<ControlPoint>(new IntPtr(p + 0x030)); // 0270DB09CC48 0x30 ControlPoints               ( 000185B77500 ModelEnumListType ControlPoint[] ControlPoint[] List<ControlPoint> Pointer )
            value.Length                                    = GetSingle(new IntPtr(p + 0x038)); // 0270DB09CC68 0x38 Length                      ( 000186665900 ModelPrimitiveType float float float Single )
            value.IsFinalized                               = GetBool(new IntPtr(p + 0x03C)); // 0270DB09CC88 0x3C IsFinalized                 ( 000186595210 ModelPrimitiveType bool bool bool Bool )
            value.TimesTable                                = GetSingleList(new IntPtr(p + 0x040)); // 0270DB09CCA8 0x40 TimesTable                  ( 000185B80710 ModelPrimitiveListType float[] float[] List<float> Pointer )
            value.LengthsTable                              = GetSingleList(new IntPtr(p + 0x048)); // 0270DB09CCC8 0x48 LengthsTable                ( 000185B80710 ModelPrimitiveListType float[] float[] List<float> Pointer )
            value.LinearWPIndex                             = GetInt32(new IntPtr(p + 0x050)); // 0270DB09CCE8 0x50 LinearWPIndex               ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.AddedExtraStartWp                         = GetBool(new IntPtr(p + 0x054)); // 0270DB09CD08 0x54 AddedExtraStartWp           ( 000186595210 ModelPrimitiveType bool bool bool Bool )
            value.AddedExtraEndWp                           = GetBool(new IntPtr(p + 0x055)); // 0270DB09CD28 0x55 AddedExtraEndWp             ( 000186595210 ModelPrimitiveType bool bool bool Bool )
            value.IncrementalClone                          = GetObject<Path>(new IntPtr(p + 0x058), ReversePrism.DataModels.Path.FromPointer); // 0270DB09CD48 0x58 IncrementalClone            ( 000186728530 ModelClassType Path Path Path Pointer )
            value.IncrementalIndex                          = GetInt32(new IntPtr(p + 0x060)); // 0270DB09CD68 0x60 IncrementalIndex            ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Decoder                                   = GetObject<ABSPathDecoder>(new IntPtr(p + 0x068), ReversePrism.DataModels.ABSPathDecoder.FromPointer); // 0270DB09CD88 0x68 Decoder                     ( 0001866615D0 ModelClassType ABSPathDecoder ABSPathDecoder ABSPathDecoder Pointer )
            value.Changed                                   = GetBool(new IntPtr(p + 0x070)); // 0270DB09CDA8 0x70 Changed                     ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.NonLinearDrawWps                          = GetEnumList<Vector3>(new IntPtr(p + 0x078)); // 0270DB09CDC8 0x78 NonLinearDrawWps            ( 000185CB0CD8 ModelEnumListType Vector3[] Vector3[] List<Vector3> Pointer )
            value.TargetPosition                            = (Vector3)GetInt32(new IntPtr(p + 0x080)); // 0270DB09CDE8 0x80 TargetPosition              ( 0001866ABA80 ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.GizmoColor                                = (Color)GetInt32(new IntPtr(p + 0x09C)); // 0270DB09CE28 0x9C GizmoColor                  ( 0001865AABD0 ModelEnumType Color Color Color Int32 )

            return value;
        }
    }
}
