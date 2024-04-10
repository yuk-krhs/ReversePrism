using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 030 Player                                   000186648E20 ModelClassType CriAtomExPlayer CriAtomExPlayer CriAtomExPlayer Pointer
    // 038 Source                                   0001866445E0 ModelClassType CriAtomEx3dSource CriAtomEx3dSource CriAtomEx3dSource Pointer
    // 040 Initialized                              000186595480 ModelPrimitiveType bool bool bool Bool
    // 044 LastPosition                             0001866ABD10 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 050 HasValidPosition                         000186595480 ModelPrimitiveType bool bool bool Bool
    // 058 CurrentRegion                            00018664C440 ModelClassType CriAtomRegion CriAtomRegion CriAtomRegion Pointer
    // 060 CurrentListener                          00018664B5A0 ModelClassType CriAtomListener CriAtomListener CriAtomListener Pointer
    // 068 PlayOnStart                              000186594D10 ModelPrimitiveType bool bool bool Bool
    // 070 RegionOnStart                            00018664C440 ModelClassType CriAtomRegion CriAtomRegion CriAtomRegion Pointer
    // 078 ListenerOnStart                          00018664B5A0 ModelClassType CriAtomListener CriAtomListener CriAtomListener Pointer
    // 080 Use3dPositioning                         000186594D10 ModelPrimitiveType bool bool bool Bool
    // 081 FreezeOrientation                        000186594D10 ModelPrimitiveType bool bool bool Bool
    // 082 Loop                                     000186594D10 ModelPrimitiveType bool bool bool Bool
    // 084 Volume                                   0001866656B0 ModelPrimitiveType float float float Single
    // 088 Pitch                                    0001866656B0 ModelPrimitiveType float float float Single
    // 08C AndroidUseLowLatencyVoicePool            000186594D10 ModelPrimitiveType bool bool bool Bool
    // 08D Need_to_player_update_all                000186594D10 ModelPrimitiveType bool bool bool Bool
    // 08E Use3dRandomization                       000186594D10 ModelPrimitiveType bool bool bool Bool
    // 090 RandomPositionListMaxLength              000186698B70 ModelPrimitiveType uint uint uint UInt32
    // 098 Randomize3dConfig                        0001866D65B0 ModelEnumType Randomize3dConfig Randomize3dConfig Randomize3dConfig Int32
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

            value.Player                                    = GetObject<CriAtomExPlayer>(new IntPtr(p + 0x030), ReversePrism.DataModels.CriAtomExPlayer.FromPointer); // 0245A421E648 0x30 Player                      ( 000186648E20 ModelClassType CriAtomExPlayer CriAtomExPlayer CriAtomExPlayer Pointer )
            value.Source                                    = GetObject<CriAtomEx3dSource>(new IntPtr(p + 0x038), ReversePrism.DataModels.CriAtomEx3dSource.FromPointer); // 0245A421E668 0x38 Source                      ( 0001866445E0 ModelClassType CriAtomEx3dSource CriAtomEx3dSource CriAtomEx3dSource Pointer )
            value.Initialized                               = GetBool(new IntPtr(p + 0x040)); // 0245A421E688 0x40 Initialized                 ( 000186595480 ModelPrimitiveType bool bool bool Bool )
            value.LastPosition                              = (Vector3)GetInt32(new IntPtr(p + 0x044)); // 0245A421E6A8 0x44 LastPosition                ( 0001866ABD10 ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.HasValidPosition                          = GetBool(new IntPtr(p + 0x050)); // 0245A421E6C8 0x50 HasValidPosition            ( 000186595480 ModelPrimitiveType bool bool bool Bool )
            value.CurrentRegion                             = GetObject<CriAtomRegion>(new IntPtr(p + 0x058), ReversePrism.DataModels.CriAtomRegion.FromPointer); // 0245A421E6E8 0x58 CurrentRegion               ( 00018664C440 ModelClassType CriAtomRegion CriAtomRegion CriAtomRegion Pointer )
            value.CurrentListener                           = GetObject<CriAtomListener>(new IntPtr(p + 0x060), ReversePrism.DataModels.CriAtomListener.FromPointer); // 0245A421E708 0x60 CurrentListener             ( 00018664B5A0 ModelClassType CriAtomListener CriAtomListener CriAtomListener Pointer )
            value.PlayOnStart                               = GetBool(new IntPtr(p + 0x068)); // 0245A421E728 0x68 PlayOnStart                 ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.RegionOnStart                             = GetObject<CriAtomRegion>(new IntPtr(p + 0x070), ReversePrism.DataModels.CriAtomRegion.FromPointer); // 0245A421E748 0x70 RegionOnStart               ( 00018664C440 ModelClassType CriAtomRegion CriAtomRegion CriAtomRegion Pointer )
            value.ListenerOnStart                           = GetObject<CriAtomListener>(new IntPtr(p + 0x078), ReversePrism.DataModels.CriAtomListener.FromPointer); // 0245A421E768 0x78 ListenerOnStart             ( 00018664B5A0 ModelClassType CriAtomListener CriAtomListener CriAtomListener Pointer )
            value.Use3dPositioning                          = GetBool(new IntPtr(p + 0x080)); // 0245A421E788 0x80 Use3dPositioning            ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.FreezeOrientation                         = GetBool(new IntPtr(p + 0x081)); // 0245A421E7A8 0x81 FreezeOrientation           ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Loop                                      = GetBool(new IntPtr(p + 0x082)); // 0245A421E7C8 0x82 Loop                        ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Volume                                    = GetSingle(new IntPtr(p + 0x084)); // 0245A421E7E8 0x84 Volume                      ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.Pitch                                     = GetSingle(new IntPtr(p + 0x088)); // 0245A421E808 0x88 Pitch                       ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.AndroidUseLowLatencyVoicePool             = GetBool(new IntPtr(p + 0x08C)); // 0245A421E828 0x8C AndroidUseLowLatencyVoicePool ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Need_to_player_update_all                 = GetBool(new IntPtr(p + 0x08D)); // 0245A421E848 0x8D Need_to_player_update_all   ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Use3dRandomization                        = GetBool(new IntPtr(p + 0x08E)); // 0245A421E868 0x8E Use3dRandomization          ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.RandomPositionListMaxLength               = GetUInt32(new IntPtr(p + 0x090)); // 0245A421E888 0x90 RandomPositionListMaxLength ( 000186698B70 ModelPrimitiveType uint uint uint UInt32 )
            value.Randomize3dConfig                         = (Randomize3dConfig)GetInt32(new IntPtr(p + 0x098)); // 0245A421E8A8 0x98 Randomize3dConfig           ( 0001866D65B0 ModelEnumType Randomize3dConfig Randomize3dConfig Randomize3dConfig Int32 )

            return value;
        }
    }
}
