using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 m_KeywordState                           <int> IL2CPP_TYPE_I
    // 018 m_Shader                                 <int> IL2CPP_TYPE_I
    // 020 m_ComputeShader                          <int> IL2CPP_TYPE_I
    // 028 M_StateIndex                             ModelPrimitiveType ulong ulong ulong UInt64
    public partial class ShaderKeywordSet : DataModel
    {
        public ulong                                    M_StateIndex                            { get; set; }

        public static ShaderKeywordSet? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ShaderKeywordSet() { Pointer= p0 };

            value.M_StateIndex                              = GetUInt64(new IntPtr(p + 0x028)); // 0x28 M_StateIndex                ( ModelPrimitiveType ulong ulong ulong UInt64 )

            return value;
        }
    }
}
