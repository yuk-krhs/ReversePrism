using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 028 Stream                                   000186670BE0 ModelClassType Stream Stream Stream Pointer
    // 030 Transform                                000186746E90 ModelClassType ICryptoTransform ICryptoTransform ICryptoTransform Pointer
    // 038 TransformMode                            00018665FD80 ModelEnumType CryptoStreamMode CryptoStreamMode CryptoStreamMode Int32
    // 040 InputBuffer                              000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 048 InputBufferIndex                         0001865F2AF0 ModelPrimitiveType int int int Int32
    // 04C InputBlockSize                           0001865F2AF0 ModelPrimitiveType int int int Int32
    // 050 OutputBuffer                             000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 058 OutputBufferIndex                        0001865F2AF0 ModelPrimitiveType int int int Int32
    // 05C OutputBlockSize                          0001865F2AF0 ModelPrimitiveType int int int Int32
    // 060 CanRead                                  000186594D10 ModelPrimitiveType bool bool bool Bool
    // 061 CanWrite                                 000186594D10 ModelPrimitiveType bool bool bool Bool
    // 062 FinalBlockTransformed                    000186594D10 ModelPrimitiveType bool bool bool Bool
    // 068 LazyAsyncActiveSemaphore                 0001867235F0 ModelClassType SemaphoreSlim SemaphoreSlim SemaphoreSlim Pointer
    // 070 LeaveOpen                                0001865965D0 ModelPrimitiveType bool bool bool Bool
    public partial class CryptoStream
    {
        public Stream?                                  Stream                                  { get; set; }
        public ICryptoTransform?                        Transform                               { get; set; }
        public CryptoStreamMode                         TransformMode                           { get; set; }
        public List<sbyte>?                             InputBuffer                             { get; set; }
        public int                                      InputBufferIndex                        { get; set; }
        public int                                      InputBlockSize                          { get; set; }
        public List<sbyte>?                             OutputBuffer                            { get; set; }
        public int                                      OutputBufferIndex                       { get; set; }
        public int                                      OutputBlockSize                         { get; set; }
        public bool                                     CanRead                                 { get; set; }
        public bool                                     CanWrite                                { get; set; }
        public bool                                     FinalBlockTransformed                   { get; set; }
        public SemaphoreSlim?                           LazyAsyncActiveSemaphore                { get; set; }
        public bool                                     LeaveOpen                               { get; set; }

        public static CryptoStream? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CryptoStream();

            value.Stream                                    = GetObject<Stream>(new IntPtr(p + 0x028), ReversePrism.DataModels.Stream.FromPointer); // 0270D197C188 0x28 Stream                      ( 000186670BE0 ModelClassType Stream Stream Stream Pointer )
            value.Transform                                 = GetObject<ICryptoTransform>(new IntPtr(p + 0x030), ReversePrism.DataModels.ICryptoTransform.FromPointer); // 0270D197C1A8 0x30 Transform                   ( 000186746E90 ModelClassType ICryptoTransform ICryptoTransform ICryptoTransform Pointer )
            value.TransformMode                             = (CryptoStreamMode)GetInt32(new IntPtr(p + 0x038)); // 0270D197C1C8 0x38 TransformMode               ( 00018665FD80 ModelEnumType CryptoStreamMode CryptoStreamMode CryptoStreamMode Int32 )
            value.InputBuffer                               = GetSByteList(new IntPtr(p + 0x040)); // 0270D197C1E8 0x40 InputBuffer                 ( 000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.InputBufferIndex                          = GetInt32(new IntPtr(p + 0x048)); // 0270D197C208 0x48 InputBufferIndex            ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.InputBlockSize                            = GetInt32(new IntPtr(p + 0x04C)); // 0270D197C228 0x4C InputBlockSize              ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.OutputBuffer                              = GetSByteList(new IntPtr(p + 0x050)); // 0270D197C248 0x50 OutputBuffer                ( 000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.OutputBufferIndex                         = GetInt32(new IntPtr(p + 0x058)); // 0270D197C268 0x58 OutputBufferIndex           ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.OutputBlockSize                           = GetInt32(new IntPtr(p + 0x05C)); // 0270D197C288 0x5C OutputBlockSize             ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.CanRead                                   = GetBool(new IntPtr(p + 0x060)); // 0270D197C2A8 0x60 CanRead                     ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.CanWrite                                  = GetBool(new IntPtr(p + 0x061)); // 0270D197C2C8 0x61 CanWrite                    ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.FinalBlockTransformed                     = GetBool(new IntPtr(p + 0x062)); // 0270D197C2E8 0x62 FinalBlockTransformed       ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.LazyAsyncActiveSemaphore                  = GetObject<SemaphoreSlim>(new IntPtr(p + 0x068), ReversePrism.DataModels.SemaphoreSlim.FromPointer); // 0270D197C308 0x68 LazyAsyncActiveSemaphore    ( 0001867235F0 ModelClassType SemaphoreSlim SemaphoreSlim SemaphoreSlim Pointer )
            value.LeaveOpen                                 = GetBool(new IntPtr(p + 0x070)); // 0270D197C328 0x70 LeaveOpen                   ( 0001865965D0 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
