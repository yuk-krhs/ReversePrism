using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 080 Analyzer                                 ModelClassType CriLipsAnalyzer CriLipsAnalyzer CriLipsAnalyzer Pointer
    // 088 Channel                                  ModelPrimitiveType uint uint uint UInt32
    // 08C HasInitialized                           ModelPrimitiveType bool bool bool Bool
    public partial class CriLipsDeformerForAnalyzer : DataModel
    {
        public CriLipsAnalyzer?                         Analyzer                                { get; set; }
        public uint                                     Channel                                 { get; set; }
        public bool                                     HasInitialized                          { get; set; }

        public static CriLipsDeformerForAnalyzer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CriLipsDeformerForAnalyzer() { Pointer= p0 };

            value.Analyzer                                  = GetObject<CriLipsAnalyzer>(new IntPtr(p + 0x080), ReversePrism.DataModels.CriLipsAnalyzer.FromPointer); // 0x80 Analyzer                    ( ModelClassType CriLipsAnalyzer CriLipsAnalyzer CriLipsAnalyzer Pointer )
            value.Channel                                   = GetUInt32(new IntPtr(p + 0x088)); // 0x88 Channel                     ( ModelPrimitiveType uint uint uint UInt32 )
            value.HasInitialized                            = GetBool(new IntPtr(p + 0x08C)); // 0x8C HasInitialized              ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
