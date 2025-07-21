using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 SceneHash                                ModelPrimitiveType int int int Int32
    // 018 CellDataAsset                            ModelClassType TextAsset TextAsset TextAsset Pointer
    // 020 CellOptionalDataAsset                    ModelClassType TextAsset TextAsset TextAsset Pointer
    public partial class PerScenarioData : DataModel
    {
        public int                                      SceneHash                               { get; set; }
        public TextAsset?                               CellDataAsset                           { get; set; }
        public TextAsset?                               CellOptionalDataAsset                   { get; set; }

        public static PerScenarioData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PerScenarioData() { Pointer= p0 };

            value.SceneHash                                 = GetInt32(new IntPtr(p + 0x010)); // 0x10 SceneHash                   ( ModelPrimitiveType int int int Int32 )
            value.CellDataAsset                             = GetObject<TextAsset>(new IntPtr(p + 0x018), ReversePrism.DataModels.TextAsset.FromPointer); // 0x18 CellDataAsset               ( ModelClassType TextAsset TextAsset TextAsset Pointer )
            value.CellOptionalDataAsset                     = GetObject<TextAsset>(new IntPtr(p + 0x020), ReversePrism.DataModels.TextAsset.FromPointer); // 0x20 CellOptionalDataAsset       ( ModelClassType TextAsset TextAsset TextAsset Pointer )

            return value;
        }
    }
}
