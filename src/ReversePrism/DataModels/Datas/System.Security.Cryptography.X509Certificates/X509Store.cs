using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Name                                     ModelPrimitiveType string string string String
    // 018 Location                                 ModelEnumType StoreLocation StoreLocation StoreLocation Int32
    // 020 List                                     ModelClassType X509Certificate2Collection X509Certificate2Collection X509Certificate2Collection Pointer
    // 028 Flags                                    ModelEnumType OpenFlags OpenFlags OpenFlags Int32
    // 030 Store                                    ModelClassType X509Store X509Store X509Store Pointer
    public partial class X509Store : DataModel
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
            var value   = new X509Store() { Pointer= p0 };

            value.Name                                      = GetString(new IntPtr(p + 0x010)); // 0x10 Name                        ( ModelPrimitiveType string string string String )
            value.Location                                  = (StoreLocation)GetInt32(new IntPtr(p + 0x018)); // 0x18 Location                    ( ModelEnumType StoreLocation StoreLocation StoreLocation Int32 )
            value.List                                      = GetObject<X509Certificate2Collection>(new IntPtr(p + 0x020), ReversePrism.DataModels.X509Certificate2Collection.FromPointer); // 0x20 List                        ( ModelClassType X509Certificate2Collection X509Certificate2Collection X509Certificate2Collection Pointer )
            value.Flags                                     = (OpenFlags)GetInt32(new IntPtr(p + 0x028)); // 0x28 Flags                       ( ModelEnumType OpenFlags OpenFlags OpenFlags Int32 )
            value.Store                                     = GetObject<X509Store>(new IntPtr(p + 0x030), ReversePrism.DataModels.X509Store.FromPointer); // 0x30 Store                       ( ModelClassType X509Store X509Store X509Store Pointer )

            return value;
        }
    }
}
