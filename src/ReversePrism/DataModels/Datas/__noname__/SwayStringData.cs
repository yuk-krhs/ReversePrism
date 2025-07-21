using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Fp                                       ModelEnumType ForceParam ForceParam ForceParam Int32
    // 028 Point_start                              ModelPrimitiveType int int int Int32
    // 02C Point_count                              ModelPrimitiveType int int int Int32
    // 030 Dtime                                    ModelPrimitiveType float float float Single
    // 034 BaseMove                                 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 040 WindVector                               ModelEnumType Vector3 Vector3 Vector3 Int32
    // 04C BaseMat                                  ModelEnumType Matrix4x4 Matrix4x4 Matrix4x4 Int32
    // 08C ChestConstaint                           ModelPrimitiveType int int int Int32
    // 090 CollideIdx                               ModelPrimitiveType int int int Int32
    // 094 CollideMinimum                           ModelPrimitiveType float float float Single
    // 098 AngleCap                                 ModelPrimitiveType int int int Int32
    // 09C AddCollideRoot                           ModelPrimitiveType float float float Single
    // 0A0 AddCollideEnd                            ModelPrimitiveType float float float Single
    // 0A4 Point0                                   ModelEnumType Point Point Point Int32
    // 19C Point1                                   ModelEnumType Point Point Point Int32
    // 294 Point2                                   ModelEnumType Point Point Point Int32
    // 38C Point3                                   ModelEnumType Point Point Point Int32
    // 484 Point4                                   ModelEnumType Point Point Point Int32
    // 57C Point5                                   ModelEnumType Point Point Point Int32
    // 674 Point6                                   ModelEnumType Point Point Point Int32
    // 76C Point7                                   ModelEnumType Point Point Point Int32
    // 864 Flag                                     ModelEnumType SwayStringFlag SwayStringFlag SwayStringFlag Int32
    public partial class SwayStringData : DataModel
    {
        public ForceParam                               Fp                                      { get; set; }
        public int                                      Point_start                             { get; set; }
        public int                                      Point_count                             { get; set; }
        public float                                    Dtime                                   { get; set; }
        public Vector3                                  BaseMove                                { get; set; }
        public Vector3                                  WindVector                              { get; set; }
        public Matrix4x4                                BaseMat                                 { get; set; }
        public int                                      ChestConstaint                          { get; set; }
        public int                                      CollideIdx                              { get; set; }
        public float                                    CollideMinimum                          { get; set; }
        public int                                      AngleCap                                { get; set; }
        public float                                    AddCollideRoot                          { get; set; }
        public float                                    AddCollideEnd                           { get; set; }
        public Point                                    Point0                                  { get; set; }
        public Point                                    Point1                                  { get; set; }
        public Point                                    Point2                                  { get; set; }
        public Point                                    Point3                                  { get; set; }
        public Point                                    Point4                                  { get; set; }
        public Point                                    Point5                                  { get; set; }
        public Point                                    Point6                                  { get; set; }
        public Point                                    Point7                                  { get; set; }
        public SwayStringFlag                           Flag                                    { get; set; }

        public static SwayStringData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SwayStringData() { Pointer= p0 };

            value.Fp                                        = (ForceParam)GetInt32(new IntPtr(p + 0x010)); // 0x10 Fp                          ( ModelEnumType ForceParam ForceParam ForceParam Int32 )
            value.Point_start                               = GetInt32(new IntPtr(p + 0x028)); // 0x28 Point_start                 ( ModelPrimitiveType int int int Int32 )
            value.Point_count                               = GetInt32(new IntPtr(p + 0x02C)); // 0x2C Point_count                 ( ModelPrimitiveType int int int Int32 )
            value.Dtime                                     = GetSingle(new IntPtr(p + 0x030)); // 0x30 Dtime                       ( ModelPrimitiveType float float float Single )
            value.BaseMove                                  = (Vector3)GetInt32(new IntPtr(p + 0x034)); // 0x34 BaseMove                    ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.WindVector                                = (Vector3)GetInt32(new IntPtr(p + 0x040)); // 0x40 WindVector                  ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.BaseMat                                   = (Matrix4x4)GetInt32(new IntPtr(p + 0x04C)); // 0x4C BaseMat                     ( ModelEnumType Matrix4x4 Matrix4x4 Matrix4x4 Int32 )
            value.ChestConstaint                            = GetInt32(new IntPtr(p + 0x08C)); // 0x8C ChestConstaint              ( ModelPrimitiveType int int int Int32 )
            value.CollideIdx                                = GetInt32(new IntPtr(p + 0x090)); // 0x90 CollideIdx                  ( ModelPrimitiveType int int int Int32 )
            value.CollideMinimum                            = GetSingle(new IntPtr(p + 0x094)); // 0x94 CollideMinimum              ( ModelPrimitiveType float float float Single )
            value.AngleCap                                  = GetInt32(new IntPtr(p + 0x098)); // 0x98 AngleCap                    ( ModelPrimitiveType int int int Int32 )
            value.AddCollideRoot                            = GetSingle(new IntPtr(p + 0x09C)); // 0x9C AddCollideRoot              ( ModelPrimitiveType float float float Single )
            value.AddCollideEnd                             = GetSingle(new IntPtr(p + 0x0A0)); // 0xA0 AddCollideEnd               ( ModelPrimitiveType float float float Single )
            value.Point0                                    = (Point)GetInt32(new IntPtr(p + 0x0A4)); // 0xA4 Point0                      ( ModelEnumType Point Point Point Int32 )
            value.Point1                                    = (Point)GetInt32(new IntPtr(p + 0x19C)); // 0x19C Point1                      ( ModelEnumType Point Point Point Int32 )
            value.Point2                                    = (Point)GetInt32(new IntPtr(p + 0x294)); // 0x294 Point2                      ( ModelEnumType Point Point Point Int32 )
            value.Point3                                    = (Point)GetInt32(new IntPtr(p + 0x38C)); // 0x38C Point3                      ( ModelEnumType Point Point Point Int32 )
            value.Point4                                    = (Point)GetInt32(new IntPtr(p + 0x484)); // 0x484 Point4                      ( ModelEnumType Point Point Point Int32 )
            value.Point5                                    = (Point)GetInt32(new IntPtr(p + 0x57C)); // 0x57C Point5                      ( ModelEnumType Point Point Point Int32 )
            value.Point6                                    = (Point)GetInt32(new IntPtr(p + 0x674)); // 0x674 Point6                      ( ModelEnumType Point Point Point Int32 )
            value.Point7                                    = (Point)GetInt32(new IntPtr(p + 0x76C)); // 0x76C Point7                      ( ModelEnumType Point Point Point Int32 )
            value.Flag                                      = (SwayStringFlag)GetInt32(new IntPtr(p + 0x864)); // 0x864 Flag                        ( ModelEnumType SwayStringFlag SwayStringFlag SwayStringFlag Int32 )

            return value;
        }
    }
}
