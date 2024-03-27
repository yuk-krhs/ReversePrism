using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 SceneHash                                0001865F36C0 ModelPrimitiveType int int int Int32
    // 018 CellDataAsset                            0001866353B0 ModelClassType TextAsset TextAsset TextAsset Pointer
    // 020 CellOptionalDataAsset                    0001866353B0 ModelClassType TextAsset TextAsset TextAsset Pointer
    public partial class PerScenarioData
    {
        public int                                      SceneHash                               { get; set; }
        public TextAsset?                               CellDataAsset                           { get; set; }
        public TextAsset?                               CellOptionalDataAsset                   { get; set; }

        public static PerScenarioData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PerScenarioData();

            value.SceneHash                                 = GetInt32(new IntPtr(p + 0x010)); // 0270D9222088 0x10 SceneHash                   ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.CellDataAsset                             = GetObject<TextAsset>(new IntPtr(p + 0x018), ReversePrism.DataModels.TextAsset.FromPointer); // 0270D92220A8 0x18 CellDataAsset               ( 0001866353B0 ModelClassType TextAsset TextAsset TextAsset Pointer )
            value.CellOptionalDataAsset                     = GetObject<TextAsset>(new IntPtr(p + 0x020), ReversePrism.DataModels.TextAsset.FromPointer); // 0270D92220C8 0x20 CellOptionalDataAsset       ( 0001866353B0 ModelClassType TextAsset TextAsset TextAsset Pointer )

            return value;
        }
    }
}
