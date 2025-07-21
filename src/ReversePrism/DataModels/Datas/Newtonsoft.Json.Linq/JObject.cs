using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 058 Properties                               ModelClassType JPropertyKeyedCollection JPropertyKeyedCollection JPropertyKeyedCollection Pointer
    // 060 PropertyChanged                          ModelClassType PropertyChangedEventHandler PropertyChangedEventHandler PropertyChangedEventHandler Pointer
    // 068 PropertyChanging                         ModelClassType PropertyChangingEventHandler PropertyChangingEventHandler PropertyChangingEventHandler Pointer
    public partial class JObject : DataModel
    {
        public JPropertyKeyedCollection?                Properties                              { get; set; }
        public PropertyChangedEventHandler?             PropertyChanged                         { get; set; }
        public PropertyChangingEventHandler?            PropertyChanging                        { get; set; }

        public static JObject? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new JObject() { Pointer= p0 };

            value.Properties                                = GetObject<JPropertyKeyedCollection>(new IntPtr(p + 0x058), ReversePrism.DataModels.JPropertyKeyedCollection.FromPointer); // 0x58 Properties                  ( ModelClassType JPropertyKeyedCollection JPropertyKeyedCollection JPropertyKeyedCollection Pointer )
            value.PropertyChanged                           = GetObject<PropertyChangedEventHandler>(new IntPtr(p + 0x060), ReversePrism.DataModels.PropertyChangedEventHandler.FromPointer); // 0x60 PropertyChanged             ( ModelClassType PropertyChangedEventHandler PropertyChangedEventHandler PropertyChangedEventHandler Pointer )
            value.PropertyChanging                          = GetObject<PropertyChangingEventHandler>(new IntPtr(p + 0x068), ReversePrism.DataModels.PropertyChangingEventHandler.FromPointer); // 0x68 PropertyChanging            ( ModelClassType PropertyChangingEventHandler PropertyChangingEventHandler PropertyChangingEventHandler Pointer )

            return value;
        }
    }
}
