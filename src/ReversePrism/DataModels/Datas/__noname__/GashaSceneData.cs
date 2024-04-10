using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Name                                     0001866722E0 ModelPrimitiveType string string string String
    // 018 Callback                                 000186722260 ModelClassType CallbackActionSet CallbackActionSet CallbackActionSet Pointer
    // 020 SwitchCharacter                          00018656A320 ModelClassType SwitchCharacter SwitchCharacter SwitchCharacter Pointer
    // 028 SwitchMovie                              00018656AD50 ModelClassType SwitchMovie SwitchMovie SwitchMovie Pointer
    public partial class GashaSceneData : DataModel
    {
        public string                                   Name                                    { get; set; }
        public CallbackActionSet?                       Callback                                { get; set; }
        public SwitchCharacter?                         SwitchCharacter                         { get; set; }
        public SwitchMovie?                             SwitchMovie                             { get; set; }

        public static GashaSceneData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GashaSceneData() { Pointer= p0 };

            value.Name                                      = GetString(new IntPtr(p + 0x010)); // 024664E25DF0 0x10 Name                        ( 0001866722E0 ModelPrimitiveType string string string String )
            value.Callback                                  = GetObject<CallbackActionSet>(new IntPtr(p + 0x018), ReversePrism.DataModels.CallbackActionSet.FromPointer); // 024664E25E10 0x18 Callback                    ( 000186722260 ModelClassType CallbackActionSet CallbackActionSet CallbackActionSet Pointer )
            value.SwitchCharacter                           = GetObject<SwitchCharacter>(new IntPtr(p + 0x020), ReversePrism.DataModels.SwitchCharacter.FromPointer); // 024664E25E30 0x20 SwitchCharacter             ( 00018656A320 ModelClassType SwitchCharacter SwitchCharacter SwitchCharacter Pointer )
            value.SwitchMovie                               = GetObject<SwitchMovie>(new IntPtr(p + 0x028), ReversePrism.DataModels.SwitchMovie.FromPointer); // 024664E25E50 0x28 SwitchMovie                 ( 00018656AD50 ModelClassType SwitchMovie SwitchMovie SwitchMovie Pointer )

            return value;
        }
    }
}
