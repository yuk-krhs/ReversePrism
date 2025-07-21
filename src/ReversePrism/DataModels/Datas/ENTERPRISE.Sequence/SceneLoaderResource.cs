using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 HandledScene                             ModelEnumType Scene Scene Scene Int32
    // 018 SceneName                                ModelPrimitiveType string string string String
    // 020 CurrentState                             ModelEnumType SceneLoaderState SceneLoaderState SceneLoaderState Int32
    // 028 Handle                                   ModelClassType AsyncOperation AsyncOperation AsyncOperation Pointer
    public partial class SceneLoaderResource : DataModel
    {
        public Scene                                    HandledScene                            { get; set; }
        public string                                   SceneName                               { get; set; }
        public SceneLoaderState                         CurrentState                            { get; set; }
        public AsyncOperation?                          Handle                                  { get; set; }

        public static SceneLoaderResource? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SceneLoaderResource() { Pointer= p0 };

            value.HandledScene                              = (Scene)GetInt32(new IntPtr(p + 0x010)); // 0x10 HandledScene                ( ModelEnumType Scene Scene Scene Int32 )
            value.SceneName                                 = GetString(new IntPtr(p + 0x018)); // 0x18 SceneName                   ( ModelPrimitiveType string string string String )
            value.CurrentState                              = (SceneLoaderState)GetInt32(new IntPtr(p + 0x020)); // 0x20 CurrentState                ( ModelEnumType SceneLoaderState SceneLoaderState SceneLoaderState Int32 )
            value.Handle                                    = GetObject<AsyncOperation>(new IntPtr(p + 0x028), ReversePrism.DataModels.AsyncOperation.FromPointer); // 0x28 Handle                      ( ModelClassType AsyncOperation AsyncOperation AsyncOperation Pointer )

            return value;
        }
    }
}
