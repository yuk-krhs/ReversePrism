using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 k_TextureIds                             int[] IL2CPP_TYPE_SZARRAY
    // 008 s_CommitSampler                          ProfilerMarker IL2CPP_TYPE_VALUETYPE
    // 010 M_SingleBlit                             000185CC42E8 ModelEnumListType BlitInfo[] BlitInfo[] List<BlitInfo> Pointer
    // 018 M_BlitMaterial                           00018660BDD0 ModelClassType Material Material Material Pointer
    // 020 M_Properties                             0001865E0FC0 ModelClassType MaterialPropertyBlock MaterialPropertyBlock MaterialPropertyBlock Pointer
    // 028 M_Viewport                               000186650F80 ModelEnumType RectInt RectInt RectInt Int32
    // 038 M_PrevRT                                 000186655F80 ModelClassType RenderTexture RenderTexture RenderTexture Pointer
    // 040 M_PendingBlits                           000185D2E178 ModelEnumListType List`1<BlitInfo> List`1<BlitInfo> List<BlitInfo> Pointer
    // 048 Disposed                                 000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class TextureBlitter
    {
        public List<BlitInfo>?                          M_SingleBlit                            { get; set; }
        public Material?                                M_BlitMaterial                          { get; set; }
        public MaterialPropertyBlock?                   M_Properties                            { get; set; }
        public RectInt                                  M_Viewport                              { get; set; }
        public RenderTexture?                           M_PrevRT                                { get; set; }
        public List<BlitInfo>?                          M_PendingBlits                          { get; set; }
        public bool                                     Disposed                                { get; set; }

        public static TextureBlitter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TextureBlitter();

            value.M_SingleBlit                              = GetEnumList<BlitInfo>(new IntPtr(p + 0x010)); // 0270068798A0 0x10 M_SingleBlit                ( 000185CC42E8 ModelEnumListType BlitInfo[] BlitInfo[] List<BlitInfo> Pointer )
            value.M_BlitMaterial                            = GetObject<Material>(new IntPtr(p + 0x018), ReversePrism.DataModels.Material.FromPointer); // 0270068798C0 0x18 M_BlitMaterial              ( 00018660BDD0 ModelClassType Material Material Material Pointer )
            value.M_Properties                              = GetObject<MaterialPropertyBlock>(new IntPtr(p + 0x020), ReversePrism.DataModels.MaterialPropertyBlock.FromPointer); // 0270068798E0 0x20 M_Properties                ( 0001865E0FC0 ModelClassType MaterialPropertyBlock MaterialPropertyBlock MaterialPropertyBlock Pointer )
            value.M_Viewport                                = (RectInt)GetInt32(new IntPtr(p + 0x028)); // 027006879900 0x28 M_Viewport                  ( 000186650F80 ModelEnumType RectInt RectInt RectInt Int32 )
            value.M_PrevRT                                  = GetObject<RenderTexture>(new IntPtr(p + 0x038), ReversePrism.DataModels.RenderTexture.FromPointer); // 027006879920 0x38 M_PrevRT                    ( 000186655F80 ModelClassType RenderTexture RenderTexture RenderTexture Pointer )
            value.M_PendingBlits                            = GetEnumList<BlitInfo>(new IntPtr(p + 0x040)); // 027006879940 0x40 M_PendingBlits              ( 000185D2E178 ModelEnumListType List`1<BlitInfo> List`1<BlitInfo> List<BlitInfo> Pointer )
            value.Disposed                                  = GetBool(new IntPtr(p + 0x048)); // 027006879960 0x48 Disposed                    ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
