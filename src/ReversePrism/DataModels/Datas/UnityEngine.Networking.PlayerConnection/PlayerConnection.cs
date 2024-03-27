using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 connectionNative                         IPlayerEditorConnectionNative IL2CPP_TYPE_CLASS
    // 018 M_PlayerEditorConnectionEvents           0001867511D0 ModelClassType PlayerEditorConnectionEvents PlayerEditorConnectionEvents PlayerEditorConnectionEvents Pointer
    // 020 M_connectedPlayers                       000185CECF28 ModelPrimitiveListType List`1<int> List`1<int> List<int> Pointer
    // 028 M_IsInitilized                           000186594D10 ModelPrimitiveType bool bool bool Bool
    // 008 s_Instance                               PlayerConnection IL2CPP_TYPE_CLASS
    public partial class PlayerConnection
    {
        public PlayerEditorConnectionEvents?            M_PlayerEditorConnectionEvents          { get; set; }
        public List<int>?                               M_connectedPlayers                      { get; set; }
        public bool                                     M_IsInitilized                          { get; set; }

        public static PlayerConnection? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PlayerConnection();

            value.M_PlayerEditorConnectionEvents            = GetObject<PlayerEditorConnectionEvents>(new IntPtr(p + 0x018), ReversePrism.DataModels.PlayerEditorConnectionEvents.FromPointer); // 0270023E9540 0x18 M_PlayerEditorConnectionEvents ( 0001867511D0 ModelClassType PlayerEditorConnectionEvents PlayerEditorConnectionEvents PlayerEditorConnectionEvents Pointer )
            value.M_connectedPlayers                        = GetInt32List(new IntPtr(p + 0x020)); // 0270023E9560 0x20 M_connectedPlayers          ( 000185CECF28 ModelPrimitiveListType List`1<int> List`1<int> List<int> Pointer )
            value.M_IsInitilized                            = GetBool(new IntPtr(p + 0x028)); // 0270023E9580 0x28 M_IsInitilized              ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
