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
    public partial class RSAManaged : DataModel
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
            var value   = new RSAManaged() { Pointer= p0 };

            value.IsCRTpossible                             = GetBool(new IntPtr(p + 0x020)); // 02466B411A20 0x20 IsCRTpossible               ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.KeyBlinding                               = GetBool(new IntPtr(p + 0x021)); // 02466B411A40 0x21 KeyBlinding                 ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.KeypairGenerated                          = GetBool(new IntPtr(p + 0x022)); // 02466B411A60 0x22 KeypairGenerated            ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_disposed                                = GetBool(new IntPtr(p + 0x023)); // 02466B411A80 0x23 M_disposed                  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.D                                         = GetObject<BigInteger>(new IntPtr(p + 0x028), ReversePrism.DataModels.BigInteger.FromPointer); // 02466B411AA0 0x28 D                           ( 00018674FC20 ModelClassType BigInteger BigInteger BigInteger Pointer )
            value.P                                         = GetObject<BigInteger>(new IntPtr(p + 0x030), ReversePrism.DataModels.BigInteger.FromPointer); // 02466B411AC0 0x30 P                           ( 00018674FC20 ModelClassType BigInteger BigInteger BigInteger Pointer )
            value.Q                                         = GetObject<BigInteger>(new IntPtr(p + 0x038), ReversePrism.DataModels.BigInteger.FromPointer); // 02466B411AE0 0x38 Q                           ( 00018674FC20 ModelClassType BigInteger BigInteger BigInteger Pointer )
            value.Dp                                        = GetObject<BigInteger>(new IntPtr(p + 0x040), ReversePrism.DataModels.BigInteger.FromPointer); // 02466B411B00 0x40 Dp                          ( 00018674FC20 ModelClassType BigInteger BigInteger BigInteger Pointer )
            value.Dq                                        = GetObject<BigInteger>(new IntPtr(p + 0x048), ReversePrism.DataModels.BigInteger.FromPointer); // 02466B411B20 0x48 Dq                          ( 00018674FC20 ModelClassType BigInteger BigInteger BigInteger Pointer )
            value.QInv                                      = GetObject<BigInteger>(new IntPtr(p + 0x050), ReversePrism.DataModels.BigInteger.FromPointer); // 02466B411B40 0x50 QInv                        ( 00018674FC20 ModelClassType BigInteger BigInteger BigInteger Pointer )
            value.N                                         = GetObject<BigInteger>(new IntPtr(p + 0x058), ReversePrism.DataModels.BigInteger.FromPointer); // 02466B411B60 0x58 N                           ( 00018674FC20 ModelClassType BigInteger BigInteger BigInteger Pointer )
            value.E                                         = GetObject<BigInteger>(new IntPtr(p + 0x060), ReversePrism.DataModels.BigInteger.FromPointer); // 02466B411B80 0x60 E                           ( 00018674FC20 ModelClassType BigInteger BigInteger BigInteger Pointer )
            value.KeyGenerated                              = GetObject<KeyGeneratedEventHandler>(new IntPtr(p + 0x068), ReversePrism.DataModels.KeyGeneratedEventHandler.FromPointer); // 02466B411BA0 0x68 KeyGenerated                ( 00018669EAA0 ModelClassType KeyGeneratedEventHandler KeyGeneratedEventHandler KeyGeneratedEventHandler Pointer )

            return value;
        }
    }
}
