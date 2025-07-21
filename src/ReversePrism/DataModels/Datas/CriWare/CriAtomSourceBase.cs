using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 030 Player                                   ModelClassType CriAtomExPlayer CriAtomExPlayer CriAtomExPlayer Pointer
    // 038 Source                                   ModelClassType CriAtomEx3dSource CriAtomEx3dSource CriAtomEx3dSource Pointer
    // 040 Initialized                              ModelPrimitiveType bool bool bool Bool
    // 044 LastPosition                             ModelEnumType Vector3 Vector3 Vector3 Int32
    // 050 HasValidPosition                         ModelPrimitiveType bool bool bool Bool
    // 058 CurrentRegion                            ModelClassType CriAtomRegion CriAtomRegion CriAtomRegion Pointer
    // 060 CurrentListener                          ModelClassType CriAtomListener CriAtomListener CriAtomListener Pointer
    // 068 PlayOnStart                              ModelPrimitiveType bool bool bool Bool
    // 070 RegionOnStart                            ModelClassType CriAtomRegion CriAtomRegion CriAtomRegion Pointer
    // 078 ListenerOnStart                          ModelClassType CriAtomListener CriAtomListener CriAtomListener Pointer
    // 080 Use3dPositioning                         ModelPrimitiveType bool bool bool Bool
    // 081 FreezeOrientation                        ModelPrimitiveType bool bool bool Bool
    // 082 Loop                                     ModelPrimitiveType bool bool bool Bool
    // 084 Volume                                   ModelPrimitiveType float float float Single
    // 088 Pitch                                    ModelPrimitiveType float float float Single
    // 08C AndroidUseLowLatencyVoicePool            ModelPrimitiveType bool bool bool Bool
    // 08D Need_to_player_update_all                ModelPrimitiveType bool bool bool Bool
    // 08E Use3dRandomization                       ModelPrimitiveType bool bool bool Bool
    // 090 RandomPositionListMaxLength              ModelPrimitiveType uint uint uint UInt32
    // 098 Randomize3dConfig                        ModelEnumType Randomize3dConfig Randomize3dConfig Randomize3dConfig Int32
    public partial class CriAtomSourceBase : DataModel
    {
        public CriAtomExPlayer?                         Player                                  { get; set; }
        public CriAtomEx3dSource?                       Source                                  { get; set; }
        public bool                                     Initialized                             { get; set; }
        public Vector3                                  LastPosition                            { get; set; }
        public bool                                     HasValidPosition                        { get; set; }
        public CriAtomRegion?                           CurrentRegion                           { get; set; }
        public CriAtomListener?                         CurrentListener                         { get; set; }
        public bool                                     PlayOnStart                             { get; set; }
        public CriAtomRegion?                           RegionOnStart                           { get; set; }
        public CriAtomListener?                         ListenerOnStart                         { get; set; }
        public bool                                     Use3dPositioning                        { get; set; }
        public bool                                     FreezeOrientation                       { get; set; }
        public bool                                     Loop                                    { get; set; }
        public float                                    Volume                                  { get; set; }
        public float                                    Pitch                                   { get; set; }
        public bool                                     AndroidUseLowLatencyVoicePool           { get; set; }
        public bool                                     Need_to_player_update_all               { get; set; }
        public bool                                     Use3dRandomization                      { get; set; }
        public uint                                     RandomPositionListMaxLength             { get; set; }
        public Randomize3dConfig                        Randomize3dConfig                       { get; set; }

        public static CriAtomSourceBase? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CriAtomSourceBase() { Pointer= p0 };

            value.Player                                    = GetObject<CriAtomExPlayer>(new IntPtr(p + 0x030), ReversePrism.DataModels.CriAtomExPlayer.FromPointer); // 0x30 Player                      ( ModelClassType CriAtomExPlayer CriAtomExPlayer CriAtomExPlayer Pointer )
            value.Source                                    = GetObject<CriAtomEx3dSource>(new IntPtr(p + 0x038), ReversePrism.DataModels.CriAtomEx3dSource.FromPointer); // 0x38 Source                      ( ModelClassType CriAtomEx3dSource CriAtomEx3dSource CriAtomEx3dSource Pointer )
            value.Initialized                               = GetBool(new IntPtr(p + 0x040)); // 0x40 Initialized                 ( ModelPrimitiveType bool bool bool Bool )
            value.LastPosition                              = (Vector3)GetInt32(new IntPtr(p + 0x044)); // 0x44 LastPosition                ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.HasValidPosition                          = GetBool(new IntPtr(p + 0x050)); // 0x50 HasValidPosition            ( ModelPrimitiveType bool bool bool Bool )
            value.CurrentRegion                             = GetObject<CriAtomRegion>(new IntPtr(p + 0x058), ReversePrism.DataModels.CriAtomRegion.FromPointer); // 0x58 CurrentRegion               ( ModelClassType CriAtomRegion CriAtomRegion CriAtomRegion Pointer )
            value.CurrentListener                           = GetObject<CriAtomListener>(new IntPtr(p + 0x060), ReversePrism.DataModels.CriAtomListener.FromPointer); // 0x60 CurrentListener             ( ModelClassType CriAtomListener CriAtomListener CriAtomListener Pointer )
            value.PlayOnStart                               = GetBool(new IntPtr(p + 0x068)); // 0x68 PlayOnStart                 ( ModelPrimitiveType bool bool bool Bool )
            value.RegionOnStart                             = GetObject<CriAtomRegion>(new IntPtr(p + 0x070), ReversePrism.DataModels.CriAtomRegion.FromPointer); // 0x70 RegionOnStart               ( ModelClassType CriAtomRegion CriAtomRegion CriAtomRegion Pointer )
            value.ListenerOnStart                           = GetObject<CriAtomListener>(new IntPtr(p + 0x078), ReversePrism.DataModels.CriAtomListener.FromPointer); // 0x78 ListenerOnStart             ( ModelClassType CriAtomListener CriAtomListener CriAtomListener Pointer )
            value.Use3dPositioning                          = GetBool(new IntPtr(p + 0x080)); // 0x80 Use3dPositioning            ( ModelPrimitiveType bool bool bool Bool )
            value.FreezeOrientation                         = GetBool(new IntPtr(p + 0x081)); // 0x81 FreezeOrientation           ( ModelPrimitiveType bool bool bool Bool )
            value.Loop                                      = GetBool(new IntPtr(p + 0x082)); // 0x82 Loop                        ( ModelPrimitiveType bool bool bool Bool )
            value.Volume                                    = GetSingle(new IntPtr(p + 0x084)); // 0x84 Volume                      ( ModelPrimitiveType float float float Single )
            value.Pitch                                     = GetSingle(new IntPtr(p + 0x088)); // 0x88 Pitch                       ( ModelPrimitiveType float float float Single )
            value.AndroidUseLowLatencyVoicePool             = GetBool(new IntPtr(p + 0x08C)); // 0x8C AndroidUseLowLatencyVoicePool ( ModelPrimitiveType bool bool bool Bool )
            value.Need_to_player_update_all                 = GetBool(new IntPtr(p + 0x08D)); // 0x8D Need_to_player_update_all   ( ModelPrimitiveType bool bool bool Bool )
            value.Use3dRandomization                        = GetBool(new IntPtr(p + 0x08E)); // 0x8E Use3dRandomization          ( ModelPrimitiveType bool bool bool Bool )
            value.RandomPositionListMaxLength               = GetUInt32(new IntPtr(p + 0x090)); // 0x90 RandomPositionListMaxLength ( ModelPrimitiveType uint uint uint UInt32 )
            value.Randomize3dConfig                         = (Randomize3dConfig)GetInt32(new IntPtr(p + 0x098)); // 0x98 Randomize3dConfig           ( ModelEnumType Randomize3dConfig Randomize3dConfig Randomize3dConfig Int32 )

            return value;
        }
    }
}
