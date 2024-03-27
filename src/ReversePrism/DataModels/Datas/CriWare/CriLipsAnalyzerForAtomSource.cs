using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 078 AtomSource                               00018664CF70 ModelClassType CriAtomSource CriAtomSource CriAtomSource Pointer
    // 080 AtomAnalyzer                             000186654E90 ModelClassType CriLipsAtomAnalyzer CriLipsAtomAnalyzer CriLipsAtomAnalyzer Pointer
    // 088 StartupSamplingRate                      0001865F3220 ModelPrimitiveType int int int Int32
    // 08C ShouldRetryInternalAttach                000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class CriLipsAnalyzerForAtomSource
    {
        public CriAtomSource?                           AtomSource                              { get; set; }
        public CriLipsAtomAnalyzer?                     AtomAnalyzer                            { get; set; }
        public int                                      StartupSamplingRate                     { get; set; }
        public bool                                     ShouldRetryInternalAttach               { get; set; }

        public static CriLipsAnalyzerForAtomSource? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CriLipsAnalyzerForAtomSource();

            value.AtomSource                                = GetObject<CriAtomSource>(new IntPtr(p + 0x078), ReversePrism.DataModels.CriAtomSource.FromPointer); // 0270DBBA52C8 0x78 AtomSource                  ( 00018664CF70 ModelClassType CriAtomSource CriAtomSource CriAtomSource Pointer )
            value.AtomAnalyzer                              = GetObject<CriLipsAtomAnalyzer>(new IntPtr(p + 0x080), ReversePrism.DataModels.CriLipsAtomAnalyzer.FromPointer); // 0270DBBA52E8 0x80 AtomAnalyzer                ( 000186654E90 ModelClassType CriLipsAtomAnalyzer CriLipsAtomAnalyzer CriLipsAtomAnalyzer Pointer )
            value.StartupSamplingRate                       = GetInt32(new IntPtr(p + 0x088)); // 0270DBBA5308 0x88 StartupSamplingRate         ( 0001865F3220 ModelPrimitiveType int int int Int32 )
            value.ShouldRetryInternalAttach                 = GetBool(new IntPtr(p + 0x08C)); // 0270DBBA5328 0x8C ShouldRetryInternalAttach   ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
