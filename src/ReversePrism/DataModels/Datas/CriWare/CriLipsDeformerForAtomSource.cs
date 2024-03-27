using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 080 Source                                   00018664D910 ModelClassType CriAtomSourceBase CriAtomSourceBase CriAtomSourceBase Pointer
    // 088 AtomAnalyzer                             000186654C20 ModelClassType CriLipsAtomAnalyzer CriLipsAtomAnalyzer CriLipsAtomAnalyzer Pointer
    // 090 SilenceThreshold                         000186666050 ModelPrimitiveType float float float Single
    // 094 SamplingRate                             0001865F36C0 ModelPrimitiveType int int int Int32
    public partial class CriLipsDeformerForAtomSource
    {
        public CriAtomSourceBase?                       Source                                  { get; set; }
        public CriLipsAtomAnalyzer?                     AtomAnalyzer                            { get; set; }
        public float                                    SilenceThreshold                        { get; set; }
        public int                                      SamplingRate                            { get; set; }

        public static CriLipsDeformerForAtomSource? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CriLipsDeformerForAtomSource();

            value.Source                                    = GetObject<CriAtomSourceBase>(new IntPtr(p + 0x080), ReversePrism.DataModels.CriAtomSourceBase.FromPointer); // 0270DBBA66F8 0x80 Source                      ( 00018664D910 ModelClassType CriAtomSourceBase CriAtomSourceBase CriAtomSourceBase Pointer )
            value.AtomAnalyzer                              = GetObject<CriLipsAtomAnalyzer>(new IntPtr(p + 0x088), ReversePrism.DataModels.CriLipsAtomAnalyzer.FromPointer); // 0270DBBA6718 0x88 AtomAnalyzer                ( 000186654C20 ModelClassType CriLipsAtomAnalyzer CriLipsAtomAnalyzer CriLipsAtomAnalyzer Pointer )
            value.SilenceThreshold                          = GetSingle(new IntPtr(p + 0x090)); // 0270DBBA6738 0x90 SilenceThreshold            ( 000186666050 ModelPrimitiveType float float float Single )
            value.SamplingRate                              = GetInt32(new IntPtr(p + 0x094)); // 0270DBBA6758 0x94 SamplingRate                ( 0001865F36C0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
