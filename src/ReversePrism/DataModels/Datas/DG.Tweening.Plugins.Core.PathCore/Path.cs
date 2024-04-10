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

            value.CubicBezierDecoder                        = GetObject<CubicBezierDecoder>(new IntPtr(p + 0x010), ReversePrism.DataModels.CubicBezierDecoder.FromPointer); // 02466B0FCB88 0x10 CubicBezierDecoder          ( 0001866632E0 ModelClassType CubicBezierDecoder CubicBezierDecoder CubicBezierDecoder Pointer )
            value.WpLengths                                 = GetSingleList(new IntPtr(p + 0x010)); // 02466B0FCBA8 0x10 WpLengths                   ( 000185B80920 ModelPrimitiveListType float[] float[] List<float> Pointer )
            value.Type                                      = (PathType)GetInt32(new IntPtr(p + 0x018)); // 02466B0FCBC8 0x18 Type                        ( 00018672A430 ModelEnumType PathType PathType PathType Int32 )
            value.SubdivisionsXSegment                      = GetInt32(new IntPtr(p + 0x01C)); // 02466B0FCBE8 0x1C SubdivisionsXSegment        ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.Subdivisions                              = GetInt32(new IntPtr(p + 0x020)); // 02466B0FCC08 0x20 Subdivisions                ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.Wps                                       = GetEnumList<Vector3>(new IntPtr(p + 0x028)); // 02466B0FCC28 0x28 Wps                         ( 000185CB0CD8 ModelEnumListType Vector3[] Vector3[] List<Vector3> Pointer )
            value.ControlPoints                             = GetEnumList<ControlPoint>(new IntPtr(p + 0x030)); // 02466B0FCC48 0x30 ControlPoints               ( 000185B77500 ModelEnumListType ControlPoint[] ControlPoint[] List<ControlPoint> Pointer )
            value.Length                                    = GetSingle(new IntPtr(p + 0x038)); // 02466B0FCC68 0x38 Length                      ( 000186665900 ModelPrimitiveType float float float Single )
            value.IsFinalized                               = GetBool(new IntPtr(p + 0x03C)); // 02466B0FCC88 0x3C IsFinalized                 ( 000186595210 ModelPrimitiveType bool bool bool Bool )
            value.TimesTable                                = GetSingleList(new IntPtr(p + 0x040)); // 02466B0FCCA8 0x40 TimesTable                  ( 000185B80710 ModelPrimitiveListType float[] float[] List<float> Pointer )
            value.LengthsTable                              = GetSingleList(new IntPtr(p + 0x048)); // 02466B0FCCC8 0x48 LengthsTable                ( 000185B80710 ModelPrimitiveListType float[] float[] List<float> Pointer )
            value.LinearWPIndex                             = GetInt32(new IntPtr(p + 0x050)); // 02466B0FCCE8 0x50 LinearWPIndex               ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.AddedExtraStartWp                         = GetBool(new IntPtr(p + 0x054)); // 02466B0FCD08 0x54 AddedExtraStartWp           ( 000186595210 ModelPrimitiveType bool bool bool Bool )
            value.AddedExtraEndWp                           = GetBool(new IntPtr(p + 0x055)); // 02466B0FCD28 0x55 AddedExtraEndWp             ( 000186595210 ModelPrimitiveType bool bool bool Bool )
            value.IncrementalClone                          = GetObject<Path>(new IntPtr(p + 0x058), ReversePrism.DataModels.Path.FromPointer); // 02466B0FCD48 0x58 IncrementalClone            ( 000186728530 ModelClassType Path Path Path Pointer )
            value.IncrementalIndex                          = GetInt32(new IntPtr(p + 0x060)); // 02466B0FCD68 0x60 IncrementalIndex            ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Decoder                                   = GetObject<ABSPathDecoder>(new IntPtr(p + 0x068), ReversePrism.DataModels.ABSPathDecoder.FromPointer); // 02466B0FCD88 0x68 Decoder                     ( 0001866615D0 ModelClassType ABSPathDecoder ABSPathDecoder ABSPathDecoder Pointer )
            value.Changed                                   = GetBool(new IntPtr(p + 0x070)); // 02466B0FCDA8 0x70 Changed                     ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.NonLinearDrawWps                          = GetEnumList<Vector3>(new IntPtr(p + 0x078)); // 02466B0FCDC8 0x78 NonLinearDrawWps            ( 000185CB0CD8 ModelEnumListType Vector3[] Vector3[] List<Vector3> Pointer )
            value.TargetPosition                            = (Vector3)GetInt32(new IntPtr(p + 0x080)); // 02466B0FCDE8 0x80 TargetPosition              ( 0001866ABA80 ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.GizmoColor                                = (Color)GetInt32(new IntPtr(p + 0x09C)); // 02466B0FCE28 0x9C GizmoColor                  ( 0001865AABD0 ModelEnumType Color Color Color Int32 )

            return value;
        }
    }
}
