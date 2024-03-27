using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 Empty                                    ExpandoData IL2CPP_TYPE_CLASS
    // 010 Class                                    0001865CE520 ModelClassType ExpandoClass ExpandoClass ExpandoClass Pointer
    // 018 _dataArray                               <object>[] IL2CPP_TYPE_SZARRAY
    // 020 Version                                  0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class ExpandoData
    {
        public ExpandoClass?                            Class                                   { get; set; }
        public int                                      Version                                 { get; set; }

        public static ExpandoData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ExpandoData();

            value.Class                                     = GetObject<ExpandoClass>(new IntPtr(p + 0x010), ReversePrism.DataModels.ExpandoClass.FromPointer); // 0270DA072A00 0x10 Class                       ( 0001865CE520 ModelClassType ExpandoClass ExpandoClass ExpandoClass Pointer )
            value.Version                                   = GetInt32(new IntPtr(p + 0x020)); // 0270DA072A40 0x20 Version                     ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
