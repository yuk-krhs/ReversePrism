using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Handle                                   0001865D9120 ModelEnumType GCHandle GCHandle GCHandle Int32
    // 028 instance                                 <int> IL2CPP_TYPE_I
    // 030 ReadFunc                                 00018673DDE0 ModelClassType BioReadFunc BioReadFunc BioReadFunc Pointer
    // 038 WriteFunc                                00018673E270 ModelClassType BioWriteFunc BioWriteFunc BioWriteFunc Pointer
    // 040 ControlFunc                              00018673D930 ModelClassType BioControlFunc BioControlFunc BioControlFunc Pointer
    // 048 readFuncPtr                              <int> IL2CPP_TYPE_I
    // 050 writeFuncPtr                             <int> IL2CPP_TYPE_I
    // 058 controlFuncPtr                           <int> IL2CPP_TYPE_I
    // 060 Backend                                  0001865BA400 ModelClassType IMonoBtlsBioMono IMonoBtlsBioMono IMonoBtlsBioMono Pointer
    public partial class MonoBtlsBioMono : DataModel
    {
        public GCHandle                                 Handle                                  { get; set; }
        public BioReadFunc?                             ReadFunc                                { get; set; }
        public BioWriteFunc?                            WriteFunc                               { get; set; }
        public BioControlFunc?                          ControlFunc                             { get; set; }
        public IMonoBtlsBioMono?                        Backend                                 { get; set; }

        public static MonoBtlsBioMono? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MonoBtlsBioMono() { Pointer= p0 };

            value.Handle                                    = (GCHandle)GetInt32(new IntPtr(p + 0x020)); // 0246679A6EB0 0x20 Handle                      ( 0001865D9120 ModelEnumType GCHandle GCHandle GCHandle Int32 )
            value.ReadFunc                                  = GetObject<BioReadFunc>(new IntPtr(p + 0x030), ReversePrism.DataModels.BioReadFunc.FromPointer); // 0246679A6EF0 0x30 ReadFunc                    ( 00018673DDE0 ModelClassType BioReadFunc BioReadFunc BioReadFunc Pointer )
            value.WriteFunc                                 = GetObject<BioWriteFunc>(new IntPtr(p + 0x038), ReversePrism.DataModels.BioWriteFunc.FromPointer); // 0246679A6F10 0x38 WriteFunc                   ( 00018673E270 ModelClassType BioWriteFunc BioWriteFunc BioWriteFunc Pointer )
            value.ControlFunc                               = GetObject<BioControlFunc>(new IntPtr(p + 0x040), ReversePrism.DataModels.BioControlFunc.FromPointer); // 0246679A6F30 0x40 ControlFunc                 ( 00018673D930 ModelClassType BioControlFunc BioControlFunc BioControlFunc Pointer )
            value.Backend                                   = GetObject<IMonoBtlsBioMono>(new IntPtr(p + 0x060), ReversePrism.DataModels.IMonoBtlsBioMono.FromPointer); // 0246679A6FB0 0x60 Backend                     ( 0001865BA400 ModelClassType IMonoBtlsBioMono IMonoBtlsBioMono IMonoBtlsBioMono Pointer )

            return value;
        }
    }
}
