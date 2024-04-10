using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 118 Source                                   00018664DBE0 ModelClassType CriAtomSourceBase CriAtomSourceBase CriAtomSourceBase Pointer
    // 120 AtomAnalyzer                             000186654C20 ModelClassType CriLipsAtomAnalyzer CriLipsAtomAnalyzer CriLipsAtomAnalyzer Pointer
    // 128 SilenceThreshold                         000186666050 ModelPrimitiveType float float float Single
    // 12C SamplingRate                             0001865F36C0 ModelPrimitiveType int int int Int32
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

            value.Source                                    = GetObject<CriAtomSourceBase>(new IntPtr(p + 0x118), ReversePrism.DataModels.CriAtomSourceBase.FromPointer); // 02466BC409D0 0x118 Source                      ( 00018664DBE0 ModelClassType CriAtomSourceBase CriAtomSourceBase CriAtomSourceBase Pointer )
            value.AtomAnalyzer                              = GetObject<CriLipsAtomAnalyzer>(new IntPtr(p + 0x120), ReversePrism.DataModels.CriLipsAtomAnalyzer.FromPointer); // 02466BC409F0 0x120 AtomAnalyzer                ( 000186654C20 ModelClassType CriLipsAtomAnalyzer CriLipsAtomAnalyzer CriLipsAtomAnalyzer Pointer )
            value.SilenceThreshold                          = GetSingle(new IntPtr(p + 0x128)); // 02466BC40A10 0x128 SilenceThreshold            ( 000186666050 ModelPrimitiveType float float float Single )
            value.SamplingRate                              = GetInt32(new IntPtr(p + 0x12C)); // 02466BC40A30 0x12C SamplingRate                ( 0001865F36C0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
