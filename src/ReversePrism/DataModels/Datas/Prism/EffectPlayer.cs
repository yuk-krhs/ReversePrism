using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 IsInCutScene                             ModelPrimitiveType bool bool bool Bool
    // 028 EffectControllerList                     ModelClassListType List`1<EffectController> List`1<EffectController> List<EffectController> Pointer
    // 030 MarkerList                               ModelClassListType List`1<EffectPlayMarker> List`1<EffectPlayMarker> List<EffectPlayMarker> Pointer
    // 038 NoRenderEffectLayer                      ModelPrimitiveType int int int Int32
    // 03C DefaultLayer                             ModelPrimitiveType int int int Int32
    // 040 PostprocessLayer                         ModelPrimitiveType int int int Int32
    // 044 IsIgnore                                 ModelPrimitiveType bool bool bool Bool
    // 045 IsShowUnitTrackEffect                    ModelPrimitiveType bool bool bool Bool
    // 046 IsShowAlwayTrackEffect                   ModelPrimitiveType bool bool bool Bool
    // 048 RhythmGameOption                         ModelClassType RhythmGameOptionBasic RhythmGameOptionBasic RhythmGameOptionBasic Pointer
    public partial class EffectPlayer : DataModel
    {
        public bool                                     IsInCutScene                            { get; set; }
        public List<EffectController>?                  EffectControllerList                    { get; set; }
        public List<EffectPlayMarker>?                  MarkerList                              { get; set; }
        public int                                      NoRenderEffectLayer                     { get; set; }
        public int                                      DefaultLayer                            { get; set; }
        public int                                      PostprocessLayer                        { get; set; }
        public bool                                     IsIgnore                                { get; set; }
        public bool                                     IsShowUnitTrackEffect                   { get; set; }
        public bool                                     IsShowAlwayTrackEffect                  { get; set; }
        public RhythmGameOptionBasic?                   RhythmGameOption                        { get; set; }

        public static EffectPlayer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EffectPlayer() { Pointer= p0 };

            value.IsInCutScene                              = GetBool(new IntPtr(p + 0x020)); // 0x20 IsInCutScene                ( ModelPrimitiveType bool bool bool Bool )
            value.EffectControllerList                      = GetObjectList<EffectController>(new IntPtr(p + 0x028), ReversePrism.DataModels.EffectController.FromPointer); // 0x28 EffectControllerList        ( ModelClassListType List`1<EffectController> List`1<EffectController> List<EffectController> Pointer )
            value.MarkerList                                = GetObjectList<EffectPlayMarker>(new IntPtr(p + 0x030), ReversePrism.DataModels.EffectPlayMarker.FromPointer); // 0x30 MarkerList                  ( ModelClassListType List`1<EffectPlayMarker> List`1<EffectPlayMarker> List<EffectPlayMarker> Pointer )
            value.NoRenderEffectLayer                       = GetInt32(new IntPtr(p + 0x038)); // 0x38 NoRenderEffectLayer         ( ModelPrimitiveType int int int Int32 )
            value.DefaultLayer                              = GetInt32(new IntPtr(p + 0x03C)); // 0x3C DefaultLayer                ( ModelPrimitiveType int int int Int32 )
            value.PostprocessLayer                          = GetInt32(new IntPtr(p + 0x040)); // 0x40 PostprocessLayer            ( ModelPrimitiveType int int int Int32 )
            value.IsIgnore                                  = GetBool(new IntPtr(p + 0x044)); // 0x44 IsIgnore                    ( ModelPrimitiveType bool bool bool Bool )
            value.IsShowUnitTrackEffect                     = GetBool(new IntPtr(p + 0x045)); // 0x45 IsShowUnitTrackEffect       ( ModelPrimitiveType bool bool bool Bool )
            value.IsShowAlwayTrackEffect                    = GetBool(new IntPtr(p + 0x046)); // 0x46 IsShowAlwayTrackEffect      ( ModelPrimitiveType bool bool bool Bool )
            value.RhythmGameOption                          = GetObject<RhythmGameOptionBasic>(new IntPtr(p + 0x048), ReversePrism.DataModels.RhythmGameOptionBasic.FromPointer); // 0x48 RhythmGameOption            ( ModelClassType RhythmGameOptionBasic RhythmGameOptionBasic RhythmGameOptionBasic Pointer )

            return value;
        }
    }
}
