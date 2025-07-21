using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Name                                     ModelPrimitiveType string string string String
    // 018 Id                                       ModelPrimitiveType uint uint uint UInt32
    // 01C GameValue                                ModelPrimitiveType float float float Single
    public partial class GameVariableInfo : DataModel
    {
        public string                                   Name                                    { get; set; }
        public uint                                     Id                                      { get; set; }
        public float                                    GameValue                               { get; set; }

        public static GameVariableInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GameVariableInfo() { Pointer= p0 };

            value.Name                                      = GetString(new IntPtr(p + 0x010)); // 0x10 Name                        ( ModelPrimitiveType string string string String )
            value.Id                                        = GetUInt32(new IntPtr(p + 0x018)); // 0x18 Id                          ( ModelPrimitiveType uint uint uint UInt32 )
            value.GameValue                                 = GetSingle(new IntPtr(p + 0x01C)); // 0x1C GameValue                   ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
