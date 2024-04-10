using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Settings                                 00018651FD40 ModelClassType IGameSettingStatus IGameSettingStatus IGameSettingStatus Pointer
    // 018 IsReady                                  000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class GameSettingCache : DataModel
    {
        public IGameSettingStatus?                      Settings                                { get; set; }
        public bool                                     IsReady                                 { get; set; }

        public static GameSettingCache? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GameSettingCache() { Pointer= p0 };

            value.Settings                                  = GetObject<IGameSettingStatus>(new IntPtr(p + 0x010), ReversePrism.DataModels.IGameSettingStatus.FromPointer); // 0245A4ADDEC8 0x10 Settings                    ( 00018651FD40 ModelClassType IGameSettingStatus IGameSettingStatus IGameSettingStatus Pointer )
            value.IsReady                                   = GetBool(new IntPtr(p + 0x018)); // 0245A4ADDEE8 0x18 IsReady                     ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
