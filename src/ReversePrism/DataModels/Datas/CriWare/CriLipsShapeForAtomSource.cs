using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 118 Source                                   ModelClassType CriAtomSourceBase CriAtomSourceBase CriAtomSourceBase Pointer
    // 120 AtomAnalyzer                             ModelClassType CriLipsAtomAnalyzer CriLipsAtomAnalyzer CriLipsAtomAnalyzer Pointer
    // 128 SilenceThreshold                         ModelPrimitiveType float float float Single
    // 12C SamplingRate                             ModelPrimitiveType int int int Int32
    public partial class CriLipsShapeForAtomSource : DataModel
    {
        public CriAtomSourceBase?                       Source                                  { get; set; }
        public CriLipsAtomAnalyzer?                     AtomAnalyzer                            { get; set; }
        public float                                    SilenceThreshold                        { get; set; }
        public int                                      SamplingRate                            { get; set; }

        public static CriLipsShapeForAtomSource? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CriLipsShapeForAtomSource() { Pointer= p0 };

            value.Source                                    = GetObject<CriAtomSourceBase>(new IntPtr(p + 0x118), ReversePrism.DataModels.CriAtomSourceBase.FromPointer); // 0x118 Source                      ( ModelClassType CriAtomSourceBase CriAtomSourceBase CriAtomSourceBase Pointer )
            value.AtomAnalyzer                              = GetObject<CriLipsAtomAnalyzer>(new IntPtr(p + 0x120), ReversePrism.DataModels.CriLipsAtomAnalyzer.FromPointer); // 0x120 AtomAnalyzer                ( ModelClassType CriLipsAtomAnalyzer CriLipsAtomAnalyzer CriLipsAtomAnalyzer Pointer )
            value.SilenceThreshold                          = GetSingle(new IntPtr(p + 0x128)); // 0x128 SilenceThreshold            ( ModelPrimitiveType float float float Single )
            value.SamplingRate                              = GetInt32(new IntPtr(p + 0x12C)); // 0x12C SamplingRate                ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
