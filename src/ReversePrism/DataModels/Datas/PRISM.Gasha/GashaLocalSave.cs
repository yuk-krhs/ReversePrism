using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 GashaIds                                 ModelPrimitiveListType string[] string[] List<string> Pointer
    public partial class GashaLocalSave : DataModel
    {
        public List<string>?                            GashaIds                                { get; set; }

        public static GashaLocalSave? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GashaLocalSave() { Pointer= p0 };

            value.GashaIds                                  = GetStringList(new IntPtr(p + 0x020)); // 0x20 GashaIds                    ( ModelPrimitiveListType string[] string[] List<string> Pointer )

            return value;
        }
    }
}
