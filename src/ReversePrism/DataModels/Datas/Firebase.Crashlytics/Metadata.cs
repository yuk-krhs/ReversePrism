using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Uv                                       0001866722E0 ModelPrimitiveType string string string String
    // 018 Idb                                      000186595960 ModelPrimitiveType bool bool bool Bool
    // 020 Pt                                       0001866722E0 ModelPrimitiveType string string string String
    // 028 Pc                                       0001865F36C0 ModelPrimitiveType int int int Int32
    // 02C Pf                                       0001865F36C0 ModelPrimitiveType int int int Int32
    // 030 Sms                                      0001865F36C0 ModelPrimitiveType int int int Int32
    // 034 Gms                                      0001865F36C0 ModelPrimitiveType int int int Int32
    // 038 Gdid                                     0001865F36C0 ModelPrimitiveType int int int Int32
    // 03C Gdvid                                    0001865F36C0 ModelPrimitiveType int int int Int32
    // 040 Gdn                                      0001866722E0 ModelPrimitiveType string string string String
    // 048 Gdv                                      0001866722E0 ModelPrimitiveType string string string String
    // 050 Gdver                                    0001866722E0 ModelPrimitiveType string string string String
    // 058 Gdt                                      000186694F30 ModelEnumType GraphicsDeviceType GraphicsDeviceType GraphicsDeviceType Int32
    // 05C Gsl                                      0001865F36C0 ModelPrimitiveType int int int Int32
    // 060 Grtc                                     0001865F36C0 ModelPrimitiveType int int int Int32
    // 064 Gcts                                     000186621720 ModelEnumType CopyTextureSupport CopyTextureSupport CopyTextureSupport Int32
    // 068 Gmts                                     0001865F36C0 ModelPrimitiveType int int int Int32
    // 070 Ss                                       0001866722E0 ModelPrimitiveType string string string String
    // 078 Sdpi                                     000186666050 ModelPrimitiveType float float float Single
    // 07C Srr                                      0001865F36C0 ModelPrimitiveType int int int Int32
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

            value.Uv                                        = GetString(new IntPtr(p + 0x010)); // 02466BCE0BC8 0x10 Uv                          ( 0001866722E0 ModelPrimitiveType string string string String )
            value.Idb                                       = GetBool(new IntPtr(p + 0x018)); // 02466BCE0BE8 0x18 Idb                         ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.Pt                                        = GetString(new IntPtr(p + 0x020)); // 02466BCE0C08 0x20 Pt                          ( 0001866722E0 ModelPrimitiveType string string string String )
            value.Pc                                        = GetInt32(new IntPtr(p + 0x028)); // 02466BCE0C28 0x28 Pc                          ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.Pf                                        = GetInt32(new IntPtr(p + 0x02C)); // 02466BCE0C48 0x2C Pf                          ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.Sms                                       = GetInt32(new IntPtr(p + 0x030)); // 02466BCE0C68 0x30 Sms                         ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.Gms                                       = GetInt32(new IntPtr(p + 0x034)); // 02466BCE0C88 0x34 Gms                         ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.Gdid                                      = GetInt32(new IntPtr(p + 0x038)); // 02466BCE0CA8 0x38 Gdid                        ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.Gdvid                                     = GetInt32(new IntPtr(p + 0x03C)); // 02466BCE0CC8 0x3C Gdvid                       ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.Gdn                                       = GetString(new IntPtr(p + 0x040)); // 02466BCE0CE8 0x40 Gdn                         ( 0001866722E0 ModelPrimitiveType string string string String )
            value.Gdv                                       = GetString(new IntPtr(p + 0x048)); // 02466BCE0D08 0x48 Gdv                         ( 0001866722E0 ModelPrimitiveType string string string String )
            value.Gdver                                     = GetString(new IntPtr(p + 0x050)); // 02466BCE0D28 0x50 Gdver                       ( 0001866722E0 ModelPrimitiveType string string string String )
            value.Gdt                                       = (GraphicsDeviceType)GetInt32(new IntPtr(p + 0x058)); // 02466BCE0D48 0x58 Gdt                         ( 000186694F30 ModelEnumType GraphicsDeviceType GraphicsDeviceType GraphicsDeviceType Int32 )
            value.Gsl                                       = GetInt32(new IntPtr(p + 0x05C)); // 02466BCE0D68 0x5C Gsl                         ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.Grtc                                      = GetInt32(new IntPtr(p + 0x060)); // 02466BCE0D88 0x60 Grtc                        ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.Gcts                                      = (CopyTextureSupport)GetInt32(new IntPtr(p + 0x064)); // 02466BCE0DA8 0x64 Gcts                        ( 000186621720 ModelEnumType CopyTextureSupport CopyTextureSupport CopyTextureSupport Int32 )
            value.Gmts                                      = GetInt32(new IntPtr(p + 0x068)); // 02466BCE0DC8 0x68 Gmts                        ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.Ss                                        = GetString(new IntPtr(p + 0x070)); // 02466BCE0DE8 0x70 Ss                          ( 0001866722E0 ModelPrimitiveType string string string String )
            value.Sdpi                                      = GetSingle(new IntPtr(p + 0x078)); // 02466BCE0E08 0x78 Sdpi                        ( 000186666050 ModelPrimitiveType float float float Single )
            value.Srr                                       = GetInt32(new IntPtr(p + 0x07C)); // 02466BCE0E28 0x7C Srr                         ( 0001865F36C0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
