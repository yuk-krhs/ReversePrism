using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 078 AtomSource                               ModelClassType CriAtomSource CriAtomSource CriAtomSource Pointer
    // 080 AtomAnalyzer                             ModelClassType CriLipsAtomAnalyzer CriLipsAtomAnalyzer CriLipsAtomAnalyzer Pointer
    // 088 StartupSamplingRate                      ModelPrimitiveType int int int Int32
    // 08C ShouldRetryInternalAttach                ModelPrimitiveType bool bool bool Bool
    public partial class CriLipsAnalyzerForAtomSource : DataModel
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
            var value   = new CriLipsAnalyzerForAtomSource() { Pointer= p0 };

            value.AtomSource                                = GetObject<CriAtomSource>(new IntPtr(p + 0x078), ReversePrism.DataModels.CriAtomSource.FromPointer); // 0x78 AtomSource                  ( ModelClassType CriAtomSource CriAtomSource CriAtomSource Pointer )
            value.AtomAnalyzer                              = GetObject<CriLipsAtomAnalyzer>(new IntPtr(p + 0x080), ReversePrism.DataModels.CriLipsAtomAnalyzer.FromPointer); // 0x80 AtomAnalyzer                ( ModelClassType CriLipsAtomAnalyzer CriLipsAtomAnalyzer CriLipsAtomAnalyzer Pointer )
            value.StartupSamplingRate                       = GetInt32(new IntPtr(p + 0x088)); // 0x88 StartupSamplingRate         ( ModelPrimitiveType int int int Int32 )
            value.ShouldRetryInternalAttach                 = GetBool(new IntPtr(p + 0x08C)); // 0x8C ShouldRetryInternalAttach   ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
