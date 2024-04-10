using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 firebaseMonoBehaviour                    FirebaseMonoBehaviour IL2CPP_TYPE_CLASS
    // 008 <AppUtils>k__BackingField                IFirebaseAppUtils IL2CPP_TYPE_CLASS
    // 010 TickCount                                0001865F38E0 ModelPrimitiveType int int int Int32
    // 018 ThreadDispatcher                         0001866DB090 ModelClassType Dispatcher Dispatcher Dispatcher Pointer
    // 010 IsPlayMode                               000186594D10 ModelPrimitiveType bool bool bool Bool
    // 020 _FirebaseHandler                         000186597120 ModelClassType FirebaseHandler FirebaseHandler FirebaseHandler Pointer
    // 018 Updated                                  EventHandler`1<EventArgs> IL2CPP_TYPE_GENERICINST
    // 020 UpdatedEventWrapper                      0001866794E0 ModelClassType Action Action Action Pointer
    // 028 ApplicationFocusChanged                  EventHandler`1<ApplicationFocusChangedEventArgs> IL2CPP_TYPE_GENERICINST
    public partial class FirebaseHandler : DataModel
    {
        public int                                      TickCount                               { get; set; }
        public Dispatcher?                              ThreadDispatcher                        { get; set; }
        public bool                                     IsPlayMode                              { get; set; }
        public FirebaseHandler?                         _FirebaseHandler                        { get; set; }
        public Action?                                  UpdatedEventWrapper                     { get; set; }

        public static FirebaseHandler? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FirebaseHandler() { Pointer= p0 };

            value.TickCount                                 = GetInt32(new IntPtr(p + 0x010)); // 02466BD77FA8 0x10 TickCount                   ( 0001865F38E0 ModelPrimitiveType int int int Int32 )
            value.ThreadDispatcher                          = GetObject<Dispatcher>(new IntPtr(p + 0x018), ReversePrism.DataModels.Dispatcher.FromPointer); // 02466BD77FC8 0x18 ThreadDispatcher            ( 0001866DB090 ModelClassType Dispatcher Dispatcher Dispatcher Pointer )
            value.IsPlayMode                                = GetBool(new IntPtr(p + 0x010)); // 02466BD77FE8 0x10 IsPlayMode                  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value._FirebaseHandler                          = GetObject<FirebaseHandler>(new IntPtr(p + 0x020), ReversePrism.DataModels.FirebaseHandler.FromPointer); // 02466BD78008 0x20 _FirebaseHandler            ( 000186597120 ModelClassType FirebaseHandler FirebaseHandler FirebaseHandler Pointer )
            value.UpdatedEventWrapper                       = GetObject<Action>(new IntPtr(p + 0x020), ReversePrism.DataModels.Action.FromPointer); // 02466BD78048 0x20 UpdatedEventWrapper         ( 0001866794E0 ModelClassType Action Action Action Pointer )

            return value;
        }
    }
}
