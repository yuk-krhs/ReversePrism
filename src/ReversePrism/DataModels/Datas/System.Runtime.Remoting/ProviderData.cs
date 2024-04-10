using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Ref                                      000186671BA0 ModelPrimitiveType string string string String
    // 018 Type                                     000186671BA0 ModelPrimitiveType string string string String
    // 020 Id                                       000186671BA0 ModelPrimitiveType string string string String
    // 028 CustomProperties                         0001865DE5A0 ModelClassType Hashtable Hashtable Hashtable Pointer
    // 030 CustomData                               000186591D70 ModelClassType IList IList IList Pointer
    public partial class ProviderData : DataModel
    {
        public string                                   Ref                                     { get; set; }
        public string                                   Type                                    { get; set; }
        public string                                   Id                                      { get; set; }
        public Hashtable?                               CustomProperties                        { get; set; }
        public IList?                                   CustomData                              { get; set; }

        public static ProviderData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProviderData() { Pointer= p0 };

            value.Ref                                       = GetString(new IntPtr(p + 0x010)); // 024666C2CF00 0x10 Ref                         ( 000186671BA0 ModelPrimitiveType string string string String )
            value.Type                                      = GetString(new IntPtr(p + 0x018)); // 024666C2CF20 0x18 Type                        ( 000186671BA0 ModelPrimitiveType string string string String )
            value.Id                                        = GetString(new IntPtr(p + 0x020)); // 024666C2CF40 0x20 Id                          ( 000186671BA0 ModelPrimitiveType string string string String )
            value.CustomProperties                          = GetObject<Hashtable>(new IntPtr(p + 0x028), ReversePrism.DataModels.Hashtable.FromPointer); // 024666C2CF60 0x28 CustomProperties            ( 0001865DE5A0 ModelClassType Hashtable Hashtable Hashtable Pointer )
            value.CustomData                                = GetObject<IList>(new IntPtr(p + 0x030), ReversePrism.DataModels.IList.FromPointer); // 024666C2CF80 0x30 CustomData                  ( 000186591D70 ModelClassType IList IList IList Pointer )

            return value;
        }
    }
}
