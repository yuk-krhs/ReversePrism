using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 NormalOutlineString                      string IL2CPP_TYPE_STRING
    // 000 NormalOutlineLiteString                  string IL2CPP_TYPE_STRING
    // 000 NormalOutlineSuperLiteString             string IL2CPP_TYPE_STRING
    // 000 NormalOutline                            Shader IL2CPP_TYPE_CLASS
    // 008 NormalOutlineLite                        Shader IL2CPP_TYPE_CLASS
    // 010 NormalOutlineSuperLite                   00018674D100 ModelClassType Shader Shader Shader Pointer
    public partial class CharaShader
    {
        public Shader?                                  NormalOutlineSuperLite                  { get; set; }

        public static CharaShader? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CharaShader();

            value.NormalOutlineSuperLite                    = GetObject<Shader>(new IntPtr(p + 0x010), ReversePrism.DataModels.Shader.FromPointer); // 0270073B3C68 0x10 NormalOutlineSuperLite      ( 00018674D100 ModelClassType Shader Shader Shader Pointer )

            return value;
        }
    }
}
