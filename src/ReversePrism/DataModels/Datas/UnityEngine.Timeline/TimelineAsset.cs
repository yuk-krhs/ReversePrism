using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 k_LatestVersion                          int IL2CPP_TYPE_I4
    // 018 M_Version                                0001865F2AF0 ModelPrimitiveType int int int Int32
    // 020 M_Tracks                                 000185D068C8 ModelClassListType List`1<ScriptableObject> List`1<ScriptableObject> List<ScriptableObject> Pointer
    // 028 M_FixedDuration                          0001865C2950 ModelPrimitiveType double double double Double
    // 030 M_CacheOutputTracks                      000185CACA28 ModelClassListType TrackAsset[] TrackAsset[] List<TrackAsset> Pointer
    // 038 M_CacheRootTracks                        000185D156E8 ModelClassListType List`1<TrackAsset> List`1<TrackAsset> List<TrackAsset> Pointer
    // 040 M_CacheFlattenedTracks                   000185CACA28 ModelClassListType TrackAsset[] TrackAsset[] List<TrackAsset> Pointer
    // 048 M_EditorSettings                         00018660AD90 ModelClassType EditorSettings EditorSettings EditorSettings Pointer
    // 050 M_DurationMode                           00018660A6B0 ModelEnumType DurationMode DurationMode DurationMode Int32
    // 058 M_MarkerTrack                            0001865D4E40 ModelClassType MarkerTrack MarkerTrack MarkerTrack Pointer
    public partial class TimelineAsset
    {
        public int                                      M_Version                               { get; set; }
        public List<ScriptableObject>?                  M_Tracks                                { get; set; }
        public double                                   M_FixedDuration                         { get; set; }
        public List<TrackAsset>?                        M_CacheOutputTracks                     { get; set; }
        public List<TrackAsset>?                        M_CacheRootTracks                       { get; set; }
        public List<TrackAsset>?                        M_CacheFlattenedTracks                  { get; set; }
        public EditorSettings?                          M_EditorSettings                        { get; set; }
        public DurationMode                             M_DurationMode                          { get; set; }
        public MarkerTrack?                             M_MarkerTrack                           { get; set; }

        public static TimelineAsset? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TimelineAsset();

            value.M_Version                                 = GetInt32(new IntPtr(p + 0x018)); // 027006A58898 0x18 M_Version                   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_Tracks                                  = GetObjectList<ScriptableObject>(new IntPtr(p + 0x020), ReversePrism.DataModels.ScriptableObject.FromPointer); // 027006A588B8 0x20 M_Tracks                    ( 000185D068C8 ModelClassListType List`1<ScriptableObject> List`1<ScriptableObject> List<ScriptableObject> Pointer )
            value.M_FixedDuration                           = GetDouble(new IntPtr(p + 0x028)); // 027006A588D8 0x28 M_FixedDuration             ( 0001865C2950 ModelPrimitiveType double double double Double )
            value.M_CacheOutputTracks                       = GetObjectList<TrackAsset>(new IntPtr(p + 0x030), ReversePrism.DataModels.TrackAsset.FromPointer); // 027006A588F8 0x30 M_CacheOutputTracks         ( 000185CACA28 ModelClassListType TrackAsset[] TrackAsset[] List<TrackAsset> Pointer )
            value.M_CacheRootTracks                         = GetObjectList<TrackAsset>(new IntPtr(p + 0x038), ReversePrism.DataModels.TrackAsset.FromPointer); // 027006A58918 0x38 M_CacheRootTracks           ( 000185D156E8 ModelClassListType List`1<TrackAsset> List`1<TrackAsset> List<TrackAsset> Pointer )
            value.M_CacheFlattenedTracks                    = GetObjectList<TrackAsset>(new IntPtr(p + 0x040), ReversePrism.DataModels.TrackAsset.FromPointer); // 027006A58938 0x40 M_CacheFlattenedTracks      ( 000185CACA28 ModelClassListType TrackAsset[] TrackAsset[] List<TrackAsset> Pointer )
            value.M_EditorSettings                          = GetObject<EditorSettings>(new IntPtr(p + 0x048), ReversePrism.DataModels.EditorSettings.FromPointer); // 027006A58958 0x48 M_EditorSettings            ( 00018660AD90 ModelClassType EditorSettings EditorSettings EditorSettings Pointer )
            value.M_DurationMode                            = (DurationMode)GetInt32(new IntPtr(p + 0x050)); // 027006A58978 0x50 M_DurationMode              ( 00018660A6B0 ModelEnumType DurationMode DurationMode DurationMode Int32 )
            value.M_MarkerTrack                             = GetObject<MarkerTrack>(new IntPtr(p + 0x058), ReversePrism.DataModels.MarkerTrack.FromPointer); // 027006A58998 0x58 M_MarkerTrack               ( 0001865D4E40 ModelClassType MarkerTrack MarkerTrack MarkerTrack Pointer )

            return value;
        }
    }
}
