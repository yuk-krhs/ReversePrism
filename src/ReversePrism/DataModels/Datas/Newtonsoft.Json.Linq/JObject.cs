using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 058 Properties                               0001867456C0 ModelClassType JPropertyKeyedCollection JPropertyKeyedCollection JPropertyKeyedCollection Pointer
    // 060 PropertyChanged                          0001865D1C20 ModelClassType PropertyChangedEventHandler PropertyChangedEventHandler PropertyChangedEventHandler Pointer
    // 068 PropertyChanging                         0001865D2580 ModelClassType PropertyChangingEventHandler PropertyChangingEventHandler PropertyChangingEventHandler Pointer
    public partial class JObject
    {
        public JPropertyKeyedCollection?                Properties                              { get; set; }
        public PropertyChangedEventHandler?             PropertyChanged                         { get; set; }
        public PropertyChangingEventHandler?            PropertyChanging                        { get; set; }

        public static JObject? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new JObject();

            value.Properties                                = GetObject<JPropertyKeyedCollection>(new IntPtr(p + 0x058), ReversePrism.DataModels.JPropertyKeyedCollection.FromPointer); // 0270D87868A0 0x58 Properties                  ( 0001867456C0 ModelClassType JPropertyKeyedCollection JPropertyKeyedCollection JPropertyKeyedCollection Pointer )
            value.PropertyChanged                           = GetObject<PropertyChangedEventHandler>(new IntPtr(p + 0x060), ReversePrism.DataModels.PropertyChangedEventHandler.FromPointer); // 0270D87868C0 0x60 PropertyChanged             ( 0001865D1C20 ModelClassType PropertyChangedEventHandler PropertyChangedEventHandler PropertyChangedEventHandler Pointer )
            value.PropertyChanging                          = GetObject<PropertyChangingEventHandler>(new IntPtr(p + 0x068), ReversePrism.DataModels.PropertyChangingEventHandler.FromPointer); // 0270D87868E0 0x68 PropertyChanging            ( 0001865D2580 ModelClassType PropertyChangingEventHandler PropertyChangingEventHandler PropertyChangingEventHandler Pointer )

            return value;
        }
    }
}
