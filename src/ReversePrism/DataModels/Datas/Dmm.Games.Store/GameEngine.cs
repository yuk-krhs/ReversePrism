using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 GameEngineName                           0001866722E0 ModelPrimitiveType string string string String
    // 018 GameEngineParameter                      0001865E61E0 ModelClassType GameEngineParameter GameEngineParameter GameEngineParameter Pointer
    public partial class GameEngine : DataModel
    {
        public string                                   GameEngineName                          { get; set; }
        public GameEngineParameter?                     GameEngineParameter                     { get; set; }

        public static GameEngine? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GameEngine() { Pointer= p0 };

            value.GameEngineName                            = GetString(new IntPtr(p + 0x010)); // 02466B511AF8 0x10 GameEngineName              ( 0001866722E0 ModelPrimitiveType string string string String )
            value.GameEngineParameter                       = GetObject<GameEngineParameter>(new IntPtr(p + 0x018), ReversePrism.DataModels.GameEngineParameter.FromPointer); // 02466B511B18 0x18 GameEngineParameter         ( 0001865E61E0 ModelClassType GameEngineParameter GameEngineParameter GameEngineParameter Pointer )

            return value;
        }
    }
}
