using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 GameEngineName                           ModelPrimitiveType string string string String
    // 018 GameEngineParameter                      ModelClassType GameEngineParameter GameEngineParameter GameEngineParameter Pointer
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

            value.GameEngineName                            = GetString(new IntPtr(p + 0x010)); // 0x10 GameEngineName              ( ModelPrimitiveType string string string String )
            value.GameEngineParameter                       = GetObject<GameEngineParameter>(new IntPtr(p + 0x018), ReversePrism.DataModels.GameEngineParameter.FromPointer); // 0x18 GameEngineParameter         ( ModelClassType GameEngineParameter GameEngineParameter GameEngineParameter Pointer )

            return value;
        }
    }
}
