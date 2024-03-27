using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _DefaultMaxTweeners                      int IL2CPP_TYPE_I4
    // 000 _DefaultMaxSequences                     int IL2CPP_TYPE_I4
    // 000 _MaxTweensReached                        string IL2CPP_TYPE_STRING
    // 000 _EpsilonVsTimeCheck                      float IL2CPP_TYPE_R4
    // 000 isUnityEditor                            bool IL2CPP_TYPE_BOOLEAN
    // 001 isDebugBuild                             bool IL2CPP_TYPE_BOOLEAN
    // 004 maxActive                                int IL2CPP_TYPE_I4
    // 008 maxTweeners                              int IL2CPP_TYPE_I4
    // 00C maxSequences                             int IL2CPP_TYPE_I4
    // 010 HasActiveTweens                          000186595E60 ModelPrimitiveType bool bool bool Bool
    // 011 HasActiveDefaultTweens                   000186595E60 ModelPrimitiveType bool bool bool Bool
    // 012 HasActiveLateTweens                      000186595E60 ModelPrimitiveType bool bool bool Bool
    // 013 HasActiveFixedTweens                     000186595E60 ModelPrimitiveType bool bool bool Bool
    // 014 HasActiveManualTweens                    000186595E60 ModelPrimitiveType bool bool bool Bool
    // 018 TotActiveTweens                          0001865F3B80 ModelPrimitiveType int int int Int32
    // 01C TotActiveDefaultTweens                   0001865F3B80 ModelPrimitiveType int int int Int32
    // 020 TotActiveLateTweens                      0001865F3B80 ModelPrimitiveType int int int Int32
    // 024 TotActiveFixedTweens                     0001865F3B80 ModelPrimitiveType int int int Int32
    // 028 TotActiveManualTweens                    0001865F3B80 ModelPrimitiveType int int int Int32
    // 02C TotActiveTweeners                        0001865F3B80 ModelPrimitiveType int int int Int32
    // 030 TotActiveSequences                       0001865F3B80 ModelPrimitiveType int int int Int32
    // 034 TotPooledTweeners                        0001865F3B80 ModelPrimitiveType int int int Int32
    // 038 TotPooledSequences                       0001865F3B80 ModelPrimitiveType int int int Int32
    // 03C TotTweeners                              0001865F3B80 ModelPrimitiveType int int int Int32
    // 040 TotSequences                             0001865F3B80 ModelPrimitiveType int int int Int32
    // 044 IsUpdateLoop                             000186595E60 ModelPrimitiveType bool bool bool Bool
    // 048 ActiveTweens                             000185CAD5E8 ModelClassListType Tween[] Tween[] List<Tween> Pointer
    // 050 PooledTweeners                           000185CAD4A8 ModelClassListType Tween[] Tween[] List<Tween> Pointer
    // 058 _PooledSequences                         Stack`1<Tween> IL2CPP_TYPE_GENERICINST
    // 060 KillList                                 000185D16758 ModelClassListType List`1<Tween> List`1<Tween> List<Tween> Pointer
    // 068 _TweenLinks                              Dictionary`2<Tween, TweenLink> IL2CPP_TYPE_GENERICINST
    // 070 TotTweenLinks                            0001865F38E0 ModelPrimitiveType int int int Int32
    // 074 MaxActiveLookupId                        0001865F38E0 ModelPrimitiveType int int int Int32
    // 078 RequiresActiveReorganization             000186595C30 ModelPrimitiveType bool bool bool Bool
    // 07C ReorganizeFromId                         0001865F38E0 ModelPrimitiveType int int int Int32
    // 080 MinPooledTweenerId                       0001865F38E0 ModelPrimitiveType int int int Int32
    // 084 MaxPooledTweenerId                       0001865F38E0 ModelPrimitiveType int int int Int32
    // 088 DespawnAllCalledFromUpdateLoopCallback   000186595C30 ModelPrimitiveType bool bool bool Bool
    public partial class TweenManager
    {
        public bool                                     HasActiveTweens                         { get; set; }
        public bool                                     HasActiveDefaultTweens                  { get; set; }
        public bool                                     HasActiveLateTweens                     { get; set; }
        public bool                                     HasActiveFixedTweens                    { get; set; }
        public bool                                     HasActiveManualTweens                   { get; set; }
        public int                                      TotActiveTweens                         { get; set; }
        public int                                      TotActiveDefaultTweens                  { get; set; }
        public int                                      TotActiveLateTweens                     { get; set; }
        public int                                      TotActiveFixedTweens                    { get; set; }
        public int                                      TotActiveManualTweens                   { get; set; }
        public int                                      TotActiveTweeners                       { get; set; }
        public int                                      TotActiveSequences                      { get; set; }
        public int                                      TotPooledTweeners                       { get; set; }
        public int                                      TotPooledSequences                      { get; set; }
        public int                                      TotTweeners                             { get; set; }
        public int                                      TotSequences                            { get; set; }
        public bool                                     IsUpdateLoop                            { get; set; }
        public List<Tween>?                             ActiveTweens                            { get; set; }
        public List<Tween>?                             PooledTweeners                          { get; set; }
        public List<Tween>?                             KillList                                { get; set; }
        public int                                      TotTweenLinks                           { get; set; }
        public int                                      MaxActiveLookupId                       { get; set; }
        public bool                                     RequiresActiveReorganization            { get; set; }
        public int                                      ReorganizeFromId                        { get; set; }
        public int                                      MinPooledTweenerId                      { get; set; }
        public int                                      MaxPooledTweenerId                      { get; set; }
        public bool                                     DespawnAllCalledFromUpdateLoopCallback  { get; set; }

        public static TweenManager? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TweenManager();

            value.HasActiveTweens                           = GetBool(new IntPtr(p + 0x010)); // 027004347920 0x10 HasActiveTweens             ( 000186595E60 ModelPrimitiveType bool bool bool Bool )
            value.HasActiveDefaultTweens                    = GetBool(new IntPtr(p + 0x011)); // 027004347940 0x11 HasActiveDefaultTweens      ( 000186595E60 ModelPrimitiveType bool bool bool Bool )
            value.HasActiveLateTweens                       = GetBool(new IntPtr(p + 0x012)); // 027004347960 0x12 HasActiveLateTweens         ( 000186595E60 ModelPrimitiveType bool bool bool Bool )
            value.HasActiveFixedTweens                      = GetBool(new IntPtr(p + 0x013)); // 027004347980 0x13 HasActiveFixedTweens        ( 000186595E60 ModelPrimitiveType bool bool bool Bool )
            value.HasActiveManualTweens                     = GetBool(new IntPtr(p + 0x014)); // 0270043479A0 0x14 HasActiveManualTweens       ( 000186595E60 ModelPrimitiveType bool bool bool Bool )
            value.TotActiveTweens                           = GetInt32(new IntPtr(p + 0x018)); // 0270043479C0 0x18 TotActiveTweens             ( 0001865F3B80 ModelPrimitiveType int int int Int32 )
            value.TotActiveDefaultTweens                    = GetInt32(new IntPtr(p + 0x01C)); // 0270043479E0 0x1C TotActiveDefaultTweens      ( 0001865F3B80 ModelPrimitiveType int int int Int32 )
            value.TotActiveLateTweens                       = GetInt32(new IntPtr(p + 0x020)); // 027004347A00 0x20 TotActiveLateTweens         ( 0001865F3B80 ModelPrimitiveType int int int Int32 )
            value.TotActiveFixedTweens                      = GetInt32(new IntPtr(p + 0x024)); // 027004347A20 0x24 TotActiveFixedTweens        ( 0001865F3B80 ModelPrimitiveType int int int Int32 )
            value.TotActiveManualTweens                     = GetInt32(new IntPtr(p + 0x028)); // 027004347A40 0x28 TotActiveManualTweens       ( 0001865F3B80 ModelPrimitiveType int int int Int32 )
            value.TotActiveTweeners                         = GetInt32(new IntPtr(p + 0x02C)); // 027004347A60 0x2C TotActiveTweeners           ( 0001865F3B80 ModelPrimitiveType int int int Int32 )
            value.TotActiveSequences                        = GetInt32(new IntPtr(p + 0x030)); // 027004347A80 0x30 TotActiveSequences          ( 0001865F3B80 ModelPrimitiveType int int int Int32 )
            value.TotPooledTweeners                         = GetInt32(new IntPtr(p + 0x034)); // 027004347AA0 0x34 TotPooledTweeners           ( 0001865F3B80 ModelPrimitiveType int int int Int32 )
            value.TotPooledSequences                        = GetInt32(new IntPtr(p + 0x038)); // 027004347AC0 0x38 TotPooledSequences          ( 0001865F3B80 ModelPrimitiveType int int int Int32 )
            value.TotTweeners                               = GetInt32(new IntPtr(p + 0x03C)); // 027004347AE0 0x3C TotTweeners                 ( 0001865F3B80 ModelPrimitiveType int int int Int32 )
            value.TotSequences                              = GetInt32(new IntPtr(p + 0x040)); // 027004347B00 0x40 TotSequences                ( 0001865F3B80 ModelPrimitiveType int int int Int32 )
            value.IsUpdateLoop                              = GetBool(new IntPtr(p + 0x044)); // 027004347B20 0x44 IsUpdateLoop                ( 000186595E60 ModelPrimitiveType bool bool bool Bool )
            value.ActiveTweens                              = GetObjectList<Tween>(new IntPtr(p + 0x048), ReversePrism.DataModels.Tween.FromPointer); // 027004347B40 0x48 ActiveTweens                ( 000185CAD5E8 ModelClassListType Tween[] Tween[] List<Tween> Pointer )
            value.PooledTweeners                            = GetObjectList<Tween>(new IntPtr(p + 0x050), ReversePrism.DataModels.Tween.FromPointer); // 027004347B60 0x50 PooledTweeners              ( 000185CAD4A8 ModelClassListType Tween[] Tween[] List<Tween> Pointer )
            value.KillList                                  = GetObjectList<Tween>(new IntPtr(p + 0x060), ReversePrism.DataModels.Tween.FromPointer); // 027004347BA0 0x60 KillList                    ( 000185D16758 ModelClassListType List`1<Tween> List`1<Tween> List<Tween> Pointer )
            value.TotTweenLinks                             = GetInt32(new IntPtr(p + 0x070)); // 027004347BE0 0x70 TotTweenLinks               ( 0001865F38E0 ModelPrimitiveType int int int Int32 )
            value.MaxActiveLookupId                         = GetInt32(new IntPtr(p + 0x074)); // 027004347C00 0x74 MaxActiveLookupId           ( 0001865F38E0 ModelPrimitiveType int int int Int32 )
            value.RequiresActiveReorganization              = GetBool(new IntPtr(p + 0x078)); // 027004347C20 0x78 RequiresActiveReorganization ( 000186595C30 ModelPrimitiveType bool bool bool Bool )
            value.ReorganizeFromId                          = GetInt32(new IntPtr(p + 0x07C)); // 027004347C40 0x7C ReorganizeFromId            ( 0001865F38E0 ModelPrimitiveType int int int Int32 )
            value.MinPooledTweenerId                        = GetInt32(new IntPtr(p + 0x080)); // 027004347C60 0x80 MinPooledTweenerId          ( 0001865F38E0 ModelPrimitiveType int int int Int32 )
            value.MaxPooledTweenerId                        = GetInt32(new IntPtr(p + 0x084)); // 027004347C80 0x84 MaxPooledTweenerId          ( 0001865F38E0 ModelPrimitiveType int int int Int32 )
            value.DespawnAllCalledFromUpdateLoopCallback    = GetBool(new IntPtr(p + 0x088)); // 027004347CA0 0x88 DespawnAllCalledFromUpdateLoopCallback ( 000186595C30 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
