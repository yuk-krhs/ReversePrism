using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Director                               00018674DCD0 ModelClassType PlayableDirector PlayableDirector PlayableDirector Pointer
    // 018 M_Clips                                  000185CABDB8 ModelClassListType TimelineClip[] TimelineClip[] List<TimelineClip> Pointer
    // 020 M_Bind                                   00018664D910 ModelClassType CriAtomSourceBase CriAtomSourceBase CriAtomSourceBase Pointer
    // 028 M_AisacControls                          000186671BA0 ModelPrimitiveType string string string String
    // 030 M_StopOnWrapping                         000186595210 ModelPrimitiveType bool bool bool Bool
    // 031 M_StopAtGraphEnd                         000186595210 ModelPrimitiveType bool bool bool Bool
    // 034 M_Guid                                   0001865DBED0 ModelEnumType Guid Guid Guid Int32
    // 000 cScratchTimeIntervalMs                   int IL2CPP_TYPE_I4
    // 048 M_lastScrubTime                          0001865B9010 ModelPrimitiveType DateTime DateTime DateTime DateTime
    // 050 M_lastDirectorTime                       0001865C2950 ModelPrimitiveType double double double Double
    public partial class CriAtomMixerBehaviour
    {
        public PlayableDirector?                        M_Director                              { get; set; }
        public List<TimelineClip>?                      M_Clips                                 { get; set; }
        public CriAtomSourceBase?                       M_Bind                                  { get; set; }
        public string                                   M_AisacControls                         { get; set; }
        public bool                                     M_StopOnWrapping                        { get; set; }
        public bool                                     M_StopAtGraphEnd                        { get; set; }
        public Guid                                     M_Guid                                  { get; set; }
        public DateTime                                 M_lastScrubTime                         { get; set; }
        public double                                   M_lastDirectorTime                      { get; set; }

        public static CriAtomMixerBehaviour? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CriAtomMixerBehaviour();

            value.M_Director                                = GetObject<PlayableDirector>(new IntPtr(p + 0x010), ReversePrism.DataModels.PlayableDirector.FromPointer); // 0270DACEE8C0 0x10 M_Director                  ( 00018674DCD0 ModelClassType PlayableDirector PlayableDirector PlayableDirector Pointer )
            value.M_Clips                                   = GetObjectList<TimelineClip>(new IntPtr(p + 0x018), ReversePrism.DataModels.TimelineClip.FromPointer); // 0270DACEE8E0 0x18 M_Clips                     ( 000185CABDB8 ModelClassListType TimelineClip[] TimelineClip[] List<TimelineClip> Pointer )
            value.M_Bind                                    = GetObject<CriAtomSourceBase>(new IntPtr(p + 0x020), ReversePrism.DataModels.CriAtomSourceBase.FromPointer); // 0270DACEE900 0x20 M_Bind                      ( 00018664D910 ModelClassType CriAtomSourceBase CriAtomSourceBase CriAtomSourceBase Pointer )
            value.M_AisacControls                           = GetString(new IntPtr(p + 0x028)); // 0270DACEE920 0x28 M_AisacControls             ( 000186671BA0 ModelPrimitiveType string string string String )
            value.M_StopOnWrapping                          = GetBool(new IntPtr(p + 0x030)); // 0270DACEE940 0x30 M_StopOnWrapping            ( 000186595210 ModelPrimitiveType bool bool bool Bool )
            value.M_StopAtGraphEnd                          = GetBool(new IntPtr(p + 0x031)); // 0270DACEE960 0x31 M_StopAtGraphEnd            ( 000186595210 ModelPrimitiveType bool bool bool Bool )
            value.M_Guid                                    = (Guid)GetInt32(new IntPtr(p + 0x034)); // 0270DACEE980 0x34 M_Guid                      ( 0001865DBED0 ModelEnumType Guid Guid Guid Int32 )
            value.M_lastScrubTime                           = GetDateTime(new IntPtr(p + 0x048)); // 0270DACEE9C0 0x48 M_lastScrubTime             ( 0001865B9010 ModelPrimitiveType DateTime DateTime DateTime DateTime )
            value.M_lastDirectorTime                        = GetDouble(new IntPtr(p + 0x050)); // 0270DACEE9E0 0x50 M_lastDirectorTime          ( 0001865C2950 ModelPrimitiveType double double double Double )

            return value;
        }
    }
}
