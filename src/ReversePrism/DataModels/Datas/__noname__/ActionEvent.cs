using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 030 M_ActionId                               000186671910 ModelPrimitiveType string string string String
    // 038 M_ActionName                             000186671910 ModelPrimitiveType string string string String
    public partial class ActionEvent
    {
        public string                                   M_ActionId                              { get; set; }
        public string                                   M_ActionName                            { get; set; }

        public static ActionEvent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ActionEvent();

            value.M_ActionId                                = GetString(new IntPtr(p + 0x030)); // 0270D7723430 0x30 M_ActionId                  ( 000186671910 ModelPrimitiveType string string string String )
            value.M_ActionName                              = GetString(new IntPtr(p + 0x038)); // 0270D7723450 0x38 M_ActionName                ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
