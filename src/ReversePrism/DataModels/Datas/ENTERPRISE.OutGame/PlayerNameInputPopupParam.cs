using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 090 ProducerName                             ModelPrimitiveType string string string String
    public partial class PlayerNameInputPopupParam : DataModel
    {
        public string                                   ProducerName                            { get; set; }

        public static PlayerNameInputPopupParam? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PlayerNameInputPopupParam() { Pointer= p0 };

            value.ProducerName                              = GetString(new IntPtr(p + 0x090)); // 0x90 ProducerName                ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
