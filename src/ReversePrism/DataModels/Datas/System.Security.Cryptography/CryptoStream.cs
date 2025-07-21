using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 028 Stream                                   ModelClassType Stream Stream Stream Pointer
    // 030 Transform                                ModelClassType ICryptoTransform ICryptoTransform ICryptoTransform Pointer
    // 038 TransformMode                            ModelEnumType CryptoStreamMode CryptoStreamMode CryptoStreamMode Int32
    // 040 InputBuffer                              ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 048 InputBufferIndex                         ModelPrimitiveType int int int Int32
    // 04C InputBlockSize                           ModelPrimitiveType int int int Int32
    // 050 OutputBuffer                             ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 058 OutputBufferIndex                        ModelPrimitiveType int int int Int32
    // 05C OutputBlockSize                          ModelPrimitiveType int int int Int32
    // 060 CanRead                                  ModelPrimitiveType bool bool bool Bool
    // 061 CanWrite                                 ModelPrimitiveType bool bool bool Bool
    // 062 FinalBlockTransformed                    ModelPrimitiveType bool bool bool Bool
    // 068 LazyAsyncActiveSemaphore                 ModelClassType SemaphoreSlim SemaphoreSlim SemaphoreSlim Pointer
    // 070 LeaveOpen                                ModelPrimitiveType bool bool bool Bool
    public partial class CryptoStream : DataModel
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
            var value   = new CryptoStream() { Pointer= p0 };

            value.Stream                                    = GetObject<Stream>(new IntPtr(p + 0x028), ReversePrism.DataModels.Stream.FromPointer); // 0x28 Stream                      ( ModelClassType Stream Stream Stream Pointer )
            value.Transform                                 = GetObject<ICryptoTransform>(new IntPtr(p + 0x030), ReversePrism.DataModels.ICryptoTransform.FromPointer); // 0x30 Transform                   ( ModelClassType ICryptoTransform ICryptoTransform ICryptoTransform Pointer )
            value.TransformMode                             = (CryptoStreamMode)GetInt32(new IntPtr(p + 0x038)); // 0x38 TransformMode               ( ModelEnumType CryptoStreamMode CryptoStreamMode CryptoStreamMode Int32 )
            value.InputBuffer                               = GetSByteList(new IntPtr(p + 0x040)); // 0x40 InputBuffer                 ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.InputBufferIndex                          = GetInt32(new IntPtr(p + 0x048)); // 0x48 InputBufferIndex            ( ModelPrimitiveType int int int Int32 )
            value.InputBlockSize                            = GetInt32(new IntPtr(p + 0x04C)); // 0x4C InputBlockSize              ( ModelPrimitiveType int int int Int32 )
            value.OutputBuffer                              = GetSByteList(new IntPtr(p + 0x050)); // 0x50 OutputBuffer                ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.OutputBufferIndex                         = GetInt32(new IntPtr(p + 0x058)); // 0x58 OutputBufferIndex           ( ModelPrimitiveType int int int Int32 )
            value.OutputBlockSize                           = GetInt32(new IntPtr(p + 0x05C)); // 0x5C OutputBlockSize             ( ModelPrimitiveType int int int Int32 )
            value.CanRead                                   = GetBool(new IntPtr(p + 0x060)); // 0x60 CanRead                     ( ModelPrimitiveType bool bool bool Bool )
            value.CanWrite                                  = GetBool(new IntPtr(p + 0x061)); // 0x61 CanWrite                    ( ModelPrimitiveType bool bool bool Bool )
            value.FinalBlockTransformed                     = GetBool(new IntPtr(p + 0x062)); // 0x62 FinalBlockTransformed       ( ModelPrimitiveType bool bool bool Bool )
            value.LazyAsyncActiveSemaphore                  = GetObject<SemaphoreSlim>(new IntPtr(p + 0x068), ReversePrism.DataModels.SemaphoreSlim.FromPointer); // 0x68 LazyAsyncActiveSemaphore    ( ModelClassType SemaphoreSlim SemaphoreSlim SemaphoreSlim Pointer )
            value.LeaveOpen                                 = GetBool(new IntPtr(p + 0x070)); // 0x70 LeaveOpen                   ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
