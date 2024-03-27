using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _xmlTypes                                Hashtable IL2CPP_TYPE_CLASS
    // 008 _xmlElements                             Hashtable IL2CPP_TYPE_CLASS
    // 010 SoapActions                              0001865DEF20 ModelClassType Hashtable Hashtable Hashtable Pointer
    // 018 SoapActionsMethods                       0001865DEF20 ModelClassType Hashtable Hashtable Hashtable Pointer
    // 020 TypeInfos                                0001865DEF20 ModelClassType Hashtable Hashtable Hashtable Pointer
    public partial class SoapServices
    {
        public Hashtable?                               SoapActions                             { get; set; }
        public Hashtable?                               SoapActionsMethods                      { get; set; }
        public Hashtable?                               TypeInfos                               { get; set; }

        public static SoapServices? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SoapServices();

            value.SoapActions                               = GetObject<Hashtable>(new IntPtr(p + 0x010), ReversePrism.DataModels.Hashtable.FromPointer); // 0270D6BB9590 0x10 SoapActions                 ( 0001865DEF20 ModelClassType Hashtable Hashtable Hashtable Pointer )
            value.SoapActionsMethods                        = GetObject<Hashtable>(new IntPtr(p + 0x018), ReversePrism.DataModels.Hashtable.FromPointer); // 0270D6BB95B0 0x18 SoapActionsMethods          ( 0001865DEF20 ModelClassType Hashtable Hashtable Hashtable Pointer )
            value.TypeInfos                                 = GetObject<Hashtable>(new IntPtr(p + 0x020), ReversePrism.DataModels.Hashtable.FromPointer); // 0270D6BB95D0 0x20 TypeInfos                   ( 0001865DEF20 ModelClassType Hashtable Hashtable Hashtable Pointer )

            return value;
        }
    }
}
