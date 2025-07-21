using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Ref                                      ModelPrimitiveType string string string String
    // 018 Type                                     ModelPrimitiveType string string string String
    // 020 Id                                       ModelPrimitiveType string string string String
    // 028 CustomProperties                         ModelClassType Hashtable Hashtable Hashtable Pointer
    // 030 CustomData                               ModelClassType IList IList IList Pointer
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

            value.Ref                                       = GetString(new IntPtr(p + 0x010)); // 0x10 Ref                         ( ModelPrimitiveType string string string String )
            value.Type                                      = GetString(new IntPtr(p + 0x018)); // 0x18 Type                        ( ModelPrimitiveType string string string String )
            value.Id                                        = GetString(new IntPtr(p + 0x020)); // 0x20 Id                          ( ModelPrimitiveType string string string String )
            value.CustomProperties                          = GetObject<Hashtable>(new IntPtr(p + 0x028), ReversePrism.DataModels.Hashtable.FromPointer); // 0x28 CustomProperties            ( ModelClassType Hashtable Hashtable Hashtable Pointer )
            value.CustomData                                = GetObject<IList>(new IntPtr(p + 0x030), ReversePrism.DataModels.IList.FromPointer); // 0x30 CustomData                  ( ModelClassType IList IList IList Pointer )

            return value;
        }
    }
}
