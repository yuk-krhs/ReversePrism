using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 GashaIds                                 000185B81990 ModelPrimitiveListType string[] string[] List<string> Pointer
    public partial class GashaLocalSave
    {
        public List<string>?                            GashaIds                                { get; set; }

        public static GashaLocalSave? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GashaLocalSave();

            value.GashaIds                                  = GetStringList(new IntPtr(p + 0x020)); // 027003A71358 0x20 GashaIds                    ( 000185B81990 ModelPrimitiveListType string[] string[] List<string> Pointer )

            return value;
        }
    }
}
