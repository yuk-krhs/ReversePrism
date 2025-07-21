using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ClickSE                                  ModelEnumType SoundKey SoundKey SoundKey Int32
    // 020 OnClick                                  ModelClassType Action Action Action Pointer
    public partial class OutOfRangeInfoParameter : DataModel
    {
        public SoundKey                                 ClickSE                                 { get; set; }
        public Action?                                  OnClick                                 { get; set; }

        public static OutOfRangeInfoParameter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new OutOfRangeInfoParameter() { Pointer= p0 };

            value.ClickSE                                   = (SoundKey)GetInt32(new IntPtr(p + 0x010)); // 0x10 ClickSE                     ( ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.OnClick                                   = GetObject<Action>(new IntPtr(p + 0x020), ReversePrism.DataModels.Action.FromPointer); // 0x20 OnClick                     ( ModelClassType Action Action Action Pointer )

            return value;
        }
    }
}
