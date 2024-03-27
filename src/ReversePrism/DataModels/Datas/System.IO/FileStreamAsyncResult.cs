using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 state                                    <object> IL2CPP_TYPE_OBJECT
    // 018 Completed                                000186594D10 ModelPrimitiveType bool bool bool Bool
    // 020 Wh                                       00018660A400 ModelClassType ManualResetEvent ManualResetEvent ManualResetEvent Pointer
    // 028 Cb                                       0001866EDF20 ModelClassType AsyncCallback AsyncCallback AsyncCallback Pointer
    // 030 CompletedSynch                           000186594D10 ModelPrimitiveType bool bool bool Bool
    // 034 Count                                    0001865F36C0 ModelPrimitiveType int int int Int32
    // 038 OriginalCount                            0001865F36C0 ModelPrimitiveType int int int Int32
    // 03C BytesRead                                0001865F36C0 ModelPrimitiveType int int int Int32
    // 040 Realcb                                   0001866EDF20 ModelClassType AsyncCallback AsyncCallback AsyncCallback Pointer
    public partial class FileStreamAsyncResult
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
            var value   = new FileStreamAsyncResult();

            value.Completed                                 = GetBool(new IntPtr(p + 0x018)); // 0270D6E3E660 0x18 Completed                   ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Wh                                        = GetObject<ManualResetEvent>(new IntPtr(p + 0x020), ReversePrism.DataModels.ManualResetEvent.FromPointer); // 0270D6E3E680 0x20 Wh                          ( 00018660A400 ModelClassType ManualResetEvent ManualResetEvent ManualResetEvent Pointer )
            value.Cb                                        = GetObject<AsyncCallback>(new IntPtr(p + 0x028), ReversePrism.DataModels.AsyncCallback.FromPointer); // 0270D6E3E6A0 0x28 Cb                          ( 0001866EDF20 ModelClassType AsyncCallback AsyncCallback AsyncCallback Pointer )
            value.CompletedSynch                            = GetBool(new IntPtr(p + 0x030)); // 0270D6E3E6C0 0x30 CompletedSynch              ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Count                                     = GetInt32(new IntPtr(p + 0x034)); // 0270D6E3E6E0 0x34 Count                       ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.OriginalCount                             = GetInt32(new IntPtr(p + 0x038)); // 0270D6E3E700 0x38 OriginalCount               ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.BytesRead                                 = GetInt32(new IntPtr(p + 0x03C)); // 0270D6E3E720 0x3C BytesRead                   ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.Realcb                                    = GetObject<AsyncCallback>(new IntPtr(p + 0x040), ReversePrism.DataModels.AsyncCallback.FromPointer); // 0270D6E3E740 0x40 Realcb                      ( 0001866EDF20 ModelClassType AsyncCallback AsyncCallback AsyncCallback Pointer )

            return value;
        }
    }
}
