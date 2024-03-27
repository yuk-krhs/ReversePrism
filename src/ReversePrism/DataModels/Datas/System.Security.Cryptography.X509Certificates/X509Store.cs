using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Name                                     000186671910 ModelPrimitiveType string string string String
    // 018 Location                                 000186592FA0 ModelEnumType StoreLocation StoreLocation StoreLocation Int32
    // 020 List                                     0001865642C0 ModelClassType X509Certificate2Collection X509Certificate2Collection X509Certificate2Collection Pointer
    // 028 Flags                                    0001866E1000 ModelEnumType OpenFlags OpenFlags OpenFlags Int32
    // 030 Store                                    00018656FB90 ModelClassType X509Store X509Store X509Store Pointer
    public partial class X509Store
    {
        public string                                   Name                                    { get; set; }
        public StoreLocation                            Location                                { get; set; }
        public X509Certificate2Collection?              List                                    { get; set; }
        public OpenFlags                                Flags                                   { get; set; }
        public X509Store?                               Store                                   { get; set; }

        public static X509Store? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new X509Store();

            value.Name                                      = GetString(new IntPtr(p + 0x010)); // 0270D79EB5A0 0x10 Name                        ( 000186671910 ModelPrimitiveType string string string String )
            value.Location                                  = (StoreLocation)GetInt32(new IntPtr(p + 0x018)); // 0270D79EB5C0 0x18 Location                    ( 000186592FA0 ModelEnumType StoreLocation StoreLocation StoreLocation Int32 )
            value.List                                      = GetObject<X509Certificate2Collection>(new IntPtr(p + 0x020), ReversePrism.DataModels.X509Certificate2Collection.FromPointer); // 0270D79EB5E0 0x20 List                        ( 0001865642C0 ModelClassType X509Certificate2Collection X509Certificate2Collection X509Certificate2Collection Pointer )
            value.Flags                                     = (OpenFlags)GetInt32(new IntPtr(p + 0x028)); // 0270D79EB600 0x28 Flags                       ( 0001866E1000 ModelEnumType OpenFlags OpenFlags OpenFlags Int32 )
            value.Store                                     = GetObject<X509Store>(new IntPtr(p + 0x030), ReversePrism.DataModels.X509Store.FromPointer); // 0270D79EB620 0x30 Store                       ( 00018656FB90 ModelClassType X509Store X509Store X509Store Pointer )

            return value;
        }
    }
}
