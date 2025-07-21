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
    // 010 HasActiveTweens                          ModelPrimitiveType bool bool bool Bool
    // 011 HasActiveDefaultTweens                   ModelPrimitiveType bool bool bool Bool
    // 012 HasActiveLateTweens                      ModelPrimitiveType bool bool bool Bool
    // 013 HasActiveFixedTweens                     ModelPrimitiveType bool bool bool Bool
    // 014 HasActiveManualTweens                    ModelPrimitiveType bool bool bool Bool
    // 018 TotActiveTweens                          ModelPrimitiveType int int int Int32
    // 01C TotActiveDefaultTweens                   ModelPrimitiveType int int int Int32
    // 020 TotActiveLateTweens                      ModelPrimitiveType int int int Int32
    // 024 TotActiveFixedTweens                     ModelPrimitiveType int int int Int32
    // 028 TotActiveManualTweens                    ModelPrimitiveType int int int Int32
    // 02C TotActiveTweeners                        ModelPrimitiveType int int int Int32
    // 030 TotActiveSequences                       ModelPrimitiveType int int int Int32
    // 034 TotPooledTweeners                        ModelPrimitiveType int int int Int32
    // 038 TotPooledSequences                       ModelPrimitiveType int int int Int32
    // 03C TotTweeners                              ModelPrimitiveType int int int Int32
    // 040 TotSequences                             ModelPrimitiveType int int int Int32
    // 044 IsUpdateLoop                             ModelPrimitiveType bool bool bool Bool
    // 048 ActiveTweens                             ModelClassListType Tween[] Tween[] List<Tween> Pointer
    // 050 PooledTweeners                           ModelClassListType Tween[] Tween[] List<Tween> Pointer
    // 058 _PooledSequences                         Stack`1<Tween> IL2CPP_TYPE_GENERICINST
    // 060 KillList                                 ModelClassListType List`1<Tween> List`1<Tween> List<Tween> Pointer
    // 068 _TweenLinks                              Dictionary`2<Tween, TweenLink> IL2CPP_TYPE_GENERICINST
    // 070 TotTweenLinks                            ModelPrimitiveType int int int Int32
    // 074 MaxActiveLookupId                        ModelPrimitiveType int int int Int32
    // 078 RequiresActiveReorganization             ModelPrimitiveType bool bool bool Bool
    // 07C ReorganizeFromId                         ModelPrimitiveType int int int Int32
    // 080 MinPooledTweenerId                       ModelPrimitiveType int int int Int32
    // 084 MaxPooledTweenerId                       ModelPrimitiveType int int int Int32
    // 088 DespawnAllCalledFromUpdateLoopCallback   ModelPrimitiveType bool bool bool Bool
    public partial class TweenManager : DataModel
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
            var value   = new TweenManager() { Pointer= p0 };

            value.HasActiveTweens                           = GetBool(new IntPtr(p + 0x010)); // 0x10 HasActiveTweens             ( ModelPrimitiveType bool bool bool Bool )
            value.HasActiveDefaultTweens                    = GetBool(new IntPtr(p + 0x011)); // 0x11 HasActiveDefaultTweens      ( ModelPrimitiveType bool bool bool Bool )
            value.HasActiveLateTweens                       = GetBool(new IntPtr(p + 0x012)); // 0x12 HasActiveLateTweens         ( ModelPrimitiveType bool bool bool Bool )
            value.HasActiveFixedTweens                      = GetBool(new IntPtr(p + 0x013)); // 0x13 HasActiveFixedTweens        ( ModelPrimitiveType bool bool bool Bool )
            value.HasActiveManualTweens                     = GetBool(new IntPtr(p + 0x014)); // 0x14 HasActiveManualTweens       ( ModelPrimitiveType bool bool bool Bool )
            value.TotActiveTweens                           = GetInt32(new IntPtr(p + 0x018)); // 0x18 TotActiveTweens             ( ModelPrimitiveType int int int Int32 )
            value.TotActiveDefaultTweens                    = GetInt32(new IntPtr(p + 0x01C)); // 0x1C TotActiveDefaultTweens      ( ModelPrimitiveType int int int Int32 )
            value.TotActiveLateTweens                       = GetInt32(new IntPtr(p + 0x020)); // 0x20 TotActiveLateTweens         ( ModelPrimitiveType int int int Int32 )
            value.TotActiveFixedTweens                      = GetInt32(new IntPtr(p + 0x024)); // 0x24 TotActiveFixedTweens        ( ModelPrimitiveType int int int Int32 )
            value.TotActiveManualTweens                     = GetInt32(new IntPtr(p + 0x028)); // 0x28 TotActiveManualTweens       ( ModelPrimitiveType int int int Int32 )
            value.TotActiveTweeners                         = GetInt32(new IntPtr(p + 0x02C)); // 0x2C TotActiveTweeners           ( ModelPrimitiveType int int int Int32 )
            value.TotActiveSequences                        = GetInt32(new IntPtr(p + 0x030)); // 0x30 TotActiveSequences          ( ModelPrimitiveType int int int Int32 )
            value.TotPooledTweeners                         = GetInt32(new IntPtr(p + 0x034)); // 0x34 TotPooledTweeners           ( ModelPrimitiveType int int int Int32 )
            value.TotPooledSequences                        = GetInt32(new IntPtr(p + 0x038)); // 0x38 TotPooledSequences          ( ModelPrimitiveType int int int Int32 )
            value.TotTweeners                               = GetInt32(new IntPtr(p + 0x03C)); // 0x3C TotTweeners                 ( ModelPrimitiveType int int int Int32 )
            value.TotSequences                              = GetInt32(new IntPtr(p + 0x040)); // 0x40 TotSequences                ( ModelPrimitiveType int int int Int32 )
            value.IsUpdateLoop                              = GetBool(new IntPtr(p + 0x044)); // 0x44 IsUpdateLoop                ( ModelPrimitiveType bool bool bool Bool )
            value.ActiveTweens                              = GetObjectList<Tween>(new IntPtr(p + 0x048), ReversePrism.DataModels.Tween.FromPointer); // 0x48 ActiveTweens                ( ModelClassListType Tween[] Tween[] List<Tween> Pointer )
            value.PooledTweeners                            = GetObjectList<Tween>(new IntPtr(p + 0x050), ReversePrism.DataModels.Tween.FromPointer); // 0x50 PooledTweeners              ( ModelClassListType Tween[] Tween[] List<Tween> Pointer )
            value.KillList                                  = GetObjectList<Tween>(new IntPtr(p + 0x060), ReversePrism.DataModels.Tween.FromPointer); // 0x60 KillList                    ( ModelClassListType List`1<Tween> List`1<Tween> List<Tween> Pointer )
            value.TotTweenLinks                             = GetInt32(new IntPtr(p + 0x070)); // 0x70 TotTweenLinks               ( ModelPrimitiveType int int int Int32 )
            value.MaxActiveLookupId                         = GetInt32(new IntPtr(p + 0x074)); // 0x74 MaxActiveLookupId           ( ModelPrimitiveType int int int Int32 )
            value.RequiresActiveReorganization              = GetBool(new IntPtr(p + 0x078)); // 0x78 RequiresActiveReorganization ( ModelPrimitiveType bool bool bool Bool )
            value.ReorganizeFromId                          = GetInt32(new IntPtr(p + 0x07C)); // 0x7C ReorganizeFromId            ( ModelPrimitiveType int int int Int32 )
            value.MinPooledTweenerId                        = GetInt32(new IntPtr(p + 0x080)); // 0x80 MinPooledTweenerId          ( ModelPrimitiveType int int int Int32 )
            value.MaxPooledTweenerId                        = GetInt32(new IntPtr(p + 0x084)); // 0x84 MaxPooledTweenerId          ( ModelPrimitiveType int int int Int32 )
            value.DespawnAllCalledFromUpdateLoopCallback    = GetBool(new IntPtr(p + 0x088)); // 0x88 DespawnAllCalledFromUpdateLoopCallback ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
