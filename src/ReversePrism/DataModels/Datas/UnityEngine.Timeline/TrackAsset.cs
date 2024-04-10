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
    // 020 M_AnimClip                               0001866B2550 ModelClassType AnimationClip AnimationClip AnimationClip Pointer
    // 000 s_BuildData                              TransientBuildData IL2CPP_TYPE_VALUETYPE
    // 000 kDefaultCurvesName                       string IL2CPP_TYPE_STRING
    // 018 OnClipPlayableCreate                     Action`3<TimelineClip, GameObject, Playable> IL2CPP_TYPE_GENERICINST
    // 020 OnTrackAnimationPlayableCreate           Action`3<TrackAsset, GameObject, Playable> IL2CPP_TYPE_GENERICINST
    // 028 M_Locked                                 000186594D10 ModelPrimitiveType bool bool bool Bool
    // 029 M_Muted                                  000186594D10 ModelPrimitiveType bool bool bool Bool
    // 030 M_CustomPlayableFullTypename             000186671910 ModelPrimitiveType string string string String
    // 038 M_Curves                                 0001866B2300 ModelClassType AnimationClip AnimationClip AnimationClip Pointer
    // 040 M_Parent                                 00018674D0F0 ModelClassType PlayableAsset PlayableAsset PlayableAsset Pointer
    // 048 M_Children                               000185D068C8 ModelClassListType List`1<ScriptableObject> List`1<ScriptableObject> List<ScriptableObject> Pointer
    // 050 M_ItemsHash                              0001865F5290 ModelPrimitiveType int int int Int32
    // 058 M_ClipsCache                             000185CABEA8 ModelClassListType TimelineClip[] TimelineClip[] List<TimelineClip> Pointer
    // 060 M_Start                                  0001866D9AA0 ModelEnumType DiscreteTime DiscreteTime DiscreteTime Int32
    // 068 M_End                                    0001866D9AA0 ModelEnumType DiscreteTime DiscreteTime DiscreteTime Int32
    // 070 M_CacheSorted                            000186594D10 ModelPrimitiveType bool bool bool Bool
    // 071 m_SupportsNotifications                  Nullable`1<bool> IL2CPP_TYPE_GENERICINST
    // 028 S_EmptyCache                             000185CAC928 ModelClassListType TrackAsset[] TrackAsset[] List<TrackAsset> Pointer
    // 078 m_ChildTrackCache                        IEnumerable`1<TrackAsset> IL2CPP_TYPE_GENERICINST
    // 030 s_TrackBindingTypeAttributeCache         Dictionary`2<Type, TrackBindingTypeAttribute> IL2CPP_TYPE_GENERICINST
    // 080 M_Clips                                  000185D14918 ModelClassListType List`1<TimelineClip> List`1<TimelineClip> List<TimelineClip> Pointer
    // 088 M_Markers                                0001865D4980 ModelEnumType MarkerList MarkerList MarkerList Int32
    public partial class TrackAsset : DataModel
    {
        public int                                      M_Version                               { get; set; }
        public AnimationClip?                           M_AnimClip                              { get; set; }
        public bool                                     M_Locked                                { get; set; }
        public bool                                     M_Muted                                 { get; set; }
        public string                                   M_CustomPlayableFullTypename            { get; set; }
        public AnimationClip?                           M_Curves                                { get; set; }
        public PlayableAsset?                           M_Parent                                { get; set; }
        public List<ScriptableObject>?                  M_Children                              { get; set; }
        public int                                      M_ItemsHash                             { get; set; }
        public List<TimelineClip>?                      M_ClipsCache                            { get; set; }
        public DiscreteTime                             M_Start                                 { get; set; }
        public DiscreteTime                             M_End                                   { get; set; }
        public bool                                     M_CacheSorted                           { get; set; }
        public List<TrackAsset>?                        S_EmptyCache                            { get; set; }
        public List<TimelineClip>?                      M_Clips                                 { get; set; }
        public MarkerList                               M_Markers                               { get; set; }

        public static TrackAsset? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TrackAsset() { Pointer= p0 };

            value.M_Version                                 = GetInt32(new IntPtr(p + 0x018)); // 024664B7F018 0x18 M_Version                   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_AnimClip                                = GetObject<AnimationClip>(new IntPtr(p + 0x020), ReversePrism.DataModels.AnimationClip.FromPointer); // 024664B7F038 0x20 M_AnimClip                  ( 0001866B2550 ModelClassType AnimationClip AnimationClip AnimationClip Pointer )
            value.M_Locked                                  = GetBool(new IntPtr(p + 0x028)); // 024664B7F0D8 0x28 M_Locked                    ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_Muted                                   = GetBool(new IntPtr(p + 0x029)); // 024664B7F0F8 0x29 M_Muted                     ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_CustomPlayableFullTypename              = GetString(new IntPtr(p + 0x030)); // 024664B7F118 0x30 M_CustomPlayableFullTypename ( 000186671910 ModelPrimitiveType string string string String )
            value.M_Curves                                  = GetObject<AnimationClip>(new IntPtr(p + 0x038), ReversePrism.DataModels.AnimationClip.FromPointer); // 024664B7F138 0x38 M_Curves                    ( 0001866B2300 ModelClassType AnimationClip AnimationClip AnimationClip Pointer )
            value.M_Parent                                  = GetObject<PlayableAsset>(new IntPtr(p + 0x040), ReversePrism.DataModels.PlayableAsset.FromPointer); // 024664B7F158 0x40 M_Parent                    ( 00018674D0F0 ModelClassType PlayableAsset PlayableAsset PlayableAsset Pointer )
            value.M_Children                                = GetObjectList<ScriptableObject>(new IntPtr(p + 0x048), ReversePrism.DataModels.ScriptableObject.FromPointer); // 024664B7F178 0x48 M_Children                  ( 000185D068C8 ModelClassListType List`1<ScriptableObject> List`1<ScriptableObject> List<ScriptableObject> Pointer )
            value.M_ItemsHash                               = GetInt32(new IntPtr(p + 0x050)); // 024664B7F198 0x50 M_ItemsHash                 ( 0001865F5290 ModelPrimitiveType int int int Int32 )
            value.M_ClipsCache                              = GetObjectList<TimelineClip>(new IntPtr(p + 0x058), ReversePrism.DataModels.TimelineClip.FromPointer); // 024664B7F1B8 0x58 M_ClipsCache                ( 000185CABEA8 ModelClassListType TimelineClip[] TimelineClip[] List<TimelineClip> Pointer )
            value.M_Start                                   = (DiscreteTime)GetInt32(new IntPtr(p + 0x060)); // 024664B7F1D8 0x60 M_Start                     ( 0001866D9AA0 ModelEnumType DiscreteTime DiscreteTime DiscreteTime Int32 )
            value.M_End                                     = (DiscreteTime)GetInt32(new IntPtr(p + 0x068)); // 024664B7F1F8 0x68 M_End                       ( 0001866D9AA0 ModelEnumType DiscreteTime DiscreteTime DiscreteTime Int32 )
            value.M_CacheSorted                             = GetBool(new IntPtr(p + 0x070)); // 024664B7F218 0x70 M_CacheSorted               ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.S_EmptyCache                              = GetObjectList<TrackAsset>(new IntPtr(p + 0x028), ReversePrism.DataModels.TrackAsset.FromPointer); // 024664B7F258 0x28 S_EmptyCache                ( 000185CAC928 ModelClassListType TrackAsset[] TrackAsset[] List<TrackAsset> Pointer )
            value.M_Clips                                   = GetObjectList<TimelineClip>(new IntPtr(p + 0x080), ReversePrism.DataModels.TimelineClip.FromPointer); // 024664B7F2B8 0x80 M_Clips                     ( 000185D14918 ModelClassListType List`1<TimelineClip> List`1<TimelineClip> List<TimelineClip> Pointer )
            value.M_Markers                                 = (MarkerList)GetInt32(new IntPtr(p + 0x088)); // 024664B7F2D8 0x88 M_Markers                   ( 0001865D4980 ModelEnumType MarkerList MarkerList MarkerList Int32 )

            return value;
        }
    }
}
