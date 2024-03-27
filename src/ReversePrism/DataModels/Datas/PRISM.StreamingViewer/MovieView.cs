using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 PrefabPath                               string IL2CPP_TYPE_STRING
    // 020 DefaultScale                             0001866AC430 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 02C Rotate                                   00018664A570 ModelEnumType Quaternion Quaternion Quaternion Int32
    // 040 Panel                                    000186603F80 ModelClassType MeshRenderer MeshRenderer MeshRenderer Pointer
    // 048 CriManaMovieController                   00018665A010 ModelClassType CriManaMovieController CriManaMovieController CriManaMovieController Pointer
    // 050 MainCamera                               0001865A1C90 ModelClassType Camera Camera Camera Pointer
    // 058 CriManaMovieMaterialBase                 00018665ACA0 ModelClassType CriManaMovieMaterialBase CriManaMovieMaterialBase CriManaMovieMaterialBase Pointer
    // 060 GcHandle                                 0001865D9120 ModelEnumType GCHandle GCHandle GCHandle Int32
    // 068 DataPath                                 000186671910 ModelPrimitiveType string string string String
    // 070 IsPlaying                                000186594D10 ModelPrimitiveType bool bool bool Bool
    // 078 Data                                     000186634CA0 ModelClassType TextAsset TextAsset TextAsset Pointer
    // 080 receivedData                             Queue`1<ReceivedData> IL2CPP_TYPE_GENERICINST
    // 088 Offset                                   0001866ABF40 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 094 Size                                     000186666050 ModelPrimitiveType float float float Single
    // 098 IsViewPaused                             000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class MovieView
    {
        public Vector3                                  DefaultScale                            { get; set; }
        public Quaternion                               Rotate                                  { get; set; }
        public MeshRenderer?                            Panel                                   { get; set; }
        public CriManaMovieController?                  CriManaMovieController                  { get; set; }
        public Camera?                                  MainCamera                              { get; set; }
        public CriManaMovieMaterialBase?                CriManaMovieMaterialBase                { get; set; }
        public GCHandle                                 GcHandle                                { get; set; }
        public string                                   DataPath                                { get; set; }
        public bool                                     IsPlaying                               { get; set; }
        public TextAsset?                               Data                                    { get; set; }
        public Vector3                                  Offset                                  { get; set; }
        public float                                    Size                                    { get; set; }
        public bool                                     IsViewPaused                            { get; set; }

        public static MovieView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MovieView();

            value.DefaultScale                              = (Vector3)GetInt32(new IntPtr(p + 0x020)); // 0270D4F55BF8 0x20 DefaultScale                ( 0001866AC430 ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.Rotate                                    = (Quaternion)GetInt32(new IntPtr(p + 0x02C)); // 0270D4F55C18 0x2C Rotate                      ( 00018664A570 ModelEnumType Quaternion Quaternion Quaternion Int32 )
            value.Panel                                     = GetObject<MeshRenderer>(new IntPtr(p + 0x040), ReversePrism.DataModels.MeshRenderer.FromPointer); // 0270D4F55C38 0x40 Panel                       ( 000186603F80 ModelClassType MeshRenderer MeshRenderer MeshRenderer Pointer )
            value.CriManaMovieController                    = GetObject<CriManaMovieController>(new IntPtr(p + 0x048), ReversePrism.DataModels.CriManaMovieController.FromPointer); // 0270D4F55C58 0x48 CriManaMovieController      ( 00018665A010 ModelClassType CriManaMovieController CriManaMovieController CriManaMovieController Pointer )
            value.MainCamera                                = GetObject<Camera>(new IntPtr(p + 0x050), ReversePrism.DataModels.Camera.FromPointer); // 0270D4F55C78 0x50 MainCamera                  ( 0001865A1C90 ModelClassType Camera Camera Camera Pointer )
            value.CriManaMovieMaterialBase                  = GetObject<CriManaMovieMaterialBase>(new IntPtr(p + 0x058), ReversePrism.DataModels.CriManaMovieMaterialBase.FromPointer); // 0270D4F55C98 0x58 CriManaMovieMaterialBase    ( 00018665ACA0 ModelClassType CriManaMovieMaterialBase CriManaMovieMaterialBase CriManaMovieMaterialBase Pointer )
            value.GcHandle                                  = (GCHandle)GetInt32(new IntPtr(p + 0x060)); // 0270D4F55CB8 0x60 GcHandle                    ( 0001865D9120 ModelEnumType GCHandle GCHandle GCHandle Int32 )
            value.DataPath                                  = GetString(new IntPtr(p + 0x068)); // 0270D4F55CD8 0x68 DataPath                    ( 000186671910 ModelPrimitiveType string string string String )
            value.IsPlaying                                 = GetBool(new IntPtr(p + 0x070)); // 0270D4F55CF8 0x70 IsPlaying                   ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Data                                      = GetObject<TextAsset>(new IntPtr(p + 0x078), ReversePrism.DataModels.TextAsset.FromPointer); // 0270D4F55D18 0x78 Data                        ( 000186634CA0 ModelClassType TextAsset TextAsset TextAsset Pointer )
            value.Offset                                    = (Vector3)GetInt32(new IntPtr(p + 0x088)); // 0270D4F55D58 0x88 Offset                      ( 0001866ABF40 ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.Size                                      = GetSingle(new IntPtr(p + 0x094)); // 0270D4F55D78 0x94 Size                        ( 000186666050 ModelPrimitiveType float float float Single )
            value.IsViewPaused                              = GetBool(new IntPtr(p + 0x098)); // 0270D4F55D98 0x98 IsViewPaused                ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
