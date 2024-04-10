using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 SceneName                                000186671910 ModelPrimitiveType string string string String
    // 018 ErrorReason                              0001865CA820 ModelClassType Exception Exception Exception Pointer
    // 020 CurrentState                             0001866CE140 ModelEnumType SceneLoaderState SceneLoaderState SceneLoaderState Int32
    // 028 AsyncHandle                              0001866CB5C0 ModelClassType SceneAsyncOperation SceneAsyncOperation SceneAsyncOperation Pointer
    // 030 TargetSource                             000186671910 ModelPrimitiveType string string string String
    public partial class SceneLoaderAsync : DataModel
    {
        public string                                   SceneName                               { get; set; }
        public Exception?                               ErrorReason                             { get; set; }
        public SceneLoaderState                         CurrentState                            { get; set; }
        public SceneAsyncOperation?                     AsyncHandle                             { get; set; }
        public string                                   TargetSource                            { get; set; }

        public static SceneLoaderAsync? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SceneLoaderAsync() { Pointer= p0 };

            value.SceneName                                 = GetString(new IntPtr(p + 0x010)); // 0245A3EF1658 0x10 SceneName                   ( 000186671910 ModelPrimitiveType string string string String )
            value.ErrorReason                               = GetObject<Exception>(new IntPtr(p + 0x018), ReversePrism.DataModels.Exception.FromPointer); // 0245A3EF1678 0x18 ErrorReason                 ( 0001865CA820 ModelClassType Exception Exception Exception Pointer )
            value.CurrentState                              = (SceneLoaderState)GetInt32(new IntPtr(p + 0x020)); // 0245A3EF1698 0x20 CurrentState                ( 0001866CE140 ModelEnumType SceneLoaderState SceneLoaderState SceneLoaderState Int32 )
            value.AsyncHandle                               = GetObject<SceneAsyncOperation>(new IntPtr(p + 0x028), ReversePrism.DataModels.SceneAsyncOperation.FromPointer); // 0245A3EF16B8 0x28 AsyncHandle                 ( 0001866CB5C0 ModelClassType SceneAsyncOperation SceneAsyncOperation SceneAsyncOperation Pointer )
            value.TargetSource                              = GetString(new IntPtr(p + 0x030)); // 0245A3EF16D8 0x30 TargetSource                ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
