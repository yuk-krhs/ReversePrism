using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Uv                                       ModelPrimitiveType string string string String
    // 018 Idb                                      ModelPrimitiveType bool bool bool Bool
    // 020 Pt                                       ModelPrimitiveType string string string String
    // 028 Pc                                       ModelPrimitiveType int int int Int32
    // 02C Pf                                       ModelPrimitiveType int int int Int32
    // 030 Sms                                      ModelPrimitiveType int int int Int32
    // 034 Gms                                      ModelPrimitiveType int int int Int32
    // 038 Gdid                                     ModelPrimitiveType int int int Int32
    // 03C Gdvid                                    ModelPrimitiveType int int int Int32
    // 040 Gdn                                      ModelPrimitiveType string string string String
    // 048 Gdv                                      ModelPrimitiveType string string string String
    // 050 Gdver                                    ModelPrimitiveType string string string String
    // 058 Gdt                                      ModelEnumType GraphicsDeviceType GraphicsDeviceType GraphicsDeviceType Int32
    // 05C Gsl                                      ModelPrimitiveType int int int Int32
    // 060 Grtc                                     ModelPrimitiveType int int int Int32
    // 064 Gcts                                     ModelEnumType CopyTextureSupport CopyTextureSupport CopyTextureSupport Int32
    // 068 Gmts                                     ModelPrimitiveType int int int Int32
    // 070 Ss                                       ModelPrimitiveType string string string String
    // 078 Sdpi                                     ModelPrimitiveType float float float Single
    // 07C Srr                                      ModelPrimitiveType int int int Int32
    public partial class Metadata : DataModel
    {
        public string                                   Uv                                      { get; set; }
        public bool                                     Idb                                     { get; set; }
        public string                                   Pt                                      { get; set; }
        public int                                      Pc                                      { get; set; }
        public int                                      Pf                                      { get; set; }
        public int                                      Sms                                     { get; set; }
        public int                                      Gms                                     { get; set; }
        public int                                      Gdid                                    { get; set; }
        public int                                      Gdvid                                   { get; set; }
        public string                                   Gdn                                     { get; set; }
        public string                                   Gdv                                     { get; set; }
        public string                                   Gdver                                   { get; set; }
        public GraphicsDeviceType                       Gdt                                     { get; set; }
        public int                                      Gsl                                     { get; set; }
        public int                                      Grtc                                    { get; set; }
        public CopyTextureSupport                       Gcts                                    { get; set; }
        public int                                      Gmts                                    { get; set; }
        public string                                   Ss                                      { get; set; }
        public float                                    Sdpi                                    { get; set; }
        public int                                      Srr                                     { get; set; }

        public static Metadata? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Metadata() { Pointer= p0 };

            value.Uv                                        = GetString(new IntPtr(p + 0x010)); // 0x10 Uv                          ( ModelPrimitiveType string string string String )
            value.Idb                                       = GetBool(new IntPtr(p + 0x018)); // 0x18 Idb                         ( ModelPrimitiveType bool bool bool Bool )
            value.Pt                                        = GetString(new IntPtr(p + 0x020)); // 0x20 Pt                          ( ModelPrimitiveType string string string String )
            value.Pc                                        = GetInt32(new IntPtr(p + 0x028)); // 0x28 Pc                          ( ModelPrimitiveType int int int Int32 )
            value.Pf                                        = GetInt32(new IntPtr(p + 0x02C)); // 0x2C Pf                          ( ModelPrimitiveType int int int Int32 )
            value.Sms                                       = GetInt32(new IntPtr(p + 0x030)); // 0x30 Sms                         ( ModelPrimitiveType int int int Int32 )
            value.Gms                                       = GetInt32(new IntPtr(p + 0x034)); // 0x34 Gms                         ( ModelPrimitiveType int int int Int32 )
            value.Gdid                                      = GetInt32(new IntPtr(p + 0x038)); // 0x38 Gdid                        ( ModelPrimitiveType int int int Int32 )
            value.Gdvid                                     = GetInt32(new IntPtr(p + 0x03C)); // 0x3C Gdvid                       ( ModelPrimitiveType int int int Int32 )
            value.Gdn                                       = GetString(new IntPtr(p + 0x040)); // 0x40 Gdn                         ( ModelPrimitiveType string string string String )
            value.Gdv                                       = GetString(new IntPtr(p + 0x048)); // 0x48 Gdv                         ( ModelPrimitiveType string string string String )
            value.Gdver                                     = GetString(new IntPtr(p + 0x050)); // 0x50 Gdver                       ( ModelPrimitiveType string string string String )
            value.Gdt                                       = (GraphicsDeviceType)GetInt32(new IntPtr(p + 0x058)); // 0x58 Gdt                         ( ModelEnumType GraphicsDeviceType GraphicsDeviceType GraphicsDeviceType Int32 )
            value.Gsl                                       = GetInt32(new IntPtr(p + 0x05C)); // 0x5C Gsl                         ( ModelPrimitiveType int int int Int32 )
            value.Grtc                                      = GetInt32(new IntPtr(p + 0x060)); // 0x60 Grtc                        ( ModelPrimitiveType int int int Int32 )
            value.Gcts                                      = (CopyTextureSupport)GetInt32(new IntPtr(p + 0x064)); // 0x64 Gcts                        ( ModelEnumType CopyTextureSupport CopyTextureSupport CopyTextureSupport Int32 )
            value.Gmts                                      = GetInt32(new IntPtr(p + 0x068)); // 0x68 Gmts                        ( ModelPrimitiveType int int int Int32 )
            value.Ss                                        = GetString(new IntPtr(p + 0x070)); // 0x70 Ss                          ( ModelPrimitiveType string string string String )
            value.Sdpi                                      = GetSingle(new IntPtr(p + 0x078)); // 0x78 Sdpi                        ( ModelPrimitiveType float float float Single )
            value.Srr                                       = GetInt32(new IntPtr(p + 0x07C)); // 0x7C Srr                         ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
