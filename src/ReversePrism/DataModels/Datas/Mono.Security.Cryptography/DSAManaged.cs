using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 KeypairGenerated                         000186594D10 ModelPrimitiveType bool bool bool Bool
    // 021 M_disposed                               000186594D10 ModelPrimitiveType bool bool bool Bool
    // 028 P                                        00018674FF50 ModelClassType BigInteger BigInteger BigInteger Pointer
    // 030 Q                                        00018674FF50 ModelClassType BigInteger BigInteger BigInteger Pointer
    // 038 G                                        00018674FF50 ModelClassType BigInteger BigInteger BigInteger Pointer
    // 040 X                                        00018674FF50 ModelClassType BigInteger BigInteger BigInteger Pointer
    // 048 Y                                        00018674FF50 ModelClassType BigInteger BigInteger BigInteger Pointer
    // 050 J                                        00018674FF50 ModelClassType BigInteger BigInteger BigInteger Pointer
    // 058 Seed                                     00018674FF50 ModelClassType BigInteger BigInteger BigInteger Pointer
    // 060 Counter                                  0001865F2AF0 ModelPrimitiveType int int int Int32
    // 064 J_missing                                000186594D10 ModelPrimitiveType bool bool bool Bool
    // 068 Rng                                      00018660A680 ModelClassType RandomNumberGenerator RandomNumberGenerator RandomNumberGenerator Pointer
    // 070 KeyGenerated                             000186577950 ModelClassType KeyGeneratedEventHandler KeyGeneratedEventHandler KeyGeneratedEventHandler Pointer
    public partial class DSAManaged : DataModel
    {
        public bool                                     KeypairGenerated                        { get; set; }
        public bool                                     M_disposed                              { get; set; }
        public BigInteger?                              P                                       { get; set; }
        public BigInteger?                              Q                                       { get; set; }
        public BigInteger?                              G                                       { get; set; }
        public BigInteger?                              X                                       { get; set; }
        public BigInteger?                              Y                                       { get; set; }
        public BigInteger?                              J                                       { get; set; }
        public BigInteger?                              Seed                                    { get; set; }
        public int                                      Counter                                 { get; set; }
        public bool                                     J_missing                               { get; set; }
        public RandomNumberGenerator?                   Rng                                     { get; set; }
        public KeyGeneratedEventHandler?                KeyGenerated                            { get; set; }

        public static DSAManaged? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DSAManaged() { Pointer= p0 };

            value.KeypairGenerated                          = GetBool(new IntPtr(p + 0x020)); // 0246669D1C10 0x20 KeypairGenerated            ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_disposed                                = GetBool(new IntPtr(p + 0x021)); // 0246669D1C30 0x21 M_disposed                  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.P                                         = GetObject<BigInteger>(new IntPtr(p + 0x028), ReversePrism.DataModels.BigInteger.FromPointer); // 0246669D1C50 0x28 P                           ( 00018674FF50 ModelClassType BigInteger BigInteger BigInteger Pointer )
            value.Q                                         = GetObject<BigInteger>(new IntPtr(p + 0x030), ReversePrism.DataModels.BigInteger.FromPointer); // 0246669D1C70 0x30 Q                           ( 00018674FF50 ModelClassType BigInteger BigInteger BigInteger Pointer )
            value.G                                         = GetObject<BigInteger>(new IntPtr(p + 0x038), ReversePrism.DataModels.BigInteger.FromPointer); // 0246669D1C90 0x38 G                           ( 00018674FF50 ModelClassType BigInteger BigInteger BigInteger Pointer )
            value.X                                         = GetObject<BigInteger>(new IntPtr(p + 0x040), ReversePrism.DataModels.BigInteger.FromPointer); // 0246669D1CB0 0x40 X                           ( 00018674FF50 ModelClassType BigInteger BigInteger BigInteger Pointer )
            value.Y                                         = GetObject<BigInteger>(new IntPtr(p + 0x048), ReversePrism.DataModels.BigInteger.FromPointer); // 0246669D1CD0 0x48 Y                           ( 00018674FF50 ModelClassType BigInteger BigInteger BigInteger Pointer )
            value.J                                         = GetObject<BigInteger>(new IntPtr(p + 0x050), ReversePrism.DataModels.BigInteger.FromPointer); // 0246669D1CF0 0x50 J                           ( 00018674FF50 ModelClassType BigInteger BigInteger BigInteger Pointer )
            value.Seed                                      = GetObject<BigInteger>(new IntPtr(p + 0x058), ReversePrism.DataModels.BigInteger.FromPointer); // 0246669D1D10 0x58 Seed                        ( 00018674FF50 ModelClassType BigInteger BigInteger BigInteger Pointer )
            value.Counter                                   = GetInt32(new IntPtr(p + 0x060)); // 0246669D1D30 0x60 Counter                     ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.J_missing                                 = GetBool(new IntPtr(p + 0x064)); // 0246669D1D50 0x64 J_missing                   ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Rng                                       = GetObject<RandomNumberGenerator>(new IntPtr(p + 0x068), ReversePrism.DataModels.RandomNumberGenerator.FromPointer); // 0246669D1D70 0x68 Rng                         ( 00018660A680 ModelClassType RandomNumberGenerator RandomNumberGenerator RandomNumberGenerator Pointer )
            value.KeyGenerated                              = GetObject<KeyGeneratedEventHandler>(new IntPtr(p + 0x070), ReversePrism.DataModels.KeyGeneratedEventHandler.FromPointer); // 0246669D1D90 0x70 KeyGenerated                ( 000186577950 ModelClassType KeyGeneratedEventHandler KeyGeneratedEventHandler KeyGeneratedEventHandler Pointer )

            return value;
        }
    }
}
