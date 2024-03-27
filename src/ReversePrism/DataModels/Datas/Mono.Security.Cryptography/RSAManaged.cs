using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 IsCRTpossible                            000186594D10 ModelPrimitiveType bool bool bool Bool
    // 021 KeyBlinding                              000186594D10 ModelPrimitiveType bool bool bool Bool
    // 022 KeypairGenerated                         000186594D10 ModelPrimitiveType bool bool bool Bool
    // 023 M_disposed                               000186594D10 ModelPrimitiveType bool bool bool Bool
    // 028 D                                        00018674FC20 ModelClassType BigInteger BigInteger BigInteger Pointer
    // 030 P                                        00018674FC20 ModelClassType BigInteger BigInteger BigInteger Pointer
    // 038 Q                                        00018674FC20 ModelClassType BigInteger BigInteger BigInteger Pointer
    // 040 Dp                                       00018674FC20 ModelClassType BigInteger BigInteger BigInteger Pointer
    // 048 Dq                                       00018674FC20 ModelClassType BigInteger BigInteger BigInteger Pointer
    // 050 QInv                                     00018674FC20 ModelClassType BigInteger BigInteger BigInteger Pointer
    // 058 N                                        00018674FC20 ModelClassType BigInteger BigInteger BigInteger Pointer
    // 060 E                                        00018674FC20 ModelClassType BigInteger BigInteger BigInteger Pointer
    // 068 KeyGenerated                             00018669EAA0 ModelClassType KeyGeneratedEventHandler KeyGeneratedEventHandler KeyGeneratedEventHandler Pointer
    public partial class RSAManaged
    {
        public bool                                     IsCRTpossible                           { get; set; }
        public bool                                     KeyBlinding                             { get; set; }
        public bool                                     KeypairGenerated                        { get; set; }
        public bool                                     M_disposed                              { get; set; }
        public BigInteger?                              D                                       { get; set; }
        public BigInteger?                              P                                       { get; set; }
        public BigInteger?                              Q                                       { get; set; }
        public BigInteger?                              Dp                                      { get; set; }
        public BigInteger?                              Dq                                      { get; set; }
        public BigInteger?                              QInv                                    { get; set; }
        public BigInteger?                              N                                       { get; set; }
        public BigInteger?                              E                                       { get; set; }
        public KeyGeneratedEventHandler?                KeyGenerated                            { get; set; }

        public static RSAManaged? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RSAManaged();

            value.IsCRTpossible                             = GetBool(new IntPtr(p + 0x020)); // 0270DB3A85B0 0x20 IsCRTpossible               ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.KeyBlinding                               = GetBool(new IntPtr(p + 0x021)); // 0270DB3A85D0 0x21 KeyBlinding                 ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.KeypairGenerated                          = GetBool(new IntPtr(p + 0x022)); // 0270DB3A85F0 0x22 KeypairGenerated            ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_disposed                                = GetBool(new IntPtr(p + 0x023)); // 0270DB3A8610 0x23 M_disposed                  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.D                                         = GetObject<BigInteger>(new IntPtr(p + 0x028), ReversePrism.DataModels.BigInteger.FromPointer); // 0270DB3A8630 0x28 D                           ( 00018674FC20 ModelClassType BigInteger BigInteger BigInteger Pointer )
            value.P                                         = GetObject<BigInteger>(new IntPtr(p + 0x030), ReversePrism.DataModels.BigInteger.FromPointer); // 0270DB3A8650 0x30 P                           ( 00018674FC20 ModelClassType BigInteger BigInteger BigInteger Pointer )
            value.Q                                         = GetObject<BigInteger>(new IntPtr(p + 0x038), ReversePrism.DataModels.BigInteger.FromPointer); // 0270DB3A8670 0x38 Q                           ( 00018674FC20 ModelClassType BigInteger BigInteger BigInteger Pointer )
            value.Dp                                        = GetObject<BigInteger>(new IntPtr(p + 0x040), ReversePrism.DataModels.BigInteger.FromPointer); // 0270DB3A8690 0x40 Dp                          ( 00018674FC20 ModelClassType BigInteger BigInteger BigInteger Pointer )
            value.Dq                                        = GetObject<BigInteger>(new IntPtr(p + 0x048), ReversePrism.DataModels.BigInteger.FromPointer); // 0270DB3A86B0 0x48 Dq                          ( 00018674FC20 ModelClassType BigInteger BigInteger BigInteger Pointer )
            value.QInv                                      = GetObject<BigInteger>(new IntPtr(p + 0x050), ReversePrism.DataModels.BigInteger.FromPointer); // 0270DB3A86D0 0x50 QInv                        ( 00018674FC20 ModelClassType BigInteger BigInteger BigInteger Pointer )
            value.N                                         = GetObject<BigInteger>(new IntPtr(p + 0x058), ReversePrism.DataModels.BigInteger.FromPointer); // 0270DB3A86F0 0x58 N                           ( 00018674FC20 ModelClassType BigInteger BigInteger BigInteger Pointer )
            value.E                                         = GetObject<BigInteger>(new IntPtr(p + 0x060), ReversePrism.DataModels.BigInteger.FromPointer); // 0270DB3A8710 0x60 E                           ( 00018674FC20 ModelClassType BigInteger BigInteger BigInteger Pointer )
            value.KeyGenerated                              = GetObject<KeyGeneratedEventHandler>(new IntPtr(p + 0x068), ReversePrism.DataModels.KeyGeneratedEventHandler.FromPointer); // 0270DB3A8730 0x68 KeyGenerated                ( 00018669EAA0 ModelClassType KeyGeneratedEventHandler KeyGeneratedEventHandler KeyGeneratedEventHandler Pointer )

            return value;
        }
    }
}
