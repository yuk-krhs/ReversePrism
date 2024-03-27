using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Objects                                000185D068C8 ModelClassListType List`1<ScriptableObject> List`1<ScriptableObject> List<ScriptableObject> Pointer
    // 018 M_Cache                                  000185CE6278 ModelClassListType List`1<IMarker> List`1<IMarker> List<IMarker> Pointer
    // 020 M_CacheDirty                             000186594D10 ModelPrimitiveType bool bool bool Bool
    // 021 M_HasNotifications                       000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class MarkerList
    {
        public List<ScriptableObject>?                  M_Objects                               { get; set; }
        public List<IMarker>?                           M_Cache                                 { get; set; }
        public bool                                     M_CacheDirty                            { get; set; }
        public bool                                     M_HasNotifications                      { get; set; }

        public static MarkerList? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MarkerList();

            value.M_Objects                                 = GetObjectList<ScriptableObject>(new IntPtr(p + 0x010), ReversePrism.DataModels.ScriptableObject.FromPointer); // 027006F4FC50 0x10 M_Objects                   ( 000185D068C8 ModelClassListType List`1<ScriptableObject> List`1<ScriptableObject> List<ScriptableObject> Pointer )
            value.M_Cache                                   = GetObjectList<IMarker>(new IntPtr(p + 0x018), ReversePrism.DataModels.IMarker.FromPointer); // 027006F4FC70 0x18 M_Cache                     ( 000185CE6278 ModelClassListType List`1<IMarker> List`1<IMarker> List<IMarker> Pointer )
            value.M_CacheDirty                              = GetBool(new IntPtr(p + 0x020)); // 027006F4FC90 0x20 M_CacheDirty                ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_HasNotifications                        = GetBool(new IntPtr(p + 0x021)); // 027006F4FCB0 0x21 M_HasNotifications          ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
