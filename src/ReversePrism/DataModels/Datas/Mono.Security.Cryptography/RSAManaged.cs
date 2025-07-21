using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 IsCRTpossible                            ModelPrimitiveType bool bool bool Bool
    // 021 KeyBlinding                              ModelPrimitiveType bool bool bool Bool
    // 022 KeypairGenerated                         ModelPrimitiveType bool bool bool Bool
    // 023 M_disposed                               ModelPrimitiveType bool bool bool Bool
    // 028 D                                        ModelClassType BigInteger BigInteger BigInteger Pointer
    // 030 P                                        ModelClassType BigInteger BigInteger BigInteger Pointer
    // 038 Q                                        ModelClassType BigInteger BigInteger BigInteger Pointer
    // 040 Dp                                       ModelClassType BigInteger BigInteger BigInteger Pointer
    // 048 Dq                                       ModelClassType BigInteger BigInteger BigInteger Pointer
    // 050 QInv                                     ModelClassType BigInteger BigInteger BigInteger Pointer
    // 058 N                                        ModelClassType BigInteger BigInteger BigInteger Pointer
    // 060 E                                        ModelClassType BigInteger BigInteger BigInteger Pointer
    // 068 KeyGenerated                             ModelClassType KeyGeneratedEventHandler KeyGeneratedEventHandler KeyGeneratedEventHandler Pointer
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

            value.IsCRTpossible                             = GetBool(new IntPtr(p + 0x020)); // 0x20 IsCRTpossible               ( ModelPrimitiveType bool bool bool Bool )
            value.KeyBlinding                               = GetBool(new IntPtr(p + 0x021)); // 0x21 KeyBlinding                 ( ModelPrimitiveType bool bool bool Bool )
            value.KeypairGenerated                          = GetBool(new IntPtr(p + 0x022)); // 0x22 KeypairGenerated            ( ModelPrimitiveType bool bool bool Bool )
            value.M_disposed                                = GetBool(new IntPtr(p + 0x023)); // 0x23 M_disposed                  ( ModelPrimitiveType bool bool bool Bool )
            value.D                                         = GetObject<BigInteger>(new IntPtr(p + 0x028), ReversePrism.DataModels.BigInteger.FromPointer); // 0x28 D                           ( ModelClassType BigInteger BigInteger BigInteger Pointer )
            value.P                                         = GetObject<BigInteger>(new IntPtr(p + 0x030), ReversePrism.DataModels.BigInteger.FromPointer); // 0x30 P                           ( ModelClassType BigInteger BigInteger BigInteger Pointer )
            value.Q                                         = GetObject<BigInteger>(new IntPtr(p + 0x038), ReversePrism.DataModels.BigInteger.FromPointer); // 0x38 Q                           ( ModelClassType BigInteger BigInteger BigInteger Pointer )
            value.Dp                                        = GetObject<BigInteger>(new IntPtr(p + 0x040), ReversePrism.DataModels.BigInteger.FromPointer); // 0x40 Dp                          ( ModelClassType BigInteger BigInteger BigInteger Pointer )
            value.Dq                                        = GetObject<BigInteger>(new IntPtr(p + 0x048), ReversePrism.DataModels.BigInteger.FromPointer); // 0x48 Dq                          ( ModelClassType BigInteger BigInteger BigInteger Pointer )
            value.QInv                                      = GetObject<BigInteger>(new IntPtr(p + 0x050), ReversePrism.DataModels.BigInteger.FromPointer); // 0x50 QInv                        ( ModelClassType BigInteger BigInteger BigInteger Pointer )
            value.N                                         = GetObject<BigInteger>(new IntPtr(p + 0x058), ReversePrism.DataModels.BigInteger.FromPointer); // 0x58 N                           ( ModelClassType BigInteger BigInteger BigInteger Pointer )
            value.E                                         = GetObject<BigInteger>(new IntPtr(p + 0x060), ReversePrism.DataModels.BigInteger.FromPointer); // 0x60 E                           ( ModelClassType BigInteger BigInteger BigInteger Pointer )
            value.KeyGenerated                              = GetObject<KeyGeneratedEventHandler>(new IntPtr(p + 0x068), ReversePrism.DataModels.KeyGeneratedEventHandler.FromPointer); // 0x68 KeyGenerated                ( ModelClassType KeyGeneratedEventHandler KeyGeneratedEventHandler KeyGeneratedEventHandler Pointer )

            return value;
        }
    }
}
