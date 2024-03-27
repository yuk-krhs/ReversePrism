using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Types                                    000185B83050 ModelClassListType Type[] Type[] List<Type> Pointer
    // 018 Values                                   00018664F1C0 ModelClassType StandardValuesCollection StandardValuesCollection StandardValuesCollection Pointer
    public partial class TypeListConverter
    {
        public List<Type>?                              Types                                   { get; set; }
        public StandardValuesCollection?                Values                                  { get; set; }

        public static TypeListConverter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TypeListConverter();

            value.Types                                     = GetObjectList<Type>(new IntPtr(p + 0x010), ReversePrism.DataModels.Type.FromPointer); // 0270D7B3A200 0x10 Types                       ( 000185B83050 ModelClassListType Type[] Type[] List<Type> Pointer )
            value.Values                                    = GetObject<StandardValuesCollection>(new IntPtr(p + 0x018), ReversePrism.DataModels.StandardValuesCollection.FromPointer); // 0270D7B3A220 0x18 Values                      ( 00018664F1C0 ModelClassType StandardValuesCollection StandardValuesCollection StandardValuesCollection Pointer )

            return value;
        }
    }
}
