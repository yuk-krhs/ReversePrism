using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 118 Analyzer                                 0001866544C0 ModelClassType CriLipsAnalyzer CriLipsAnalyzer CriLipsAnalyzer Pointer
    // 120 Channel                                  000186698B70 ModelPrimitiveType uint uint uint UInt32
    // 124 HasInitialized                           000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class CriLipsShapeForAnalyzer
    {
        public CriLipsAnalyzer?                         Analyzer                                { get; set; }
        public uint                                     Channel                                 { get; set; }
        public bool                                     HasInitialized                          { get; set; }

        public static CriLipsShapeForAnalyzer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CriLipsShapeForAnalyzer();

            value.Analyzer                                  = GetObject<CriLipsAnalyzer>(new IntPtr(p + 0x118), ReversePrism.DataModels.CriLipsAnalyzer.FromPointer); // 0270DBBA94B0 0x118 Analyzer                    ( 0001866544C0 ModelClassType CriLipsAnalyzer CriLipsAnalyzer CriLipsAnalyzer Pointer )
            value.Channel                                   = GetUInt32(new IntPtr(p + 0x120)); // 0270DBBA94D0 0x120 Channel                     ( 000186698B70 ModelPrimitiveType uint uint uint UInt32 )
            value.HasInitialized                            = GetBool(new IntPtr(p + 0x124)); // 0270DBBA94F0 0x124 HasInitialized              ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
