using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 040 Path                                     000186671910 ModelPrimitiveType string string string String
    // 048 BindId                                   000186698B70 ModelPrimitiveType uint uint uint UInt32
    public partial class CriFsBindRequest : DataModel
    {
        public string                                   Path                                    { get; set; }
        public uint                                     BindId                                  { get; set; }

        public static CriFsBindRequest? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CriFsBindRequest() { Pointer= p0 };

            value.Path                                      = GetString(new IntPtr(p + 0x040)); // 02466AD1FA68 0x40 Path                        ( 000186671910 ModelPrimitiveType string string string String )
            value.BindId                                    = GetUInt32(new IntPtr(p + 0x048)); // 02466AD1FA88 0x48 BindId                      ( 000186698B70 ModelPrimitiveType uint uint uint UInt32 )

            return value;
        }
    }
}
