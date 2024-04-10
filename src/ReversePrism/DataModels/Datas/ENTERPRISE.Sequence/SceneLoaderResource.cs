using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 SceneName                                000186671910 ModelPrimitiveType string string string String
    // 018 CurrentState                             0001866CE140 ModelEnumType SceneLoaderState SceneLoaderState SceneLoaderState Int32
    // 020 Handle                                   0001866FAA20 ModelClassType AsyncOperation AsyncOperation AsyncOperation Pointer
    public partial class SceneLoaderResource : DataModel
    {
        public string                                   SceneName                               { get; set; }
        public SceneLoaderState                         CurrentState                            { get; set; }
        public AsyncOperation?                          Handle                                  { get; set; }

        public static SceneLoaderResource? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SceneLoaderResource() { Pointer= p0 };

            value.SceneName                                 = GetString(new IntPtr(p + 0x010)); // 0245A3EF0548 0x10 SceneName                   ( 000186671910 ModelPrimitiveType string string string String )
            value.CurrentState                              = (SceneLoaderState)GetInt32(new IntPtr(p + 0x018)); // 0245A3EF0568 0x18 CurrentState                ( 0001866CE140 ModelEnumType SceneLoaderState SceneLoaderState SceneLoaderState Int32 )
            value.Handle                                    = GetObject<AsyncOperation>(new IntPtr(p + 0x020), ReversePrism.DataModels.AsyncOperation.FromPointer); // 0245A3EF0588 0x20 Handle                      ( 0001866FAA20 ModelClassType AsyncOperation AsyncOperation AsyncOperation Pointer )

            return value;
        }
    }
}
