using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 GameEngineName                           string IL2CPP_TYPE_STRING
    // 010 Settings                                 0001866E6900 ModelClassType DmmGamesStoreSdkSettings DmmGamesStoreSdkSettings DmmGamesStoreSdkSettings Pointer
    // 000 _receiveGo                               GameObject IL2CPP_TYPE_CLASS
    // 008 _receiveCode                             DmmSdkReceiveObject IL2CPP_TYPE_CLASS
    // 018 IsEditorInit                             000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class DmmGamesStoreSdk
    {
        public DmmGamesStoreSdkSettings?                Settings                                { get; set; }
        public bool                                     IsEditorInit                            { get; set; }

        public static DmmGamesStoreSdk? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DmmGamesStoreSdk();

            value.Settings                                  = GetObject<DmmGamesStoreSdkSettings>(new IntPtr(p + 0x010), ReversePrism.DataModels.DmmGamesStoreSdkSettings.FromPointer); // 0270DB481B50 0x10 Settings                    ( 0001866E6900 ModelClassType DmmGamesStoreSdkSettings DmmGamesStoreSdkSettings DmmGamesStoreSdkSettings Pointer )
            value.IsEditorInit                              = GetBool(new IntPtr(p + 0x018)); // 0270DB481BB0 0x18 IsEditorInit                ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
