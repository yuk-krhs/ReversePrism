using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 SceneName                                ModelPrimitiveType string string string String
    // 018 ErrorReason                              ModelClassType Exception Exception Exception Pointer
    // 020 CurrentState                             ModelEnumType SceneLoaderState SceneLoaderState SceneLoaderState Int32
    // 028 AsyncHandle                              ModelClassType SceneAsyncOperation SceneAsyncOperation SceneAsyncOperation Pointer
    // 030 TargetSource                             ModelPrimitiveType string string string String
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

            value.SceneName                                 = GetString(new IntPtr(p + 0x010)); // 0x10 SceneName                   ( ModelPrimitiveType string string string String )
            value.ErrorReason                               = GetObject<Exception>(new IntPtr(p + 0x018), ReversePrism.DataModels.Exception.FromPointer); // 0x18 ErrorReason                 ( ModelClassType Exception Exception Exception Pointer )
            value.CurrentState                              = (SceneLoaderState)GetInt32(new IntPtr(p + 0x020)); // 0x20 CurrentState                ( ModelEnumType SceneLoaderState SceneLoaderState SceneLoaderState Int32 )
            value.AsyncHandle                               = GetObject<SceneAsyncOperation>(new IntPtr(p + 0x028), ReversePrism.DataModels.SceneAsyncOperation.FromPointer); // 0x28 AsyncHandle                 ( ModelClassType SceneAsyncOperation SceneAsyncOperation SceneAsyncOperation Pointer )
            value.TargetSource                              = GetString(new IntPtr(p + 0x030)); // 0x30 TargetSource                ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
