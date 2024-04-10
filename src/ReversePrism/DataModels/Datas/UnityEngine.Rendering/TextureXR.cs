using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 m_MaxViews                               int IL2CPP_TYPE_I4
    // 008 m_BlackUIntTexture2DArray                Texture IL2CPP_TYPE_CLASS
    // 010 M_BlackUIntTexture                       00018664D950 ModelClassType Texture Texture Texture Pointer
    // 018 M_BlackUIntTexture2DArrayRTH             00018664B7D0 ModelClassType RTHandle RTHandle RTHandle Pointer
    // 020 M_BlackUIntTextureRTH                    00018664B7D0 ModelClassType RTHandle RTHandle RTHandle Pointer
    // 028 M_ClearTexture2DArray                    00018664DE20 ModelClassType Texture2DArray Texture2DArray Texture2DArray Pointer
    // 030 M_ClearTexture                           000186686190 ModelClassType Texture2D Texture2D Texture2D Pointer
    // 038 M_ClearTexture2DArrayRTH                 00018664B7D0 ModelClassType RTHandle RTHandle RTHandle Pointer
    // 040 M_ClearTextureRTH                        00018664B7D0 ModelClassType RTHandle RTHandle RTHandle Pointer
    // 048 M_MagentaTexture2DArray                  00018664DE20 ModelClassType Texture2DArray Texture2DArray Texture2DArray Pointer
    // 050 M_MagentaTexture                         000186686190 ModelClassType Texture2D Texture2D Texture2D Pointer
    // 058 M_MagentaTexture2DArrayRTH               00018664B7D0 ModelClassType RTHandle RTHandle RTHandle Pointer
    // 060 M_MagentaTextureRTH                      00018664B7D0 ModelClassType RTHandle RTHandle RTHandle Pointer
    // 068 M_BlackTexture                           000186686190 ModelClassType Texture2D Texture2D Texture2D Pointer
    // 070 M_BlackTexture3D                         00018664F180 ModelClassType Texture3D Texture3D Texture3D Pointer
    // 078 M_BlackTexture2DArray                    00018664DE20 ModelClassType Texture2DArray Texture2DArray Texture2DArray Pointer
    // 080 M_BlackTexture2DArrayRTH                 00018664B7D0 ModelClassType RTHandle RTHandle RTHandle Pointer
    // 088 M_BlackTextureRTH                        00018664B7D0 ModelClassType RTHandle RTHandle RTHandle Pointer
    // 090 M_BlackTexture3DRTH                      00018664B7D0 ModelClassType RTHandle RTHandle RTHandle Pointer
    // 098 M_WhiteTexture2DArray                    00018664DE20 ModelClassType Texture2DArray Texture2DArray Texture2DArray Pointer
    // 0A0 M_WhiteTexture2DArrayRTH                 00018664B7D0 ModelClassType RTHandle RTHandle RTHandle Pointer
    // 0A8 M_WhiteTextureRTH                        00018664B7D0 ModelClassType RTHandle RTHandle RTHandle Pointer
    public partial class TextureXR : DataModel
    {
        public Texture?                                 M_BlackUIntTexture                      { get; set; }
        public RTHandle?                                M_BlackUIntTexture2DArrayRTH            { get; set; }
        public RTHandle?                                M_BlackUIntTextureRTH                   { get; set; }
        public Texture2DArray?                          M_ClearTexture2DArray                   { get; set; }
        public Texture2D?                               M_ClearTexture                          { get; set; }
        public RTHandle?                                M_ClearTexture2DArrayRTH                { get; set; }
        public RTHandle?                                M_ClearTextureRTH                       { get; set; }
        public Texture2DArray?                          M_MagentaTexture2DArray                 { get; set; }
        public Texture2D?                               M_MagentaTexture                        { get; set; }
        public RTHandle?                                M_MagentaTexture2DArrayRTH              { get; set; }
        public RTHandle?                                M_MagentaTextureRTH                     { get; set; }
        public Texture2D?                               M_BlackTexture                          { get; set; }
        public Texture3D?                               M_BlackTexture3D                        { get; set; }
        public Texture2DArray?                          M_BlackTexture2DArray                   { get; set; }
        public RTHandle?                                M_BlackTexture2DArrayRTH                { get; set; }
        public RTHandle?                                M_BlackTextureRTH                       { get; set; }
        public RTHandle?                                M_BlackTexture3DRTH                     { get; set; }
        public Texture2DArray?                          M_WhiteTexture2DArray                   { get; set; }
        public RTHandle?                                M_WhiteTexture2DArrayRTH                { get; set; }
        public RTHandle?                                M_WhiteTextureRTH                       { get; set; }

        public static TextureXR? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TextureXR() { Pointer= p0 };

            value.M_BlackUIntTexture                        = GetObject<Texture>(new IntPtr(p + 0x010), ReversePrism.DataModels.Texture.FromPointer); // 0246692FC070 0x10 M_BlackUIntTexture          ( 00018664D950 ModelClassType Texture Texture Texture Pointer )
            value.M_BlackUIntTexture2DArrayRTH              = GetObject<RTHandle>(new IntPtr(p + 0x018), ReversePrism.DataModels.RTHandle.FromPointer); // 0246692FC090 0x18 M_BlackUIntTexture2DArrayRTH ( 00018664B7D0 ModelClassType RTHandle RTHandle RTHandle Pointer )
            value.M_BlackUIntTextureRTH                     = GetObject<RTHandle>(new IntPtr(p + 0x020), ReversePrism.DataModels.RTHandle.FromPointer); // 0246692FC0B0 0x20 M_BlackUIntTextureRTH       ( 00018664B7D0 ModelClassType RTHandle RTHandle RTHandle Pointer )
            value.M_ClearTexture2DArray                     = GetObject<Texture2DArray>(new IntPtr(p + 0x028), ReversePrism.DataModels.Texture2DArray.FromPointer); // 0246692FC0D0 0x28 M_ClearTexture2DArray       ( 00018664DE20 ModelClassType Texture2DArray Texture2DArray Texture2DArray Pointer )
            value.M_ClearTexture                            = GetObject<Texture2D>(new IntPtr(p + 0x030), ReversePrism.DataModels.Texture2D.FromPointer); // 0246692FC0F0 0x30 M_ClearTexture              ( 000186686190 ModelClassType Texture2D Texture2D Texture2D Pointer )
            value.M_ClearTexture2DArrayRTH                  = GetObject<RTHandle>(new IntPtr(p + 0x038), ReversePrism.DataModels.RTHandle.FromPointer); // 0246692FC110 0x38 M_ClearTexture2DArrayRTH    ( 00018664B7D0 ModelClassType RTHandle RTHandle RTHandle Pointer )
            value.M_ClearTextureRTH                         = GetObject<RTHandle>(new IntPtr(p + 0x040), ReversePrism.DataModels.RTHandle.FromPointer); // 0246692FC130 0x40 M_ClearTextureRTH           ( 00018664B7D0 ModelClassType RTHandle RTHandle RTHandle Pointer )
            value.M_MagentaTexture2DArray                   = GetObject<Texture2DArray>(new IntPtr(p + 0x048), ReversePrism.DataModels.Texture2DArray.FromPointer); // 0246692FC150 0x48 M_MagentaTexture2DArray     ( 00018664DE20 ModelClassType Texture2DArray Texture2DArray Texture2DArray Pointer )
            value.M_MagentaTexture                          = GetObject<Texture2D>(new IntPtr(p + 0x050), ReversePrism.DataModels.Texture2D.FromPointer); // 0246692FC170 0x50 M_MagentaTexture            ( 000186686190 ModelClassType Texture2D Texture2D Texture2D Pointer )
            value.M_MagentaTexture2DArrayRTH                = GetObject<RTHandle>(new IntPtr(p + 0x058), ReversePrism.DataModels.RTHandle.FromPointer); // 0246692FC190 0x58 M_MagentaTexture2DArrayRTH  ( 00018664B7D0 ModelClassType RTHandle RTHandle RTHandle Pointer )
            value.M_MagentaTextureRTH                       = GetObject<RTHandle>(new IntPtr(p + 0x060), ReversePrism.DataModels.RTHandle.FromPointer); // 0246692FC1B0 0x60 M_MagentaTextureRTH         ( 00018664B7D0 ModelClassType RTHandle RTHandle RTHandle Pointer )
            value.M_BlackTexture                            = GetObject<Texture2D>(new IntPtr(p + 0x068), ReversePrism.DataModels.Texture2D.FromPointer); // 0246692FC1D0 0x68 M_BlackTexture              ( 000186686190 ModelClassType Texture2D Texture2D Texture2D Pointer )
            value.M_BlackTexture3D                          = GetObject<Texture3D>(new IntPtr(p + 0x070), ReversePrism.DataModels.Texture3D.FromPointer); // 0246692FC1F0 0x70 M_BlackTexture3D            ( 00018664F180 ModelClassType Texture3D Texture3D Texture3D Pointer )
            value.M_BlackTexture2DArray                     = GetObject<Texture2DArray>(new IntPtr(p + 0x078), ReversePrism.DataModels.Texture2DArray.FromPointer); // 0246692FC210 0x78 M_BlackTexture2DArray       ( 00018664DE20 ModelClassType Texture2DArray Texture2DArray Texture2DArray Pointer )
            value.M_BlackTexture2DArrayRTH                  = GetObject<RTHandle>(new IntPtr(p + 0x080), ReversePrism.DataModels.RTHandle.FromPointer); // 0246692FC230 0x80 M_BlackTexture2DArrayRTH    ( 00018664B7D0 ModelClassType RTHandle RTHandle RTHandle Pointer )
            value.M_BlackTextureRTH                         = GetObject<RTHandle>(new IntPtr(p + 0x088), ReversePrism.DataModels.RTHandle.FromPointer); // 0246692FC250 0x88 M_BlackTextureRTH           ( 00018664B7D0 ModelClassType RTHandle RTHandle RTHandle Pointer )
            value.M_BlackTexture3DRTH                       = GetObject<RTHandle>(new IntPtr(p + 0x090), ReversePrism.DataModels.RTHandle.FromPointer); // 0246692FC270 0x90 M_BlackTexture3DRTH         ( 00018664B7D0 ModelClassType RTHandle RTHandle RTHandle Pointer )
            value.M_WhiteTexture2DArray                     = GetObject<Texture2DArray>(new IntPtr(p + 0x098), ReversePrism.DataModels.Texture2DArray.FromPointer); // 0246692FC290 0x98 M_WhiteTexture2DArray       ( 00018664DE20 ModelClassType Texture2DArray Texture2DArray Texture2DArray Pointer )
            value.M_WhiteTexture2DArrayRTH                  = GetObject<RTHandle>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.RTHandle.FromPointer); // 0246692FC2B0 0xA0 M_WhiteTexture2DArrayRTH    ( 00018664B7D0 ModelClassType RTHandle RTHandle RTHandle Pointer )
            value.M_WhiteTextureRTH                         = GetObject<RTHandle>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.RTHandle.FromPointer); // 0246692FC2D0 0xA8 M_WhiteTextureRTH           ( 00018664B7D0 ModelClassType RTHandle RTHandle RTHandle Pointer )

            return value;
        }
    }
}
