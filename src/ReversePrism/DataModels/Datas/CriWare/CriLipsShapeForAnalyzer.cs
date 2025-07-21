using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 118 Analyzer                                 ModelClassType CriLipsAnalyzer CriLipsAnalyzer CriLipsAnalyzer Pointer
    // 120 Channel                                  ModelPrimitiveType uint uint uint UInt32
    // 124 HasInitialized                           ModelPrimitiveType bool bool bool Bool
    public partial class CriLipsShapeForAnalyzer : DataModel
    {
        public CriLipsAnalyzer?                         Analyzer                                { get; set; }
        public uint                                     Channel                                 { get; set; }
        public bool                                     HasInitialized                          { get; set; }

        public static CriLipsShapeForAnalyzer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CriLipsShapeForAnalyzer() { Pointer= p0 };

            value.Analyzer                                  = GetObject<CriLipsAnalyzer>(new IntPtr(p + 0x118), ReversePrism.DataModels.CriLipsAnalyzer.FromPointer); // 0x118 Analyzer                    ( ModelClassType CriLipsAnalyzer CriLipsAnalyzer CriLipsAnalyzer Pointer )
            value.Channel                                   = GetUInt32(new IntPtr(p + 0x120)); // 0x120 Channel                     ( ModelPrimitiveType uint uint uint UInt32 )
            value.HasInitialized                            = GetBool(new IntPtr(p + 0x124)); // 0x124 HasInitialized              ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
