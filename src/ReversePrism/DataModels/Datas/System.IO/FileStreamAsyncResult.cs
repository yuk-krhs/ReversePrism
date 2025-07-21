using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 state                                    <object> IL2CPP_TYPE_OBJECT
    // 018 Completed                                ModelPrimitiveType bool bool bool Bool
    // 020 Wh                                       ModelClassType ManualResetEvent ManualResetEvent ManualResetEvent Pointer
    // 028 Cb                                       ModelClassType AsyncCallback AsyncCallback AsyncCallback Pointer
    // 030 CompletedSynch                           ModelPrimitiveType bool bool bool Bool
    // 034 Count                                    ModelPrimitiveType int int int Int32
    // 038 OriginalCount                            ModelPrimitiveType int int int Int32
    // 03C BytesRead                                ModelPrimitiveType int int int Int32
    // 040 Realcb                                   ModelClassType AsyncCallback AsyncCallback AsyncCallback Pointer
    public partial class FileStreamAsyncResult : DataModel
    {
        public bool                                     Completed                               { get; set; }
        public ManualResetEvent?                        Wh                                      { get; set; }
        public AsyncCallback?                           Cb                                      { get; set; }
        public bool                                     CompletedSynch                          { get; set; }
        public int                                      Count                                   { get; set; }
        public int                                      OriginalCount                           { get; set; }
        public int                                      BytesRead                               { get; set; }
        public AsyncCallback?                           Realcb                                  { get; set; }

        public static FileStreamAsyncResult? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FileStreamAsyncResult() { Pointer= p0 };

            value.Completed                                 = GetBool(new IntPtr(p + 0x018)); // 0x18 Completed                   ( ModelPrimitiveType bool bool bool Bool )
            value.Wh                                        = GetObject<ManualResetEvent>(new IntPtr(p + 0x020), ReversePrism.DataModels.ManualResetEvent.FromPointer); // 0x20 Wh                          ( ModelClassType ManualResetEvent ManualResetEvent ManualResetEvent Pointer )
            value.Cb                                        = GetObject<AsyncCallback>(new IntPtr(p + 0x028), ReversePrism.DataModels.AsyncCallback.FromPointer); // 0x28 Cb                          ( ModelClassType AsyncCallback AsyncCallback AsyncCallback Pointer )
            value.CompletedSynch                            = GetBool(new IntPtr(p + 0x030)); // 0x30 CompletedSynch              ( ModelPrimitiveType bool bool bool Bool )
            value.Count                                     = GetInt32(new IntPtr(p + 0x034)); // 0x34 Count                       ( ModelPrimitiveType int int int Int32 )
            value.OriginalCount                             = GetInt32(new IntPtr(p + 0x038)); // 0x38 OriginalCount               ( ModelPrimitiveType int int int Int32 )
            value.BytesRead                                 = GetInt32(new IntPtr(p + 0x03C)); // 0x3C BytesRead                   ( ModelPrimitiveType int int int Int32 )
            value.Realcb                                    = GetObject<AsyncCallback>(new IntPtr(p + 0x040), ReversePrism.DataModels.AsyncCallback.FromPointer); // 0x40 Realcb                      ( ModelClassType AsyncCallback AsyncCallback AsyncCallback Pointer )

            return value;
        }
    }
}
