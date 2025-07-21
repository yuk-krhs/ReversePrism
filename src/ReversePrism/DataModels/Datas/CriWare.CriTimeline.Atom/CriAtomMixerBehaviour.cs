using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Director                               ModelClassType PlayableDirector PlayableDirector PlayableDirector Pointer
    // 018 M_Clips                                  ModelClassListType TimelineClip[] TimelineClip[] List<TimelineClip> Pointer
    // 020 M_Bind                                   ModelClassType CriAtomSourceBase CriAtomSourceBase CriAtomSourceBase Pointer
    // 028 M_AisacControls                          ModelPrimitiveType string string string String
    // 030 M_StopOnWrapping                         ModelPrimitiveType bool bool bool Bool
    // 031 M_StopAtGraphEnd                         ModelPrimitiveType bool bool bool Bool
    // 034 M_Guid                                   ModelEnumType Guid Guid Guid Int32
    // 000 cScratchTimeIntervalMs                   int IL2CPP_TYPE_I4
    // 048 M_lastScrubTime                          ModelPrimitiveType DateTime DateTime DateTime DateTime
    // 050 M_lastDirectorTime                       ModelPrimitiveType double double double Double
    public partial class CriAtomMixerBehaviour : DataModel
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
            var value   = new CriAtomMixerBehaviour() { Pointer= p0 };

            value.M_Director                                = GetObject<PlayableDirector>(new IntPtr(p + 0x010), ReversePrism.DataModels.PlayableDirector.FromPointer); // 0x10 M_Director                  ( ModelClassType PlayableDirector PlayableDirector PlayableDirector Pointer )
            value.M_Clips                                   = GetObjectList<TimelineClip>(new IntPtr(p + 0x018), ReversePrism.DataModels.TimelineClip.FromPointer); // 0x18 M_Clips                     ( ModelClassListType TimelineClip[] TimelineClip[] List<TimelineClip> Pointer )
            value.M_Bind                                    = GetObject<CriAtomSourceBase>(new IntPtr(p + 0x020), ReversePrism.DataModels.CriAtomSourceBase.FromPointer); // 0x20 M_Bind                      ( ModelClassType CriAtomSourceBase CriAtomSourceBase CriAtomSourceBase Pointer )
            value.M_AisacControls                           = GetString(new IntPtr(p + 0x028)); // 0x28 M_AisacControls             ( ModelPrimitiveType string string string String )
            value.M_StopOnWrapping                          = GetBool(new IntPtr(p + 0x030)); // 0x30 M_StopOnWrapping            ( ModelPrimitiveType bool bool bool Bool )
            value.M_StopAtGraphEnd                          = GetBool(new IntPtr(p + 0x031)); // 0x31 M_StopAtGraphEnd            ( ModelPrimitiveType bool bool bool Bool )
            value.M_Guid                                    = (Guid)GetInt32(new IntPtr(p + 0x034)); // 0x34 M_Guid                      ( ModelEnumType Guid Guid Guid Int32 )
            value.M_lastScrubTime                           = GetDateTime(new IntPtr(p + 0x048)); // 0x48 M_lastScrubTime             ( ModelPrimitiveType DateTime DateTime DateTime DateTime )
            value.M_lastDirectorTime                        = GetDouble(new IntPtr(p + 0x050)); // 0x50 M_lastDirectorTime          ( ModelPrimitiveType double double double Double )

            return value;
        }
    }
}
