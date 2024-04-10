using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Callback                                 000186531CE0 ModelClassType Callback Callback Callback Pointer
    public partial class GameEngineParameter : DataModel
    {
        public Callback?                                Callback                                { get; set; }

        public static GameEngineParameter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GameEngineParameter() { Pointer= p0 };

            value.Callback                                  = GetObject<Callback>(new IntPtr(p + 0x010), ReversePrism.DataModels.Callback.FromPointer); // 02466B511B98 0x10 Callback                    ( 000186531CE0 ModelClassType Callback Callback Callback Pointer )

            return value;
        }
    }
}
